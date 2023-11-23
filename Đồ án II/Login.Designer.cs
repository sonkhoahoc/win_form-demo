
namespace Đồ_án_II
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnvien = new System.Windows.Forms.RadioButton();
            this.rdquanli = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncannel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdnvien);
            this.groupBox1.Controls.Add(this.rdquanli);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btncannel);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Location = new System.Drawing.Point(179, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdnvien
            // 
            this.rdnvien.AutoSize = true;
            this.rdnvien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnvien.ForeColor = System.Drawing.Color.White;
            this.rdnvien.Location = new System.Drawing.Point(296, 251);
            this.rdnvien.Name = "rdnvien";
            this.rdnvien.Size = new System.Drawing.Size(97, 23);
            this.rdnvien.TabIndex = 6;
            this.rdnvien.TabStop = true;
            this.rdnvien.Text = "Nhân viên";
            this.rdnvien.UseVisualStyleBackColor = true;
            // 
            // rdquanli
            // 
            this.rdquanli.AutoSize = true;
            this.rdquanli.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdquanli.ForeColor = System.Drawing.Color.White;
            this.rdquanli.Location = new System.Drawing.Point(151, 251);
            this.rdquanli.Name = "rdquanli";
            this.rdquanli.Size = new System.Drawing.Size(85, 23);
            this.rdquanli.TabIndex = 5;
            this.rdquanli.TabStop = true;
            this.rdquanli.Text = "Quản lý ";
            this.rdquanli.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(135, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 84);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btncannel
            // 
            this.btncannel.BackColor = System.Drawing.Color.White;
            this.btncannel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncannel.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncannel.Image = ((System.Drawing.Image)(resources.GetObject("btncannel.Image")));
            this.btncannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncannel.Location = new System.Drawing.Point(317, 301);
            this.btncannel.Name = "btncannel";
            this.btncannel.Size = new System.Drawing.Size(99, 45);
            this.btncannel.TabIndex = 3;
            this.btncannel.Text = "Cannel";
            this.btncannel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncannel.UseVisualStyleBackColor = false;
            this.btncannel.Click += new System.EventHandler(this.btncannel_Click_1);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(191, 301);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(98, 45);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.ForeColor = System.Drawing.Color.DimGray;
            this.txtmk.Location = new System.Drawing.Point(142, 191);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(204, 27);
            this.txtmk.TabIndex = 1;
            this.txtmk.Text = "Password";
            this.txtmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matkhau_KeyDown);
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.ForeColor = System.Drawing.Color.DimGray;
            this.txttk.Location = new System.Drawing.Point(142, 143);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(204, 27);
            this.txttk.TabIndex = 0;
            this.txttk.Text = "Use name";
            this.txttk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txttk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_taikhoan_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(868, 489);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncannel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.RadioButton rdnvien;
        private System.Windows.Forms.RadioButton rdquanli;
    }
}

