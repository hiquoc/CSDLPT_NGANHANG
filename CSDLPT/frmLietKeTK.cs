using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmLietKeTK : Form
    {
        public frmLietKeTK()
        {
            InitializeComponent();
        }

        private void frmLietKeTK_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.FillByOne(this.DS.TaiKhoan, Program.tenChiNhanh);

            DataTable originalTable = (DataTable)Program.bds_dspm.DataSource;
            DataTable tableCopy = originalTable.Copy();

            bool rowExists = false;
            foreach (DataRow row in tableCopy.Rows)
            {
                if (row["TENCN"].ToString() == "Cả 2 chi nhánh" && row["TENSERVER"].ToString() == "2CN")
                {
                    rowExists = true;
                    break;
                }
            }

            if (!rowExists)
            {
                DataRow newRow = tableCopy.NewRow();
                newRow["TENCN"] = "Cả 2 chi nhánh";
                newRow["TENSERVER"] = "2CN";
                tableCopy.Rows.Add(newRow);
            }

            cmbChiNhanh.DataSource = tableCopy;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup != "NganHang")
            {
                cmbChiNhanh.Enabled = false;
            }

            if (cmbChiNhanh.Text.ToString() == "Bến Thành")
            {
                textCN.Text = "Bến Thành";
            }
            else if (cmbChiNhanh.Text.ToString() == "Tân Định")
            {
                textCN.Text = "Tân Định";
            }
            else
            {
                textCN.Text = "Cả 2 chi nhánh";
            }
        }


        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex == 2)
            {
                this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TKTableAdapter.FillAll(this.DS.TaiKhoan);
                textCN.Text = "Cả 2 chi nhánh";
                return;
            }
            if (cmbChiNhanh.Text == "Bến Thành")
            {
                this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TKTableAdapter.FillByOne(this.DS.TaiKhoan, "BENTHANH");
            }
            else
            {
                this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TKTableAdapter.FillByOne(this.DS.TaiKhoan, "TANDINH");
            }
            if (cmbChiNhanh.Text.ToString() == "Bến Thành")
            {
                textCN.Text = "Bến Thành";
            }
            else
            {
                textCN.Text = "Tân Định";
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dateTuNgay.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày không hợp lệ!", "", MessageBoxButtons.OK);
                dateTuNgay.Focus();
                return;
            }
            if (dateDenNgay.Value < dateTuNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "", MessageBoxButtons.OK);
                dateDenNgay.Focus();
                return;
            }
            String macn = textCN.Text;
            DateTime TuNgay = dateTuNgay.Value;
            string stringTuNgay = TuNgay.ToString("dd-MM-yyyy");
            DateTime DenNgay = dateDenNgay.Value;
            string stringDenNgay = DenNgay.ToString("dd-MM-yyyy");

            XRPLietKeTK rpt;
            if (macn == "Cả 2 chi nhánh")
            {
                rpt = new XRPLietKeTK("2CN", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO CỦA CẢ 2 CHI NHÁNH\r\nTỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }
            else if (macn == "Bến Thành")
            {
                rpt = new XRPLietKeTK("BENTHANH", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO\r\n CỦA CHI NHÁNH: BẾN THÀNH TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }
            else
            {
                rpt = new XRPLietKeTK("TANDINH", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO\r\n CỦA CHI NHÁNH: TÂN ĐỊNH TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }

            try
            {
                string filePath = @"D:\Report_" + macn.Replace(" ", "_") + "_" + stringTuNgay + "_to_" + stringDenNgay + ".pdf";

                if (System.IO.File.Exists(filePath))
                {
                    DialogResult result = MessageBox.Show("File đã tồn tại. Bạn có muốn ghi đè lên file không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                rpt.ExportToPdf(filePath);
                MessageBox.Show("Báo cáo đã được lưu tại: " + filePath, "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu báo cáo: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            textCN.Text = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
        }

        private void btnXT_Click(object sender, EventArgs e)
        {
            if (dateTuNgay.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày không hợp lệ!", "", MessageBoxButtons.OK);
                dateTuNgay.Focus();
                return;
            }
            if (dateDenNgay.Value < dateTuNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "", MessageBoxButtons.OK);
                dateDenNgay.Focus();
                return;
            }
            String macn = textCN.Text;
            DateTime TuNgay = dateTuNgay.Value;
            string stringTuNgay = TuNgay.ToString("dd-MM-yyyy");
            DateTime DenNgay = dateDenNgay.Value;
            string stringDenNgay = DenNgay.ToString("dd-MM-yyyy");

            XRPLietKeTK rpt;
            if (macn == "Cả 2 chi nhánh")
            {
                rpt = new XRPLietKeTK("2CN", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO CỦA CẢ 2 CHI NHÁNH\r\nTỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }
            else if (macn == "Bến Thành")
            {
                rpt = new XRPLietKeTK("BENTHANH", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO\r\n CỦA CHI NHÁNH: BẾN THÀNH TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }
            else
            {
                rpt = new XRPLietKeTK("TANDINH", stringTuNgay, stringDenNgay);
                rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN ĐƯỢC TẠO\r\n CỦA CHI NHÁNH: TÂN ĐỊNH TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            }
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
