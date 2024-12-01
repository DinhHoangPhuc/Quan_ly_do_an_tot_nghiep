using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Ql_DATN
{
    public partial class NopDoAn : Form
    {
        private DoAnBus bus;
      

        public NopDoAn()
        {
            InitializeComponent();
            bus = new DoAnBus();
            this.Load += NopDoAn_Load;
            this.Click += btnNop_Click;
           
            this.Click += btnHuy_Click;
            string maNhom = "N002";
            LoadMaDeTaiForMaNhom(maNhom);
            LoadDoAn();
           // dataGridViewDoAn.SelectionChanged += new EventHandler(dataGridViewDoAn_SelectionChanged);

        }
        private void LoadDataToComboBox()
        {
            foreach (DataGridViewRow row in dataGridViewDoAn.Rows)
            {

                if (row.Cells["MaDeTai"].Value != null)
                {

                    string maDeTai = row.Cells["MaDeTai"].Value.ToString();
                    cbbMaDeTai.Items.Add(maDeTai);
                }
            }
        }

        private void LoadDoAn()
        {
            try
            {
               
                var data = bus.GetDoAnVaDiems();
                dataGridViewDoAn.DataSource = data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NopDoAn_Load(object sender, EventArgs e)
        {


            List<string> nhom = bus.GetMaNhomList();
            cbbMaNhom.DataSource = nhom;
            LoadDoAn();

        }
        private void LoadMaDeTaiForMaNhom(string maNhom)
        {
            List<string> maDeTaiList = bus.GetMaDeTaiByMaNhom(maNhom);
            cbbMaDeTai.DataSource = maDeTaiList;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {

            try
            {
                string maDeTai = cbbMaDeTai.SelectedValue?.ToString();
                string maNhom = cbbMaNhom.SelectedValue?.ToString();
                DateTime ngayNopDoAn = dateTimeNgayNop.Value;

                if (string.IsNullOrEmpty(maDeTai) || string.IsNullOrEmpty(maNhom))
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin Mã Đề Tài và Mã Nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Tài liệu Word|*.docx;*.doc",
                    Title = "Chọn file để tải lên"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                    rtxNoiDungDoAn.Text = openFileDialog.FileName;
                    bool result = bus.UploadFileToDatabase(maNhom, maDeTai, ngayNopDoAn, fileBytes);

                    if (result)
                    {
                        MessageBox.Show("Nộp đồ án thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewDoAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoAn.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewDoAn.SelectedRows[0];

                cbbMaDeTai.SelectedValue = selectedRow.Cells["MaDeTai"].Value.ToString();
                cbbMaNhom.SelectedValue = selectedRow.Cells["MaNhom"].Value.ToString();
                dateTimeNgayNop.Value = Convert.ToDateTime(selectedRow.Cells["NgayNopDoAn"].Value);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbbMaDeTai.SelectedIndex = -1;
            cbbMaNhom.SelectedIndex = -1;

            dateTimeNgayNop.Value = DateTime.Now;
        }
    }
}
