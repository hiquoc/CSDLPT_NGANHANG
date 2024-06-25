using System;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void HienThiMenu()
        {
            switch (Program.mGroup)
            {
                case "NganHang":
                    rib_QuanLy.Visible = true;
                    ribBaoCao.Visible = true;
                    ribNghiepVu.Visible = false;
                    ribSaoKe.Visible = false;
                    Program.frmChinh.btn_TaoTK.Enabled = true;
                    Program.frmChinh.btn_TaoTKKH.Enabled = false;
                    Program.frmChinh.MANV.Visible = true;
                    break;
                case "ChiNhanh":
                    rib_QuanLy.Visible = true;
                    ribNghiepVu.Visible = true;
                    ribBaoCao.Visible = true;
                    ribSaoKe.Visible = false;
                    Program.frmChinh.btn_TaoTK.Enabled = true;
                    Program.frmChinh.btn_TaoTKKH.Enabled = true;
                    Program.frmChinh.MANV.Visible = true;
                    break;
                case "KhachHang":
                    rib_QuanLy.Visible = false;
                    ribNghiepVu.Visible = false;
                    ribBaoCao.Visible = false;
                    ribSaoKe.Visible = true;
                    Program.frmChinh.btn_TaoTK.Enabled = false;
                    Program.frmChinh.btn_TaoTKKH.Enabled = false;
                    Program.frmChinh.MANV.Visible = false;
                    break;
            }

        }
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }



        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }



        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            btn_DangNhap.Enabled = true;
            btn_DangXuat.Enabled = false;
            rib_QuanLy.Visible = false;
            ribNghiepVu.Visible = false;
            ribBaoCao.Visible = false;
            ribSaoKe.Visible = false;
            Program.frmChinh.btn_TaoTK.Enabled = false;

            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null) f.Activate();
            else
            {
                frmDangNhap form = new frmDangNhap();
                //form.MdiParent = this;
                form.Show();
            }

            Program.frmChinh.MANV.Text = "MÃ NV:";
            Program.frmChinh.HOTEN.Text = "HỌ TÊN:";
            Program.frmChinh.NHOM.Text = "NHÓM:";
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

        private void btn_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btn_KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnTaoTKKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmTaoTKKH));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTKKH f = new frmTaoTKKH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGoiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmGoiRut));
            if (frm != null) frm.Activate();
            else
            {
                frmGoiRut f = new frmGoiRut();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmChuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                frmChuyenTien f = new frmChuyenTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_TaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }



        private void btnSaoKeGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmSaoKeGD));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoKeGD f = new frmSaoKeGD();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSaoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmSaoKeGDUser));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoKeGDUser f = new frmSaoKeGDUser();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLietKeTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmLietKeTK));
            if (frm != null) frm.Activate();
            else
            {
                frmLietKeTK f = new frmLietKeTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLietKeKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmLietKeKH));
            if (frm != null) frm.Activate();
            else
            {
                frmLietKeKH f = new frmLietKeKH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_TaoTKKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmTaoLoginKH));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLoginKH f = new frmTaoLoginKH();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
