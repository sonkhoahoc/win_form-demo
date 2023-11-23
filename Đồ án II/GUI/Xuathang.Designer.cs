
namespace Đồ_án_II
{
    partial class Frm_XH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_XH));
            this.btLapchitietdonhang = new System.Windows.Forms.Button();
            this.dgv_dskh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDonhang = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.txtngayxuat = new System.Windows.Forms.DateTimePicker();
            this.grdh = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).BeginInit();
            this.grdh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLapchitietdonhang
            // 
            this.btLapchitietdonhang.BackColor = System.Drawing.Color.White;
            this.btLapchitietdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLapchitietdonhang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapchitietdonhang.Image = ((System.Drawing.Image)(resources.GetObject("btLapchitietdonhang.Image")));
            this.btLapchitietdonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapchitietdonhang.Location = new System.Drawing.Point(948, 300);
            this.btLapchitietdonhang.Name = "btLapchitietdonhang";
            this.btLapchitietdonhang.Size = new System.Drawing.Size(246, 49);
            this.btLapchitietdonhang.TabIndex = 19;
            this.btLapchitietdonhang.Text = "Lập chi tiết đơn hàng";
            this.btLapchitietdonhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLapchitietdonhang.UseVisualStyleBackColor = false;
            this.btLapchitietdonhang.Click += new System.EventHandler(this.btLapchitietdonhang_Click);
            // 
            // dgv_dskh
            // 
            this.dgv_dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_dskh.Location = new System.Drawing.Point(17, 25);
            this.dgv_dskh.Name = "dgv_dskh";
            this.dgv_dskh.RowHeadersWidth = 51;
            this.dgv_dskh.Size = new System.Drawing.Size(797, 171);
            this.dgv_dskh.TabIndex = 0;
            this.dgv_dskh.SelectionChanged += new System.EventHandler(this.dgv_dskh_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên KH";
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
            this.Column5.HeaderText = "SDT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ghichu";
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dskh);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 256);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày xuất:";
            // 
            // dgvDonhang
            // 
            this.dgvDonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDonhang.Location = new System.Drawing.Point(17, 162);
            this.dgvDonhang.Name = "dgvDonhang";
            this.dgvDonhang.RowHeadersWidth = 51;
            this.dgvDonhang.Size = new System.Drawing.Size(797, 175);
            this.dgvDonhang.TabIndex = 2;
            this.dgvDonhang.Click += new System.EventHandler(this.dgvDonhang_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaHDX";
            this.Column7.HeaderText = "Mã Hóa Đơn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNV";
            this.Column8.HeaderText = "Mã Nhân Viên";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaKH";
            this.Column9.HeaderText = "Mã KH";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NgayXuat";
            this.Column10.HeaderText = "Ngày Xuất";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(135, 40);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(170, 23);
            this.txtmahd.TabIndex = 3;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(447, 42);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(170, 23);
            this.txtMakh.TabIndex = 3;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(135, 88);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(170, 24);
            this.cbManv.TabIndex = 5;
            // 
            // txtngayxuat
            // 
            this.txtngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngayxuat.Location = new System.Drawing.Point(447, 91);
            this.txtngayxuat.Name = "txtngayxuat";
            this.txtngayxuat.Size = new System.Drawing.Size(170, 23);
            this.txtngayxuat.TabIndex = 6;
            // 
            // grdh
            // 
            this.grdh.Controls.Add(this.txtngayxuat);
            this.grdh.Controls.Add(this.cbManv);
            this.grdh.Controls.Add(this.txtMakh);
            this.grdh.Controls.Add(this.txtmahd);
            this.grdh.Controls.Add(this.dgvDonhang);
            this.grdh.Controls.Add(this.label5);
            this.grdh.Controls.Add(this.label4);
            this.grdh.Controls.Add(this.label3);
            this.grdh.Controls.Add(this.label2);
            this.grdh.Location = new System.Drawing.Point(12, 300);
            this.grdh.Name = "grdh";
            this.grdh.Size = new System.Drawing.Size(820, 339);
            this.grdh.TabIndex = 10;
            this.grdh.TabStop = false;
            this.grdh.Text = "Lập đơn hàng cho khách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhập tên Khách Hàng:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(948, 130);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(243, 23);
            this.txtten.TabIndex = 12;
            // 
            // btTimkiem
            // 
            this.btTimkiem.BackColor = System.Drawing.Color.White;
            this.btTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTimkiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(948, 186);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(109, 41);
            this.btTimkiem.TabIndex = 18;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimkiem.UseVisualStyleBackColor = false;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(1082, 186);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 41);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(1082, 249);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 37);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(948, 249);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 37);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Frm_XH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 639);
            this.Controls.Add(this.btLapchitietdonhang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdh);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_XH";
            this.Text = "Xuất Hàng";
            this.Load += new System.EventHandler(this.Frm_XH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).EndInit();
            this.grdh.ResumeLayout(false);
            this.grdh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLapchitietdonhang;
        private System.Windows.Forms.DataGridView dgv_dskh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.DateTimePicker txtngayxuat;
        private System.Windows.Forms.GroupBox grdh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
    }
}