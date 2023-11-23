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
    public partial class rp_Phieuxuathang : Form
    {
        public rp_Phieuxuathang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Phieuxuathang px = new Phieuxuathang();
            //px.SetParameterValue("MaHDX", Chitiethoadonxuat.MAHDX);
            //crystalReportViewer1.ReportSource = px;
            crystalReportViewer1.ReportSource = px;
        }
    }
}
