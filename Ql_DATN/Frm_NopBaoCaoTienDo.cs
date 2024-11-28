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
    public partial class Frm_NopBaoCaoTienDo : Form
    {
        private NopBaoCaoTienDoBUS baoCaoBUS = new NopBaoCaoTienDoBUS();

        public Frm_NopBaoCaoTienDo()
        {
            InitializeComponent();
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    // Lấy danh sách Mã Nhóm
                    var danhSachNhom = context.NhomSinhViens.Select(n => n.MaNhom).ToList();
                    if (danhSachNhom.Count > 0)
                    {
                        cmbMaNhom.DataSource = danhSachNhom;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu Mã Nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                using (var context = new QLDADataContext("Data Source=MSI;Initial Catalog=QL_DOAN_TEST;User ID=sa;Password=123"))
                {
                    // Lấy danh sách Mã Giảng Viên
                    var danhSachGiangVien = context.GiangViens.Select(gv => gv.MaGiangVien).ToList();
                    if (danhSachGiangVien.Count > 0)
                    {
                        cmbMaGiangVien.DataSource = danhSachGiangVien;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu Mã Giảng Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu ComboBox: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnNopBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                string maBaoCao = txtMaBaoCao.Text.Trim();
                int tuanThu = 0;
                DateTime ngayBaoCao = DTPNgayBaoCao.Value;
                string noiDung = multitxtNoiDung.Text.Trim();
                bool coMat = ckbCo.Checked; // True nếu "Có" được chọn
                string maNhom = cmbMaNhom.SelectedItem.ToString(); // Lấy mã nhóm từ ComboBox
                string maGiangVien = cmbMaGiangVien.SelectedItem.ToString(); // Lấy mã giảng viên từ ComboBox

                // Kiểm tra dữ liệu cơ bản
                if (string.IsNullOrEmpty(maBaoCao) || string.IsNullOrEmpty(maNhom) || string.IsNullOrEmpty(maGiangVien))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra Tuần
                if (!int.TryParse(txtTuanThu.Text.Trim(), out tuanThu))
                {
                    MessageBox.Show("Tuần phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi BUS để thêm dữ liệu vào database
                bool ketQua = baoCaoBUS.ThemBaoCao(maBaoCao, tuanThu, ngayBaoCao, noiDung, coMat, maNhom, maGiangVien);

                if (ketQua)
                {
                    MessageBox.Show("Nộp báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form nếu cần
                }
                else
                {
                    MessageBox.Show("Nộp báo cáo thất bại. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_NopBaoCaoTienDo_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
    }
}
