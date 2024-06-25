using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmChuyenTien : Form
    {
        string cmnd = "";
        private string sotkc, sotkn;
        private int sodu;
        int pos = 0;
        public frmChuyenTien()
        {
            InitializeComponent();
            textST.EditValueChanged += textST_EditValueChanged;
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChuyenTien_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHTableAdapter.FillAll(this.DS.KhachHang);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            textGD_MaNV.Text = Program.username;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (textCMNDTim.Text.Trim() == "" || textCMNDTim.Text.Length != 10)
            {
                MessageBox.Show("CMND không được trống và phải đủ 10 số!", "", MessageBoxButtons.OK);
                textCMNDTim.Focus();

                return;
            }
            this.KHTableAdapter.FillBy(this.DS.KhachHang, textCMNDTim.Text.TrimEnd());
            if (this.DS.KhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "", MessageBoxButtons.OK);
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
                this.KHTableAdapter.FillAll(this.DS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            if (cmnd == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "", MessageBoxButtons.OK);
            }
            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);
            btnChon2.Enabled = true;

        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            string macn = "TANDINH";
            if (cmbChiNhanh.Text.ToString() == "Bến Thành")
            {
                macn = "BENTHANH";
            }
            if (((DataRowView)bdsTK[bdsTK.Position])["MACN"].ToString().Trim() != macn)
            {
                MessageBox.Show("Không thể tạo giao dịch cho tài khoản không trùng chi nhánh!");
                return;
            }
            sotkc = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            if (sotkc == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
            }

            DataRowView rowView = (DataRowView)bdsTK[bdsTK.Position];
            decimal soduMoney = (decimal)rowView["SODU"];
            sodu = (int)soduMoney;
            this.LayTTTKCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LayTTTKCTableAdapter.Fill(this.DS.frmChuyenTien_LayTTTKC, sotkc);

            textGD_TKC.Text = sotkc;
            btnChon3.Enabled = true;
        }




        private void btnChon3_Click(object sender, EventArgs e)
        {
            sotkn = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            if (sotkn == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
            }
            if (sotkn == sotkc)
            {
                MessageBox.Show("Không thể chuyển cho bản thân!", "", MessageBoxButtons.OK);
                return;
            }
            /*DataRowView rowView = (DataRowView)bdsTK[bdsTK.Position];
            decimal soduMoney = (decimal)rowView["SODU"];
            sodu = (int)soduMoney;*/
            this.LayTTTKNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LayTTTKNTableAdapter.Fill(this.DS.frmChuyenTien_LayTTTKN, sotkn);

            textGD_TKN.Text = sotkn;

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

        private void textSoDu_TextChanged(object sender, EventArgs e)
        {
            textSoDu.TextChanged -= textSoDu_TextChanged;

            try
            {
                string input = textSoDu.Text;
                input = input.Replace(".", "");
                input = input.Replace(",", ".");
                if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
                {
                    CultureInfo culture = new CultureInfo("vi-VN");
                    string formattedValue = value.ToString("#,##0", culture);

                    formattedValue += " đ";

                    textSoDu.Text = formattedValue;
                    textSoDu.SelectionStart = textSoDu.Text.Length;
                }
                else
                {
                    textSoDu.Clear();
                }
            }
            catch
            {
                textSoDu.Clear();
            }
            finally
            {
                textSoDu.TextChanged += textSoDu_TextChanged;
            }
        }

        private void textSoDu1_TextChanged(object sender, EventArgs e)
        {
            textSoDu1.TextChanged -= textSoDu1_TextChanged;

            try
            {
                string input = textSoDu1.Text;
                input = input.Replace(".", "");
                input = input.Replace(",", ".");
                if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
                {
                    CultureInfo culture = new CultureInfo("vi-VN");
                    string formattedValue = value.ToString("#,##0", culture);

                    formattedValue += " đ";

                    textSoDu1.Text = formattedValue;
                    textSoDu1.SelectionStart = textSoDu1.Text.Length;
                }
                else
                {
                    textSoDu1.Clear();
                }
            }
            catch
            {
                textSoDu1.Clear();
            }
            finally
            {
                textSoDu1.TextChanged += textSoDu1_TextChanged;
            }
        }

        private void textGD_SoTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGD_XacNhan_Click(object sender, EventArgs e)
        {
            string sotien = "";
            string formattedText = textST.Text;
            formattedText = formattedText.Replace(",", "").Replace(".", "").Replace(" ", "").Replace("đ", "");
            if (int.TryParse(formattedText, out int number))
            {
                sotien = number.ToString();
            }
            if (sotien == "")
            {
                MessageBox.Show("Hãy nhập số tiền giao dịch!", "", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(sotien) <= 0)
            {
                MessageBox.Show("Số tiền giao dịch phải lớn hơn 0!", "", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(sotien) > sodu)
            {
                MessageBox.Show("Số tiền giao dịch lớn hơn số dư của tài khoản!", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
                string cml = "EXEC frmChuyenTien_thuchienGD '" + sotkc.TrimEnd() + "', '" + sotkn.TrimEnd() + "', '" + int.Parse(sotien) + "', '" + dt + "', '" + textGD_MaNV.Text.TrimEnd() + "'";
                Program.ExecSqlNonQuery(cml);
                UpdateData();
                textST.Text = "0";
                MessageBox.Show("Thực hiện giao dịch thành công! ", "", MessageBoxButtons.OK);
                decimal soduMoney = (decimal)this.TKTableAdapter.GetSoDu(sotkc);
                sodu = (int)soduMoney;

            }
            catch
            {
                return;
            }

            void UpdateData()
            {
                try
                {
                    this.TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);
                    textSoDu.Text = TKTableAdapter.GetSoDu(sotkc).ToString();
                    textSoDu1.Text = TKTableAdapter.GetSoDu(sotkn).ToString();
                    /*this.LayTTTKCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LayTTTKCTableAdapter.Fill(this.DS.frmChuyenTien_LayTTTKC, textSoTKC.Text);
                    this.LayTTTKNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LayTTTKNTableAdapter.Fill(this.DS.frmChuyenTien_LayTTTKN, textSoTKN.Text);*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }
    }

}
