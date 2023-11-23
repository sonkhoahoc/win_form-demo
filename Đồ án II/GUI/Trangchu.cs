using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using Đồ_án_II.GUI;

namespace Đồ_án_II
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private TabbedView tabbedView;

        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        public void PhanQuyen()
        {
            accordionControlElement9.Enabled = false;
            accordionControlElement6.Enabled = false;            
        }
        private void BtnDangXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void RibbonForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Frm_NH v = new Frm_NH();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            Frm_XH v = new Frm_XH();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            Frm_NV v = new Frm_NV();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            Frm_KH v = new Frm_KH();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            Frm_Xe v = new Frm_Xe();
             v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            Frm_NCC v = new Frm_NCC();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            rp_thongkexeton v = new rp_thongkexeton();
            v.Show();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            rp_thongkexebanchay v = new rp_thongkexebanchay();
            v.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            QuanLyBaoHanh v = new QuanLyBaoHanh();
            v.MdiParent = this;
            v.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Xemloaixe v = new Xemloaixe();
            v.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimkiemXe v = new TimkiemXe();
            v.MdiParent = this;
            v.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimkiemTTNV v = new TimkiemTTNV();
            v.MdiParent = this;
            v.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimkiemTTKH v = new TimkiemTTKH();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement12_Click_1(object sender, EventArgs e)
        {
            LichSuNhapHang v = new LichSuNhapHang();
            v.MdiParent = this;
            v.Show();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            LichSuBanHang v = new LichSuBanHang();
            v.MdiParent = this;
            v.Show();
        }
    }
}