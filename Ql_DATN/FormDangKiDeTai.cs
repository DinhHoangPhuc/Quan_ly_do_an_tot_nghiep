using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ql_DATN
{
    public partial class FormDangKiDeTai : Form
    {
        private readonly DangKiDeTaiBUS _dangKiDeTaiBUS = new DangKiDeTaiBUS();

        public FormDangKiDeTai()
        {
            InitializeComponent();
        }

        private void FormDangKiDeTai_Load(object sender, EventArgs e)
        {
            List<NhomSinhVien> nhomSinhViens = _dangKiDeTaiBUS.LayDanhSachNhomSinhVienChuaDangKiDeTai();
            List<DeTai> deTails = _dangKiDeTaiBUS.LayDanhSachDeTaiKhaDung();
            List<HocKy> hocKies = _dangKiDeTaiBUS.LayDanhSachHocKy();


            cbNhomSV.DataSource = nhomSinhViens;
            cbNhomSV.DisplayMember = "MaNhom";
            cbNhomSV.ValueMember = "MaNhom";

            cbDeTai.DataSource = deTails;
            cbDeTai.DisplayMember = "TenDeTai";
            cbDeTai.ValueMember = "MaDeTai";

            cbHocKi.DataSource = hocKies;
            cbHocKi.DisplayMember = "TenHocKy";
            cbHocKi.ValueMember = "MaHocKy";


        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string selectedMaNhom = cbNhomSV.SelectedValue?.ToString();
            string selectedMaDeTai = cbDeTai.SelectedValue?.ToString();
            string selectedMaHocKy = cbHocKi.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(selectedMaNhom))
            {
                MessageBox.Show("Vui lòng chọn nhóm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(selectedMaDeTai))
            {
                MessageBox.Show("Vui lòng chọn đề tài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(selectedMaHocKy))
            {
                MessageBox.Show("Vui lòng chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool dangKiThanhCong = _dangKiDeTaiBUS.DangKiDeTai(selectedMaNhom, selectedMaDeTai, selectedMaHocKy);

                if (dangKiThanhCong)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormDangKiDeTai_Load(sender, e);
                    cbNhomSV_SelectedIndexChanged(cbNhomSV, EventArgs.Empty);
                    cbDeTai_SelectedIndexChanged(cbDeTai, EventArgs.Empty);

                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNhomSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhomSV.SelectedValue != null)
            {
                string maNhom = cbNhomSV.SelectedValue.ToString();

                NhomSinhVien selectedNhom = _dangKiDeTaiBUS.LayThongTinNhomBangMaNhom(maNhom);

                if (selectedNhom != null)
                {
                    txtMaNhom.Text = selectedNhom.MaNhom;
                    txtMaNhomTruong.Text = selectedNhom.MaNhomTruong;
                }
            }
        }

        private void cbDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbDeTai.SelectedValue != null)
            {
                string maDeTai = cbDeTai.SelectedValue.ToString();

                DeTai selectedDetai = _dangKiDeTaiBUS.LayDeTaiBangMaDeTai(maDeTai);
                if (selectedDetai != null)
                {
                    txtMaDeTai.Text = selectedDetai.MaDeTai;
                    txtTenDeTai.Text = selectedDetai.TenDeTai;
                    txtTrangThaiPheDuyet.Text = selectedDetai.TrangThai;
                    txtGVHD.Text = selectedDetai.MaGVHuongDan;
                    txtGVPB.Text = selectedDetai.MaGVPhanBien;
                }
            }
        }
    }
}
