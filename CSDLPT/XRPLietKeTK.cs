using System;

namespace CSDLPT
{
    public partial class XRPLietKeTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XRPLietKeTK(String macn, string tungay, string denngay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macn;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denngay;
            this.sqlDataSource1.Fill();
        }

    }
}
