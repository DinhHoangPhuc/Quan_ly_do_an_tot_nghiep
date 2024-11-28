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
    public partial class FormNopBaoCaoTienDo : Form
    {
        private NopBaoCaoTienDoBUS baoCaoBUS = new NopBaoCaoTienDoBUS();

        public FormNopBaoCaoTienDo()
        {
            InitializeComponent();
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
                string maNhom = txtMaNhom.Text.Trim();
                string maGiangVien = txtMaGiangVien.Text.Trim();

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
    }
}
