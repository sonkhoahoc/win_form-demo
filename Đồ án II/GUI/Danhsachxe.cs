using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Đồ_án_II.GUI;

namespace Đồ_án_II
{
    public partial class Frm_Xe : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Xe()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void Loaddl()
        {
            var qr = from d in qlxm.Xes
                     select d;
            dgvDsxe.DataSource = qr.ToList();
            dgvDsxe.Columns[12].Visible = false;
            dgvDsxe.Columns[13].Visible = false;
            dgvDsxe.Columns[14].Visible = false;
        }

        private void Frm_Xe_Click(object sender, EventArgs e)
        {
            txtMaxe.Enabled = false;
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtMaxe.Focus();
                return;
            }
            if (dgvDsxe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtMaxe.Text = dgvDsxe.CurrentRow.Cells[0].Value.ToString();
            txtTenxe.Text = dgvDsxe.CurrentRow.Cells[1].Value.ToString();
            cbMaloaixe.Text = dgvDsxe.CurrentRow.Cells[2].Value.ToString();
            cbMaNCC.Text = dgvDsxe.CurrentRow.Cells[3].Value.ToString();
            txtgianhap.Text = dgvDsxe.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = dgvDsxe.CurrentRow.Cells[5].Value.ToString();
            txtSoluong.Text = dgvDsxe.CurrentRow.Cells[6].Value.ToString();
            txtSokhung.Text = dgvDsxe.CurrentRow.Cells[7].Value.ToString();
            txtSomay.Text = dgvDsxe.CurrentRow.Cells[8].Value.ToString();
            txtmau.Text = dgvDsxe.CurrentRow.Cells[9].Value.ToString();
            txtDungtich.Text = dgvDsxe.CurrentRow.Cells[10].Value.ToString();
            txttinhtrang.Text = dgvDsxe.CurrentRow.Cells[11].Value.ToString();
        }

        private void Frm_Xe_Load(object sender, EventArgs e)
        {
            vohieuhoa(false);
            Loaddl();
            cbMaloaixe.DataSource = qlxm.Xes.Select(s => s.Maloaixe).Distinct().ToList();
            cbMaNCC.DataSource = qlxm.Xes.Select(s => s.MaNCC).Distinct().ToList();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvDsxe.SelectedRows.Count; i++)
                {
                    string st = dgvDsxe.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.Xes
                             where d.MaXe == st
                             select d;
                    qlxm.Xes.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                Loaddl();
            }
        }
        private void reset()
        {
            txtMaxe.Text = "";
            txtTenxe.Text = "";
            cbMaloaixe.Text = "";
            cbMaNCC.Text = "";
            txtgianhap.Text = "";
            txtGiaBan.Text = "";
            txtSoluong.Text = "";
            txtSokhung.Text = "";
            txtSomay.Text = "";
            txtmau.Text = "";
            txtDungtich.Text = "";
            txttinhtrang.Text = "";
        }
        private void vohieuhoa(bool kt)
        {
            txtMaxe.Enabled = kt;
            txtTenxe.Enabled = kt;
            cbMaloaixe.Enabled = kt;
            cbMaNCC.Enabled = kt;
            txtgianhap.Enabled = kt;
            txtGiaBan.Enabled = kt;
            txtSoluong.Enabled = kt;
            txtSokhung.Enabled = kt;
            txtSomay.Enabled = kt;
            txtmau.Enabled = kt;
            txtDungtich.Enabled = kt;
            txttinhtrang.Enabled = kt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                btThem.Text = "Lưu";
                vohieuhoa(true);
                txtMaxe.Enabled = true;
                reset();
                txtMaxe.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;

            }
            else
            {
                btThem.Text = "Thêm";
                if (txtMaxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaxe.Focus();
                    return;
                }
                if (txtTenxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenxe.Focus();
                    return;
                }
                if (cbMaloaixe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaloaixe.Focus();
                    return;
                }
                if (cbMaNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã NCC", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaNCC.Focus();
                    return;
                }
                if (txtgianhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtgianhap.Focus();
                    return;
                }
                if (txtGiaBan.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaBan.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
                if (txtSokhung.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số khung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSokhung.Focus();
                    return;
                }
                if (txtSomay.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSomay.Focus();
                    return;
                }
                if (txtmau.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập màu xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmau.Focus();
                    return;
                }
                if (txtDungtich.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập dung tích xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDungtich.Focus();
                    return;
                }
                if (txttinhtrang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tình trạng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttinhtrang.Focus();
                    return;
                }
                var qr = from d in qlxm.Xes
                         where d.MaXe == txtMaxe.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Xe x = new Xe();
                    x.MaXe = txtMaxe.Text;
                    x.TenXe = txtTenxe.Text;
                    x.Maloaixe = cbMaloaixe.Text;
                    x.MaNCC = cbMaNCC.Text;
                    x.GiaNhap = Convert.ToInt64(txtgianhap.Text);
                    x.GiaBan = Convert.ToInt64(txtGiaBan.Text);
                    x.SoLuong = Convert.ToInt32(txtSoluong.Text);
                    x.SoKhung = txtSokhung.Text;
                    x.SoMay = txtSomay.Text;
                    x.Mau = txtmau.Text;
                    x.Dungtich = txtDungtich.Text;
                    x.TinhTrang = txttinhtrang.Text;
                    qlxm.Xes.Add(x);
                    qlxm.SaveChanges();
                    MessageBox.Show("Thêm xe thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    reset();
                    Loaddl();
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtMaxe.Enabled = false;
            }
            else
            {
                if (txtMaxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaxe.Focus();
                    return;
                }
                if (txtTenxe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenxe.Focus();
                    return;
                }
                if (cbMaloaixe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaloaixe.Focus();
                    return;
                }
                if (cbMaNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã NCC", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaNCC.Focus();
                    return;
                }
                if (txtgianhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtgianhap.Focus();
                    return;
                }
                if (txtGiaBan.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaBan.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
                if (txtSokhung.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số khung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSokhung.Focus();
                    return;
                }
                if (txtSomay.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSomay.Focus();
                    return;
                }
                if (txtmau.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập màu xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmau.Focus();
                    return;
                }
                if (txtDungtich.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập dung tích xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDungtich.Focus();
                    return;
                }
                if (txttinhtrang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tình trạng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttinhtrang.Focus();
                    return;
                }
                else
                {
                    Xe x = qlxm.Xes.Single(s => s.MaXe == txtMaxe.Text);
                    x.MaXe = txtMaxe.Text;
                    x.TenXe = txtTenxe.Text;
                    x.Maloaixe = cbMaloaixe.Text;
                    x.MaNCC = cbMaNCC.Text;
                    x.GiaNhap = Convert.ToInt32(txtgianhap.Text);
                    x.GiaBan = Convert.ToInt32(txtGiaBan.Text);
                    x.SoLuong = Convert.ToInt32(txtSoluong.Text);
                    x.SoKhung = txtSokhung.Text;
                    x.SoMay = txtSomay.Text;
                    x.Mau = txtmau.Text;
                    x.Dungtich = txtDungtich.Text;
                    x.TinhTrang = txttinhtrang.Text;
                    qlxm.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    //btSua.Enabled = true;
                    //btXoa.Enabled = true;
                    reset();
                    Loaddl();
                }
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMaxe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}