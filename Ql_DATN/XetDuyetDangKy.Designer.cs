namespace Ql_DATN
{
    partial class XetDuyetDangKy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDangKyDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThoiGianDangKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangKyDeTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DOANDataSet1 = new Ql_DATN.QL_DOANDataSet1();
            this.qL_DOANDataSet = new Ql_DATN.QL_DOANDataSet();
            this.qLDOANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDOANDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dangKyDeTaiTableAdapter = new Ql_DATN.QL_DOANDataSet1TableAdapters.DangKyDeTaiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDKDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNhomTruong = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGVPB = new System.Windows.Forms.TextBox();
            this.txtGVHD = new System.Windows.Forms.TextBox();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.txtMaDeTai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTrangThaiPheDuyet = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyDeTaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDangKyDeTaiDataGridViewTextBoxColumn,
            this.ngayDangKyDataGridViewTextBoxColumn,
            this.maNhomDataGridViewTextBoxColumn,
            this.maDeTaiDataGridViewTextBoxColumn,
            this.maThoiGianDangKyDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dangKyDeTaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 634);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 559);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maDangKyDeTaiDataGridViewTextBoxColumn
            // 
            this.maDangKyDeTaiDataGridViewTextBoxColumn.DataPropertyName = "MaDangKyDeTai";
            this.maDangKyDeTaiDataGridViewTextBoxColumn.HeaderText = "MaDangKyDeTai";
            this.maDangKyDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDangKyDeTaiDataGridViewTextBoxColumn.Name = "maDangKyDeTaiDataGridViewTextBoxColumn";
            this.maDangKyDeTaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDangKyDataGridViewTextBoxColumn
            // 
            this.ngayDangKyDataGridViewTextBoxColumn.DataPropertyName = "NgayDangKy";
            this.ngayDangKyDataGridViewTextBoxColumn.HeaderText = "NgayDangKy";
            this.ngayDangKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDangKyDataGridViewTextBoxColumn.Name = "ngayDangKyDataGridViewTextBoxColumn";
            this.ngayDangKyDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // maDeTaiDataGridViewTextBoxColumn
            // 
            this.maDeTaiDataGridViewTextBoxColumn.DataPropertyName = "MaDeTai";
            this.maDeTaiDataGridViewTextBoxColumn.HeaderText = "MaDeTai";
            this.maDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDeTaiDataGridViewTextBoxColumn.Name = "maDeTaiDataGridViewTextBoxColumn";
            this.maDeTaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maThoiGianDangKyDataGridViewTextBoxColumn
            // 
            this.maThoiGianDangKyDataGridViewTextBoxColumn.DataPropertyName = "MaThoiGianDangKy";
            this.maThoiGianDangKyDataGridViewTextBoxColumn.HeaderText = "MaThoiGianDangKy";
            this.maThoiGianDangKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maThoiGianDangKyDataGridViewTextBoxColumn.Name = "maThoiGianDangKyDataGridViewTextBoxColumn";
            this.maThoiGianDangKyDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dangKyDeTaiBindingSource
            // 
            this.dangKyDeTaiBindingSource.DataMember = "DangKyDeTai";
            this.dangKyDeTaiBindingSource.DataSource = this.qL_DOANDataSet1;
            // 
            // qL_DOANDataSet1
            // 
            this.qL_DOANDataSet1.DataSetName = "QL_DOANDataSet1";
            this.qL_DOANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_DOANDataSet
            // 
            this.qL_DOANDataSet.DataSetName = "QL_DOANDataSet";
            this.qL_DOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDOANDataSetBindingSource
            // 
            this.qLDOANDataSetBindingSource.DataSource = this.qL_DOANDataSet;
            this.qLDOANDataSetBindingSource.Position = 0;
            // 
            // qLDOANDataSetBindingSource1
            // 
            this.qLDOANDataSetBindingSource1.DataSource = this.qL_DOANDataSet;
            this.qLDOANDataSetBindingSource1.Position = 0;
            // 
            // dangKyDeTaiTableAdapter
            // 
            this.dangKyDeTaiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(754, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ĐKĐT";
            // 
            // txtMaDKDT
            // 
            this.txtMaDKDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMaDKDT.Location = new System.Drawing.Point(878, 82);
            this.txtMaDKDT.Name = "txtMaDKDT";
            this.txtMaDKDT.ReadOnly = true;
            this.txtMaDKDT.Size = new System.Drawing.Size(368, 34);
            this.txtMaDKDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(764, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày ĐK";
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNgayDK.Location = new System.Drawing.Point(878, 146);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.ReadOnly = true;
            this.txtNgayDK.Size = new System.Drawing.Size(368, 34);
            this.txtNgayDK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(660, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Nhóm Trưởng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(636, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã Nhóm Sinh Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(734, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên Nhóm";
            // 
            // txtMaNhomTruong
            // 
            this.txtMaNhomTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMaNhomTruong.Location = new System.Drawing.Point(878, 328);
            this.txtMaNhomTruong.Name = "txtMaNhomTruong";
            this.txtMaNhomTruong.ReadOnly = true;
            this.txtMaNhomTruong.Size = new System.Drawing.Size(368, 34);
            this.txtMaNhomTruong.TabIndex = 7;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMaNhom.Location = new System.Drawing.Point(878, 264);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.ReadOnly = true;
            this.txtMaNhom.Size = new System.Drawing.Size(368, 34);
            this.txtMaNhom.TabIndex = 8;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenNhom.Location = new System.Drawing.Point(878, 205);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.ReadOnly = true;
            this.txtTenNhom.Size = new System.Drawing.Size(368, 34);
            this.txtTenNhom.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(777, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Học Kì";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(167, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "GVPB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(165, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "GVHD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(116, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tên Đề Tài";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(126, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mã Đề Tài";
            // 
            // txtGVPB
            // 
            this.txtGVPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGVPB.Location = new System.Drawing.Point(260, 317);
            this.txtGVPB.Name = "txtGVPB";
            this.txtGVPB.ReadOnly = true;
            this.txtGVPB.Size = new System.Drawing.Size(300, 34);
            this.txtGVPB.TabIndex = 13;
            // 
            // txtGVHD
            // 
            this.txtGVHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGVHD.Location = new System.Drawing.Point(260, 265);
            this.txtGVHD.Name = "txtGVHD";
            this.txtGVHD.ReadOnly = true;
            this.txtGVHD.Size = new System.Drawing.Size(300, 34);
            this.txtGVHD.TabIndex = 14;
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenDeTai.Location = new System.Drawing.Point(260, 144);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.ReadOnly = true;
            this.txtTenDeTai.Size = new System.Drawing.Size(300, 34);
            this.txtTenDeTai.TabIndex = 16;
            // 
            // txtMaDeTai
            // 
            this.txtMaDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMaDeTai.Location = new System.Drawing.Point(260, 85);
            this.txtMaDeTai.Name = "txtMaDeTai";
            this.txtMaDeTai.ReadOnly = true;
            this.txtMaDeTai.Size = new System.Drawing.Size(300, 34);
            this.txtMaDeTai.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(3, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Trạng Thái Phê Duyệt";
            // 
            // cbTrangThaiPheDuyet
            // 
            this.cbTrangThaiPheDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbTrangThaiPheDuyet.FormattingEnabled = true;
            this.cbTrangThaiPheDuyet.Location = new System.Drawing.Point(260, 205);
            this.cbTrangThaiPheDuyet.Name = "cbTrangThaiPheDuyet";
            this.cbTrangThaiPheDuyet.Size = new System.Drawing.Size(300, 37);
            this.cbTrangThaiPheDuyet.TabIndex = 23;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCapNhat.Location = new System.Drawing.Point(462, 505);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(326, 85);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtHocKi
            // 
            this.txtHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHocKi.Location = new System.Drawing.Point(878, 387);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.ReadOnly = true;
            this.txtHocKi.Size = new System.Drawing.Size(368, 34);
            this.txtHocKi.TabIndex = 25;
            // 
            // XetDuyetDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 1205);
            this.Controls.Add(this.txtHocKi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbTrangThaiPheDuyet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGVPB);
            this.Controls.Add(this.txtGVHD);
            this.Controls.Add(this.txtTenDeTai);
            this.Controls.Add(this.txtMaDeTai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaNhomTruong);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDKDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XetDuyetDangKy";
            this.Text = "XetDuyetDangKy";
            this.Load += new System.EventHandler(this.XetDuyetDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyDeTaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLDOANDataSetBindingSource1;
        private QL_DOANDataSet qL_DOANDataSet;
        private System.Windows.Forms.BindingSource qLDOANDataSetBindingSource;
        private QL_DOANDataSet1 qL_DOANDataSet1;
        private System.Windows.Forms.BindingSource dangKyDeTaiBindingSource;
        private QL_DOANDataSet1TableAdapters.DangKyDeTaiTableAdapter dangKyDeTaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDangKyDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThoiGianDangKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDKDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNhomTruong;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGVPB;
        private System.Windows.Forms.TextBox txtGVHD;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.TextBox txtMaDeTai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTrangThaiPheDuyet;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtHocKi;
    }
}