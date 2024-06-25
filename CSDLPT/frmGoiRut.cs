using System;
using System.Data;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmGoiRut : Form
    {
        string sotk = "";
        string cmnd = "";
        int sodu = 0;
        public frmGoiRut()
        {
            InitializeComponent();
            textST.EditValueChanged += textST_EditValueChanged;
        }

        private void frmGoiRut_KhachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGR_KH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGoiRut_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.GR_TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GR_GDTableAdapter.Connection.ConnectionString = Program.connstr;

            this.GR_KHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GR_KHTableAdapter.FillAll(this.DS.frmGoiRut_KhachHang);


            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (textCMNDTim.Text.Trim() == "" || textCMNDTim.Text.Length != 10)
            {
                MessageBox.Show("CMND không được trống và phải đủ 10 số!", "", MessageBoxButtons.OK);
                textCMNDTim.Focus();

                return;
            }
            this.GR_KHTableAdapter.FillBy(this.DS.frmGoiRut_KhachHang, textCMNDTim.Text.TrimEnd());
            if (this.DS.frmGoiRut_KhachHang.Rows.Count == 0)
            {
                btnChon.Enabled = false;
            }
            else
            {
                btnChon.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                textCMNDTim.Text = "";
                btnChon.Enabled = true;
                this.GR_KHTableAdapter.Fill(this.DS.frmGoiRut_KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            cmnd = ((DataRowView)bdsGR_KH[bdsGR_KH.Position])["CMND"].ToString();
            if (cmnd == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "", MessageBoxButtons.OK);
            }
            this.GR_TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsGR_TK[bdsGR_TK.Position])["MACN"].ToString().Trim() != Program.tenChiNhanh)
            {
                MessageBox.Show("Không thể tạo giao dịch gởi rút đối với tài khoản thuộc chi nhánh khác!", "", MessageBoxButtons.OK);
                return;
            }
            sotk = ((DataRowView)bdsGR_TK[bdsGR_TK.Position])["SOTK"].ToString();
            if (sotk == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
                return;
            }
            DataRowView rowView = (DataRowView)bdsGR_TK[bdsGR_TK.Position];
            decimal soduMoney = (decimal)rowView["SODU"];
            sodu = (int)soduMoney;
            this.GR_GDTableAdapter.FillBy(this.DS.GD_GOIRUT, sotk);
            textSoTK.Text = sotk;
        }

        private bool check()
        {
            string sotien = "";
            string formattedText = textST.Text;
            formattedText = formattedText.Replace(",", "").Replace(".", "").Replace(" ", "").Replace("đ", "");
            if (int.TryParse(formattedText, out int number))
            {
                sotien = number.ToString();
            }
            if (int.Parse(sotien) < 100000)
            {
                MessageBox.Show("Số tiền thực hiện giao dịch tối thiểu là 100000!", "", MessageBoxButtons.OK);
                textST.Focus();
                return false;
            }
            if (cmbGD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch!", "", MessageBoxButtons.OK);
                cmbGD.Focus();
                return false;
            }

            if (cmbGD.Text == "Rút tiền")
            {
                if (sodu < int.Parse(sotien))
                {
                    MessageBox.Show("Số dư tài khoản không đủ để thực hiện giao dịch này!", "", MessageBoxButtons.OK);
                    textST.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnTaoGD_Click(object sender, EventArgs e)
        {
            if (sotk == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
                return;
            }
            panelControl8.Enabled = true;
            btnTaoGD.Enabled = false;
            textSoTK.Text = sotk;
            textMaNV.Text = Program.username;
            textST.Text = "100000";

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                return;
            }
            string ldg = "RT";
            if (cmbGD.Text == "Gởi tiền") { ldg = "GT"; }
            string sotien = "";
            string formattedText = textST.Text;
            formattedText = formattedText.Replace(",", "").Replace(".", "").Replace(" ", "").Replace("đ", "");
            if (int.TryParse(formattedText, out int number))
            {
                sotien = number.ToString();
            }
            try
            {
                string dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
                string cml = "EXEC frmGoiRut_thuchienGD '" + textSoTK.Text.TrimEnd() + "', '" + ldg + "', '" + dt + "', " + int.Parse(sotien) + ", '" + textMaNV.Text.TrimEnd() + "'";
                Program.ExecSqlNonQuery(cml);
                this.GR_GDTableAdapter.FillBy(this.DS.GD_GOIRUT, sotk);
                panelControl8.Enabled = false;
                btnTaoGD.Enabled = true;
                textSoTK.Text = "";
                textMaNV.Text = "";
                textST.Text = "100000";
                MessageBox.Show("Thực hiện giao dịch thành công! ", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện giao dịch! " + ex.Message, "", MessageBoxButtons.OK);
            }
            this.GR_GDTableAdapter.FillBy(this.DS.GD_GOIRUT, sotk);
            this.GR_TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);
            decimal soduMoney = (decimal)this.GR_TKTableAdapter.GetSoDu(sotk);
            sodu = (int)soduMoney;
        }

        private void textST_EditValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textST.Text, out int number))
            {
                string formattedNumber = number.ToString("#,##0");

                formattedNumber += " đ";
                textST.Text = formattedNumber;
            }
            else
            {
                textST.Text = "";
            }
        }
    }
}
