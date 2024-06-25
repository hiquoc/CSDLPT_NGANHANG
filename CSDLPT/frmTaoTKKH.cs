using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmTaoTKKH : Form
    {
        int vitri = 0;
        String macn = Program.tenChiNhanh.Trim();
        bool btn_Them_clicked = false;
        public frmTaoTKKH()
        {
            InitializeComponent();
            textST.EditValueChanged += textST_EditValueChanged;
        }



        private void TaoTKKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.KhachHang' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.TaiKhoan' table. You can move, or remove it, as needed.

            DS.EnforceConstraints = false;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.Fill(this.DS.TaiKhoan);
            this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHTableAdapter.FillAll(this.DS.KhachHang);
            textMaCN.Text = Program.tenChiNhanh;
            textST.Text = "100000";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (textCMNDTim.Text.Trim() == "" || textCMNDTim.Text.Length != 10)
            {
                MessageBox.Show("CMND không được trống và phải đủ 10 số!", "", MessageBoxButtons.OK);
                textCMNDTim.Focus();

                return;
            }
            try
            {
                this.KHTableAdapter.FillBy(this.DS.KhachHang, textCMNDTim.Text.TrimEnd());
                panelControl2.Enabled = gcTK.Enabled = true;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm khách hàng!", "", MessageBoxButtons.OK);
            }
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            panelControl3.Enabled = true;
            vitri = bdsTK.Position;
            bdsTK.AddNew();

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcTK.Enabled = false;
            btn_Them_clicked = true;

            textCMND.Text = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            textMaCN.Text = macn;
            textST.Text = "100000";


            int ma = 0;
            try
            {
                string strlenh1 = "SELECT Maxx = ISNULL(MAX(CAST(sotk AS INT)), 0) FROM TAIKHOAN";

                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                if (Program.myReader != null && Program.myReader.HasRows)
                {
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 0)
                    {
                        if (macn == "BENTHANH") { ma = 1; }
                        else { ma = 2; }
                    }
                    else
                    {
                        ma = Program.myReader.GetInt32(0) + 2;
                    }

                }
                textSoTK.Text = ma.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Program.conn.Close();
            }

        }


        private bool kiemtra()
        {
            string strlenh2 = "SELECT * FROM dbo.KHACHHANG WHERE CMND = '" + textCMND.Text.TrimEnd() + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh2);
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Không tìm thấy CMND trong danh sách khách hàng \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return false;
            }
            Program.myReader.Close();
            return true;
        }
        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*bool ketQua = kiemtra();
            if (ketQua == false)
            {
                btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = true;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = panelControl3.Enabled = false;
                gcTK.Enabled = true;
                btn_Them_clicked = false;
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
                return;
            }*/
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
                string cml = "EXEC frmTaoTKKH_TaoTK'" + textSoTK.Text.TrimEnd() + "','" + textCMND.Text.TrimEnd() + "','" + int.Parse(sotien) + "','" + textMaCN.Text.Trim() + "','" + dt + "'";
                Program.ExecSqlNonQuery(cml);
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi lưu tạo tài khoản! " + ex.Message, "", MessageBoxButtons.OK);
            }



            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = panelControl3.Enabled = false;
            gcTK.Enabled = true;
            btn_Them_clicked = false;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            /*bool ketQua = kiemtra();
            if (ketQua == false)
            {
                btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = true;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = panelControl3.Enabled = false;
                gcTK.Enabled = true;
                btn_Them_clicked = false;
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
                return;
            }*/
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
                string cml = "EXEC frmTaoTKKH_TaoTK'" + textSoTK.Text.TrimEnd() + "','" + textCMND.Text.TrimEnd() + "','" + int.Parse(sotien) + "','" + textMaCN.Text.TrimEnd() + "','" + dt + "'";
                Program.ExecSqlNonQuery(cml);
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tạo tài khoản! " + ex.Message, "", MessageBoxButtons.OK);
            }
            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = panelControl3.Enabled = false;
            gcTK.Enabled = true;
            btn_Them_clicked = false;
        }
        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (((DataRowView)bdsTK[bdsTK.Position])["MACN"].ToString().Trim() != Program.tenChiNhanh)
            {
                MessageBox.Show("Bạn không có quyền xóa tài khoản này!");
                return;
            }
            String sotk = ((DataRowView)bdsTK[bdsTK.Position])["SoTK"].ToString().TrimEnd();
            string strlenh1 = "SELECT * FROM DBO.GD_GOIRUT WHERE SOTK= '" + sotk + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh1);

            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                MessageBox.Show("Không thể xóa vì tài khoản này đã thực hiện giao dịch gởi/rút!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            string strlenh2 = "SELECT * FROM DBO.GD_CHUYENTIEN WHERE SOTK_CHUYEN= '" + sotk + "' OR SOTK_NHAN= '" + sotk + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh2);

            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                MessageBox.Show("Không thể xóa vì tài khoản này đã thực hiện giao dịch chuyển tiền!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();

            if (MessageBox.Show("Bạn có chắc là muốn xóa tài khoản này không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsTK.RemoveCurrent();
                    this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TKTableAdapter.Update(this.DS.TaiKhoan);
                    MessageBox.Show("Xoá thành công !", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi xóa tài khoản!" + ex.Message, "", MessageBoxButtons.OK);
                    this.TKTableAdapter.Fill(this.DS.TaiKhoan);
                    bdsTK.Position = bdsTK.Find("SoTK", sotk);
                    return;
                }
            }
            if (bdsTK.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btn_Them.Enabled == false) { bdsTK.Position = vitri; }
            gcTK.Enabled = true;
            panelControl3.Enabled = false;

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
            btn_Them_clicked = false;
            try
            {
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btn_Them.Enabled == false) { bdsTK.Position = vitri; }
            gcTK.Enabled = true;
            panelControl3.Enabled = false;

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
            btn_Them_clicked = false;
            try
            {
                this.TKTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            if (cmnd == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "", MessageBoxButtons.OK);
            }
            this.TKTableAdapter.FillBy(this.DS.TaiKhoan, cmnd);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            textCMNDTim.Text = "";
            this.KHTableAdapter.FillAll(this.DS.KhachHang);
            this.TKTableAdapter.Fill(this.DS.TaiKhoan);
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
                /*textST.Text = "";*/
            }
        }
    }
}
