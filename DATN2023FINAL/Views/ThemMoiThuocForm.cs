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
using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;

namespace DATN2023FINAL.Views
{
    public partial class ThemMoiThuocForm : DevExpress.XtraEditors.XtraForm
    {
        sql_MedicineGroup sql_MG = new sql_MedicineGroup();
        sql_Medicine sql_M = new sql_Medicine();
        tblMedicine med = new tblMedicine();
        sql_Donvitinh sql_DVT = new sql_Donvitinh();
       
        public ThemMoiThuocForm()
        {
            InitializeComponent();
        }

        private void ThemMoiThuocForm_Load(object sender, EventArgs e)
        {
            //Mã thuốc sinh tự động
            txtID_Thuoc.Enabled = false;
            txtID_Thuoc.Text = sql_M.LoadID();
            //fill combobox Nhóm thuốc
            cmbID_NT.DataSource = sql_MG.LoadMedicineGroup();
            cmbID_NT.ValueMember = "MG_ID";
            cmbID_NT.DisplayMember = "MG_Name";
            cmbID_NT.SelectedIndex = -1;
            //fill combobox DVTCB
            cmbDVTCB.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVTCB.ValueMember = "U_ID";
            cmbDVTCB.DisplayMember = "U_Name";
            cmbDVTCB.SelectedIndex = -1;
            //fill combobox DVN
            cmbDVN.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVN.ValueMember = "U_ID";
            cmbDVN.DisplayMember = "U_Name";
            cmbDVN.SelectedIndex = -1;
            //Số lượng tồn ban đầu = 0
            txtSoLuong.Text = "0";
            txtSoLuong.Enabled = false;
        }
        public void ResetCotroll()
        {
            //Mã thuốc sinh tự động
            txtID_Thuoc.Enabled = false;
            txtID_Thuoc.Text = sql_M.LoadID();
            //fill combobox Nhóm thuốc
            cmbID_NT.DataSource = sql_MG.LoadMedicineGroup();
            cmbID_NT.ValueMember = "MG_ID";
            cmbID_NT.DisplayMember = "MG_Name";
            cmbID_NT.SelectedIndex = -1;
            //fill combobox DVTCB
            cmbDVTCB.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVTCB.ValueMember = "U_ID";
            cmbDVTCB.DisplayMember = "U_Name";
            cmbDVTCB.SelectedIndex = -1;
            //fill combobox DVN
            cmbDVN.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVN.ValueMember = "U_ID";
            cmbDVN.DisplayMember = "U_Name";
            cmbDVN.SelectedIndex = -1;
            //Số lượng tồn ban đầu = 0
            txtSoLuong.Text = "0";
            txtSoLuong.Enabled = false;
            //trống các textbox
            txtTen_Thuoc.Text = String.Empty;
            txtTPC.Text = String.Empty;
            txtSDK.Text = String.Empty;
            txtHamLuong.Text = String.Empty;
            txtNuocSX.Text = String.Empty;
            txtDongGoi.Text = String.Empty;
            txtSoLo.Text = String.Empty;
            txtQuyDoi.Text = String.Empty;
            txtGiaBan.Text = String.Empty;
            txtGiaNhap.Text = String.Empty;
            txtDinhMucTon.Text = String.Empty;
            txtTen_Thuoc.Focus();
        }
        private void btnAddNT_Click(object sender, EventArgs e)
        {
            DetailMedicineGroupForm f = new DetailMedicineGroupForm();
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            cmbID_NT.DataSource = sql_MG.LoadMedicineGroup();
            cmbID_NT.ValueMember = "MG_ID";
            cmbID_NT.DisplayMember = "MG_Name";
            cmbID_NT.SelectedIndex = -1;
        }

        private void btnAddDVTCB_Click(object sender, EventArgs e)
        {
            DetailUnitForm f = new DetailUnitForm(this);
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            cmbDVTCB.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVTCB.ValueMember = "U_ID";
            cmbDVTCB.DisplayMember = "U_Name";
            cmbDVTCB.SelectedIndex = -1;
        }

        private void btnAddDVN_Click(object sender, EventArgs e)
        {
            DetailUnitForm f = new DetailUnitForm(this);
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            cmbDVN.DataSource = sql_DVT.LoadDonvitinh();
            cmbDVN.ValueMember = "U_ID";
            cmbDVN.DisplayMember = "U_Name";
            cmbDVN.SelectedIndex = -1;
        }

