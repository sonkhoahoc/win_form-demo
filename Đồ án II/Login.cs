using Đồ_án_II.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Đồ_án_II
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "" && txtmk.Text != "")
            {
                if (rdquanli.Checked || rdnvien.Checked)
                {
                    MessageBox.Show("Bạn chưa điền thông tin mật khẩu đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (txtmk.Text == "" && txttk.Text != "")
            {
                if (rdquanli.Checked || rdnvien.Checked)
                {
                    MessageBox.Show("Bạn chưa điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (txttk.Text == "" && txtmk.Text == "")
            {
                if (rdquanli.Checked || rdnvien.Checked)
                {
                    MessageBox.Show("Chưa điền tài khoản & mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (txttk.Text != "" && txtmk.Text !=""  && txtmk.Text.Trim().Length < 5)
            {
                if (rdquanli.Checked || rdnvien.Checked)
                {
                    MessageBox.Show("Mật khẩu tối thiểu từ 5 kí tự ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (txttk.Text != "" && txtmk.Text != "" && txttk.Text.Trim().Length > 25 && txtmk.Text.Trim().Length >25)
            {
                if (rdquanli.Checked || rdnvien.Checked)
                {
                    MessageBox.Show("Mật khẩu không vượt quá 25 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (txtmk.Text != "" && txttk.Text != "" && 1 <= txttk.Text.Trim().Length&& txttk.Text.Trim().Length <= 25 && 5<=txtmk.Text.Trim().Length&& txtmk.Text.Trim().Length <= 25)
            {
                if (rdquanli.Checked)
                {

                    var qr = from d in qlxm.Admins
                             where d.Usename == txttk.Text && d.Password == txtmk.Text
                             select d;
                    if (qr.Count() == 0)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttk.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        RibbonForm1 fr = new RibbonForm1();
                        fr.Show();
                        this.Hide();
                    }
                }
                else if (rdnvien.Checked)
                {
                    var qr = from d in qlxm.NhanViens
                             where d.MaNV == txttk.Text && d.Pass == txtmk.Text
                             select d;
                    if (qr.Count() == 0)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttk.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RibbonForm1 fr = new RibbonForm1();
                        fr.PhanQuyen();
                        fr.Show();
                        this.Hide();
                    }
                }
            }
        }
 

        private void btncannel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_taikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmk.Focus();
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
