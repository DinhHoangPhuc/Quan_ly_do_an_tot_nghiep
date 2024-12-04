namespace Ql_DATN
{
    partial class FormDeXuatDeTai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateNgayDeXuat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeXuat = new MaterialSkin.Controls.MaterialButton();
            this.txtTrangThai = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaDeTai = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.txtTenDetai = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnChiTietDeTai = new MaterialSkin.Controls.MaterialButton();
            this.errorProviderTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayDeXuat
            // 
            this.dateNgayDeXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgayDeXuat.Enabled = false;
            this.dateNgayDeXuat.Location = new System.Drawing.Point(1515, 2);
            this.dateNgayDeXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayDeXuat.Name = "dateNgayDeXuat";
            this.dateNgayDeXuat.Size = new System.Drawing.Size(374, 22);
            this.dateNgayDeXuat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã đề tài";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 75);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên đề tài";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 75);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mô tả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 75);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1326, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 75);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày đề xuất";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(16, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.materialLabel1.Size = new System.Drawing.Size(1892, 51);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "ĐỀ XUẤT ĐỀ TÀI";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDeTai, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChiTietDeTai, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // dgvDeTai
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDeTai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeTai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeTai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeTai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeTai.EnableHeadersVisualStyles = false;
            this.dgvDeTai.Location = new System.Drawing.Point(18, 376);
            this.dgvDeTai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.RowHeadersWidth = 51;
            this.dgvDeTai.Size = new System.Drawing.Size(1888, 453);
            this.dgvDeTai.TabIndex = 20;
            this.dgvDeTai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeTai_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateNgayDeXuat, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDeXuat, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTrangThai, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDeTai, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMoTa, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDetai, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 65);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1892, 150);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // btnDeXuat
            // 
            this.btnDeXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeXuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeXuat.Depth = 0;
            this.btnDeXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeXuat.HighEmphasis = true;
            this.btnDeXuat.Icon = null;
            this.btnDeXuat.Location = new System.Drawing.Point(1517, 82);
            this.btnDeXuat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDeXuat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeXuat.Name = "btnDeXuat";
            this.btnDeXuat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeXuat.Size = new System.Drawing.Size(370, 61);
            this.btnDeXuat.TabIndex = 13;
            this.btnDeXuat.Text = "Đề xuất";
            this.btnDeXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeXuat.UseAccentColor = false;
            this.btnDeXuat.UseVisualStyleBackColor = true;
            this.btnDeXuat.Click += new System.EventHandler(this.btnDeXuat_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrangThai.AnimateReadOnly = false;
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrangThai.Depth = 0;
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrangThai.LeadingIcon = null;
            this.txtTrangThai.Location = new System.Drawing.Point(949, 79);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrangThai.MaxLength = 50;
            this.txtTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTrangThai.Multiline = false;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(370, 50);
            this.txtTrangThai.TabIndex = 16;
            this.txtTrangThai.Text = "";
            this.txtTrangThai.TrailingIcon = null;
            // 
            // txtMaDeTai
            // 
            this.txtMaDeTai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDeTai.Enabled = false;
            this.txtMaDeTai.Location = new System.Drawing.Point(193, 4);
            this.txtMaDeTai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDeTai.Name = "txtMaDeTai";
            this.txtMaDeTai.Size = new System.Drawing.Size(559, 22);
            this.txtMaDeTai.TabIndex = 18;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(193, 79);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(559, 67);
            this.txtMoTa.TabIndex = 19;
            this.txtMoTa.Text = "";
            // 
            // txtTenDetai
            // 
            this.txtTenDetai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDetai.Location = new System.Drawing.Point(949, 4);
            this.txtTenDetai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDetai.Name = "txtTenDetai";
            this.txtTenDetai.Size = new System.Drawing.Size(370, 22);
            this.txtTenDetai.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbLocTrangThai, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 221);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1890, 146);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lọc đề tài";
            // 
            // cbLocTrangThai
            // 
            this.cbLocTrangThai.FormattingEnabled = true;
            this.cbLocTrangThai.Location = new System.Drawing.Point(193, 4);
            this.cbLocTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLocTrangThai.Name = "cbLocTrangThai";
            this.cbLocTrangThai.Size = new System.Drawing.Size(499, 24);
            this.cbLocTrangThai.TabIndex = 1;
            this.cbLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbLocTrangThai_SelectedIndexChanged);
            // 
            // btnChiTietDeTai
            // 
            this.btnChiTietDeTai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTietDeTai.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChiTietDeTai.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChiTietDeTai.Depth = 0;
            this.btnChiTietDeTai.HighEmphasis = true;
            this.btnChiTietDeTai.Icon = null;
            this.btnChiTietDeTai.Location = new System.Drawing.Point(1758, 841);
            this.btnChiTietDeTai.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnChiTietDeTai.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChiTietDeTai.Name = "btnChiTietDeTai";
            this.btnChiTietDeTai.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChiTietDeTai.Size = new System.Drawing.Size(148, 36);
            this.btnChiTietDeTai.TabIndex = 21;
            this.btnChiTietDeTai.Text = "Chỉnh sửa đề tài";
            this.btnChiTietDeTai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChiTietDeTai.UseAccentColor = false;
            this.btnChiTietDeTai.UseVisualStyleBackColor = true;
            this.btnChiTietDeTai.Click += new System.EventHandler(this.btnChiTietDeTai_Click);
            // 
            // errorProviderTextBox
            // 
            this.errorProviderTextBox.ContainerControl = this;
            // 
            // FormDeXuatDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeXuatDeTai";
            this.Text = "FormDeXuatDeTai";
            this.Load += new System.EventHandler(this.FormDeXuatDeTai_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateNgayDeXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnDeXuat;
        private MaterialSkin.Controls.MaterialTextBox txtTrangThai;
        private System.Windows.Forms.ErrorProvider errorProviderTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDeTai;
        private MaterialSkin.Controls.MaterialButton btnChiTietDeTai;
        private System.Windows.Forms.TextBox txtMaDeTai;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenDetai;
        private System.Windows.Forms.ComboBox cbLocTrangThai;
    }
}