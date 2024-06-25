using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.LayTKLGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
            this.NVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NVTableAdapter.Fill(this.DS.NhanVien);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                //btn_Them.Enabled = btn_Sua.Enabled = btn_Ghi.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenCN.Enabled = panelControl2.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                //btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = true;
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
                try
                {
                    this.LayTKLGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
                    this.NVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NVTableAdapter.Fill(this.DS.NhanVien);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Program.tenChiNhanh = cmbChiNhanh.Text.ToString();
                if (cmbChiNhanh.Text.ToString() == "Bến Thành")
                {
                    Program.tenChiNhanh = "BENTHANH";
                }
                else
                {
                    Program.tenChiNhanh = "TANDINH";
                }

            }
            textChiNhanh.Text = Program.tenChiNhanh;
        }

        private void btn_Tao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Tao.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = true;
            panelControl4.Enabled = btn_PhucHoi.Enabled = true;
            textNhom.Text = Program.mGroup;
            textChiNhanh.Text = Program.tenChiNhanh;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl4.Enabled = false;
            btn_Tao.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = true;
            btn_PhucHoi.Enabled = false;
            try
            {
                this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
                this.NVTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                panelControl4.Enabled = false;
                btn_Tao.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = true;
                btn_PhucHoi.Enabled = false;
                this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
                this.NVTableAdapter.Fill(this.DS.NhanVien);
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
            string TTX = ((DataRowView)bdsNV[bdsNV.Position])["TrangThaiXoa"].ToString();
            if (TTX == "1")
            {
                MessageBox.Show("Nhân viên không làm việc ở chi nhánh này!", "", MessageBoxButtons.OK);
                return false;
            }
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
            if (textMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã nhân viên! ", "", MessageBoxButtons.OK);
                textMaNV.Focus();
                return false;
            }

            try
            {
                string cml1 = "select MANV from NhanVien where MANV='" + textMaNV.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(cml1);
                if (Program.myReader != null && Program.myReader.HasRows)
                {
                    Program.myReader.Close();
                    string cml2 = "SELECT name  FROM sys.database_principals WHERE type_desc = 'SQL_USER' and name='" + textMaNV.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(cml2);
                    if (Program.myReader != null && Program.myReader.HasRows)
                    {
                        MessageBox.Show("Nhân viên đã có tài khoản!", "", MessageBoxButtons.OK);
                        textMaNV.Focus();
                        Program.myReader.Close();
                        return false;
                    }
                    Program.myReader.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên ở chi nhánh này! ", "", MessageBoxButtons.OK);
                    textMaNV.Focus();
                    Program.myReader.Close();
                    return false;
                }
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
            SqlParameter myParm;

            SqlCommand Sqlcmd = new SqlCommand("SP_TAOTAIKHOAN", Program.conn);

            Sqlcmd.CommandType = CommandType.StoredProcedure;

            Sqlcmd.Parameters.Add(new SqlParameter("return_value", SqlDbType.Int)).Direction = ParameterDirection.ReturnValue;

            myParm = Sqlcmd.Parameters.Add(new SqlParameter("@LGNAME", SqlDbType.VarChar, 50));
            myParm.Direction = ParameterDirection.Input;
            myParm.Value = textTK.Text;

            myParm = Sqlcmd.Parameters.Add(new SqlParameter("@PASS", SqlDbType.VarChar, 50));
            myParm.Direction = ParameterDirection.Input;
            myParm.Value = textMK.Text;

            myParm = Sqlcmd.Parameters.Add(new SqlParameter("@USERNAME", SqlDbType.VarChar, 30));
            myParm.Direction = ParameterDirection.Input;
            myParm.Value = textMaNV.Text;

            myParm = Sqlcmd.Parameters.Add(new SqlParameter("@ROLE", SqlDbType.VarChar, 10));
            myParm.Direction = ParameterDirection.Input;
            myParm.Value = textNhom.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {

                Sqlcmd.ExecuteScalar();
                Program.conn.Close();
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                panelControl4.Enabled = false;
                btn_Tao.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = true;
                panelControl4.Enabled = btn_PhucHoi.Enabled = false;
                this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 15118)
                    MessageBox.Show("Password bạn nhập không thỏa chính sách bảo mật của Windows Server 2003 vì còn đơn giản", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show(ex.Message + "\nTài khoản bạn nhập đã có trong Server. Bạn nhập lại tài khoản khác.", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tk = ((DataRowView)bdsLayTKLG[bdsLayTKLG.Position])["Tai khoan"].ToString();
            string manv = ((DataRowView)bdsLayTKLG[bdsLayTKLG.Position])["Ma nhan vien"].ToString();
            string nhom = ((DataRowView)bdsLayTKLG[bdsLayTKLG.Position])["Nhom"].ToString();
            if (nhom != Program.mGroup)
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên thuộc nhóm khác!", "", MessageBoxButtons.OK);
                return;
            }
            if (manv == Program.username)
            {
                MessageBox.Show("Không thể xóa nhân viên đang đăng nhập!", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản của nhân viên: " + manv + " ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string cml1 = "EXEC SP_DROPUSER " + manv + "; \r\nEXEC SP_DROPLOGIN " + tk + ";";
                Program.ExecSqlNonQuery(cml1);
                this.LayTKLGTableAdapter.Fill(this.DS.frmTaoLogin_LayTKLG);
            }
        }
    }
}
