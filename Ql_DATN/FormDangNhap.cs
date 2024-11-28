using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using BUS;

namespace Ql_DATN
{
    public partial class FormDangNhap : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly DangNhap dangNhaphelper;

        public FormDangNhap()
        {
            InitializeComponent();

            // Khởi tạo MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Mặc định là Light Theme
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE);

            dangNhaphelper = new DangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            bool ketQuaDangNhap = dangNhaphelper.Login(taiKhoan, matKhau);

            if (ketQuaDangNhap)
            {
                if (dangNhaphelper.CheckHoatDongTaiKhoan(taiKhoan))
                {
                    Session.Username = taiKhoan;

                    MessageBox.Show("Đăng nhập thành công");
                    MoFormTrangChu();
                }
                else
                {
                    MessageBox.Show("Tài khoản bị vô hiệu hóa");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !!");
            }
        }

        private void MoFormTrangChu()
        {
            FormTrangChu frm = new FormTrangChu();
            frm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Password = !chkShowPassword.Checked;
        }
    }
}
