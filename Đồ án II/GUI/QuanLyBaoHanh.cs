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
    public partial class QuanLyBaoHanh : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyBaoHanh()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        public static string MaPhieuBH;
        private void Loaddgv()
        {
            dgvbh.DataSource = qlxm.BaoHanhs.ToList();
            dgvbh.Columns[6].Visible = false;
            dgvbh.Columns[7].Visible = false;
            dgvbh.Columns[8].Visible = false;
        }
        private void vohieuhoa(bool kt)
        {
            txtmaphieubh.Enabled = kt;
            txtmakh.Enabled = kt;
            txtmanv.Enabled = kt;
            txtmaxe.Enabled = kt;
            txttgbh.Enabled = kt;
            txtngaymua.Enabled = kt;
        }
        private void reset()
        {
            txtmaphieubh.Text = "";
            txtmakh.Text = "";
            txtmanv.Text = "";
            txtmaxe.Text = "";
            txttgbh.Text = "";
            txtngaymua.Text = "";
        }

        private void BaoHanh_Load(object sender, EventArgs e)
        {
            var qr = from d in qlxm.ChitietHDXes
                     select new { d.MaHDX, d.MaXe, d.HoaDonXuat.MaNV, d.HoaDonXuat.MaKH, d.HoaDonXuat.NgayXuat };
            dgvphieuxuat.DataSource = qr.ToList();
            Loaddgv();
            vohieuhoa(false);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                btThem.Text = "Lưu";
                vohieuhoa(true);
                txtmaphieubh.Text = "";
                txttgbh.Text = "";
                txtmaphieubh.Focus();
                txtmakh.Enabled = false;
                txtmanv.Enabled = false;
                txtmaxe.Enabled = false;
                txtngaymua.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtmaphieubh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmaphieubh.Focus();
                    return;
                }
                if (txttgbh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttgbh.Focus();
                    return;
                }
                var qr = from d in qlxm.BaoHanhs
                         where d.MaPhieuBH == txtmaphieubh.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã phiếu bảo hành", "'Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmaphieubh.Text = "";
                    txtmaphieubh.Focus();
                    return;
                }
                else
                {
                    BaoHanh bh = new BaoHanh();
                    bh.MaPhieuBH = txtmaphieubh.Text;
                    bh.MaKH = txtmakh.Text;
                    bh.MaNV = txtmanv.Text;
                    bh.MaXe = txtmaxe.Text;
                    bh.TGBH = txttgbh.Text;
                    bh.NgayMua = Convert.ToDateTime(txtngaymua.Text);
                    qlxm.BaoHanhs.Add(bh);
                    qlxm.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    Loaddgv();
                }
            }
        }

        private void dgvphieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvphieuxuat_SelectionChanged(object sender, EventArgs e)
        {
            txtmaxe.Text = dgvphieuxuat.CurrentRow.Cells[1].Value.ToString();
            txtmanv.Text = dgvphieuxuat.CurrentRow.Cells[2].Value.ToString();
            txtmakh.Text = dgvphieuxuat.CurrentRow.Cells[3].Value.ToString();
            txtngaymua.Text = dgvphieuxuat.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvbh_Click(object sender, EventArgs e)
        {
            txtmaphieubh.Text = dgvbh.CurrentRow.Cells[0].Value.ToString();
            txtmakh.Text = dgvbh.CurrentRow.Cells[1].Value.ToString();
            txtmanv.Text = dgvbh.CurrentRow.Cells[2].Value.ToString();
            txtmaxe.Text = dgvbh.CurrentRow.Cells[3].Value.ToString();
            txttgbh.Text = dgvbh.CurrentRow.Cells[4].Value.ToString();
            txtngaymua.Text = dgvbh.CurrentRow.Cells[5].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtmaphieubh.Enabled = false;
                txtmakh.Enabled = false;
                txtmanv.Enabled = false;
                txtmaxe.Enabled = false;
                txtngaymua.Enabled = false;
            }
            else
            {
                if (txtmaphieubh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmaphieubh.Focus();
                    return;
                }
                if (txttgbh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttgbh.Focus();
                    return;
                }
                else
                {
                    BaoHanh bh = qlxm.BaoHanhs.Single(s => s.MaPhieuBH == txtmaphieubh.Text);
                    bh.MaPhieuBH = txtmaphieubh.Text;
                    bh.MaKH = txtmakh.Text;
                    bh.MaNV = txtmanv.Text;
                    bh.MaXe = txtmaxe.Text;
                    bh.TGBH = txttgbh.Text;
                    bh.NgayMua = Convert.ToDateTime(txtngaymua.Text);
                    qlxm.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                    Loaddgv();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvbh.SelectedRows.Count; i++)
                {
                    string st = dgvbh.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.BaoHanhs
                             where d.MaPhieuBH == st
                             select d;
                    qlxm.BaoHanhs.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                Loaddgv();
            }
        }

        private void btinphieu_Click(object sender, EventArgs e)
        {
            MaPhieuBH = txtmaphieubh.Text;
            rp_PhieuBaoHanh fr = new rp_PhieuBaoHanh();
            fr.Show();
            this.Hide();
        }
    }
}