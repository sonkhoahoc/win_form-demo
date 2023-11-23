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

namespace Đồ_án_II.GUI
{
    public partial class Chitiethoadonnhap : DevExpress.XtraEditors.XtraForm
    {
        public Chitiethoadonnhap()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        public static string MAHDN;
        private void LoaddgvXe()
        {
            dgvXE.DataSource = qlxm.Xes.ToList();
            dgvXE.Columns[12].Visible = false;
            dgvXE.Columns[13].Visible = false;
            dgvXE.Columns[14].Visible = false;
            dgvXE.Columns[15].Visible = false;
            dgvXE.Columns[16].Visible = false;
        }
        private void LoadChitietHDN()
        {
            dgvChitietHDN.DataSource = qlxm.ChitietHDNs.ToList();
        }
        public string mahdn = Frm_NH.Mahdn;
        private void Chitiethoadonnhap_Load(object sender, EventArgs e)
        {
            txtMahdn.Text = mahdn;
            LoaddgvXe();
            LoadChitietHDN();
            txtMahdn.Enabled = false;
            txtMaxe.Enabled = false;
            txtDongia.Enabled = false;
            txtsoluong.Enabled = false;
            txtThueVAT.Enabled = false;
            dgvChitietHDN.Columns[5].Visible = false;
            dgvChitietHDN.Columns[6].Visible = false;
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            var qr = from d in qlxm.Xes
                     where d.TenXe.Contains(txttenxe.Text)
                     select d;

            if (qr.Count() == 0)
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            else
                dgvXE.DataSource = qr.ToList();
            txttenxe.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                btThem.Text = "Lưu";
                txtMaxe.Text = dgvXE.CurrentRow.Cells[0].Value.ToString();
                txtDongia.Text = dgvXE.CurrentRow.Cells[5].Value.ToString();
                btSua.Enabled = false;
                btXoa.Enabled = false;
                txtThueVAT.Enabled = true;
                txtsoluong.Enabled = true;
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtsoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số lượng nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoluong.Focus();
                    return;
                }
                if (txtThueVAT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Thuế VAT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThueVAT.Focus();
                    return;
                }
                else
                {
                    ChitietHDN ct = new ChitietHDN();
                    ct.MaHDN = txtMahdn.Text;
                    ct.MaXe = txtMaxe.Text;
                    ct.Dongia = Convert.ToInt32(txtDongia.Text);
                    ct.Soluong = Convert.ToInt32(txtsoluong.Text);
                    ct.ThueVAT = Convert.ToDecimal(txtThueVAT.Text);
                    qlxm.ChitietHDNs.Add(ct);
                    qlxm.SaveChanges();
                    MessageBox.Show("Đã thêm chi tiết hóa đơn nhập", "Thông báo");
                    Xe x = qlxm.Xes.Single(s => s.MaXe == txtMaxe.Text);
                    x.SoLuong += Convert.ToInt32(txtsoluong.Text);
                    qlxm.SaveChanges();
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    LoadChitietHDN();
                    LoaddgvXe();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                txtThueVAT.Enabled = true;
                txtsoluong.Enabled = true;
            }
            else
            {
                if (txtsoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số lượng nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoluong.Focus();
                    return;
                }
                if (txtThueVAT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Thuế VAT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThueVAT.Focus();
                    return;
                }
                else
                {
                    ChitietHDN ct = qlxm.ChitietHDNs.Single(s => s.MaHDN == txtMahdn.Text);
                    ct.MaHDN = txtMahdn.Text;
                    ct.MaXe = txtMaxe.Text;
                    ct.Dongia = Convert.ToInt32(txtDongia.Text);
                    ct.Soluong = Convert.ToInt32(txtsoluong.Text);
                    ct.ThueVAT = Convert.ToDecimal(txtThueVAT.Text);
                    qlxm.SaveChanges();
                    MessageBox.Show("Đã sửa chi tiết hóa đơn xuất", "Thông báo");
                    LoadChitietHDN();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvChitietHDN.SelectedRows.Count; i++)
                {
                    string st = dgvChitietHDN.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.ChitietHDNs
                             where d.MaHDN == st
                             select d;
                    qlxm.ChitietHDNs.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadChitietHDN();
            }
        }

        private void dgvXE_SelectionChanged(object sender, EventArgs e)
        {
            txtMaxe.Text = dgvXE.CurrentRow.Cells[0].Value.ToString();
            txtDongia.Text = dgvXE.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvChitietHDN_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtMahdn.Focus();
                return;
            }
            if (dgvChitietHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtMahdn.Text = dgvChitietHDN.CurrentRow.Cells[0].Value.ToString();
            txtMaxe.Text = dgvChitietHDN.CurrentRow.Cells[1].Value.ToString();
            txtDongia.Text = dgvChitietHDN.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text = dgvChitietHDN.CurrentRow.Cells[3].Value.ToString();
            txtThueVAT.Text = dgvChitietHDN.CurrentRow.Cells[4].Value.ToString();
        }

        private void btInhoadonnhap_Click(object sender, EventArgs e)
        {
            MAHDN = txtMahdn.Text;
            rp_phieunhaphang fr = new rp_phieunhaphang();
            fr.Show();
            this.Hide();
        }
    }
}