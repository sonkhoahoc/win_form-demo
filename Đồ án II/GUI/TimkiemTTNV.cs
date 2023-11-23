using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;
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
    public partial class TimkiemTTNV : DevExpress.XtraEditors.XtraForm
    {
        public TimkiemTTNV()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void TimkiemTTNV_Load(object sender, EventArgs e)
        {
            dgvTTNV.DataSource = qlxm.NhanViens.ToList();
            dgvTTNV.Columns[10].Visible = false;
            dgvTTNV.Columns[11].Visible = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (rdManv.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Mã Nhân Viên cần tìm");
                var qr = from d in qlxm.NhanViens
                         where d.MaNV.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTNV.DataSource = qr.ToList();
            }
            else
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Tên Nhân Viên cần tìm");
                var qr = from d in qlxm.NhanViens
                         where d.TenNV.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTNV.DataSource = qr.ToList();
            }
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgvTTNV.DataSource = qlxm.NhanViens.ToList();
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
            worksheet.Name = "Thongtinnhanvien";

            // Tạo phần đầu

            Range head = worksheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN NHÂN VIÊN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing header part in Excel  
            for (int i = 1; i < dgvTTNV.Columns.Count + 1; i++)
            {
                worksheet.Cells[3, i] = dgvTTNV.Columns[i - 1].HeaderText;
            }
            Range rowHead = worksheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvTTNV.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTTNV.Columns.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = dgvTTNV.Rows[i].Cells[j].Value.ToString();
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dgvTTNV.Rows.Count - 1;
            int columnEnd = dgvTTNV.Columns.Count;

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
            saveFileDialog.FileName = "Thongtinnhanvien_" + DateTime.Now.Date.ToString("ddMMyyyy") + ".xlsx";
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