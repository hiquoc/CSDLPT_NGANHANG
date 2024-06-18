namespace CSDLPT
{
    public partial class XRPLietKeKH : DevExpress.XtraReports.UI.XtraReport
    {
        public XRPLietKeKH()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
