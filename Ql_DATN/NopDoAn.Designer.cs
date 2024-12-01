namespace Ql_DATN
{
    partial class NopDoAn
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnNop = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewDoAn = new System.Windows.Forms.DataGridView();
            this.dateTimeNgayNop = new System.Windows.Forms.DateTimePicker();
            this.cbbMaNhom = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbMaDeTai = new MaterialSkin.Controls.MaterialComboBox();
            this.rtxNoiDungDoAn = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NỘP ĐỒ ÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày nộp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã đề tài";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxNoiDungDoAn);
            this.panel1.Controls.Add(this.cbbMaDeTai);
            this.panel1.Controls.Add(this.cbbMaNhom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNop);
            this.panel1.Controls.Add(this.dataGridViewDoAn);
            this.panel1.Controls.Add(this.dateTimeNgayNop);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 595);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nội dung đồ án";
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.ForeColor = System.Drawing.Color.Gray;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(271, 242);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(64, 36);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNop
            // 
            this.btnNop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNop.Depth = 0;
            this.btnNop.HighEmphasis = true;
            this.btnNop.Icon = null;
            this.btnNop.Location = new System.Drawing.Point(139, 252);
            this.btnNop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNop.Name = "btnNop";
            this.btnNop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNop.Size = new System.Drawing.Size(64, 36);
            this.btnNop.TabIndex = 13;
            this.btnNop.Text = "Nộp";
            this.btnNop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNop.UseAccentColor = false;
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // dataGridViewDoAn
            // 
            this.dataGridViewDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoAn.Location = new System.Drawing.Point(15, 317);
            this.dataGridViewDoAn.Name = "dataGridViewDoAn";
            this.dataGridViewDoAn.RowHeadersWidth = 62;
            this.dataGridViewDoAn.RowTemplate.Height = 28;
            this.dataGridViewDoAn.Size = new System.Drawing.Size(696, 265);
            this.dataGridViewDoAn.TabIndex = 11;
            this.dataGridViewDoAn.SelectionChanged += new System.EventHandler(this.dataGridViewDoAn_SelectionChanged);
            // 
            // dateTimeNgayNop
            // 
            this.dateTimeNgayNop.Location = new System.Drawing.Point(472, 60);
            this.dateTimeNgayNop.Name = "dateTimeNgayNop";
            this.dateTimeNgayNop.Size = new System.Drawing.Size(208, 26);
            this.dateTimeNgayNop.TabIndex = 10;
            // 
            // cbbMaNhom
            // 
            this.cbbMaNhom.AutoResize = false;
            this.cbbMaNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbMaNhom.Depth = 0;
            this.cbbMaNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbMaNhom.DropDownHeight = 174;
            this.cbbMaNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNhom.DropDownWidth = 121;
            this.cbbMaNhom.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbMaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbMaNhom.FormattingEnabled = true;
            this.cbbMaNhom.IntegralHeight = false;
            this.cbbMaNhom.ItemHeight = 43;
            this.cbbMaNhom.Location = new System.Drawing.Point(120, 58);
            this.cbbMaNhom.MaxDropDownItems = 4;
            this.cbbMaNhom.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbMaNhom.Name = "cbbMaNhom";
            this.cbbMaNhom.Size = new System.Drawing.Size(190, 49);
            this.cbbMaNhom.StartIndex = 0;
            this.cbbMaNhom.TabIndex = 26;
            // 
            // cbbMaDeTai
            // 
            this.cbbMaDeTai.AutoResize = false;
            this.cbbMaDeTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbMaDeTai.Depth = 0;
            this.cbbMaDeTai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbMaDeTai.DropDownHeight = 174;
            this.cbbMaDeTai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDeTai.DropDownWidth = 121;
            this.cbbMaDeTai.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbMaDeTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbMaDeTai.FormattingEnabled = true;
            this.cbbMaDeTai.IntegralHeight = false;
            this.cbbMaDeTai.ItemHeight = 43;
            this.cbbMaDeTai.Location = new System.Drawing.Point(120, 158);
            this.cbbMaDeTai.MaxDropDownItems = 4;
            this.cbbMaDeTai.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbMaDeTai.Name = "cbbMaDeTai";
            this.cbbMaDeTai.Size = new System.Drawing.Size(190, 49);
            this.cbbMaDeTai.StartIndex = 0;
            this.cbbMaDeTai.TabIndex = 27;
            // 
            // rtxNoiDungDoAn
            // 
            this.rtxNoiDungDoAn.AnimateReadOnly = false;
            this.rtxNoiDungDoAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxNoiDungDoAn.Depth = 0;
            this.rtxNoiDungDoAn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtxNoiDungDoAn.LeadingIcon = null;
            this.rtxNoiDungDoAn.Location = new System.Drawing.Point(473, 159);
            this.rtxNoiDungDoAn.MaxLength = 50;
            this.rtxNoiDungDoAn.MouseState = MaterialSkin.MouseState.OUT;
            this.rtxNoiDungDoAn.Multiline = false;
            this.rtxNoiDungDoAn.Name = "rtxNoiDungDoAn";
            this.rtxNoiDungDoAn.Size = new System.Drawing.Size(204, 50);
            this.rtxNoiDungDoAn.TabIndex = 28;
            this.rtxNoiDungDoAn.Text = "";
            this.rtxNoiDungDoAn.TrailingIcon = null;
            // 
            // NopDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 619);
            this.Controls.Add(this.panel1);
            this.Name = "NopDoAn";
            this.Text = "NopDoAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDoAn;
        private MaterialSkin.Controls.MaterialButton btnNop;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNop;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cbbMaDeTai;
        private MaterialSkin.Controls.MaterialComboBox cbbMaNhom;
        private MaterialSkin.Controls.MaterialTextBox rtxNoiDungDoAn;
    }
}