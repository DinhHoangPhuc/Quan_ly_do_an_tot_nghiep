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
            }
        }

        private void btnLuuTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                deTaiPhanHoi.CapNhatTrangThaiDeTai(txtMaDeTai.Text, cbTrangThai.SelectedValue.ToString());
                deTaiPhanHoi.LuuLichSuTrangThaiDeTai(txtMaDeTai.Text, cbTrangThai.SelectedValue.ToString(), Session.Username);

                MessageBox.Show("Cập nhật trạng thái đề tài thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXemChiTietDeTai_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtMaDeTai.Text))
            {
                FormChiTietDeTai formChiTietDeTai = new FormChiTietDeTai(txtMaDeTai.Text);
                formChiTietDeTai.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đề tài");
            }
        }

        private void btnYeuCauChinhSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaDeTai.Text))
            {
                FormYeuCauChinhSuaDeTai formYeuCauChinhSua = new FormYeuCauChinhSuaDeTai(txtMaDeTai.Text);
                formYeuCauChinhSua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đề tài");
            }
        }
    }
 }
