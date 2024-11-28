using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Ql_DATN
{
    public partial class Frm_DanhGiaBCTD : Form
    {
        private DanhGiaBCTDBUS danhGiaBUS = new DanhGiaBCTDBUS();
        public Frm_DanhGiaBCTD()
        {
            InitializeComponent();
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Kết nối CSDL để lấy danh sách Mã Báo Cáo
                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    var danhSachBaoCao = context.BaoCaoTienDos.Select(bc => bc.MaBaoCao).ToList();
                    cmbMaBaoCao.DataSource = danhSachBaoCao;
                }

                // Kết nối CSDL để lấy danh sách Mã Giảng Viên
                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    var danhSachGiangVien = context.GiangViens.Select(gv => gv.MaGiangVien).ToList();
                    cmbMaGiangVien.DataSource = danhSachGiangVien;
                }

                // Kết nối CSDL để lấy danh sách Mã Nhóm
                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    var danhSachNhom = context.NhomSinhViens.Select(n => n.MaNhom).ToList();
                    cmbMaNhom.DataSource = danhSachNhom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu ComboBox: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBaoCaoTienDoData()
        {
            try
            {
                // Kết nối CSDL và lấy dữ liệu từ bảng BaoCaoTienDo
                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    var baoCaoTienDos = context.BaoCaoTienDos.ToList();

                    // Chuyển dữ liệu từ danh sách vào DataGridView
                    dgvBaoCaoTienDo.DataSource = baoCaoTienDos.Select(bc => new
                    {
                        MaBaoCao = bc.MaBaoCao,
                        TuanThu = bc.TuanThu,
                        NgayBaoCao = bc.NgayBaoCao,
                        NoiDung = bc.NoiDung,
                        CoMat = bc.CoMat ? "Có" : "Không",  // Hiển thị dạng "Có"/"Không" thay vì true/false
                        MaNhom = bc.MaNhom,
                        MaGiangVien = bc.MaGiangVien
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Báo Cáo Tiến Độ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuiDanhGia_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                string maDanhGia = txtMaDanhGia.Text.Trim();
                string maBaoCao = cmbMaBaoCao.SelectedItem.ToString(); // Lấy mã báo cáo từ ComboBox
                DateTime ngayDanhGia = DTPNgayDanhGia.Value;
                string maNhom = cmbMaNhom.SelectedItem.ToString(); // Lấy mã nhóm từ ComboBox
                string maGiangVien = cmbMaGiangVien.SelectedItem.ToString(); // Lấy mã giảng viên từ ComboBox
                string noiDung = multitxtNDDanhGia.Text.Trim();

                // Kiểm tra dữ liệu cơ bản
                if (string.IsNullOrEmpty(maDanhGia) || string.IsNullOrEmpty(maBaoCao) || string.IsNullOrEmpty(maNhom) || string.IsNullOrEmpty(maGiangVien))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BUS để thêm dữ liệu vào database
                bool ketQua = danhGiaBUS.ThemDanhGia(maDanhGia, maBaoCao, ngayDanhGia, maNhom, maGiangVien, noiDung);

                if (ketQua)
                {
                    MessageBox.Show("Đánh giá báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form nếu cần
                }
                else
                {
                    MessageBox.Show("Đánh giá báo cáo thất bại. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_DanhGiaBCTD_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadBaoCaoTienDoData();
        }
    }
}