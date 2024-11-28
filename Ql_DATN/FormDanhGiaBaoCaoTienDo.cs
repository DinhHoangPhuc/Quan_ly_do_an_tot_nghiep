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
    public partial class FormDanhGiaBaoCaoTienDo : Form
    {
        private DanhGiaBCTDBUS danhGiaBUS = new DanhGiaBCTDBUS();
        public FormDanhGiaBaoCaoTienDo()
        {
            InitializeComponent();
        }

        private void btnGuiDanhGia_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                string maDanhGia = txtMaDanhGia.Text.Trim();
                string maBaoCao = txtMaBaoCao.Text.Trim();
                DateTime ngayDanhGia = DTPNgayDanhGia.Value;
                string maNhom = txtMaNhom.Text.Trim();
                string maGiangVien = txtMaGiangVien.Text.Trim();
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
    }
}
