using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối về cơ sỏ dữ liệu gốc.\nBạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n");
                return 0;
            }
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TENCN"; cmbChiNhanh.ValueMember = "TENSERVER";

        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM [dbo].[V_DS_PHANMANH]");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
        }
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (textLogin.Text.Trim() == "" || textPass.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = textLogin.Text; Program.password = textPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cmbChiNhanh.SelectedIndex;
            Program.tenChiNhanh = cmbChiNhanh.Text.ToString();
            if (cmbChiNhanh.Text.ToString() == "Bến Thành")
            {
                Program.tenChiNhanh = "BENTHANH";
            }
            else
            {
                Program.tenChiNhanh = "TANDINH";
            }
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_LayThongTinNhanVien '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0); //lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "MÃ NV: " + Program.username;
            Program.frmChinh.HOTEN.Text = "HỌ TÊN: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "NHÓM: " + Program.mGroup;
            Program.frmChinh.HienThiMenu();
            this.Visible = false;
            Program.frmChinh.btn_DangXuat.Enabled = true;
            Program.frmChinh.btn_DangNhap.Enabled = false;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}