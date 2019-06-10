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
            load_cboLop();
            load_cboMonHoc();
            load_cboHocKy();
            load_cboNamHoc();
        }

        private void frmNhapDiemChung_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion -Form-

        #region -bindingNavigatorItems_Click-

        #region -Xem điểm-

        private void bindingNavigatorXemDiemItem_Click(object sender, EventArgs e)
        {
            string maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
            string hoTen = dgvDiem.GetFocusedRowCellDisplayText(col_hoTen);
            string maHocKy = cboHocKy.SelectedValue.ToString();
            string maNamHoc = cboNamHoc.SelectedValue.ToString();
            frmNhapDiemChiTiet frm = new frmNhapDiemChiTiet(maHS, maHocKy, maNamHoc);
            frm.Show();
        }

        #endregion -Xem điểm-

        #region -Lưu điểm-

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maHS, maMonHoc, maHocKy, maNamHoc;
            float diemMieng, diem15P, diem1Tiet, diemThi;
            maMonHoc = cboMonHoc.SelectedValue.ToString();
            maHocKy = cboHocKy.SelectedValue.ToString();
            maNamHoc = cboNamHoc.SelectedValue.ToString();
            bindingNavigatorDiem.BindingSource.MoveFirst();
            for (int i = 0; i < dgvDiem.RowCount; i++)
            {
                //maHS, maMon, mahocky, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi
                maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
                diemMieng = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemMieng));
                diem15P = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut));
                diem1Tiet = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem1Tiet));
                diemThi = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemThi));

                HOCTAP_BUS.SuaDiem(maHS, maMonHoc, maHocKy, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi);
                bindingNavigatorDiem.BindingSource.MoveNext();
            }
            //string maLop = cboLop.SelectedValue.ToString();
            //bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
        }

        #endregion -Lưu điểm-


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            load_BangDiem();
        }


        #endregion -bindingNavigatorItems_Click-

        #region -comBoBox_ValueMemberChanged-

        private void comBoBox_ValueMemberChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        #endregion -comBoBox_ValueChanged-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        private void load_cboNamHoc()
        {
            cboNamHoc.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.DisplayMember = "TENNAMHOC";
            cboNamHoc.ValueMember = "MANAMHOC";
        }
        private void load_cboHocKy()
        {
            cboHocKy.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.DisplayMember = "TENHOCKY";
            cboHocKy.ValueMember = "MAHK";
        }
        private void load_cboLop()
        {
            cboLop.DataSource = LOP_BUS.LayTatCaLop();
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }
        private void load_cboMonHoc()
        {
            cboMonHoc.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            cboMonHoc.DisplayMember = "TENMONHOC";
            cboMonHoc.ValueMember = "MAMONHOC";
        }

        private void load_BangDiem()
        {
            if (cboLop.Text != "" && cboMonHoc.Text != "" && cboHocKy.Text != "" && cboNamHoc.Text != "")
            {
                string maLop = cboLop.SelectedValue.ToString();
                string maMonHoc = cboMonHoc.SelectedValue.ToString();
                string maHocKy = cboHocKy.SelectedValue.ToString();
                string maNamHoc = cboNamHoc.SelectedValue.ToString();
                bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
                bindingNavigatorXemDiemItem.Enabled = true;
            }
        }

        #endregion -Load-

        #endregion -Methods-
    }
}