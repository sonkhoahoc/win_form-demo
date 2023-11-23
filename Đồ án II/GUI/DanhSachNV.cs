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

namespace Đồ_án_II
{
    public partial class Frm_NV : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NV()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void LoadNV()
        {
            dgvNV.DataSource = qlxm.NhanViens.ToList();
            dgvNV.Columns[10].Visible = false;
            dgvNV.Columns[11].Visible = false;
        }

        private void Frm_NV_Load(object sender, EventArgs e)
        {
            LoadNV();
            vohieuhoa(false);
        }

        private void Frm_NV_Click(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtManv.Focus();
                return;
            }
            if (dgvNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtManv.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            txtgt.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            txtNs.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtdc.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            txtSdt.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
            txtCv.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtCMND.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();
            txtNgayvl.Text = dgvNV.CurrentRow.Cells[8].Value.ToString();
            txtpass.Text = dgvNV.CurrentRow.Cells[9].Value.ToString();
        }
        private void reset()
        {
            txtManv.Text = "";
            txthoten.Text = "";
            txtgt.Text = "";
            txtNs.Text = "";
            txtdc.Text = "";
            txtSdt.Text = "";
            txtCv.Text = "";
            txtCMND.Text = "";
            txtNgayvl.Text = "";
            txtpass.Text = "";
        }
        private void vohieuhoa(bool kt)
        {
            txtManv.Enabled = kt;
            txthoten.Enabled = kt;
            txtgt.Enabled = kt;
            txtNs.Enabled = kt;
            txtdc.Enabled = kt;
            txtSdt.Enabled = kt;
            txtCv.Enabled = kt;
            txtCMND.Enabled = kt;
            txtNgayvl.Enabled = kt;
            txtpass.Enabled = kt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                vohieuhoa(true);
                txtManv.Enabled = true;
                reset();
                txtManv.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btThem.Text = "Lưu";
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtManv.Focus();
                    return;
                }
                if (txthoten.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txthoten.Focus();
                    return;
                }
                if (txtgt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtgt.Focus();
                    return;
                }
                if (txtNs.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNs.Focus();
                    return;
                }
                if (txtdc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdc.Focus();
                    return;
                }
                if (txtSdt.Text.Trim().Length == 0&&txtSdt.Text.Trim().Length >10)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại hoặc độ dài không quá 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return;
                }
                if (txtCv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCv.Focus();
                    return;
                }
                if (txtCMND.Text.Trim().Length == 0&& txtCMND.Text.Trim().Length > 13)
                {
                    MessageBox.Show("Bạn phải nhập số chứng minh nhân dân hoặc độ dài không quá 13 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMND.Focus();
                    return;
                }
                if (txtNgayvl.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgayvl.Focus();
                    return;
                }
                if (txtpass.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Focus();
                    return;
                }
                var qr = from d in qlxm.NhanViens
                         where d.MaNV == txtManv.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = txtManv.Text;
                    nv.TenNV = txthoten.Text;
                    nv.GioiTinh = txtgt.Text;
                    nv.Ngaysinh = Convert.ToDateTime(txtNs.Text);
                    nv.Diachi = txtdc.Text;
                    nv.SDT = txtSdt.Text;
                    nv.ChucVu = txtCv.Text;
                    nv.CMND = txtCMND.Text;
                    nv.Ngayvaolam = Convert.ToDateTime(txtNgayvl.Text);
                    nv.Pass = txtpass.Text;
                    qlxm.NhanViens.Add(nv);
                    qlxm.SaveChanges();
                    MessageBox.Show("Đã thêm nhân viên", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    reset();
                    LoadNV();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtManv.Enabled = false;
            }
            else
            {
                if (txtManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtManv.Focus();
                    return;
                }
                if (txthoten.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txthoten.Focus();
                    return;
                }
                if (txtgt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtgt.Focus();
                    return;
                }
                if (txtNs.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNs.Focus();
                    return;
                }
                if (txtdc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdc.Focus();
                    return;
                }
                if (txtSdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return;
                }
                if (txtCv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCv.Focus();
                    return;
                }
                if (txtCMND.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMND.Focus();
                    return;
                }
                if (txtNgayvl.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgayvl.Focus();
                    return;
                }
                if (txtpass.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Focus();
                    return;
                }
                else
                {
                    NhanVien nv = qlxm.NhanViens.Single(s => s.MaNV == txtManv.Text);
                    nv.MaNV = txtManv.Text;
                    nv.TenNV = txthoten.Text;
                    nv.GioiTinh = txtgt.Text;
                    nv.Ngaysinh = Convert.ToDateTime(txtNs.Text);
                    nv.Diachi = txtdc.Text;
                    nv.SDT = txtSdt.Text;
                    nv.ChucVu = txtCv.Text;
                    nv.CMND = txtCMND.Text;
                    nv.Ngayvaolam = Convert.ToDateTime(txtNgayvl.Text);
                    nv.Pass = txtpass.Text;
                    qlxm.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    reset();
                    LoadNV();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvNV.SelectedRows.Count; i++)
                {
                    string st = dgvNV.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.NhanViens
                             where d.MaNV == st
                             select d;
                    qlxm.NhanViens.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadNV();
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}