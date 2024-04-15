namespace CSDLPT
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new CSDLPT.DS();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.textMaNVMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChuyenCN = new System.Windows.Forms.Button();
            this.textCMND = new DevExpress.XtraEditors.TextEdit();
            this.textMaCN = new System.Windows.Forms.TextBox();
            this.textSoDT = new System.Windows.Forms.TextBox();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textHo = new System.Windows.Forms.TextBox();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NhanVienTableAdapter = new CSDLPT.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGoiRut = new System.Windows.Forms.BindingSource(this.components);
            this.GoiRutTableAdapter = new CSDLPT.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.bdsChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.ChuyenTienTableAdapter = new CSDLPT.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.pHAIComboBox = new System.Windows.Forms.ComboBox();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(82, 34);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(88, 16);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(398, 34);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(66, 16);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(398, 92);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 16);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(906, 96);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(87, 16);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(905, 34);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(88, 16);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(124, 96);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(46, 16);
            cMNDLabel.TabIndex = 15;
            cMNDLabel.Text = "CMND:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(703, 92);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(36, 16);
            pHAILabel.TabIndex = 24;
            pHAILabel.Text = "Phái:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
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
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_PhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btn_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Sua_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1400, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1400, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1025);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1400, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1025);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_ChuyenCN
            // 
            this.btn_ChuyenCN.Caption = "Danh sách nhân viên";
            this.btn_ChuyenCN.Id = 8;
            this.btn_ChuyenCN.Name = "btn_ChuyenCN";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pHAIComboBox);
            this.panelControl2.Controls.Add(pHAILabel);
            this.panelControl2.Controls.Add(this.btnXacNhan);
            this.panelControl2.Controls.Add(this.textMaNVMoi);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.btnChuyenCN);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.textCMND);
            this.panelControl2.Controls.Add(mACNLabel);
            this.panelControl2.Controls.Add(this.textMaCN);
            this.panelControl2.Controls.Add(sODTLabel);
            this.panelControl2.Controls.Add(this.textSoDT);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.textDiaChi);
            this.panelControl2.Controls.Add(this.textTen);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.textHo);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.textMaNV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 833);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1400, 222);
            this.panelControl2.TabIndex = 11;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(655, 146);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(113, 28);
            this.btnXacNhan.TabIndex = 24;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // textMaNVMoi
            // 
            this.textMaNVMoi.Enabled = false;
            this.textMaNVMoi.Location = new System.Drawing.Point(530, 148);
            this.textMaNVMoi.Name = "textMaNVMoi";
            this.textMaNVMoi.Size = new System.Drawing.Size(100, 23);
            this.textMaNVMoi.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(398, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã nhân viên mới: ";
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Enabled = false;
            this.btnChuyenCN.Location = new System.Drawing.Point(176, 144);
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.Size = new System.Drawing.Size(149, 30);
            this.btnChuyenCN.TabIndex = 20;
            this.btnChuyenCN.Text = "Chuyển chi nhánh";
            this.btnChuyenCN.UseVisualStyleBackColor = true;
            this.btnChuyenCN.Click += new System.EventHandler(this.btnChuyenCN_Click);
            // 
            // textCMND
            // 
            this.textCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "CMND", true));
            this.textCMND.Location = new System.Drawing.Point(176, 93);
            this.textCMND.MenuManager = this.barManager1;
            this.textCMND.Name = "textCMND";
            this.textCMND.Properties.DisplayFormat.FormatString = "n0";
            this.textCMND.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textCMND.Size = new System.Drawing.Size(125, 22);
            this.textCMND.TabIndex = 4;
            // 
            // textMaCN
            // 
            this.textMaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MACN", true));
            this.textMaCN.Location = new System.Drawing.Point(999, 31);
            this.textMaCN.Name = "textMaCN";
            this.textMaCN.ReadOnly = true;
            this.textMaCN.Size = new System.Drawing.Size(143, 23);
            this.textMaCN.TabIndex = 15;
            // 
            // textSoDT
            // 
            this.textSoDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "SODT", true));
            this.textSoDT.Location = new System.Drawing.Point(999, 93);
            this.textSoDT.Name = "textSoDT";
            this.textSoDT.Size = new System.Drawing.Size(143, 23);
            this.textSoDT.TabIndex = 6;
            // 
            // textDiaChi
            // 
            this.textDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "DIACHI", true));
            this.textDiaChi.Location = new System.Drawing.Point(480, 89);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(150, 23);
            this.textDiaChi.TabIndex = 5;
            // 
            // textTen
            // 
            this.textTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.textTen.Location = new System.Drawing.Point(636, 31);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(78, 23);
            this.textTen.TabIndex = 3;
            // 
            // textHo
            // 
            this.textHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.textHo.Location = new System.Drawing.Point(480, 31);
            this.textHo.Name = "textHo";
            this.textHo.Size = new System.Drawing.Size(150, 23);
            this.textHo.TabIndex = 2;
            // 
            // textMaNV
            // 
            this.textMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.textMaNV.Location = new System.Drawing.Point(176, 31);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.ReadOnly = true;
            this.textMaNV.Size = new System.Drawing.Size(125, 23);
            this.textMaNV.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1400, 69);
            this.panelControl1.TabIndex = 16;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(137, 22);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(158, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH";
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.frmGoiRut_KhachHangTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.NhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNV.Location = new System.Drawing.Point(0, 99);
            this.gcNV.MainView = this.gridView2;
            this.gcNV.MenuManager = this.barManager1;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(1400, 734);
            this.gcNV.TabIndex = 17;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV1,
            this.colHO1,
            this.colTEN1,
            this.colCMND1,
            this.colDIACHI1,
            this.colPHAI1,
            this.colSODT1,
            this.colMACN1,
            this.colTrangThaiXoa1});
            this.gridView2.GridControl = this.gcNV;
            this.gridView2.Name = "gridView2";
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "MÃ NHÂN VIÊN";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 0;
            this.colMANV1.Width = 94;
            // 
            // colHO1
            // 
            this.colHO1.Caption = "HỌ";
            this.colHO1.FieldName = "HO";
            this.colHO1.MinWidth = 25;
            this.colHO1.Name = "colHO1";
            this.colHO1.Visible = true;
            this.colHO1.VisibleIndex = 1;
            this.colHO1.Width = 94;
            // 
            // colTEN1
            // 
            this.colTEN1.Caption = "TÊN";
            this.colTEN1.FieldName = "TEN";
            this.colTEN1.MinWidth = 25;
            this.colTEN1.Name = "colTEN1";
            this.colTEN1.Visible = true;
            this.colTEN1.VisibleIndex = 2;
            this.colTEN1.Width = 94;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 25;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 3;
            this.colCMND1.Width = 94;
            // 
            // colDIACHI1
            // 
            this.colDIACHI1.Caption = "ĐỊA CHỈ";
            this.colDIACHI1.FieldName = "DIACHI";
            this.colDIACHI1.MinWidth = 25;
            this.colDIACHI1.Name = "colDIACHI1";
            this.colDIACHI1.Visible = true;
            this.colDIACHI1.VisibleIndex = 4;
            this.colDIACHI1.Width = 94;
            // 
            // colPHAI1
            // 
            this.colPHAI1.Caption = "PHÁI";
            this.colPHAI1.FieldName = "PHAI";
            this.colPHAI1.MinWidth = 25;
            this.colPHAI1.Name = "colPHAI1";
            this.colPHAI1.Visible = true;
            this.colPHAI1.VisibleIndex = 5;
            this.colPHAI1.Width = 94;
            // 
            // colSODT1
            // 
            this.colSODT1.Caption = "SỐ ĐIỆN THOẠI";
            this.colSODT1.FieldName = "SODT";
            this.colSODT1.MinWidth = 25;
            this.colSODT1.Name = "colSODT1";
            this.colSODT1.Visible = true;
            this.colSODT1.VisibleIndex = 6;
            this.colSODT1.Width = 94;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "MÃ CHI NHÁNH";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 25;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 7;
            this.colMACN1.Width = 94;
            // 
            // colTrangThaiXoa1
            // 
            this.colTrangThaiXoa1.Caption = "TRẠNG THÁI XÓA";
            this.colTrangThaiXoa1.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa1.MinWidth = 25;
            this.colTrangThaiXoa1.Name = "colTrangThaiXoa1";
            this.colTrangThaiXoa1.Visible = true;
            this.colTrangThaiXoa1.VisibleIndex = 8;
            this.colTrangThaiXoa1.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gcNV;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 94;
            // 
            // bdsGoiRut
            // 
            this.bdsGoiRut.DataMember = "FK_GD_GOIRUT_NhanVien";
            this.bdsGoiRut.DataSource = this.bdsNV;
            // 
            // GoiRutTableAdapter
            // 
            this.GoiRutTableAdapter.ClearBeforeFill = true;
            // 
            // bdsChuyenTien
            // 
            this.bdsChuyenTien.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            this.bdsChuyenTien.DataSource = this.bdsNV;
            // 
            // ChuyenTienTableAdapter
            // 
            this.ChuyenTienTableAdapter.ClearBeforeFill = true;
            // 
            // pHAIComboBox
            // 
            this.pHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "PHAI", true));
            this.pHAIComboBox.FormattingEnabled = true;
            this.pHAIComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.pHAIComboBox.Location = new System.Drawing.Point(745, 89);
            this.pHAIComboBox.Name = "pHAIComboBox";
            this.pHAIComboBox.Size = new System.Drawing.Size(66, 24);
            this.pHAIComboBox.TabIndex = 25;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1400, 1055);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_Ghi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarButtonItem btn_ChuyenCN;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DSTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.TextBox textHo;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textMaCN;
        private System.Windows.Forms.TextBox textSoDT;
        private System.Windows.Forms.TextBox textDiaChi;
        private DevExpress.XtraEditors.TextEdit textCMND;
        private System.Windows.Forms.BindingSource bdsGoiRut;
        private DSTableAdapters.GD_GOIRUTTableAdapter GoiRutTableAdapter;
        private System.Windows.Forms.BindingSource bdsChuyenTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter ChuyenTienTableAdapter;
        private System.Windows.Forms.Button btnChuyenCN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa1;
        private System.Windows.Forms.TextBox textMaNVMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox pHAIComboBox;
    }
}