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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ql_DATN
{
    public partial class FormTrangChu : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Form frmDeXuatDeTai;
        private Form frmDuyetDeTai;
        private Form formQuanLyNguoiDung;
        private Form frmNopDoAn;
        private Form frmTinhLuong;
        private Form frmQuanLyViPham;

        public FormTrangChu()
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

            InitializeChildForms();
            //CheckUserPermissions();
        }

        private void InitializeChildForms()
        {
            frmDeXuatDeTai = new FormDeXuatDeTai();
            frmDuyetDeTai = new FormDuyetDeTai();
            frmNopDoAn = new NopDoAn();
            //formQuanLyNguoiDung = new FormQuanLyNguoiDung();
            //frmPhanQuyen = new FormPhanQuyen();
            //frmQuanLyViPham = new FormViPham();
        }

        private void CheckUserPermissions()
        {
            //string username = Session.Username;
            //UserService userService = new UserService();
            //PermissionService permissionService = new PermissionService();

            //string userGroup = userService.GetUserGroup(username);
            //List<string> permissions = permissionService.GetPermissions(userGroup);

            //// Log the permissions for debugging
            //Console.WriteLine("Permissions for user group " + userGroup + ": " + string.Join(", ", permissions));

            //// Disable tabs based on permissions
            //if (!permissions.Contains("FormDashBoard") && tabControl.TabPages.Contains(TrangChuPage))
            //{
            //    tabControl.TabPages.Remove(TrangChuPage);
            //}
            //if (!permissions.Contains("FormDiemThiDua") && tabControl.TabPages.Contains(DiemThiDuaViPhamPage))
            //{
            //    tabControl.TabPages.Remove(DiemThiDuaViPhamPage);
            //}
            //if (!permissions.Contains("FormQuanLyNguoiDung") && tabControl.TabPages.Contains(QuanLynguoiDungPage))
            //{
            //    tabControl.TabPages.Remove(QuanLynguoiDungPage);
            //}
            //if (!permissions.Contains("FormPhanQuyen") && tabControl.TabPages.Contains(PhanQuyenPage))
            //{
            //    tabControl.TabPages.Remove(PhanQuyenPage);
            //}
            //if (!permissions.Contains("FormTinhLuong") && tabControl.TabPages.Contains(QuanLyTienLuongPage))
            //{
            //    tabControl.TabPages.Remove(QuanLyTienLuongPage);
            //}
            //if (!permissions.Contains("FormViPham") && tabControl.TabPages.Contains(QuanLyViPhamPage))
            //{
            //    tabControl.TabPages.Remove(QuanLyViPhamPage);
            //}
            //if (!permissions.Contains("FormXemTienLuong") && tabControl.TabPages.Contains(LuongPage))
            //{
            //    tabControl.TabPages.Remove(LuongPage);
            //}
        }


        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            //// Chuyển đổi giữa Light và Dark Theme
            //if (materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
            //{
            //    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //}
            //else
            //{
            //    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //}

            //// Lưu trạng thái theme vào Settings
            //Properties.Settings.Default.IsDarkTheme = (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK);
            //Properties.Settings.Default.Save();

            //// Cập nhật theme cho tất cả các form đang mở
            //UpdateThemeForAllForms();
        }

        private void UpdateThemeForAllForms()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MaterialForm materialForm)
                {
                    materialSkinManager.AddFormToManage(materialForm);
                    ResetControlSizes(materialForm);
                }
            }
        }

        private void ResetControlSizes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                control.Size = control.PreferredSize;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            if (tabControl.SelectedTab == DeXuatDeTaiPage)
            {
                AddFormDeXuatDeTaiToTabPage();
            }
            else if (tabControl.SelectedTab == DuyetDeTaiPage)
            {
                AddFormDuyetDeTaiToTabPage();
            }
            else if (tabControl.SelectedTab == DangKiDeTaiPage)
            {
                AddFormQuanLyNguoiDungToTabPage();
            }
            else if (tabControl.SelectedTab == NopDoAnPage)
            {
                AddFormNopDoAnToTabPage();
            }
            else if (tabControl.SelectedTab == NopBaoCaoTienDoPage)
            {
                AddFormQuanLyTienLuongToTabPage();
            }
            else if (tabControl.SelectedTab == XacNhanDangKiDeTaiPage)
            {
                AddFormQuanLyViPhamToTabPage();
            }
            else if (tabControl.SelectedTab == DangGiaBaoCaoTienDoPage)
            {
                AddFormXemTienLuongToTabPage();
            }
        }

        private void ShowChildForm<T>(ref T childForm) where T : Form, new()
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new T();
            }

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        private void AddFormDeXuatDeTaiToTabPage()
        {
            frmDeXuatDeTai.TopLevel = false;
            frmDeXuatDeTai.FormBorderStyle = FormBorderStyle.None;
            frmDeXuatDeTai.Dock = DockStyle.Fill;

            panelDeXuatDeTai.Controls.Clear();

            panelDeXuatDeTai.Controls.Add(frmDeXuatDeTai);
            frmDeXuatDeTai.Show();
        }

        private void AddFormDuyetDeTaiToTabPage()
        {
            frmDuyetDeTai.TopLevel = false;
            frmDuyetDeTai.FormBorderStyle = FormBorderStyle.None;
            frmDuyetDeTai.Dock = DockStyle.Fill;

            panelDuyetDeTai.Controls.Clear();

            panelDuyetDeTai.Controls.Add(frmDuyetDeTai);
            frmDuyetDeTai.Show();
        }

        private void AddFormQuanLyNguoiDungToTabPage()
        {
            formQuanLyNguoiDung.TopLevel = false;
            formQuanLyNguoiDung.FormBorderStyle = FormBorderStyle.None;
            formQuanLyNguoiDung.Dock = DockStyle.Fill;

            DangKiDeTaiPage.Controls.Clear();

            DangKiDeTaiPage.Controls.Add(formQuanLyNguoiDung);
            formQuanLyNguoiDung.Show();
        }

        private void AddFormNopDoAnToTabPage()
        {
            frmNopDoAn.TopLevel = false;
            frmNopDoAn.FormBorderStyle = FormBorderStyle.None;
            frmNopDoAn.Dock = DockStyle.Fill;

            NopDoAnPage.Controls.Clear();

            NopDoAnPage.Controls.Add(frmNopDoAn);
            frmNopDoAn.Show();
        }

        private void AddFormQuanLyTienLuongToTabPage()
        {
            //frmTinhLuong = new FormTinhLuong();

            //frmTinhLuong.TopLevel = false;
            //frmTinhLuong.FormBorderStyle = FormBorderStyle.None;
            //frmTinhLuong.Dock = DockStyle.Fill;

            //QuanLyTienLuongPage.Controls.Clear();

            //QuanLyTienLuongPage.Controls.Add(frmTinhLuong);
            //frmTinhLuong.Show();
        }

        private void AddFormQuanLyViPhamToTabPage()
        {
            frmQuanLyViPham.TopLevel = false;
            frmQuanLyViPham.FormBorderStyle = FormBorderStyle.None;
            frmQuanLyViPham.Dock = DockStyle.Fill;

            XacNhanDangKiDeTaiPage.Controls.Clear();

            XacNhanDangKiDeTaiPage.Controls.Add(frmQuanLyViPham);
            frmQuanLyViPham.Show();
        }

        private void AddFormXemTienLuongToTabPage()
        {
            //Form frmXemTienLuong = new FormXemTienLuong();
            //frmXemTienLuong.TopLevel = false;
            //frmXemTienLuong.FormBorderStyle = FormBorderStyle.None;
            //frmXemTienLuong.Dock = DockStyle.Fill;
            //LuongPage.Controls.Clear();
            //LuongPage.Controls.Add(frmXemTienLuong);
            //frmXemTienLuong.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void DangXuatPage_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Session.Username = null;


            FormDangNhap loginForm = new FormDangNhap();
            loginForm.Show();
            this.Close();

        }
    }
}
