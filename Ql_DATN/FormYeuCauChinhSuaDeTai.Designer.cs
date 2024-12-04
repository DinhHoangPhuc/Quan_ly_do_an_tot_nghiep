namespace Ql_DATN
{
    partial class FormYeuCauChinhSuaDeTai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.txtYeuCau = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(787, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yêu cầu chỉnh sửa đề tài";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCapNhat, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbTruong, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtYeuCau, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 187);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(38, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(193, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Chọn trường cần chỉnh sửa";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(126, 68);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Nhập nội dung";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = null;
            this.btnCapNhat.Location = new System.Drawing.Point(238, 132);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(97, 36);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập  nhật";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Location = new System.Drawing.Point(237, 13);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(293, 28);
            this.cbTruong.TabIndex = 3;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Location = new System.Drawing.Point(237, 71);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(293, 52);
            this.txtYeuCau.TabIndex = 4;
            this.txtYeuCau.Text = "";
            // 
            // FormYeuCauChinhSuaDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 226);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormYeuCauChinhSuaDeTai";
            this.Text = "FormYeuCauChinhSuaDeTai";
            this.Load += new System.EventHandler(this.FormYeuCauChinhSuaDeTai_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private System.Windows.Forms.ComboBox cbTruong;
        private System.Windows.Forms.RichTextBox txtYeuCau;
    }
}