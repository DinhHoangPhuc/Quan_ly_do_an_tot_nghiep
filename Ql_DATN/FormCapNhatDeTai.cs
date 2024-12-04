using BUS;
using DTO;
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
    public partial class FormCapNhatDeTai : Form
    {
        private DeTaiPhanHoi deTaiPhanHoi = new DeTaiPhanHoi();
        private string maDeTai;

        public FormCapNhatDeTai()
        {
            InitializeComponent();
        }

        public FormCapNhatDeTai(string maDeTai)
        {
            InitializeComponent();
            this.maDeTai = maDeTai;
        }

        private void FormCapNhatDeTai_Load(object sender, EventArgs e)
        {
            LoadComboTruong();
            LoadYeuCauChinhSua();
            LoadLichSuTrangThai();
            LoadLicuSuChinhsua();
        }

        private void LoadComboTruong()
        {
            cbTruong.DataSource = deTaiPhanHoi.GetTruongChinhSua();
        }

        private void LoadYeuCauChinhSua()
        {
            dgvYeuCauChinhSua.DataSource = deTaiPhanHoi.GetYeuCauChinhSuaDeTaiByMaDeTai(maDeTai);
        }

        private void LoadLichSuTrangThai()
        {
            dgvLichSuTrangThai.DataSource = deTaiPhanHoi.GetLichSuTrangThaiDeTaiByMaDeTai(maDeTai);
        }

        private void LoadLicuSuChinhsua()
        {
            dgvLichSuChinhSua.DataSource = deTaiPhanHoi.GetLichSuChinhSuaDeTaiByMaDeTai(maDeTai);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(cbTruong.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                try
                {
                    deTaiPhanHoi.CapNhatDeTai(maDeTai, cbTruong.SelectedValue.ToString(), txtNoiDung.Text, Session.Username);
                    MessageBox.Show("Cập nhật thành công");

                    LoadYeuCauChinhSua();
                    LoadLichSuTrangThai();
                    LoadLicuSuChinhsua();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trường chính sửa và nội dung");
            }
        }

        //private void dgvPhanHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dgvPhanHoi.Rows[e.RowIndex];
        //        txtmaPhanHoi.Text = row.Cells["MaPhanHoi"].Value.ToString();
        //        txtMaDeTaiPhanHoi.Text = row.Cells["MaDeTai"].Value.ToString();
        //        txtSuaDetai.Text = row.Cells["NoiDungChinhSua"].Value?.ToString();
        //        txtPhanHoi.Text = row.Cells["NoiDungPhanHoi"].Value.ToString();
        //        dateNgayCinhSua.Text = row.Cells["NgayChinhSua"].Value?.ToString();
        //        dateNgayPhanHoi.Text = row.Cells["NgayPhanHoi"].Value.ToString();
        //    }
        //}

        //private void btnLuudeTai_Click(object sender, EventArgs e)
        //{
        //    bool result = deTaiPhanHoi.LuuChinhSuaDeTai(int.Parse(txtmaPhanHoi.Text), txtSuaDetai.Text);

        //    if (result)
        //    {
        //        MessageBox.Show("Lưu chỉnh sửa thành công");
        //        LoadPhanHoiByDeTai(txtMaDeTaiPhanHoi.Text);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lưu chỉnh sửa thất bại");
        //    }
        //}

        //private void LoadPhanHoiByDeTai(string maDeTai)
        //{
        //    List<PhanHoiDeTaiDTO> lstPhanHoi = deTaiPhanHoi.GetPhanHoiDeTaiByMaDeTai(maDeTai);
        //    if (lstPhanHoi != null)
        //    {
        //        dgvPhanHoi.DataSource = lstPhanHoi;
        //    }
        //}
    }
}
