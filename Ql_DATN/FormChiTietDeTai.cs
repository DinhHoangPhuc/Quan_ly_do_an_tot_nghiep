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
    public partial class FormChiTietDeTai : Form
    {
        private DeTaiPhanHoi deTaiPhanHoi = new DeTaiPhanHoi();
        private string maDeTai;

        public FormChiTietDeTai()
        {
            InitializeComponent();
        }

        public FormChiTietDeTai(string maDeTai)
        {
            InitializeComponent();
            this.maDeTai = maDeTai;
        }

        private void FormChiTietDeTai_Load(object sender, EventArgs e)
        {
            LoadYeuCauChinhSua();
            LoadLichSuTrangThai();
            LoadLicuSuChinhsua();
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
    }
}
