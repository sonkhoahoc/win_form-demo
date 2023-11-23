using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Đồ_án_II.GUI;

namespace Đồ_án_II
{
    public partial class Frm_NH : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NH()
        {
            InitializeComponent();
        }

        QLXMEntities qlxm = new QLXMEntities();
        public static string Mahdn;
        private void LoadNCC()
        {
            dgv_dsncc.DataSource = qlxm.NCCs.ToList();
            dgv_dsncc.Columns[5].Visible = false;
            dgv_dsncc.Columns[6].Visible = false;
        }
        private void LoadHDN()
        {
            dgvhoadonnhap.DataSource = qlxm.HoaDonNhaps.ToList();
            dgvhoadonnhap.Columns[4].Visible = false;
            dgvhoadonnhap.Columns[5].Visible = false;
        }
        private void Loadcb()
        {
            cbManv.DataSource = qlxm.NhanViens.Select(s => s.MaNV).ToList();
        }

        private void dgv_dsncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_NH_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadHDN();
            Loadcb();
            cbManv.Text = "";
            vohieuhoa(false);
        }
        private void vohieuhoa(bool kt)
        {
            txtMaNCC.Enabled = kt;
            txtmahdn.Enabled = kt;
            cbManv.Enabled = kt;
            txtngaynhap.Enabled = kt;
        }
        private void reset()
        {
            txtMaNCC.Text = "";
            txtmahdn.Text = "";
            txtngaynhap.Text = "";
            cbManv.Text = "";
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            var qr = from d in qlxm.NCCs
                     where d.TenNCC.Contains(txtten.Text)
                     select d;
            if (qr.Count() == 0)
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            else
                dgv_dsncc.DataSource = qr.ToList();
            txtten.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                btThem.Text = "Lưu";
                txtMaNCC.Text = dgv_dsncc.CurrentRow.Cells[0].Value.ToString();
                txtmahdn.Text = "";
                txtmahdn.Focus();
                vohieuhoa(true);
                txtMaNCC.Enabled = false;
                txtmahdn.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtmahdn.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahdn.Focus();
                    return;
                }
                if (txtMaNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahdn.Focus();
                    return;
                }
                if (txtngaynhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngaynhap.Focus();
                    return;
                }
                if (cbManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbManv.Focus();
                    return;
                }
                var qr = from d in qlxm.HoaDonNhaps
                         where d.MaHDN == txtmahdn.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã hóa đơn", "'Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahdn.Text = "";
                    txtmahdn.Focus();
                    return;
                }
                else
                {
                    HoaDonNhap hdn = new HoaDonNhap();
                    hdn.MaHDN = txtmahdn.Text;
                    hdn.MaNV = cbManv.Text;
                    hdn.MaNCC = txtMaNCC.Text;
                    hdn.NgayNhap = Convert.ToDateTime(txtngaynhap.Text);
                    qlxm.HoaDonNhaps.Add(hdn);
                    qlxm.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    LoadHDN();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtmahdn.Enabled = false;
                txtMaNCC.Enabled = false;
            }
            else
            {
                if (txtmahdn.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahdn.Focus();
                    return;
                }
                if (txtMaNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahdn.Focus();
                    return;
                }
                if (txtngaynhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngaynhap.Focus();
                    return;
                }
                if (cbManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbManv.Focus();
                    return;
                }
                else
                {
                    HoaDonNhap hdn = qlxm.HoaDonNhaps.Single(s => s.MaHDN == txtmahdn.Text);
                    hdn.MaHDN = txtmahdn.Text;
                    hdn.MaNV = cbManv.Text;
                    hdn.MaNCC = txtMaNCC.Text;
                    hdn.NgayNhap = Convert.ToDateTime(txtngaynhap.Text);
                    qlxm.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                    LoadHDN();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvhoadonnhap.SelectedRows.Count; i++)
                {
                    string st = dgvhoadonnhap.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.HoaDonNhaps
                             where d.MaHDN == st
                             select d;
                    qlxm.HoaDonNhaps.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadHDN();
            }
        }

        private void dgv_dsncc_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = dgv_dsncc.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvhoadonnhap_Click(object sender, EventArgs e)
        {

            txtmahdn.Text = dgvhoadonnhap.CurrentRow.Cells[0].Value.ToString();
            cbManv.Text = dgvhoadonnhap.CurrentRow.Cells[1].Value.ToString();
            txtMaNCC.Text = dgvhoadonnhap.CurrentRow.Cells[2].Value.ToString(); ;
            txtngaynhap.Text = dgvhoadonnhap.CurrentRow.Cells[3].Value.ToString();
        }

        private void btLapchitietdonhang_Click(object sender, EventArgs e)
        {
            Mahdn = txtmahdn.Text;
            Chitiethoadonnhap v = new Chitiethoadonnhap();
            //v.Show();
            //v.MdiParent = this;
            v.Show();
            this.Hide();
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}