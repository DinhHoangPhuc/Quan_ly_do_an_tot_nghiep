namespace Ql_DATN
{
    partial class FormDanhGiaBaoCaoTienDo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuiDanhGia = new MaterialSkin.Controls.MaterialButton();
            this.txtMaDanhGia = new System.Windows.Forms.TextBox();
            this.txtMaBaoCao = new System.Windows.Forms.TextBox();
            this.DTPNgayDanhGia = new System.Windows.Forms.DateTimePicker();
            this.multitxtNDDanhGia = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đánh Giá Báo Cáo Tiến Độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đánh Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Báo Cáo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Đánh Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nội dung đánh giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Nhóm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Giảng Viên:";
            // 
            // btnGuiDanhGia
            // 
            this.btnGuiDanhGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuiDanhGia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuiDanhGia.Depth = 0;
            this.btnGuiDanhGia.HighEmphasis = true;
            this.btnGuiDanhGia.Icon = null;
            this.btnGuiDanhGia.Location = new System.Drawing.Point(199, 497);
            this.btnGuiDanhGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuiDanhGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuiDanhGia.Name = "btnGuiDanhGia";
            this.btnGuiDanhGia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuiDanhGia.Size = new System.Drawing.Size(118, 36);
            this.btnGuiDanhGia.TabIndex = 7;
            this.btnGuiDanhGia.Text = "Gửi Đánh Giá";
            this.btnGuiDanhGia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuiDanhGia.UseAccentColor = false;
            this.btnGuiDanhGia.UseVisualStyleBackColor = true;
            this.btnGuiDanhGia.Click += new System.EventHandler(this.btnGuiDanhGia_Click);
            // 
            // txtMaDanhGia
            // 
            this.txtMaDanhGia.Location = new System.Drawing.Point(199, 92);
            this.txtMaDanhGia.Name = "txtMaDanhGia";
            this.txtMaDanhGia.Size = new System.Drawing.Size(151, 20);
            this.txtMaDanhGia.TabIndex = 8;
            // 
            // txtMaBaoCao
            // 
            this.txtMaBaoCao.Location = new System.Drawing.Point(199, 136);
            this.txtMaBaoCao.Name = "txtMaBaoCao";
            this.txtMaBaoCao.Size = new System.Drawing.Size(151, 20);
            this.txtMaBaoCao.TabIndex = 9;
            // 
            // DTPNgayDanhGia
            // 
            this.DTPNgayDanhGia.Location = new System.Drawing.Point(199, 182);
            this.DTPNgayDanhGia.Name = "DTPNgayDanhGia";
            this.DTPNgayDanhGia.Size = new System.Drawing.Size(200, 20);
            this.DTPNgayDanhGia.TabIndex = 10;
            // 
            // multitxtNDDanhGia
            // 
            this.multitxtNDDanhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multitxtNDDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multitxtNDDanhGia.Depth = 0;
            this.multitxtNDDanhGia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multitxtNDDanhGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multitxtNDDanhGia.Location = new System.Drawing.Point(199, 322);
            this.multitxtNDDanhGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.multitxtNDDanhGia.Name = "multitxtNDDanhGia";
            this.multitxtNDDanhGia.Size = new System.Drawing.Size(552, 150);
            this.multitxtNDDanhGia.TabIndex = 11;
            this.multitxtNDDanhGia.Text = "";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(199, 228);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(151, 20);
            this.txtMaNhom.TabIndex = 12;
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Location = new System.Drawing.Point(199, 274);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(151, 20);
            this.txtMaGiangVien.TabIndex = 13;
            // 
            // Frm_DanhGiaBCTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.txtMaGiangVien);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.multitxtNDDanhGia);
            this.Controls.Add(this.DTPNgayDanhGia);
            this.Controls.Add(this.txtMaBaoCao);
            this.Controls.Add(this.txtMaDanhGia);
            this.Controls.Add(this.btnGuiDanhGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DanhGiaBCTD";
            this.Text = "Frm_DanhGiaBCTD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialButton btnGuiDanhGia;
        private System.Windows.Forms.TextBox txtMaDanhGia;
        private System.Windows.Forms.TextBox txtMaBaoCao;
        private System.Windows.Forms.DateTimePicker DTPNgayDanhGia;
        private MaterialSkin.Controls.MaterialMultiLineTextBox multitxtNDDanhGia;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.TextBox txtMaGiangVien;
    }
}