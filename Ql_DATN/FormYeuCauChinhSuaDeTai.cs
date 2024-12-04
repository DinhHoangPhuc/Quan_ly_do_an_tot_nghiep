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
    public partial class FormYeuCauChinhSuaDeTai : Form
    {
        private DeTaiPhanHoi deTaiPhanHoi = new DeTaiPhanHoi();
        private string maDeTai;

        public FormYeuCauChinhSuaDeTai()
        {
            InitializeComponent();
        }

        public FormYeuCauChinhSuaDeTai(string maDeTai)
        {
            InitializeComponent();
            this.maDeTai = maDeTai;
        }

        private void FormYeuCauChinhSuaDeTai_Load(object sender, EventArgs e)
        {
            LoadComboTruong();
        }

        private void LoadComboTruong()
        {
            cbTruong.DataSource = deTaiPhanHoi.GetTruongChinhSua();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                deTaiPhanHoi.LuuYeuCauChinhSuaDeTai(maDeTai, cbTruong.SelectedValue.ToString(), txtYeuCau.Text, deTaiPhanHoi.GetMaGVByMaND(Session.Username));
                MessageBox.Show("Yêu cầu chỉnh sửa đề tài thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
