
namespace Đồ_án_II.GUI
{
    partial class TimkiemXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimkiemXe));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ht = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btHienhet = new System.Windows.Forms.Button();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.cb_tt = new System.Windows.Forms.CheckBox();
            this.cb_mancc = new System.Windows.Forms.CheckBox();
            this.cb_tenxe = new System.Windows.Forms.CheckBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ht);
            this.groupBox2.Location = new System.Drawing.Point(34, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Xe";
            // 
            // dgv_ht
            // 
            this.dgv_ht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgv_ht.Location = new System.Drawing.Point(16, 25);
            this.dgv_ht.Name = "dgv_ht";
            this.dgv_ht.RowHeadersWidth = 51;
            this.dgv_ht.Size = new System.Drawing.Size(680, 170);
            this.dgv_ht.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaXe";
            this.Column1.HeaderText = "Mã Xe";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenXe";
            this.Column2.HeaderText = "Tên Xe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Maloaixe";
            this.Column3.HeaderText = "Mã loại xe";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNCC";
            this.Column4.HeaderText = "Mã NCC";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaNhap";
            this.Column5.HeaderText = "Giá Nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaBan";
            this.Column6.HeaderText = "Giá Bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SoKhung";
            this.Column8.HeaderText = "Số Khung";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoMay";
            this.Column9.HeaderText = "Số Máy";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Mau";
            this.Column10.HeaderText = "Màu";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Dungtich";
            this.Column11.HeaderText = "Dung Tích";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TinhTrang";
            this.Column12.HeaderText = "Tình Trạng";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.btHienhet);
            this.groupBox1.Controls.Add(this.txt_tinhtrang);
            this.groupBox1.Controls.Add(this.txt_mancc);
            this.groupBox1.Controls.Add(this.txt_tenxe);
            this.groupBox1.Controls.Add(this.cb_tt);
            this.groupBox1.Controls.Add(this.cb_mancc);
            this.groupBox1.Controls.Add(this.cb_tenxe);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.White;
            this.btTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Image = ((System.Drawing.Image)(resources.GetObject("btTim.Image")));
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(436, 63);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(105, 37);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btHienhet
            // 
            this.btHienhet.BackColor = System.Drawing.Color.White;
            this.btHienhet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHienhet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienhet.Image = global::Đồ_án_II.Properties.Resources.clipboard;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(436, 121);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(105, 37);
            this.btHienhet.TabIndex = 4;
            this.btHienhet.Text = "Hiện hết";
            this.btHienhet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHienhet.UseVisualStyleBackColor = false;
            this.btHienhet.Click += new System.EventHandler(this.btHienhet_Click);
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(162, 154);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(165, 23);
            this.txt_tinhtrang.TabIndex = 3;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(162, 95);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(165, 23);
            this.txt_mancc.TabIndex = 3;
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(162, 39);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(165, 23);
            this.txt_tenxe.TabIndex = 3;
            // 
            // cb_tt
            // 
            this.cb_tt.AutoSize = true;
            this.cb_tt.Location = new System.Drawing.Point(32, 157);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(93, 21);
            this.cb_tt.TabIndex = 2;
            this.cb_tt.Text = "Tình trạng";
            this.cb_tt.UseVisualStyleBackColor = true;
            this.cb_tt.CheckedChanged += new System.EventHandler(this.cb_tt_CheckedChanged);
            // 
            // cb_mancc
            // 
            this.cb_mancc.AutoSize = true;
            this.cb_mancc.Location = new System.Drawing.Point(32, 98);
            this.cb_mancc.Name = "cb_mancc";
            this.cb_mancc.Size = new System.Drawing.Size(78, 21);
            this.cb_mancc.TabIndex = 1;
            this.cb_mancc.Text = "Mã NCC";
            this.cb_mancc.UseVisualStyleBackColor = true;
            this.cb_mancc.CheckedChanged += new System.EventHandler(this.cb_mancc_CheckedChanged);
            // 
            // cb_tenxe
            // 
            this.cb_tenxe.AutoSize = true;
            this.cb_tenxe.Location = new System.Drawing.Point(32, 39);
            this.cb_tenxe.Name = "cb_tenxe";
            this.cb_tenxe.Size = new System.Drawing.Size(72, 21);
            this.cb_tenxe.TabIndex = 0;
            this.cb_tenxe.Text = "Tên xe";
            this.cb_tenxe.UseVisualStyleBackColor = true;
            this.cb_tenxe.CheckedChanged += new System.EventHandler(this.cb_tenxe_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(436, 176);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 40);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // TimkiemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimkiemXe";
            this.Text = "Tìm kiếm xe";
            this.Load += new System.EventHandler(this.TimkiemXe_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.CheckBox cb_tt;
        private System.Windows.Forms.CheckBox cb_mancc;
        private System.Windows.Forms.CheckBox cb_tenxe;
        private System.Windows.Forms.Button btnExcel;
    }
}