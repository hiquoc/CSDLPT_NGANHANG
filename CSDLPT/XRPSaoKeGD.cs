using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class XRPSaoKeGD : XtraReport
    {
        private bool dataExists;

        public XRPSaoKeGD(int sotk, string tungay, string denngay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = sotk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denngay;

            dataExists = CheckAndFillData(sotk, tungay, denngay);
        }

        private bool CheckAndFillData(int sotk, string tungay, string denngay)
        {
            try
            {
                DateTime parsedTuNgay = DateTime.ParseExact(tungay, "dd-MM-yyyy", null);
                DateTime parsedDenNgay = DateTime.ParseExact(denngay, "dd-MM-yyyy", null);

                string formattedTuNgay = parsedTuNgay.ToString("yyyy-MM-dd");
                string formattedDenNgay = parsedDenNgay.ToString("yyyy-MM-dd");

                string query = $"EXEC frmThongKe_SaoKeGD '{sotk}', '{formattedTuNgay}', '{formattedDenNgay}'";
                Program.myReader = Program.ExecSqlDataReader(query);

                if (Program.myReader == null) return false;

                bool hasData = Program.myReader.HasRows;
                Program.myReader.Close();

                if (hasData)
                {
                    this.sqlDataSource1.Fill();
                }

                return hasData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                return false;
            }
        }

        public bool DataExists()
        {
            return dataExists;
        }
    }
}
