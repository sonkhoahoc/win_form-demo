using DevExpress.XtraCharts;
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
using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Đồ_án_II.GUI
{
    public partial class TimkiemXe : DevExpress.XtraEditors.XtraForm
    {
        public TimkiemXe()
        {
            InitializeComponent();
        }

        QLXMEntities db = new QLXMEntities();
        private void TimkiemXe_Load(object sender, EventArgs e)
        {
            dgv_ht.DataSource = db.Xes.ToList();
            dgv_ht.Columns[12].Visible = false;
            dgv_ht.Columns[13].Visible = false;
            dgv_ht.Columns[14].Visible = false;
            dgv_ht.Columns[15].Visible = false;
            dgv_ht.Columns[16].Visible = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (cb_tenxe.Checked == true && cb_mancc.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.MaNCC.Contains(txt_mancc.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tenxe.Checked == true && cb_mancc.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.MaNCC.Contains(txt_mancc.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }

            }
            else if (cb_tenxe.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }

            }
            else if (cb_mancc.Checked == true && cb_tt.Checked == true)
            {

                var qr = from d in db.Xes
                         where d.MaNCC.Contains(txt_mancc.Text) && d.TinhTrang.Contains(txt_tinhtrang.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tenxe.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.TenXe.Contains(txt_tenxe.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_mancc.Checked == true)
            {
                var qr = from d in db.Xes
                         where d.MaNCC.Contains(txt_mancc.Text)
                         select d;
                if (qr.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr.ToList();
                }
            }
            else if (cb_tt.Checked == true)
            {

                var qr1 = from d in db.Xes
                          where d.TinhTrang.Contains(txt_tinhtrang.Text)
                          select d;

                if (qr1.Count() == 0)
                {
                    MessageBox.Show("Dữ liệu tìm thấy không có trong bảng", "Thông báo");
                }
                else
                {
                    dgv_ht.DataSource = qr1.ToList();
                }
            }
        }
        private void reset()
        {
            txt_tenxe.Text = "";
            txt_mancc.Text = "";
            txt_tinhtrang.Text = "";
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgv_ht.DataSource = db.Xes.ToList();
            reset();
        }

        private void cb_tenxe_CheckedChanged(object sender, EventArgs e)
        {
            txt_tenxe.Text = "";
        }

        private void cb_mancc_CheckedChanged(object sender, EventArgs e)
        {
            txt_mancc.Text = "";
        }

        private void cb_tt_CheckedChanged(object sender, EventArgs e)
        {
            txt_tinhtrang.ResetText();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Thongtinxemay";

            // Tạo phần đầu

            Range head = worksheet.get_Range("A1", "L1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN XE MÁY";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing header part in Excel  
            for (int i = 1; i < dgv_ht.Columns.Count + 1; i++)
            {
                worksheet.Cells[3, i] = dgv_ht.Columns[i - 1].HeaderText;
            }
            Range rowHead = worksheet.get_Range("A3", "L3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgv_ht.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_ht.Columns.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = dgv_ht.Rows[i].Cells[j].Value.ToString();
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dgv_ht.Rows.Count - 1;
            int columnEnd = dgv_ht.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Range c1 = (Range)worksheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Range c2 = (Range)worksheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Range range = worksheet.get_Range(c1, c2);

            // Kẻ viền
            range.Borders.LineStyle = Constants.xlSolid;

            //Tự căn chỉnh động rộng cột
            worksheet.Columns.AutoFit();

            // Lưu file xuống
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Thongtinxemay_" + DateTime.Now.Date.ToString("ddMMyyyy") + ".xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            // Exit from the application  
            app.Quit();
        }
    }
}