using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmLietKeKH : Form
    {
        public frmLietKeKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLietKeKH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHTableAdapter.Fill(this.DS.KhachHang);
            cmbChiNhanh.DataSource = Program.bds_dspm;
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
            else
            {
                textCN.Text = "Tân Định";
            }

        }
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
            }
            else
            {
                this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHTableAdapter.Fill(this.DS.KhachHang);
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

            String macn = textCN.Text;


            XRPLietKeKH rpt = new XRPLietKeKH();
            rpt.lblTieuDe.Text = "DANH SÁCH TÀI KHOẢN CỦA CHI NHÁNH: " + macn.ToUpper();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
