using DevExpress.XtraBars;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        public void ToanQuyen()
        {
            ribUser.Enabled = true;
            ribDB.Enabled = true;
            ribMed.Enabled = true;
            ribDoitac.Enabled = true;
            ribTaiKhoan.Enabled = true;
            ribNhap.Enabled = true;
            ribSale.Enabled = true;
            ribDoitra.Enabled = true;
            ribReportType.Enabled = true;
        }
        public void BanHang()
        {
            ribUser.Enabled = true;
            ribDB.Enabled = false;
            ribMed.Enabled = true;
            ribDoitac.Enabled = true;
            btnEmp.Enabled = false;
            ribTaiKhoan.Enabled = false;
            ribNhap.Enabled = true;
            ribSale.Enabled = true;
            ribDoitra.Enabled = true;
            ribReportType.Enabled = false;
        }
        public void ChuaPhanQuyen()
        {
            btnLogOut.Enabled = false;
            btnChangePass.Enabled = false;
            ribDB.Enabled = false;
            ribMed.Enabled = false;
            ribDoitac.Enabled = false;
            ribTaiKhoan.Enabled = false;
            ribNhap.Enabled = false;
            ribSale.Enabled = false;
            ribDoitra.Enabled = false;
            ribReportType.Enabled = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            int _quyen = DangNhapForm.code;
           
            if (_quyen == 1)
            {
                ToanQuyen();
            }
            else if (_quyen == 2)
            {
                BanHang();
            }
            else
            {
                ChuaPhanQuyen();
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BackupDBForm));
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(RestoreDBForm));
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            btnLogin.Enabled = true;
            btnLogOut.Enabled = false;
            btnChangePass.Enabled = false;
            ribDB.Enabled = false;
            ribMed.Enabled = false;
            ribDoitac.Enabled = false;
            ribNhap.Enabled = false;
            ribSale.Enabled = false;
            ribDoitra.Enabled = false;
            //bctk+tt
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            DangNhapForm f = new DangNhapForm();
            f.ShowDialog();
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePassForm f = new ChangePassForm();
            f.ShowDialog();
        }

        private void btnMedGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(MedicineGroupForm));
        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(CustomerForm));
        }

        private void btnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(SupplierForm));
        }

        private void btnEmp_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(EmployeeForm));
        }
        private void btnAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(AccountForm));
        }
        private void btnMed_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(MedicineForm));
        }

        private void btnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(UnitForm));
        }

        private void btnNhapTuNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(HoaDonNhapForm));
        }

        private void btnSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(HoaDonBanForm));
        }

        private void btnTraNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(HoaDonTraNhaCungCap));
        }

        private void btnBCDoanhthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BCDoanhthu));
        }

        private void btnBCDoanhsoNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BCDoanhsobanhangNV));
        }

        private void btnBCThuocduoiMT_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BCDSThuocduoiDMT));
        }

        private void btnBCThuocsapHH_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BCDSThuocsaphethan));
        }

        private void btnBCNhapXuatTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(BCNhapXuatTon));
        }
    }
}