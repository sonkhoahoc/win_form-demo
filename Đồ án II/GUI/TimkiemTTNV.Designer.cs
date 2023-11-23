
namespace Đồ_án_II.GUI
{
    partial class TimkiemTTNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimkiemTTNV));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btHienhet = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.rdTenNV = new System.Windows.Forms.RadioButton();
            this.rdManv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btHienhet);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.rdTenNV);
            this.groupBox2.Controls.Add(this.rdManv);
            this.groupBox2.Location = new System.Drawing.Point(23, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(940, 184);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // btHienhet
            // 
            this.btHienhet.BackColor = System.Drawing.Color.White;
            this.btHienhet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHienhet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienhet.Image = global::Đồ_án_II.Properties.Resources.clipboard;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(475, 97);
            this.btHienhet.Margin = new System.Windows.Forms.Padding(4);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(113, 42);
            this.btHienhet.TabIndex = 5;
            this.btHienhet.Text = "Hiện hết";
            this.btHienhet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHienhet.UseVisualStyleBackColor = false;
            this.btHienhet.Click += new System.EventHandler(this.btHienhet_Click);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.White;
            this.btTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Image = ((System.Drawing.Image)(resources.GetObject("btTim.Image")));
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(475, 33);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(113, 42);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // rdTenNV
            // 
            this.rdTenNV.AutoSize = true;
            this.rdTenNV.Location = new System.Drawing.Point(56, 97);
            this.rdTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdTenNV.Name = "rdTenNV";
            this.rdTenNV.Size = new System.Drawing.Size(117, 21);
            this.rdTenNV.TabIndex = 1;
            this.rdTenNV.TabStop = true;
            this.rdTenNV.Text = "Tên Nhân Viên";
            this.rdTenNV.UseVisualStyleBackColor = true;
            // 
            // rdManv
            // 
            this.rdManv.AutoSize = true;
            this.rdManv.Location = new System.Drawing.Point(56, 42);
            this.rdManv.Margin = new System.Windows.Forms.Padding(4);
            this.rdManv.Name = "rdManv";
            this.rdManv.Size = new System.Drawing.Size(111, 21);
            this.rdManv.TabIndex = 0;
            this.rdManv.TabStop = true;
            this.rdManv.Text = "Mã Nhân Viên";
            this.rdManv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTNV);
            this.groupBox1.Location = new System.Drawing.Point(23, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 261);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Nhân viên";
            // 
            // dgvTTNV
            // 
            this.dgvTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvTTNV.Location = new System.Drawing.Point(6, 25);
            this.dgvTTNV.Name = "dgvTTNV";
            this.dgvTTNV.RowHeadersWidth = 51;
            this.dgvTTNV.Size = new System.Drawing.Size(934, 230);
            this.dgvTTNV.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ngaysinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ChucVu";
            this.Column7.HeaderText = "Chức Vụ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CMND";
            this.Column8.HeaderText = "CMND";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Ngayvaolam";
            this.Column9.HeaderText = "Ngày vào làm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Pass";
            this.Column10.HeaderText = "Password";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(630, 35);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 40);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // TimkiemTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimkiemTTNV";
            this.Text = "TimkiemTTNV";
            this.Load += new System.EventHandler(this.TimkiemTTNV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdTenNV;
        private System.Windows.Forms.RadioButton rdManv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnExcel;
    }
}