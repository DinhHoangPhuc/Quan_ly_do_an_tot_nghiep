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
using System.Data.Linq;

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
            dataGridViewDoAn.SelectionChanged += new EventHandler(dataGridViewDoAn_SelectionChanged);
            this.Click += btnHuy_Click;


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

            List<dynamic> doAnList = bus.LoadDoAn();


            dataGridViewDoAn.DataSource = doAnList;
        }

        private void NopDoAn_Load(object sender, EventArgs e)
        {

            List<DeTai> detai = bus.GetDeTaiList();

            cbbMaDeTai.DataSource = detai;
            cbbMaDeTai.DisplayMember = "MaDeTai";
            cbbMaDeTai.ValueMember = "MaDeTai";

            List<NhomSinhVien> nhom = bus.GetNhomList();
            cbbMaNhom.DataSource = nhom;
            cbbMaNhom.DisplayMember = "MaNhom";
            cbbMaNhom.ValueMember = "MaNhom";
            LoadDoAn();

        }


        private void btnNop_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();
            string maDeTai = cbbMaDeTai.SelectedValue.ToString();
            string maNhom = cbbMaNhom.SelectedValue.ToString();
            DateTime ngayNop = dateTimeNgayNop.Value;
            bool success = bus.AddData(maDeTai, maNhom, ngayNop, ID);

            if (success)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            LoadDoAn();


        }

        private void dataGridViewDoAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoAn.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewDoAn.SelectedRows[0];
                txtID.Text = selectedRow.Cells["ID"].ToString();
                cbbMaDeTai.SelectedValue = selectedRow.Cells["MaDeTai"].Value.ToString();
                cbbMaNhom.SelectedValue = selectedRow.Cells["MaNhom"].Value.ToString();
                dateTimeNgayNop.Value = Convert.ToDateTime(selectedRow.Cells["NgayNopDoAn"].Value);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbbMaDeTai.SelectedIndex = -1;
            cbbMaNhom.SelectedIndex = -1;
            txtID.Text = "";
            dateTimeNgayNop.Value = DateTime.Now;
        }


    }
}
