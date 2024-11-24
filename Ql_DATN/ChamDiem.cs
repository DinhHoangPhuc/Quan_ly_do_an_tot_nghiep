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
using BUS;

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
            LoadDoAn();
            LoadDataToGrid();
            dgvDoAnVaChamDiem.SelectionChanged += new EventHandler(dgvDoAnVaChamDiem_SelectionChanged);

        }
        private void LoadDataToGrid()
        {
            try
            {
                List<DoAnVaDiem> doAn = bus.GetAllDoAnVaDiem();
                dgvDoAnVaChamDiem.DataSource = doAn;
                dgvDoAnVaChamDiem.Columns["Id"].HeaderText = "ID";
                dgvDoAnVaChamDiem.Columns["NoiDungDoAn"].HeaderText = "Nội dung đồ án";
                dgvDoAnVaChamDiem.Columns["DiemGVHuongDan"].HeaderText = "Điểm GV Hướng Dẫn";
                dgvDoAnVaChamDiem.Columns["DiemGVPhanBien"].HeaderText = "Điểm GV Phản Biện";
                dgvDoAnVaChamDiem.Columns["DiemCuoiCung"].HeaderText = "Điểm Cuối Cùng";
                dgvDoAnVaChamDiem.Columns["NhanXet"].HeaderText = "Nhận Xét";
                dgvDoAnVaChamDiem.Columns["NgayCham"].HeaderText = "Ngày Chấm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDoAn()
        {

            List<dynamic> doAnList = bus.LoadDoAn();

            dgvDoAnVaChamDiem.DataSource = doAnList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDoAn();
            LoadDataToGrid();


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string noiDungDoAn = rtxNoiDungDoAn.Text;
                string nhanXet = rtxtNhanXetGVPB.Text;
                DateTime ngayCham = dateTimeNgayDanhGia.Value;

                float diemGVHuongDan = 0;
                float diemGVPhanBien = 0;


                bool isValidDiemGVHD = float.TryParse(txtDiemGVHD.Text, out diemGVHuongDan);
                bool isValidDiemGVPB = float.TryParse(txtDiemGVPB.Text, out diemGVPhanBien);

                if (isValidDiemGVHD && isValidDiemGVPB)
                {
                    diemGVHuongDan = (float)Math.Round(diemGVHuongDan, 2);
                    diemGVPhanBien = (float)Math.Round(diemGVPhanBien, 2);
                    bool isUpdated = bus.AddData(id, noiDungDoAn, nhanXet, diemGVHuongDan, diemGVPhanBien, ngayCham);

                    if (isUpdated)
                    {

                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGrid();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                txtMaDeTai.Text = selectedRow.Cells["MaDeTai"].Value.ToString();
                txtMaNhom.Text = selectedRow.Cells["MaNhom"].Value.ToString();
                txtID.Text = selectedRow.Cells["Id"].Value.ToString();
                dateTimeNgayBaoCao.Value = Convert.ToDateTime(selectedRow.Cells["NgayNopDoAn"].Value);
                txtDiemCuoiCung.Text = selectedRow.Cells["DiemCuoiCung"].Value.ToString();
                txtDiemGVHD.Text = selectedRow.Cells["DiemGVHuongDan"].Value.ToString();
                txtDiemGVPB.Text = selectedRow.Cells["DiemGVPhanBien"].Value.ToString();
                rtxNoiDungDoAn.Text = selectedRow.Cells["NoiDungDoAn"].Value.ToString();
                rtxtNhanXetGVPB.Text = selectedRow.Cells["NhanXet"].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            dateTimeNgayDanhGia.Value = DateTime.Now;
            txtDiemCuoiCung.Text = "";
            txtDiemGVHD.Text = "";
            txtDiemGVPB.Text = "";
            rtxNoiDungDoAn.Text = "";
            rtxtNhanXetGVPB.Text = "";
        }
    }
}
