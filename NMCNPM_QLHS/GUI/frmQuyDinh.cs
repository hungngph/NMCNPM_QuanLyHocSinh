﻿using System;
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
    public partial class frmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        static bool state = false; // Đã thay đổi dữ liệu hay chưa

        #region -Constructor-

        public frmQuyDinh()
        {
            InitializeComponent();
        }

        public frmQuyDinh(string s)
        {
            InitializeComponent();
            switch (s)
            {
                case "QuyDinhTuoi":
                    tabQuyDinh.SelectedPage = tabTuoi;
                    break;
                case "QuyDinhSiSo":
                    tabQuyDinh.SelectedPage = tabSiSo;
                    break;
                case "QuyDinhDiem":
                    tabQuyDinh.SelectedPage = tabDiem;
                    break;
            }
        }

        #endregion -Constructor-

        #region -Events-

        #region -Button_click-

        #region -Hủy bỏ-

        #region -tabDoTuoi-

        private void btnHuyBo1_Click(object sender, EventArgs e)
        {
            loadTabDoTuoi();
        }

        #endregion -tabDoTuoi-

        #region -tabSiSo-

        private void btnHuyBo2_Click(object sender, EventArgs e)
        {
            loadTabSiSo();
        }

        #endregion-tabSiSo-

        #region -tabDiem

        private void btnHuyBo3_Click(object sender, EventArgs e)
        {
            loadTabDiem();
        }

        #endregion-tabDiem

        #endregion -Hủy bỏ-

        #region -Đồng ý-

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double tuoiToiThieu = double.Parse(txtTuoiToiThieu.EditValue.ToString());
            double tuoiToiDa = double.Parse(txtTuoiToiDa.EditValue.ToString());
            double siSoToiDa = double.Parse(txtSiSoToiDa.EditValue.ToString());
            double diemToiThieu = double.Parse(txtDiemToiThieu.EditValue.ToString());
            double diemToiDa = double.Parse(txtDiemToiDa.EditValue.ToString());
            double diemDatMon = double.Parse(txtDatMon.EditValue.ToString());
            double diemDatHocKy = double.Parse(txtDatHK.EditValue.ToString());
            
            if (THAMSO_BUS.KiemTraTuoi(tuoiToiThieu, tuoiToiDa) == false)
                MessageBox.Show("Tuổi không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                switch (THAMSO_BUS.KiemTraDiem(diemToiThieu, diemToiDa, diemDatMon, diemDatHocKy))
                {
                    case 1:
                        THAMSO_BUS.LuuQuyDinh(tuoiToiThieu, tuoiToiDa, siSoToiDa, diemToiThieu, diemToiDa, diemDatMon, diemDatHocKy);
                        MessageBox.Show("Đã lưu quy định");
                        state = false;
                        break;
                    case 2:case 3:
                        MessageBox.Show("Điểm không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
                
            }
        }
        
        #endregion -Đồng ý-

        #endregion-Button_click-

        #region -TextBox_ValueChanged-

        #region -tabTuoi-

        private void TextBoxTuoi_EditValueChanged(object sender, EventArgs e)
        {
            int tuoiToiThieu = int.Parse(txtTuoiToiThieu.Text);
            int tuoiToiDa = int.Parse(txtTuoiToiDa.Text);
            if (THAMSO_BUS.KiemTraTuoi(tuoiToiThieu, tuoiToiDa) != true)
                labelTuoi.Text = "Tuổi tối thiếu phải nhỏ hơn tuổi tối đa!";
            else
                labelTuoi.Text = "";
        }
        
        #endregion -tabTuoi

        #region -tabDiem
        
        private void TextBoxDiem_EditValueChanged(object sender, EventArgs e)
        {
            double diemToiThieu = double.Parse(txtDiemToiThieu.Text);
            double diemToiDa = double.Parse(txtDiemToiDa.Text);
            double diemDatMon = double.Parse(txtDatMon.Text);
            double diemDatHK = double.Parse(txtDatHK.Text);
            switch (THAMSO_BUS.KiemTraDiem(diemToiThieu,diemToiDa,diemDatMon,diemDatHK))
            {
                case 1:
                    labelDiem.Text = "";
                    break;
                case 2:
                    labelDiem.Text = "Điểm tối thiếu phải nhỏ hơn điểm tối đa";
                    break;
                case 3:
                    labelDiem.Text = "Điểm tối thiếu <= Điểm đạt <= Điểm tối đa";
                    break;
                default:
                    break;
            }
        }

        #endregion -tabDiem

        #endregion -TextBox_ValueChanged-

        #region -Form-

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            loadQuyDinh();
        }

        private void frmQuyDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.btnDongY_Click(sender, e);
            }
        }

        #endregion -Form-

        #endregion -Events

        #region -Methods-

        private void loadQuyDinh()
        {
            loadTabDoTuoi();
            loadTabSiSo();
            loadTabDiem();
        }

        private void loadTabDoTuoi()
        {
            txtTuoiToiDa.EditValue = THAMSO_BUS.LayThamSo("TUOITOIDA");
            txtTuoiToiThieu.EditValue = THAMSO_BUS.LayThamSo("TUOITOITHIEU");
        }

        private void loadTabSiSo()
        {
            txtSiSoToiDa.EditValue = THAMSO_BUS.LayThamSo("SISOTOIDA").ToString();
        }

        private void loadTabDiem()
        {
            txtDiemToiThieu.EditValue = THAMSO_BUS.LayThamSo("DIEMTOITHIEU");
            txtDiemToiDa.EditValue = THAMSO_BUS.LayThamSo("DIEMTOIDA");
            txtDatMon.EditValue = THAMSO_BUS.LayThamSo("DIEMDATMON");
            txtDatHK.EditValue = THAMSO_BUS.LayThamSo("DIEMDAT");
        }

        #endregion -Methods-

    }
}