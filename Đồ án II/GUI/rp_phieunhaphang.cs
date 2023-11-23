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
    public partial class rp_phieunhaphang : Form
    {
        public rp_phieunhaphang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        QLXMEntities qlxm = new QLXMEntities();
        private void rp_phieunhaphang_Load(object sender, EventArgs e)
        {
            Phieunhaphang pn = new Phieunhaphang();
            //pn.SetParameterValue("MaNCC1", Chitiethoadonnhap.MAHDN);
            crystalReportViewer1.ReportSource = pn;
        }
    }
}
