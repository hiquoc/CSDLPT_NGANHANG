using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmTaoLoginKH : Form
    {
        string macn;
        public frmTaoLoginKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTaoLoginKH_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
            this.LayTKLGKHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LayTKLGKHTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLGKH);

            macn = Program.tenChiNhanh;

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            cmbChiNhanh.Enabled = false;
        }

        private void btn_Tao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl7.Enabled = true;
            btn_Tao.Enabled = btn_Xoa.Enabled = false;
            textCMND.Text = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            textNhom.Text = "KhachHang";
            textChiNhanh.Text = Program.tenChiNhanh;
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                panelControl7.Enabled = false;
                btn_Tao.Enabled = btn_Xoa.Enabled = true;
                this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
                this.LayTKLGKHTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLGKH);
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
        private bool kiemtra()
        {
            if (textTK.Text.Length <= 1 || textTK.Text.Length > 10)
            {
                MessageBox.Show("Tên tài khoản phải từ 2 đến 9 kí tự! ", "", MessageBoxButtons.OK);
                textTK.Focus();
                return false;
            }
            if (textMK.Text.Length <= 1 || textMK.Text.Length > 10)
            {
                MessageBox.Show("Mật khẩu phải từ 2 đến 9 kí tự! ", "", MessageBoxButtons.OK);
                textMK.Focus();
                return false;
            }
            if (textMK1.Text != textMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng! ", "", MessageBoxButtons.OK);
                textMK1.Focus();
                return false;
            }
            try
            {
                string cml2 = "SELECT name  FROM sys.database_principals WHERE type_desc = 'SQL_USER' and name='" + textCMND.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(cml2);
                if (Program.myReader != null && Program.myReader.HasRows)
                {
                    MessageBox.Show("Khách hàng đã có tài khoản!", "", MessageBoxButtons.OK);
                    textCMND.Focus();
                    Program.myReader.Close();
                    return false;
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string cml1 = "SELECT sysS_P.name as 'Tai khoan' FROM sys.server_principals AS sysS_P where sysS_P.name= '" + textTK.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(cml1);
                if (Program.myReader != null && Program.myReader.HasRows)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "", MessageBoxButtons.OK);
                    textTK.Focus();
                    Program.myReader.Close();
                    return false;
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;

        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (kiemtra() == false)
            {
                return;
            }
            try
            {
                string lgname = textTK.Text.Trim();
                string pass = textMK.Text.Trim();
                string username = textCMND.Text.Trim();

                SqlCommand cmd = new SqlCommand("SP_TAOTAIKHOANKH", Program.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LGNAME", lgname);
                cmd.Parameters.AddWithValue("@PASS", pass);
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Tạo thành công!", "", MessageBoxButtons.OK);
                this.LayTKLGKHTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLGKH);
                panelControl7.Enabled = false;
                btn_Tao.Enabled = btn_Xoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tk = ((DataRowView)bdsLayTKLGKH[bdsLayTKLGKH.Position])["Tai khoan"].ToString();
            string cmnd = ((DataRowView)bdsLayTKLGKH[bdsLayTKLGKH.Position])["CMND"].ToString();
            if (tk == null || cmnd == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "", MessageBoxButtons.OK);
                return;
            }
            if (cmnd == Program.username)
            {
                MessageBox.Show("Không thể xóa nhân viên đang đăng nhập!", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản của khách hàng: " + ((DataRowView)bdsLayTKLGKH[bdsLayTKLGKH.Position])["HOTEN"].ToString() + " ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string cml1 = "EXEC SP_DROPUSER " + cmnd + "; \r\nEXEC SP_DROPLOGIN " + tk + ";";
                Program.ExecSqlNonQuery(cml1);
                this.LayTKLGKHTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLGKH);
            }
        }
    }
}