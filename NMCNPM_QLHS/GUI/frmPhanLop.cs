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
using System.Collections;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmPhanLop : DevExpress.XtraEditors.XtraForm
    {

        #region -Fields-

        bool state = false; // Đã thay đổi dữ liệu hay chưa

        #endregion -Fields-

        #region -Constructor

        public frmPhanLop()
        {
            InitializeComponent();
        }

        #endregion -Constructor

        #region -Events-

        #region -Form-

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            load_DSHS();
            load_cboNamHoc();
            load_cboHocKy();
            btnChuyen.Enabled = false;
            btnDanhSach.Enabled = false;
        }

        private void frmPhanLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.btnLuu_Click(sender, e);
            }
        }

        #endregion -Form-

        #region -comBoBox_editValueChanged-

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_cboKhoiLop();
            load_cboLop();
            load_DSLop();
        }

        private void cboKhoiLop_EditValueChanged(object sender, EventArgs e)
        {
            load_cboLop();
            load_DSLop();
        }

        private void cboLop_EditValueChanged(object sender, EventArgs e)
        {
            load_DSLop();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            load_DSLop();
        }

        #endregion -comBoBox_editValueChanged-

        #region -button_click-

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            state = true;
            IEnumerator ie = lstvDSHS.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                //Trạng thái học sinh đã được phân lớp hay chưa?
                bool state = false;

                foreach (ListViewItem item in lstvDSLop.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBox.Show("Học sinh " + olditem.SubItems[1].Text + " hiện đã được phân vào lớp " + cboLop.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }
                newitem = olditem;
                lstvDSHS.Items.Remove(olditem);
                lstvDSLop.Items.Add(newitem);

            //newitem.SubItems.Add(olditem.SubItems[1].Text);
            //newitem.Tag = olditem.Tag;
            //lstvDSLop.Items.Add(newitem);
            //lstvDSLop.Items[lstvDSLop.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
            //lstvDSHS.Items.Remove(olditem);

            Cont:
                if (state == true)
                    break;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = cboLop.EditValue.ToString();
            string maNamHoc = cboNamHoc.EditValue.ToString();
            string maHocKy = cboHocKy.EditValue.ToString();
            QUATRINHHOC_BUS.LuuPhanLopHS(lstvDSLop, maLop, maHocKy);
            MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            state = false;
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            lstvDSLop.Items.Clear();
            string maLop = cboLop.EditValue.ToString();
            string maHocKy = cboHocKy.EditValue.ToString();
            var lst = HOCSINH_BUS.LayHocSinhTheoLop(maLop, maHocKy);
            foreach (var i in lst)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.MAHS;
                item.SubItems.Add(i.HOTEN);
                lstvDSLop.Items.Add(item);
            }
        }

        #endregion -button_click-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        #region -load_comBoBox-

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        private void load_cboKhoiLop()
        {
            if (cboNamHoc.Text != "")
            {
                string maNamHoc = cboNamHoc.EditValue.ToString();
                cboKhoiLop.Properties.DataSource = KHOILOP_BUS.LayKhoiTheoNamHoc(maNamHoc);
                cboKhoiLop.Properties.DisplayMember = "TENKHOI";
                cboKhoiLop.Properties.ValueMember = "MAKHOI";
            }
        }

        private void load_cboLop()
        {
            if (cboKhoiLop.Text != "")
            {
                string maKhoi = cboKhoiLop.EditValue.ToString();
                cboLop.Properties.DataSource = LOP_BUS.LayLopTheoKhoi(maKhoi);
                cboLop.Properties.DisplayMember = "TENLOP";
                cboLop.Properties.ValueMember = "MALOP";
                cboLop.EditValue = null;
            }
            else
                cboLop.Properties.DataSource = null;
        }

        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }


        #endregion

        #region -load_listView

        private void load_DSHS()
        {
            lstvDSHS.Items.Clear();
            var lst = HOCSINH_BUS.LayHocSinhChuaPhanLop();
            foreach (var i in lst)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.MAHS;
                item.SubItems.Add(i.HOTEN);
                lstvDSHS.Items.Add(item);
            }
        }

        private void load_DSLop()
        {
            if (cboNamHoc.Text != "" && cboKhoiLop.Text != "" && cboLop.Text != "" && cboHocKy.Text != "")
            {
                string maLop = cboLop.EditValue.ToString();
                string maHocKy = cboHocKy.EditValue.ToString();
                lstvDSLop.Items.Clear();
                var lst = HOCSINH_BUS.LayHocSinhTheoLop(maLop, maHocKy);
                foreach (var i in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.MAHS;
                    item.SubItems.Add(i.HOTEN);
                    lstvDSLop.Items.Add(item);
                }
                btnDanhSach.Enabled = true;
                btnChuyen.Enabled = true;
            }
            else
                lstvDSLop.Items.Clear();
        }

        #endregion -load_listView

        #endregion -Load-

        #endregion -Methods-

    }
}