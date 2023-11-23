
namespace Đồ_án_II.GUI
{
    partial class TimkiemTTKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimkiemTTKH));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btHienhet = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.rdTenkh = new System.Windows.Forms.RadioButton();
            this.rdMakh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btHienhet);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.rdTenkh);
            this.groupBox2.Controls.Add(this.rdMakh);
            this.groupBox2.Location = new System.Drawing.Point(31, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(707, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(522, 34);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 40);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btHienhet
            // 
            this.btHienhet.BackColor = System.Drawing.Color.White;
            this.btHienhet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHienhet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienhet.Image = global::Đồ_án_II.Properties.Resources.clipboard;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(391, 93);
            this.btHienhet.Margin = new System.Windows.Forms.Padding(4);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(104, 38);
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
            this.btTim.Location = new System.Drawing.Point(391, 34);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(104, 40);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // rdTenkh
            // 
            this.rdTenkh.AutoSize = true;
            this.rdTenkh.Location = new System.Drawing.Point(41, 103);
            this.rdTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.rdTenkh.Name = "rdTenkh";
            this.rdTenkh.Size = new System.Drawing.Size(128, 21);
            this.rdTenkh.TabIndex = 1;
            this.rdTenkh.TabStop = true;
            this.rdTenkh.Text = "Tên khách hàng";
            this.rdTenkh.UseVisualStyleBackColor = true;
            // 
            // rdMakh
            // 
            this.rdMakh.AutoSize = true;
            this.rdMakh.Location = new System.Drawing.Point(41, 49);
            this.rdMakh.Margin = new System.Windows.Forms.Padding(4);
            this.rdMakh.Name = "rdMakh";
            this.rdMakh.Size = new System.Drawing.Size(122, 21);
            this.rdMakh.TabIndex = 0;
            this.rdMakh.TabStop = true;
            this.rdMakh.Text = "Mã khách hàng";
            this.rdMakh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTKH);
            this.groupBox1.Location = new System.Drawing.Point(31, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 261);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvTTKH
            // 
            this.dgvTTKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTTKH.Location = new System.Drawing.Point(15, 25);
            this.dgvTTKH.Name = "dgvTTKH";
            this.dgvTTKH.RowHeadersWidth = 51;
            this.dgvTTKH.Size = new System.Drawing.Size(691, 219);
            this.dgvTTKH.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // TimkiemTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimkiemTTKH";
            this.Text = "TimkiemTTKH";
            this.Load += new System.EventHandler(this.TimkiemTTKH_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdTenkh;
        private System.Windows.Forms.RadioButton rdMakh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnExcel;
    }
}