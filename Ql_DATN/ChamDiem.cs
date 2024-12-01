using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using DTO;

namespace Ql_DATN
{
    public partial class ChamDiem : Form
    {
        private ChamDiemBUS bus;

        public ChamDiem()
        {
            InitializeComponent();
            bus = new ChamDiemBUS();
            this.Load += Form1_Load;
            this.Click += btnLuu_Click;
            LoadDataToGrid();
            dgvDoAnVaChamDiem.SelectionChanged += new EventHandler(dgvDoAnVaChamDiem_SelectionChanged);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        public void LoadDataToGrid()
        {
            var data = bus.GetAllDoAn();
            dgvDoAnVaChamDiem.DataSource = data;
        }

        private ChamDiemBUS GetBus()
        {
            return bus;
        }

        private void btnLuu_Click(object sender, EventArgs e, ChamDiemBUS bus)
        {
            try
            {  
                string maDeTai = txtMaDeTai.Text;
                string maNhom = txtMaNhom.Text;
                DateTime ngayNopDoAn = dateTimeNgayBaoCao.Value;
                string nhanXet = rtxtNhanXetGVPB.Text;
                DateTime? ngayCham = dateTimeNgayDanhGia.Checked ? (DateTime?)dateTimeNgayDanhGia.Value : null;
                float diemGVHuongDan = float.TryParse(txtDiemGVHD.Text, out diemGVHuongDan) ? Math.Abs(diemGVHuongDan) : 0f;
                diemGVHuongDan = (float)Math.Round(diemGVHuongDan, 2);
                float diemGVPB = float.TryParse(txtDiemGVPB.Text, out diemGVPB) ? Math.Abs(diemGVPB) : 0f;
                diemGVPB = (float)Math.Round(diemGVPB, 2);

                bool v = bus.AddData(maDeTai, maNhom, nhanXet,
                         diemGVHuongDan,
                         diemGVPB, 
                         ngayCham);

                // Kết quả trả về
                bool result = v;
                if (result)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value != DBNull.Value ? row.Cells[columnName].Value.ToString() : string.Empty;
        }

        private DateTime GetDateCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value != DBNull.Value ? Convert.ToDateTime(row.Cells[columnName].Value) : DateTime.Now;
        }
        private void dgvDoAnVaChamDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoAnVaChamDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDoAnVaChamDiem.SelectedRows[0];
                txtMaDeTai.Text = selectedRow.Cells["MaDeTai"].Value?.ToString() ?? string.Empty;
                txtMaNhom.Text = selectedRow.Cells["MaNhom"].Value?.ToString() ?? string.Empty;
                if (selectedRow.Cells["NgayNopDoAn"].Value != null)
                {
                    dateTimeNgayBaoCao.Value = Convert.ToDateTime(selectedRow.Cells["NgayNopDoAn"].Value);
                }
                txtDiemCuoiCung.Text = selectedRow.Cells["DiemCuoiCung"].Value?.ToString() ?? string.Empty;
                txtDiemGVHD.Text = selectedRow.Cells["DiemGVHuongDan"].Value?.ToString() ?? string.Empty;
                txtDiemGVPB.Text = selectedRow.Cells["DiemGVPhanBien"].Value?.ToString() ?? string.Empty;
       
                rtxtNhanXetGVPB.Text = selectedRow.Cells["NhanXet"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
          
            dateTimeNgayDanhGia.Value = DateTime.Now;
            txtDiemCuoiCung.Text = "";
            txtDiemGVHD.Text = "";
            txtDiemGVPB.Text = "";
            rtxtNhanXetGVPB.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maDeTai = txtMaDeTai.Text;
                string maNhom = txtMaNhom.Text;
                DateTime ngayNopDoAn = dateTimeNgayBaoCao.Value;
                string nhanXet = rtxtNhanXetGVPB.Text;
                float diemGVHuongDan = float.TryParse(txtDiemGVHD.Text, out diemGVHuongDan) ? Math.Abs(diemGVHuongDan) : 0f;
                diemGVHuongDan = (float)Math.Round(diemGVHuongDan, 2);
                float diemGVPB = float.TryParse(txtDiemGVPB.Text, out diemGVPB) ? Math.Abs(diemGVPB) : 0f;
                diemGVPB = (float)Math.Round(diemGVPB, 2);
                float diemCuoiCung = float.TryParse(txtDiemCuoiCung.Text, out diemCuoiCung) ? Math.Abs(diemCuoiCung) : 0f;
                diemCuoiCung = (float)Math.Round(diemCuoiCung, 2);
                DateTime? ngayCham = dateTimeNgayDanhGia.Checked ? (DateTime?)dateTimeNgayDanhGia.Value : null;
                bool v = bus.AddData(maDeTai, maNhom, nhanXet,diemGVHuongDan,diemGVPB,ngayCham);
                bool result = v;
                if (result)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
