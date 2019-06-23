using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmNhapDiemChung : DevExpress.XtraEditors.XtraForm
    {

        #region -Fields-

        bool state = false; // Đã thay đổi dữ liệu hay chưa

        #endregion -Fields-

        #region -Constructor-

        public frmNhapDiemChung()
        {
            InitializeComponent();
        }

        #endregion -Constructor-

        #region -Events-

        #region -Form-

        private void frmNhapDiemChung_Load(object sender, EventArgs e)
        {
            bindingNavigatorXemDiemItem.Enabled = false;
            load_cboMonHoc();
            load_cboHocKy();
            load_cboNamHoc();
            load_cboLop();
        }

        private void frmNhapDiemChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.bindingNavigatorSaveItem_Click(sender, e);
            }
        }
        private void btnThemNam_Click(object sender, EventArgs e)
        {
            var frm = new frmNamHoc();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var frm = new frmLop();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }
        private void btnThemHK_Click(object sender, EventArgs e)
        {
            var frm = new frmHocKy();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var frm = new frmMonHoc();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }
        #endregion -Form-

        #region -bindingNavigatorItems_Click-

        #region -Xem điểm-

        private void bindingNavigatorXemDiemItem_Click(object sender, EventArgs e)
        {
            string maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
            string hoTen = dgvDiem.GetFocusedRowCellDisplayText(col_hoTen);
            string maHocKy = cboHocKy.EditValue.ToString();
            string maNamHoc = cboNamHoc.EditValue.ToString();
            frmNhapDiemChiTiet frm = new frmNhapDiemChiTiet(maHS, maHocKy, maNamHoc);
            frm.Show();
        }

        #endregion -Xem điểm-

        #region -Lưu điểm-

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maHS, maMonHoc, maHocKy, maLop;
            float diemMieng, diem15P, diem1Tiet, diemThi;
            maMonHoc = cboMonHoc.EditValue.ToString();
            maHocKy = cboHocKy.EditValue.ToString();
            maLop = cboLop.EditValue.ToString();
            bindingNavigatorDiem.BindingSource.MoveFirst();
            for (int i = 0; i < dgvDiem.RowCount; i++)
            {
                //maHS, maMon, mahocky, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi
                maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
                if (dgvDiem.GetFocusedRowCellDisplayText(col_diemMieng) != "")
                    diemMieng = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemMieng));
                else
                    diemMieng = -1;
                if (dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut) != "")
                    diem15P = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut));
                else
                    diem15P = -1;
                if (dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut) != "")
                    diem1Tiet = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem1Tiet));
                else
                    diem1Tiet = -1;
                if (dgvDiem.GetFocusedRowCellDisplayText(col_diemThi) != "")
                    diemThi = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemThi));
                else
                    diemThi = -1;
                HOCTAP_BUS.SuaDiem(maHS, maMonHoc, maHocKy, maLop, diemMieng, diem15P, diem1Tiet, diemThi);
                bindingNavigatorDiem.BindingSource.MoveNext();
            }
            state = false;
            //string maLop = cboLop.SelectedValue.ToString();
            //bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
        }

        #endregion -Lưu điểm-


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            load_BangDiem();
        }


        #endregion -bindingNavigatorItems_Click-

        #region -comBoBox_EditValueChanged-

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            //load_cboLop();
            //load_BangDiem();
        }

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        #endregion -comBoBox_ValueChanged-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        private void load_cboNamHoc()
        {
            cboNamHoc.Text = NAMHOC_BUS.LayNamHocHienTai().TENNAMHOC;
            //cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            //cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            //cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }
        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }
        private void load_cboLop()
        {
            if (cboNamHoc.Text != "")
            {
                cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(NAMHOC_BUS.LayNamHocHienTai().MANAMHOC);
                //cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(cboNamHoc.EditValue.ToString());
                cboLop.Properties.DisplayMember = "TENLOP";
                cboLop.Properties.ValueMember = "MALOP";
                cboLop.EditValue = null;
            }
            else
                cboLop.Properties.DataSource = null;
        }
        private void load_cboMonHoc()
        {
            cboMonHoc.Properties.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            cboMonHoc.Properties.DisplayMember = "TENMONHOC";
            cboMonHoc.Properties.ValueMember = "MAMONHOC";
        }

        private void load_BangDiem()
        {
            //if (cboLop.Text != "" && cboMonHoc.Text != "" && cboHocKy.Text != "" && cboNamHoc.Text != "")
            if (cboLop.Text != "" && cboMonHoc.Text != "" && cboHocKy.Text != "")
            {
                string maLop = cboLop.EditValue.ToString();
                string maMonHoc = cboMonHoc.EditValue.ToString();
                string maHocKy = cboHocKy.EditValue.ToString();
                //string maNamHoc = cboNamHoc.EditValue.ToString();
                string maNamHoc = NAMHOC_BUS.LayNamHocHienTai().MANAMHOC;
                bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
                bindingNavigatorXemDiemItem.Enabled = true;
            }
            else
                bindingSourceDiem.DataSource = null;
        }



        #endregion -Load-

        #endregion -Methods-

        
    }
}