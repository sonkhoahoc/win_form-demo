﻿
namespace Đồ_án_II.GUI
{
    partial class LichSuNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuNhapHang));
            this.btnExcel = new System.Windows.Forms.Button();
            this.viewLichSuNhapDataGridView = new System.Windows.Forms.DataGridView();
            this.viewLichSuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn30Ngay = new System.Windows.Forms.Button();
            this.btnThangNay = new System.Windows.Forms.Button();
            this.btn7Ngay = new System.Windows.Forms.Button();
            this.btnHomQua = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.btnTuanNay = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewLichSuNhapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLichSuNhapBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(377, 575);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(185, 54);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Xuất sang Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // viewLichSuNhapDataGridView
            // 
            this.viewLichSuNhapDataGridView.AllowUserToAddRows = false;
            this.viewLichSuNhapDataGridView.AllowUserToDeleteRows = false;
            this.viewLichSuNhapDataGridView.AutoGenerateColumns = false;
            this.viewLichSuNhapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewLichSuNhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewLichSuNhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.viewLichSuNhapDataGridView.DataSource = this.viewLichSuNhapBindingSource;
            this.viewLichSuNhapDataGridView.Location = new System.Drawing.Point(30, 185);
            this.viewLichSuNhapDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewLichSuNhapDataGridView.Name = "viewLichSuNhapDataGridView";
            this.viewLichSuNhapDataGridView.ReadOnly = true;
            this.viewLichSuNhapDataGridView.RowHeadersVisible = false;
            this.viewLichSuNhapDataGridView.RowHeadersWidth = 51;
            this.viewLichSuNhapDataGridView.Size = new System.Drawing.Size(878, 383);
            this.viewLichSuNhapDataGridView.TabIndex = 6;
            this.viewLichSuNhapDataGridView.EditModeChanged += new System.EventHandler(this.viewLichSuNhapDataGridView_EditModeChanged);
            // 
            // viewLichSuNhapBindingSource
            // 
            this.viewLichSuNhapBindingSource.DataSource = typeof(Đồ_án_II.viewLichSuNhap);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn30Ngay);
            this.groupBox1.Controls.Add(this.btnThangNay);
            this.groupBox1.Controls.Add(this.btn7Ngay);
            this.groupBox1.Controls.Add(this.btnHomQua);
            this.groupBox1.Controls.Add(this.btnHomNay);
            this.groupBox1.Controls.Add(this.btnTuanNay);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Location = new System.Drawing.Point(30, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(878, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn30Ngay
            // 
            this.btn30Ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn30Ngay.Location = new System.Drawing.Point(717, 81);
            this.btn30Ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn30Ngay.Name = "btn30Ngay";
            this.btn30Ngay.Size = new System.Drawing.Size(115, 42);
            this.btn30Ngay.TabIndex = 3;
            this.btn30Ngay.Text = "30 ngày qua";
            this.btn30Ngay.UseVisualStyleBackColor = true;
            this.btn30Ngay.Click += new System.EventHandler(this.btn30Ngay_Click);
            // 
            // btnThangNay
            // 
            this.btnThangNay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThangNay.Location = new System.Drawing.Point(553, 81);
            this.btnThangNay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThangNay.Name = "btnThangNay";
            this.btnThangNay.Size = new System.Drawing.Size(115, 42);
            this.btnThangNay.TabIndex = 3;
            this.btnThangNay.Text = "Tháng này";
            this.btnThangNay.UseVisualStyleBackColor = true;
            this.btnThangNay.Click += new System.EventHandler(this.btnThangNay_Click);
            // 
            // btn7Ngay
            // 
            this.btn7Ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn7Ngay.Location = new System.Drawing.Point(717, 30);
            this.btn7Ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7Ngay.Name = "btn7Ngay";
            this.btn7Ngay.Size = new System.Drawing.Size(115, 42);
            this.btn7Ngay.TabIndex = 3;
            this.btn7Ngay.Text = "7 ngày qua";
            this.btn7Ngay.UseVisualStyleBackColor = true;
            this.btn7Ngay.Click += new System.EventHandler(this.btn7Ngay_Click);
            // 
            // btnHomQua
            // 
            this.btnHomQua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHomQua.Location = new System.Drawing.Point(408, 81);
            this.btnHomQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomQua.Name = "btnHomQua";
            this.btnHomQua.Size = new System.Drawing.Size(115, 42);
            this.btnHomQua.TabIndex = 3;
            this.btnHomQua.Text = "Hôm qua";
            this.btnHomQua.UseVisualStyleBackColor = true;
            this.btnHomQua.Click += new System.EventHandler(this.btnHomQua_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHomNay.Location = new System.Drawing.Point(408, 30);
            this.btnHomNay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(115, 42);
            this.btnHomNay.TabIndex = 3;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = true;
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // btnTuanNay
            // 
            this.btnTuanNay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTuanNay.Location = new System.Drawing.Point(553, 30);
            this.btnTuanNay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTuanNay.Name = "btnTuanNay";
            this.btnTuanNay.Size = new System.Drawing.Size(115, 42);
            this.btnTuanNay.TabIndex = 3;
            this.btnTuanNay.Text = "Tuần này";
            this.btnTuanNay.UseVisualStyleBackColor = true;
            this.btnTuanNay.Click += new System.EventHandler(this.btnTuanNay_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 95);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ ngày";
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(133, 91);
            this.dateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(227, 22);
            this.dateTo.TabIndex = 1;
            this.dateTo.EditValueChanged += new System.EventHandler(this.dateTo_EditValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(133, 39);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(227, 22);
            this.dateFrom.TabIndex = 0;
            this.dateFrom.EditValueChanged += new System.EventHandler(this.dateFrom_EditValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HĐ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenXe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Xe";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ThueVAT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thuế VAT";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NgayNhap";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày nhập";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TenNCC";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên NCC";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // LichSuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 659);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.viewLichSuNhapDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "LichSuNhapHang";
            this.Text = "LichSuNhapHang";
            this.Load += new System.EventHandler(this.LichSuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewLichSuNhapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLichSuNhapBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource viewLichSuNhapBindingSource;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView viewLichSuNhapDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn30Ngay;
        private System.Windows.Forms.Button btnThangNay;
        private System.Windows.Forms.Button btn7Ngay;
        private System.Windows.Forms.Button btnHomQua;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.Button btnTuanNay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}