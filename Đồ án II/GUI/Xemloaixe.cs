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
    public partial class Xemloaixe : DevExpress.XtraEditors.XtraForm
    {
        public Xemloaixe()
        {
            InitializeComponent();
        }

        QLXMEntities qlxm = new QLXMEntities();
        private void Xemloaixe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlxm.Loaixes.ToList();
            dataGridView1.Columns[2].Visible = false;
        }
    }
}