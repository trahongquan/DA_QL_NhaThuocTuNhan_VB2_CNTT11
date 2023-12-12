using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class ThemThuocVaoHDNForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Medicine cmed = new sql_Medicine();
        sql_MedicineGroup cmg = new sql_MedicineGroup();
        HoaDonNhapForm frmNhap = new HoaDonNhapForm();
        public ThemThuocVaoHDNForm()
        {
            InitializeComponent();
        }
        public ThemThuocVaoHDNForm(HoaDonNhapForm f)
        {
            InitializeComponent();
            this.frmNhap = f;
        }
        private void ThemThuocVaoHDNForm_Load(object sender, EventArgs e)
        {
            cmg.FillCombo(cmbMaNT);
            cmbMaNT.SelectedIndex = -1;
            txtTen.Enabled = false;
            txtSDK.Enabled = false;
            txtTPC.Enabled = false;
            txtHamLuong.Enabled = false;
            txtDongGoi.Enabled = false;
            txtNuocSX.Enabled = false;
            txtDVTCB.Enabled = false;
            txtSoLo.Enabled = false;
            dtpHSD.Enabled = false;
            //txtSoLuong.Enabled = false;
            txtDVNhap.Enabled = false;
            txtQuyDoi.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtGiaBan.Enabled = false;
            txtDinhMucTon.Enabled = false;
        }

        private void btnAddAndContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddAndExit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmed.FillComboByIDGroup(cmbM_ID, cmbMaNT.Text);
            cmbM_ID.SelectedIndex = -1;
        }

        private void cmbM_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tblMedicine med = cmed.getMedicine(cmbM_ID.Text);
            tblMedicine med = new tblMedicine();
            txtTen.Text = med.Name;
            txtSDK.Text = med.SDK;
            txtTPC.Text = med.TPC;
            txtHamLuong.Text = med.HL;
            txtDongGoi.Text = med.Package;
            txtNuocSX.Text = med.NuocSX;
            txtDVTCB.Text = med.BasicUnit;
            txtSoLo.Text = med.Batch;
            dtpHSD.Text = med.Dat.ToString();
            //txtSoLuong.Text = med.Quantity.ToString();
            txtDVNhap.Text = med.ImUnit;
            txtQuyDoi.Text = med.GTQD.ToString();
            txtGiaBan.Text = med.Price.ToString();
            txtGiaNhap.Text = med.ImPrice.ToString();
            txtDinhMucTon.Text = med.DMT.ToString();
        }
    }
}