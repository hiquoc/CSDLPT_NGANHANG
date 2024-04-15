namespace CSDLPT
{
    partial class frmTaoTKKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label sOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoTKKH));
            this.DS = new CSDLPT.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem22 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem23 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.textCMNDTim = new System.Windows.Forms.TextBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.TKTableAdapter = new CSDLPT.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHTableAdapter = new CSDLPT.DSTableAdapters.KhachHangTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.textSoDu = new System.Windows.Forms.TextBox();
            this.textMaCN = new System.Windows.Forms.TextBox();
            this.textSoTK = new System.Windows.Forms.TextBox();
            this.textCMND = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(155, 113);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(63, 20);
            cMNDLabel.TabIndex = 12;
            cMNDLabel.Text = "CMND";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(491, 169);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(108, 20);
            mACNLabel.TabIndex = 4;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(520, 113);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(52, 20);
            sODULabel.TabIndex = 2;
            sODULabel.Text = "Số dư";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(123, 172);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(99, 20);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem22,
            this.barButtonItem23,
            this.btn_Them,
            this.btn_Sua,
            this.btn_Ghi,
            this.btn_Xoa,
            this.btn_PhucHoi,
            this.btn_Refresh,
            this.btn_ChuyenCN,
            this.btn_Thoat});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(731, 185);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_PhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1021;
            this.bar1.Text = "Tools";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 2;
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa";
            this.btn_Sua.Id = 3;
            this.btn_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sua.ImageOptions.SvgImage")));
            this.btn_Sua.Name = "btn_Sua";
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Caption = "Ghi";
            this.btn_Ghi.Enabled = false;
            this.btn_Ghi.Id = 4;
            this.btn_Ghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Ghi.ImageOptions.SvgImage")));
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ghi_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 5;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Caption = "Refresh";
            this.btn_Refresh.Id = 7;
            this.btn_Refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Refresh.ImageOptions.SvgImage")));
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Refresh_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 9;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1585, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 904);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1585, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 874);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl3.Location = new System.Drawing.Point(1585, 30);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 874);
            // 
            // barButtonItem22
            // 
            this.barButtonItem22.Caption = "barButtonItem1";
            this.barButtonItem22.Id = 0;
            this.barButtonItem22.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.ImageOptions.LargeImage")));
            this.barButtonItem22.Name = "barButtonItem22";
            // 
            // barButtonItem23
            // 
            this.barButtonItem23.Caption = "barButtonItem2";
            this.barButtonItem23.Id = 1;
            this.barButtonItem23.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem23.ImageOptions.LargeImage")));
            this.barButtonItem23.Name = "barButtonItem23";
            // 
            // btn_ChuyenCN
            // 
            this.btn_ChuyenCN.Caption = "Danh sách nhân viên";
            this.btn_ChuyenCN.Id = 8;
            this.btn_ChuyenCN.Name = "btn_ChuyenCN";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(1585, 30);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(0, 874);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.gcKH);
            this.panelControl.Controls.Add(this.panelControl2);
            this.panelControl.Controls.Add(this.panelControl1);
            this.panelControl.Controls.Add(this.barDockControl4);
            this.panelControl.Controls.Add(this.barDockControl5);
            this.panelControl.Controls.Add(this.barDockControl6);
            this.panelControl.Controls.Add(this.barDockControl7);
            this.panelControl.Controls.Add(this.barDockControl8);
            this.panelControl.Controls.Add(this.barDockControl9);
            this.panelControl.Controls.Add(this.barDockControl10);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 30);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(955, 874);
            this.panelControl.TabIndex = 20;
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKH.Location = new System.Drawing.Point(2, 212);
            this.gcKH.MainView = this.gridView2;
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(951, 660);
            this.gcKH.TabIndex = 37;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND1,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN1});
            this.gridView2.GridControl = this.gcKH;
            this.gridView2.Name = "gridView2";
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 25;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 0;
            this.colCMND1.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "Mã chi nhánh";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 25;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 7;
            this.colMACN1.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnChon);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 145);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(951, 67);
            this.panelControl2.TabIndex = 30;
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.Location = new System.Drawing.Point(551, 22);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(94, 29);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(251, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(229, 25);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Danh sách khách hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnTim);
            this.panelControl1.Controls.Add(this.textCMNDTim);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(951, 143);
            this.panelControl1.TabIndex = 20;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Location = new System.Drawing.Point(622, 84);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 29);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Location = new System.Drawing.Point(528, 84);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 29);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // textCMNDTim
            // 
            this.textCMNDTim.Location = new System.Drawing.Point(323, 88);
            this.textCMNDTim.Name = "textCMNDTim";
            this.textCMNDTim.Size = new System.Drawing.Size(177, 23);
            this.textCMNDTim.TabIndex = 2;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(323, 30);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(177, 28);
            this.cmbChiNhanh.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 88);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(185, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập CMND khách hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(216, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(953, 2);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(953, 2);
            this.barDockControl5.Manager = null;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl5.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl6.Location = new System.Drawing.Point(953, 2);
            this.barDockControl6.Manager = null;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl6.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(2, 2);
            this.barDockControl7.Manager = this.barManager1;
            this.barDockControl7.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl7.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(953, 2);
            this.barDockControl8.Manager = this.barManager1;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl8.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl9.Location = new System.Drawing.Point(2, 872);
            this.barDockControl9.Manager = this.barManager1;
            this.barDockControl9.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl9.Size = new System.Drawing.Size(951, 0);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl10.Location = new System.Drawing.Point(2, 2);
            this.barDockControl10.Manager = this.barManager1;
            this.barDockControl10.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl10.Size = new System.Drawing.Size(951, 0);
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.DS;
            // 
            // TKTableAdapter
            // 
            this.TKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.frmGoiRut_KhachHangTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.TKTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTK.Location = new System.Drawing.Point(955, 30);
            this.gcTK.MainView = this.gridView1;
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(630, 393);
            this.gcTK.TabIndex = 12;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTK;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở tài khoản";
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // KHTableAdapter
            // 
            this.KHTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.btnGhi);
            this.panelControl3.Controls.Add(this.textSoDu);
            this.panelControl3.Controls.Add(this.textMaCN);
            this.panelControl3.Controls.Add(this.textSoTK);
            this.panelControl3.Controls.Add(cMNDLabel);
            this.panelControl3.Controls.Add(this.textCMND);
            this.panelControl3.Controls.Add(mACNLabel);
            this.panelControl3.Controls.Add(sODULabel);
            this.panelControl3.Controls.Add(sOTKLabel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Enabled = false;
            this.panelControl3.Location = new System.Drawing.Point(955, 423);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(630, 481);
            this.panelControl3.TabIndex = 38;
            // 
            // btnGhi
            // 
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Location = new System.Drawing.Point(360, 234);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(94, 29);
            this.btnGhi.TabIndex = 18;
            this.btnGhi.Text = "Xác nhận";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // textSoDu
            // 
            this.textSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true));
            this.textSoDu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoDu.Location = new System.Drawing.Point(613, 110);
            this.textSoDu.Name = "textSoDu";
            this.textSoDu.ReadOnly = true;
            this.textSoDu.Size = new System.Drawing.Size(125, 28);
            this.textSoDu.TabIndex = 17;
            // 
            // textMaCN
            // 
            this.textMaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "MACN", true));
            this.textMaCN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaCN.Location = new System.Drawing.Point(613, 169);
            this.textMaCN.Name = "textMaCN";
            this.textMaCN.ReadOnly = true;
            this.textMaCN.Size = new System.Drawing.Size(125, 28);
            this.textMaCN.TabIndex = 16;
            // 
            // textSoTK
            // 
            this.textSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.textSoTK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoTK.Location = new System.Drawing.Point(238, 166);
            this.textSoTK.Name = "textSoTK";
            this.textSoTK.ReadOnly = true;
            this.textSoTK.Size = new System.Drawing.Size(121, 28);
            this.textSoTK.TabIndex = 14;
            // 
            // textCMND
            // 
            this.textCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.textCMND.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCMND.Location = new System.Drawing.Point(238, 113);
            this.textCMND.Name = "textCMND";
            this.textCMND.Size = new System.Drawing.Size(121, 28);
            this.textCMND.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(335, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 25);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Thêm tài khoản";
            // 
            // frmTaoTKKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 904);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.gcTK);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoTKKH";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.TaoTKKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS DS;
     
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_Ghi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem22;
        private DevExpress.XtraBars.BarButtonItem barButtonItem23;
        private DevExpress.XtraBars.BarButtonItem btn_ChuyenCN;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.TextBox textCMNDTim;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.TaiKhoanTableAdapter TKTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KhachHangTableAdapter KHTableAdapter;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox textSoDu;
        private System.Windows.Forms.TextBox textMaCN;
        private System.Windows.Forms.TextBox textSoTK;
        private System.Windows.Forms.TextBox textCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}