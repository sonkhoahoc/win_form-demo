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
using VBSQLHelper;
using DevExpress.XtraReports.UI;
using Đồ_án_II.GUI;

namespace Đồ_án_II
{
    public partial class Frm_XH : DevExpress.XtraEditors.XtraForm
    {
        public Frm_XH()
        {
            InitializeComponent();
        }

        private void Frm_XH_Load(object sender, EventArgs e)
        {
            Loaddskh();
            LoadDonhang();
            Loadcb();
            cbManv.Text = "";
            vohieuhoa(false);
        }
        QLXMEntities qlxm = new QLXMEntities();
        public static string Mahdx;
        private void Loaddskh()
        {
            dgv_dskh.DataSource = qlxm.KhachHangs.ToList();
            dgv_dskh.Columns[6].Visible = false;
            dgv_dskh.Columns[7].Visible = false;
        }
        private void LoadDonhang()
        {
            dgvDonhang.DataSource = qlxm.HoaDonXuats.ToList();
            dgvDonhang.Columns[4].Visible = false;
            dgvDonhang.Columns[5].Visible = false;
            dgvDonhang.Columns[6].Visible = false;
        }
        private void Loadcb()
        {
            cbManv.DataSource = qlxm.NhanViens.Select(s => s.MaNV).ToList();
        }
        private void vohieuhoa(bool kt)
        {
            txtMakh.Enabled = kt;
            txtmahd.Enabled = kt;
            cbManv.Enabled = kt;
            txtngayxuat.Enabled = kt;
        }
        private void reset()
        {
            txtMakh.Text = "";
            txtmahd.Text = "";
            txtngayxuat.Text = "";
            cbManv.Text = "";
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            var qr = from d in qlxm.KhachHangs
                     where d.TenKH.Contains(txtten.Text)
                     select d;
            if (qr.Count() == 0)
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            else
                dgv_dskh.DataSource = qr.ToList();
            txtten.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                txtMakh.Enabled = false;
                txtMakh.Text = dgv_dskh.CurrentRow.Cells[0].Value.ToString();
                txtmahd.Text = "";
                txtmahd.Focus();
                btThem.Text = "Lưu";
                vohieuhoa(true);
                txtmahd.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtmahd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahd.Focus();
                    return;
                }
                if (txtMakh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMakh.Focus();
                    return;
                }
                if (cbManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbManv.Focus();
                    return;
                }
                if (txtngayxuat.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày xuất hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayxuat.Focus();
                    return;
                }
                var qr = from d in qlxm.HoaDonXuats
                         where d.MaHDX == txtmahd.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã đơn hàng", "'Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahd.Text = "";
                    txtmahd.Focus();
                    return;
                }
                else
                {
                    HoaDonXuat hdx = new HoaDonXuat();
                    hdx.MaHDX = txtmahd.Text;
                    hdx.MaNV = cbManv.Text;
                    hdx.MaKH = txtMakh.Text;
                    hdx.NgayXuat = Convert.ToDateTime(txtngayxuat.Text);
                    qlxm.HoaDonXuats.Add(hdx);
                    qlxm.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    LoadDonhang();
                }
            }
        }

        private void dgvDonhang_Click(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtmahd.Focus();
                return;
            }
            if (dgvDonhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtmahd.Text = dgvDonhang.CurrentRow.Cells[0].Value.ToString();
            cbManv.Text = dgvDonhang.CurrentRow.Cells[1].Value.ToString();
            txtMakh.Text = dgvDonhang.CurrentRow.Cells[2].Value.ToString();
            txtngayxuat.Text = dgvDonhang.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgv_dskh_SelectionChanged(object sender, EventArgs e)
        {
            txtMakh.Text = dgv_dskh.CurrentRow.Cells[0].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvDonhang.SelectedRows.Count; i++)
                {
                    string st = dgvDonhang.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.HoaDonXuats
                             where d.MaHDX == st
                             select d;
                    qlxm.HoaDonXuats.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadDonhang();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtmahd.Enabled = false;
                txtMakh.Enabled = false;
            }
            else
            {
                if (txtmahd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahd.Focus();
                    return;
                }
                if (txtMakh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMakh.Focus();
                    return;
                }
                if (cbManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbManv.Focus();
                    return;
                }
                if (txtngayxuat.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày xuất hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayxuat.Focus();
                    return;
                }
                else
                {
                    HoaDonXuat hdx = qlxm.HoaDonXuats.Single(s => s.MaHDX == txtmahd.Text);
                    hdx.MaHDX = txtmahd.Text;
                    hdx.MaNV = cbManv.Text;
                    hdx.MaKH = txtMakh.Text;
                    hdx.NgayXuat = Convert.ToDateTime(txtngayxuat.Text);
                    qlxm.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                    LoadDonhang();
                }
            }
        }

        private void btLapchitietdonhang_Click(object sender, EventArgs e)
        {
            Mahdx = txtmahd.Text;
            Chitiethoadonxuat fr = new Chitiethoadonxuat();
            //fr.MdiParent = this;
         
            fr.Show();
            this.Hide();
        }
    }
}