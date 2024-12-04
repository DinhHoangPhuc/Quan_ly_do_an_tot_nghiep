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
    public partial class XetDuyetDangKy : Form
    {
        public XetDuyetDangKy()
        {
            InitializeComponent();
        }

        private void XetDuyetDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DOANDataSet1.DangKyDeTai' table. You can move, or remove it, as needed.
            this.dangKyDeTaiTableAdapter.Fill(this.qL_DOANDataSet1.DangKyDeTai);
            cbTrangThaiPheDuyet.Items.Add("Đã hủy");
            cbTrangThaiPheDuyet.Items.Add("Đã đăng ký");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DangKiDeTaiBUS dkDeTai = new DangKiDeTaiBUS();

            if (e.RowIndex >= 0)
            {
                txtMaDeTai.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDangKyDeTaiDataGridViewTextBoxColumn"].Value.ToString();
                txtNgayDK.Text = dataGridView1.Rows[e.RowIndex].Cells["ngayDangKyDataGridViewTextBoxColumn"].Value.ToString();
                txtMaNhom.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNhomDataGridViewTextBoxColumn"].Value.ToString();
                txtMaDeTai.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDeTaiDataGridViewTextBoxColumn"].Value.ToString();
                cbTrangThaiPheDuyet.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["TrangThaiDataGridViewTextBoxColumn"].Value.ToString();

                DeTai dt = dkDeTai.LayDeTaiBangMaDeTai(txtMaDeTai.Text);
                DangKyDeTai dkdt = dt.DangKyDeTais.First(d => d.MaDeTai == dt.MaDeTai);
                HocKy hk = dkdt.ThoiGianDangKy.HocKy;
                NhomSinhVien nsv = dkdt.NhomSinhVien;


                txtHocKi.Text = hk.TenHocKy.ToString();
                txtTenDeTai.Text = dt.TenDeTai.ToString();
                txtMaNhom.Text = nsv.MaNhom.ToString();
                txtMaNhomTruong.Text = nsv.MaNhomTruong.ToString();
                txtGVHD.Text = dt.MaGVHuongDan.ToString();
                txtGVPB.Text = dt.MaGVPhanBien.ToString();
                txtMaDKDT.Text = dkdt.MaDangKyDeTai.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maDKDT = txtMaDKDT.Text;

            DangKiDeTaiBUS dkDeTai = new DangKiDeTaiBUS();

            string trangThai = cbTrangThaiPheDuyet.SelectedItem.ToString();

            try
            {
                dkDeTai.CapNhatTrangThaiDangKyDeTai(maDKDT, trangThai);
            }
            catch (Exception ex) {
                MessageBox.Show("Không thể cập nhật thông tin trang thái đăng ký đề tài " + ex.Message, "Thông Báo");
            }
            MessageBox.Show("Cập nhật trạng thái thành công", "Thông Báo");
        }
    }
}
