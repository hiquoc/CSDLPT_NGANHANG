﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmKhachHang : Form
    {
        int vitri = 0;
        string macn = "";
        bool btn_Them_clicked = false;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.ChuyenTienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ChuyenTienTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.GoiRutTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GoiRutTableAdapter.Fill(this.DS.GD_GOIRUT);

            this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.

            this.KhachHangTableAdapter.Fill(this.DS.KhachHang);

            //loi khi khong co nhan vien hoac khach hang
            //macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
            macn = Program.tenChiNhanh;

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                btn_Them.Enabled = btn_Sua.Enabled = btn_Ghi.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenCN.Enabled = panelControl2.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = true;
            }

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
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
                this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
            }
        }

        private void khachHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = true;
            vitri = bdsKH.Position;
            bdsKH.AddNew();
            textMaCN.Text = macn;
            btn_Them_clicked = true;

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcKH.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = true;
            vitri = bdsKH.Position;
            btn_Them_clicked = false;

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcKH.Enabled = false;
        }

        private bool kiemtra()
        {

            if (textHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được để trống!", "", MessageBoxButtons.OK);
                textHo.Focus();
                return false;
            }
            if (!textHo.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Họ khách hàng không hợp lệ!", "", MessageBoxButtons.OK);
                textHo.Focus();
                return false;
            }
            if (textTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "", MessageBoxButtons.OK);
                textTen.Focus();
                return false;
            }
            if (!textTen.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!", "", MessageBoxButtons.OK);
                textTen.Focus();
                return false;
            }
            if (textCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND khách hàng không được để trống!", "", MessageBoxButtons.OK);
                textCMND.Focus();
                return false;
            }
            if (textCMND.Text.Length != 10)
            {
                MessageBox.Show("CMND khách hàng không đúng 10 chữ số!", "", MessageBoxButtons.OK);
                textCMND.Focus();
                return false;
            }
            if (!textCMND.Text.All(Char.IsDigit))
            {
                MessageBox.Show("CMND khách hàng không hợp lệ!", "", MessageBoxButtons.OK);
                textCMND.Focus();
                return false;
            }

            if (textDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được để trống!", "", MessageBoxButtons.OK);
                textDiaChi.Focus();
                return false;
            }
            if (textSoDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại khách hàng không được để trống!", "", MessageBoxButtons.OK);
                textSoDT.Focus();
                return false;
            }
            if (textSoDT.Text.Length >= 12 || !textSoDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "", MessageBoxButtons.OK);
                textSoDT.Focus();
                return false;
            }
            if (cmbPhai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phái!", "", MessageBoxButtons.OK);
                cmbPhai.Focus();
                return false;
            }
            DateTime today = DateTime.Today;
            if (dateeditNgayCap.DateTime.Date > today)
            {
                MessageBox.Show("Ngày cấp không hợp lệ!", "", MessageBoxButtons.OK);
                dateeditNgayCap.Focus();
                return false;
            }

            if (btn_Them_clicked == true)
            {
                string strlenh1 = "EXEC frmKhachHang_trungCMND '" + textCMND.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                if (Program.myReader == null) return false;
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("CMND đã tồn tại \nVui lòng nhập lại!", "", MessageBoxButtons.OK);
                    textCMND.Focus();
                    Program.myReader.Close();
                    return false;
                }
                Program.myReader.Close();
            }
            else if (btn_Them_clicked == false && textCMND.Text != ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString())
            {
                string strlenh1 = "EXEC frmKhachHang_trungCMND '" + textCMND.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                if (Program.myReader == null) return false;
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("CMND đã tồn tại \nVui lòng nhập lại!", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return false;
                }
                Program.myReader.Close();
            }

            return true;
        }
        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemtra();
            if (ketQua == false)
                return;

            try
            {
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();
                this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhachHangTableAdapter.Update(this.DS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi ghi khách hàng! " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = panelControl2.Enabled = false;
            gcKH.Enabled = true;
            btn_Them_clicked = false;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string CMND = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            string cml1 = "select SOTK FROM TaiKhoan where CMND='" + CMND + "' and (SOTK IN(select SOTK_CHUYEN FROM GD_CHUYENTIEN) or SOTK IN(select SOTK_NHAN FROM GD_CHUYENTIEN))";
            Program.myReader = Program.ExecSqlDataReader(cml1);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                MessageBox.Show("Không thể xóa vì khách hàng này đã thực hiện giao dịch chuyển tiền!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();

            string cml2 = "select SOTK FROM TaiKhoan where CMND='" + CMND + "' and SOTK IN(select SOTK FROM GD_GOIRUT) ";
            Program.myReader = Program.ExecSqlDataReader(cml2);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                MessageBox.Show("Không thể xóa vì khách hàng này đã thực hiện giao dịch gởi/rút!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            //Program.myReader.Close();
            //string strlenh1 = "EXEC frmKhachHang_ExistsGD '" + textCMND.Text + "'";
            //Program.myReader = Program.ExecSqlDataReader(strlenh1);
            //Program.myReader.Read();
            //if (Program.myReader.HasRows)
            //{
            //    MessageBox.Show("Khách hàng đã thực hiện giao dịch \nKhông thể xoá", "", MessageBoxButtons.OK);
            //    return;
            //}
            //Program.myReader.Close();
            if (MessageBox.Show("Bạn có thật sự muốn xoá khách hàng này không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKH.RemoveCurrent();
                    this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhachHangTableAdapter.Update(this.DS.KhachHang);
                    //Program.ExecSqlNonQuery("EXEC frmKhachHang_DeleteAccountNonGD '" + CMND + "'");
                    MessageBox.Show("Xoá thành công !", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi xóa khách hàng!" + ex.Message, "", MessageBoxButtons.OK);
                    this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
                    bdsKH.Position = bdsKH.Find("CMND", CMND);
                    return;
                }
            }
            if (bdsKH.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btn_Them.Enabled == false) { bdsKH.Position = vitri; }
            gcKH.Enabled = true;
            panelControl2.Enabled = false;

            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Refresh.Enabled = btn_ChuyenCN.Enabled = btn_Thoat.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
            btn_Them_clicked = false;
            try
            {
                this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
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
                this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
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
                this.KhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhachHangTableAdapter.Fill(this.DS.KhachHang);
                this.GoiRutTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GoiRutTableAdapter.Fill(this.DS.GD_GOIRUT);
                this.ChuyenTienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ChuyenTienTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            }
        }
    }
}
