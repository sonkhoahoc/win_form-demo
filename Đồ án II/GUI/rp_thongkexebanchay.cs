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
    public partial class rp_thongkexebanchay : Form
    {
        public rp_thongkexebanchay()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            thongkexebanchaynhat tk = new thongkexebanchaynhat();
            crystalReportViewer1.ReportSource = tk;
        }

    }
}
