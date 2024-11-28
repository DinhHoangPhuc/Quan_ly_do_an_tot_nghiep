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
    public partial class FormDuyetDeTai : Form
    {
        private DeTaiPhanHoi deTaiPhanHoi = new DeTaiPhanHoi();

        public FormDuyetDeTai()
        {
            InitializeComponent();
        }

        private void FormDuyetDeTai_Load(object sender, EventArgs e)
        {
            LoadComboGVHD();
            LoadComboTrangThai();
            LoadDataGridViewDeTai();
        }

        private void LoadComboTrangThai()
        {
            cbTrangThai.DataSource = deTaiPhanHoi.GetListTrangThaiDeTai();
        }

        private void LoadDataGridViewDeTai()
        {
            dgvDeTai.DataSource = deTaiPhanHoi.GetAllDeTai();
        }

        private void LoadComboGVHD()
        {
            cbGVHD.DataSource = deTaiPhanHoi.GetAllGVHD();
            cbGVHD.DisplayMember = "TenGVHD";
            cbGVHD.ValueMember = "MaGVHD";
        }

        private void cbGVHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDeTai.DataSource = deTaiPhanHoi.LocDeTaiTheoMaGVHD(cbGVHD.SelectedValue.ToString());
        }

        //private void txtTimKiemGV_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtTimKiemGV.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txtTimKiemGV, "Tên giảng viên không được để trống.");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(txtTimKiemGV, null);
        //    }
        //}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtTimKiemGV.Text))
            {
                dgvDeTai.DataSource = deTaiPhanHoi.TimKiemDeTaiTrongTatCaCot(txtTimKiemGV.Text);
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
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                dateNgayDeXuat.Text = row.Cells["NgayDeXuat"].Value.ToString();
                dateNgayDuyet.Text = row.Cells["NgayDuyet"].Value?.ToString();
                txtMaGVPB.Text = row.Cells["MaGVPB"].Value?.ToString();
                txtMaBoMon.Text = row.Cells["MaBoMon"].Value.ToString();

                LoadPhanHoiByDeTai(row.Cells["MaDeTai"].Value.ToString());
            }
        }

        private void LoadPhanHoiByDeTai(string maDeTai)
        {
            List<PhanHoiDeTaiDTO> lstPhanHoi = deTaiPhanHoi.GetPhanHoiDeTaiByMaDeTai(maDeTai);
            if (lstPhanHoi != null)
            {
                dgvPhanHoi.DataSource = lstPhanHoi;
            }
        }

        private void dgvPhanHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanHoi.Rows[e.RowIndex];
                txtMaPhanHoi.Text = row.Cells["MaPhanHoi"].Value.ToString();
                txtMaDeTaiPhanHoi.Text = row.Cells["MaDeTai"].Value.ToString();
                txtNoiDungChinhSua.Text = row.Cells["NoiDungChinhSua"].Value?.ToString();
                txtPhanHoi.Text = row.Cells["NoiDungPhanHoi"].Value.ToString();
                dateNgayChinhSua.Text = row.Cells["NgayChinhSua"].Value?.ToString();
                dateNgayPhanHoi.Text = row.Cells["NgayPhanHoi"].Value.ToString();
            }
        }

        private void btnLuuPhanHoi_Click(object sender, EventArgs e)
        {

        }
    }
}
