using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmSaoKeGDUser : Form
    {
        public frmSaoKeGDUser()
        {
            InitializeComponent();
        }



        private void taiKhoanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSaoKeGDUser_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            string strLenh = "SELECT CMND FROM KHACHHANG WHERE CMND='" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            String cmnd = Program.myReader.GetString(0);

            Program.myReader.Close();
            Program.conn.Close();

            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup != "NganHang")
            {
                cmbChiNhanh.Enabled = false;
            }

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            textTK.Text = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (textTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
                textTK.Focus();
                return;

            }
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
            int SoTK = int.Parse(textTK.Text);
            DateTime TuNgay = dateTuNgay.Value;
            string stringTuNgay = TuNgay.ToString("dd-MM-yyyy");
            DateTime DenNgay = dateDenNgay.Value;
            string stringDenNgay = DenNgay.ToString("dd-MM-yyyy");
            XRPSaoKeGD rpt = new XRPSaoKeGD(SoTK, stringTuNgay, stringDenNgay);
            rpt.lblTieuDe.Text = "DANH SÁCH GIAO DỊCH CỦA TÀI KHOẢN CÓ MÃ: " + SoTK + "\n TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;

            if (rpt.DataExists())
            {
                try
                {
                    string filePath = @"D:\Report_" + SoTK + "_" + stringTuNgay + "_to_" + stringDenNgay + ".pdf";

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
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
            }
        }

        private void btnXT_Click(object sender, EventArgs e)
        {
            if (textTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
                textTK.Focus();
                return;

            }
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
            int SoTK = int.Parse(textTK.Text);
            DateTime TuNgay = dateTuNgay.Value;
            string stringTuNgay = TuNgay.ToString("dd-MM-yyyy");
            DateTime DenNgay = dateDenNgay.Value;
            string stringDenNgay = DenNgay.ToString("dd-MM-yyyy");
            XRPSaoKeGD rpt = new XRPSaoKeGD(SoTK, stringTuNgay, stringDenNgay);
            rpt.lblTieuDe.Text = "DANH SÁCH GIAO DỊCH CỦA TÀI KHOẢN CÓ MÃ: " + SoTK + "\n TỪ " + stringTuNgay + " ĐẾN " + stringDenNgay;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }

}