        private void btnAddAndContinue_Click(object sender, EventArgs e)
        {
            if(cmbID_NT.Text == "" || txtID_Thuoc.Text == "" || txtTen_Thuoc.Text == "" || txtSDK.Text == "" ||
                txtTPC.Text == "" || txtHamLuong.Text == "" || txtSoLo.Text == "" || txtDongGoi.Text == "" ||
                txtNuocSX.Text == "" || cmbDVTCB.Text == "" || dtpHSD.Text == "" || cmbDVN.Text == "" || txtQuyDoi.Text == "" ||
                txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtSoLuong.Text == ""|| txtDinhMucTon.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông báo");
                return;
            }
            else
            {
                if(cmbDVN.Text == cmbDVTCB.Text)
                {
                    txtQuyDoi.Text = "1";
                    
                }
                
                if(DateTime.Parse(dtpHSD.Text) < DateTime.Now)
                {
                    MessageBox.Show("Thuốc quá hạn sử dụng,\n Xác nhận lại HSD!", "Cảnh báo");
                    dtpHSD.Focus();
                    return;
                }
                med.IDG = int.Parse(cmbID_NT.SelectedValue.ToString());
                med.ID = txtID_Thuoc.Text;
                med.Name = txtTen_Thuoc.Text;
                med.SDK = txtSDK.Text;
                med.TPC = txtTPC.Text;
                med.HL = txtHamLuong.Text;
                med.Batch = txtSoLo.Text;
                med.Package = txtDongGoi.Text;
                med.NuocSX = txtNuocSX.Text;
                med.BasicUnit = cmbDVTCB.Text;
                med.Dat = DateTime.Parse(dtpHSD.Text);
                med.ImUnit = cmbDVN.Text;
                med.GTQD = int.Parse(txtQuyDoi.Text);
                med.Price = float.Parse(txtGiaBan.Text);
                med.ImPrice = float.Parse(txtGiaNhap.Text);
                med.Quantity = int.Parse(txtSoLuong.Text);
                med.DMT = int.Parse(txtDinhMucTon.Text);
                try
                {
                    sql_M.insert(med);
                    MessageBox.Show("Đã thêm!", "Thông báo");
                    ResetCotroll();
                }
                catch
                {
                    MessageBox.Show("Chưa thêm được!", "Lỗi");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAndExit_Click(object sender, EventArgs e)
        {
            if (cmbID_NT.Text == "" || txtID_Thuoc.Text == "" || txtTen_Thuoc.Text == "" || txtSDK.Text == "" ||
               txtTPC.Text == "" || txtHamLuong.Text == "" || txtSoLo.Text == "" || txtDongGoi.Text == "" ||
               txtNuocSX.Text == "" || cmbDVTCB.Text == "" || dtpHSD.Text == "" || cmbDVN.Text == "" || txtQuyDoi.Text == "" ||
               txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtSoLuong.Text == "" || txtDinhMucTon.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông báo");
                return;
            }
            else
            {
                if (cmbDVN.Text == cmbDVTCB.Text)
                {
                    txtQuyDoi.Text = "1";

                }

                if (DateTime.Parse(dtpHSD.Text) < DateTime.Now)
                {
                    MessageBox.Show("Thuốc quá hạn sử dụng,\n Xác nhận lại HSD!", "Cảnh báo");
                    dtpHSD.Focus();
                    return;
                }
                med.IDG = int.Parse(cmbID_NT.SelectedValue.ToString());
                med.ID = txtID_Thuoc.Text;
                med.Name = txtTen_Thuoc.Text;
                med.SDK = txtSDK.Text;
                med.TPC = txtTPC.Text;
                med.HL = txtHamLuong.Text;
                med.Batch = txtSoLo.Text;
                med.Package = txtDongGoi.Text;
                med.NuocSX = txtNuocSX.Text;
                med.BasicUnit = cmbDVTCB.Text;
                med.Dat = DateTime.Parse(dtpHSD.Text);
                med.ImUnit = cmbDVN.Text;
                med.GTQD = int.Parse(txtQuyDoi.Text);
                med.Price = float.Parse(txtGiaBan.Text);
                med.ImPrice = float.Parse(txtGiaNhap.Text);
                med.Quantity = int.Parse(txtSoLuong.Text);
                med.DMT = int.Parse(txtDinhMucTon.Text);
                try
                {
                    sql_M.insert(med);
                    MessageBox.Show("Đã thêm!", "Thông báo");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Chưa thêm được!", "Lỗi");
                }
            }
        }
    }
}