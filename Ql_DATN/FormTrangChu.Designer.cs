namespace Ql_DATN
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.DeXuatDeTaiPage = new System.Windows.Forms.TabPage();
            this.panelDeXuatDeTai = new System.Windows.Forms.Panel();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.DuyetDeTaiPage = new System.Windows.Forms.TabPage();
            this.panelDuyetDeTai = new System.Windows.Forms.Panel();
            this.DangKiDeTaiPage = new System.Windows.Forms.TabPage();
            this.XacNhanDangKiDeTaiPage = new System.Windows.Forms.TabPage();
            this.NopBaoCaoTienDoPage = new System.Windows.Forms.TabPage();
            this.DangGiaBaoCaoTienDoPage = new System.Windows.Forms.TabPage();
            this.NopDoAnPage = new System.Windows.Forms.TabPage();
            this.DangXuatPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDangXuat = new MaterialSkin.Controls.MaterialButton();
            this.DeXuatDeTaiPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.DuyetDeTaiPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeXuatDeTaiPage
            // 
            this.DeXuatDeTaiPage.Controls.Add(this.panelDeXuatDeTai);
            this.DeXuatDeTaiPage.ImageKey = "icons8-create-document-26.png";
            this.DeXuatDeTaiPage.Location = new System.Drawing.Point(4, 39);
            this.DeXuatDeTaiPage.Name = "DeXuatDeTaiPage";
            this.DeXuatDeTaiPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.DeXuatDeTaiPage.Size = new System.Drawing.Size(1601, 979);
            this.DeXuatDeTaiPage.TabIndex = 0;
            this.DeXuatDeTaiPage.Text = "Đề xuất đề tài";
            this.DeXuatDeTaiPage.UseVisualStyleBackColor = true;
            // 
            // panelDeXuatDeTai
            // 
            this.panelDeXuatDeTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeXuatDeTai.Location = new System.Drawing.Point(3, 3);
            this.panelDeXuatDeTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDeXuatDeTai.Name = "panelDeXuatDeTai";
            this.panelDeXuatDeTai.Size = new System.Drawing.Size(1595, 973);
            this.panelDeXuatDeTai.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.DeXuatDeTaiPage);
            this.tabControl.Controls.Add(this.DuyetDeTaiPage);
            this.tabControl.Controls.Add(this.DangKiDeTaiPage);
            this.tabControl.Controls.Add(this.XacNhanDangKiDeTaiPage);
            this.tabControl.Controls.Add(this.NopBaoCaoTienDoPage);
            this.tabControl.Controls.Add(this.DangGiaBaoCaoTienDoPage);
            this.tabControl.Controls.Add(this.NopDoAnPage);
            this.tabControl.Controls.Add(this.DangXuatPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(2, 52);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1609, 1022);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // DuyetDeTaiPage
            // 
            this.DuyetDeTaiPage.Controls.Add(this.panelDuyetDeTai);
            this.DuyetDeTaiPage.ImageKey = "icons8-confirm-32.png";
            this.DuyetDeTaiPage.Location = new System.Drawing.Point(4, 39);
            this.DuyetDeTaiPage.Name = "DuyetDeTaiPage";
            this.DuyetDeTaiPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.DuyetDeTaiPage.Size = new System.Drawing.Size(1324, 731);
            this.DuyetDeTaiPage.TabIndex = 1;
            this.DuyetDeTaiPage.Text = "Duyệt đề tài";
            this.DuyetDeTaiPage.UseVisualStyleBackColor = true;
            // 
            // panelDuyetDeTai
            // 
            this.panelDuyetDeTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDuyetDeTai.Location = new System.Drawing.Point(3, 3);
            this.panelDuyetDeTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDuyetDeTai.Name = "panelDuyetDeTai";
            this.panelDuyetDeTai.Size = new System.Drawing.Size(1318, 725);
            this.panelDuyetDeTai.TabIndex = 0;
            // 
            // DangKiDeTaiPage
            // 
            this.DangKiDeTaiPage.ImageKey = "icons8-request-feedback-48.png";
            this.DangKiDeTaiPage.Location = new System.Drawing.Point(4, 39);
            this.DangKiDeTaiPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangKiDeTaiPage.Name = "DangKiDeTaiPage";
            this.DangKiDeTaiPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangKiDeTaiPage.Size = new System.Drawing.Size(1324, 731);
            this.DangKiDeTaiPage.TabIndex = 2;
            this.DangKiDeTaiPage.Text = "Đăng kí đề tài";
            this.DangKiDeTaiPage.UseVisualStyleBackColor = true;
            // 
            // XacNhanDangKiDeTaiPage
            // 
            this.XacNhanDangKiDeTaiPage.ImageKey = "icons8-check-all-26.png";
            this.XacNhanDangKiDeTaiPage.Location = new System.Drawing.Point(4, 39);
            this.XacNhanDangKiDeTaiPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XacNhanDangKiDeTaiPage.Name = "XacNhanDangKiDeTaiPage";
            this.XacNhanDangKiDeTaiPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XacNhanDangKiDeTaiPage.Size = new System.Drawing.Size(1324, 731);
            this.XacNhanDangKiDeTaiPage.TabIndex = 3;
            this.XacNhanDangKiDeTaiPage.Text = "Xác nhận đăng kí đê tài";
            this.XacNhanDangKiDeTaiPage.UseVisualStyleBackColor = true;
            // 
            // NopBaoCaoTienDoPage
            // 
            this.NopBaoCaoTienDoPage.ImageKey = "icons8-report-32.png";
            this.NopBaoCaoTienDoPage.Location = new System.Drawing.Point(4, 39);
            this.NopBaoCaoTienDoPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NopBaoCaoTienDoPage.Name = "NopBaoCaoTienDoPage";
            this.NopBaoCaoTienDoPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NopBaoCaoTienDoPage.Size = new System.Drawing.Size(1324, 731);
            this.NopBaoCaoTienDoPage.TabIndex = 4;
            this.NopBaoCaoTienDoPage.Text = "Nộp báo cáo tiến độ";
            this.NopBaoCaoTienDoPage.UseVisualStyleBackColor = true;
            // 
            // DangGiaBaoCaoTienDoPage
            // 
            this.DangGiaBaoCaoTienDoPage.ImageKey = "icons8-evaluate-64.png";
            this.DangGiaBaoCaoTienDoPage.Location = new System.Drawing.Point(4, 39);
            this.DangGiaBaoCaoTienDoPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangGiaBaoCaoTienDoPage.Name = "DangGiaBaoCaoTienDoPage";
            this.DangGiaBaoCaoTienDoPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangGiaBaoCaoTienDoPage.Size = new System.Drawing.Size(1324, 731);
            this.DangGiaBaoCaoTienDoPage.TabIndex = 5;
            this.DangGiaBaoCaoTienDoPage.Text = "Đánh giá báo cáo tiến độ";
            this.DangGiaBaoCaoTienDoPage.UseVisualStyleBackColor = true;
            // 
            // NopDoAnPage
            // 
            this.NopDoAnPage.ImageKey = "icons8-submit-document-80.png";
            this.NopDoAnPage.Location = new System.Drawing.Point(4, 39);
            this.NopDoAnPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NopDoAnPage.Name = "NopDoAnPage";
            this.NopDoAnPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NopDoAnPage.Size = new System.Drawing.Size(1324, 731);
            this.NopDoAnPage.TabIndex = 6;
            this.NopDoAnPage.Text = "Nộp đồ án";
            this.NopDoAnPage.UseVisualStyleBackColor = true;
            // 
            // DangXuatPage
            // 
            this.DangXuatPage.ImageKey = "icons8-score-50.png";
            this.DangXuatPage.Location = new System.Drawing.Point(4, 39);
            this.DangXuatPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangXuatPage.Name = "DangXuatPage";
            this.DangXuatPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangXuatPage.Size = new System.Drawing.Size(1324, 731);
            this.DangXuatPage.TabIndex = 7;
            this.DangXuatPage.Text = "Đánh giá đồ án";
            this.DangXuatPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-score-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-submit-document-80.png");
            this.imageList1.Images.SetKeyName(2, "icons8-evaluate-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-report-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-confirm-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-request-feedback-48.png");
            this.imageList1.Images.SetKeyName(6, "icons8-check-all-26.png");
            this.imageList1.Images.SetKeyName(7, "icons8-create-document-26.png");
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangXuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangXuat.Depth = 0;
            this.btnDangXuat.HighEmphasis = true;
            this.btnDangXuat.Icon = null;
            this.btnDangXuat.Location = new System.Drawing.Point(906, 8);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDangXuat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Size = new System.Drawing.Size(103, 36);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangXuat.UseAccentColor = false;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1076);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDangXuat);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTrangChu";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.DeXuatDeTaiPage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.DuyetDeTaiPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage DeXuatDeTaiPage;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage DuyetDeTaiPage;
        private System.Windows.Forms.TabPage DangKiDeTaiPage;
        private System.Windows.Forms.TabPage XacNhanDangKiDeTaiPage;
        private System.Windows.Forms.TabPage NopBaoCaoTienDoPage;
        private System.Windows.Forms.TabPage DangGiaBaoCaoTienDoPage;
        private System.Windows.Forms.TabPage NopDoAnPage;
        private System.Windows.Forms.TabPage DangXuatPage;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnDangXuat;
        private System.Windows.Forms.Panel panelDeXuatDeTai;
        private System.Windows.Forms.Panel panelDuyetDeTai;
    }
}