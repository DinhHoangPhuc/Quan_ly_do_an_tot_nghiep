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
using DTO;

namespace Ql_DATN
{
    public partial class FormDeXuatDeTai : Form
    {
        private string MaND = Session.Username;
        private DeTaiPhanHoi deTaiPhanHoi = new DeTaiPhanHoi();

        public FormDeXuatDeTai()
        {
            InitializeComponent();
        }

        private void FormDeXuatDeTai_Load(object sender, EventArgs e)
        {
            LoadComboTrangThai();
            LoadDataDeTai();
        }

        private void LoadDataDeTai()
        {
            List<DeXuatDetai> lstDeTai = deTaiPhanHoi.GetDeTaiForGiangVien(MaND);
            if (lstDeTai != null)
            {
                dgvDeTai.DataSource = lstDeTai;
            }
            else
            {
                MessageBox.Show("Không có đề tài nào");
            }
        }

        private void dgvDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDeTai.Rows[e.RowIndex];
                txtMaDeTai.Text = row.Cells["MaDeTai"].Value.ToString();
                txtTenDetai.Text = row.Cells["TenDeTai"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                dateNgayDeXuat.Text = row.Cells["NgayDeXuat"].Value.ToString();

                //LoadPhanHoiByDeTai(row.Cells["MaDeTai"].Value.ToString());
            }
        }

        private void btnDeXuat_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                DeXuatDetai deXuatDetai = new DeXuatDetai();
                deXuatDetai.TenDeTai = txtTenDetai.Text;
                deXuatDetai.MoTa = txtMoTa.Text;
                deXuatDetai.MaGVHD = deTaiPhanHoi.GetMaGVByMaND(MaND);

                try
                {
                    deTaiPhanHoi.DeXuatDeTai(deXuatDetai, MaND);
                    MessageBox.Show("Đề xuất đề tài thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                    //bool insertResult = deTaiPhanHoi.DeXuatDeTai(deXuatDetai);

                    //if (insertResult)
                    //{
                    //    MessageBox.Show("Đề xuất đề tài thành công");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Lỗi thêm đề tài");
                    //}
            }
        }

        private void txtTenDetai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDetai.Text))
            {
                e.Cancel = true;
                errorProviderTextBox.SetError(txtTenDetai, "Tên đề tài không được để trống.");
            }
            else
            {
                e.Cancel = false;
                errorProviderTextBox.SetError(txtTenDetai, null);
            }
        }

        private void txtMoTa_Validating(object sender, CancelEventArgs e)
        {   
            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                e.Cancel = true;
                errorProviderTextBox.SetError(txtMoTa, "Mô tả không được để trống.");
            }
            else
            {
                e.Cancel = false;
                errorProviderTextBox.SetError(txtMoTa, null);
            }
        }

        private void btnChiTietDeTai_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtMaDeTai.Text))
            {
                FormCapNhatDeTai formChiTietDeTai = new FormCapNhatDeTai(txtMaDeTai.Text);
                formChiTietDeTai.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đề tài");
            }
        }

        private void LoadComboTrangThai()
        {
            cbLocTrangThai.DataSource = deTaiPhanHoi.GetListTrangThaiDeTai();
        }

        private void cbLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDeTai.DataSource = deTaiPhanHoi.LocDeTaiTheoTrangThai(cbLocTrangThai.SelectedValue.ToString(), MaND);
        }
    }
}
