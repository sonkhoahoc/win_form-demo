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
    public partial class rp_thongkexeton : Form
    {
        public rp_thongkexeton()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            thongkexetonkho tk = new thongkexetonkho();
            crystalReportViewer1.ReportSource = tk;
        }
    }
}
