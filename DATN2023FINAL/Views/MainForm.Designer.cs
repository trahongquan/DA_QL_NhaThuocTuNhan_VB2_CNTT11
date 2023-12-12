namespace DATN2023FINAL.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnMedGroup = new DevExpress.XtraBars.BarButtonItem();
            this.btnMed = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmp = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapTuNCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnSale = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraNCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonViTinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCDoanhthu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCDoanhsoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCThuocduoiMT = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCThuocsapHH = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCNhapXuatTon = new DevExpress.XtraBars.BarButtonItem();
            this.ribHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDB = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribMed = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDoitac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribSale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDoitra = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBCTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribReportType = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogOut,
            this.btnLogin,
            this.btnChangePass,
            this.btnBackup,
            this.btnRestore,
            this.btnMedGroup,
            this.btnMed,
            this.btnCustomer,
            this.btnSupplier,
            this.btnEmp,
            this.btnNhapTuNCC,
            this.btnSale,
            this.btnTraNCC,
            this.btnDonViTinh,
            this.btnAccount,
            this.btnBCDoanhthu,
            this.btnBCDoanhsoNV,
            this.btnBCThuocduoiMT,
            this.btnBCThuocsapHH,
            this.btnBCNhapXuatTon});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 30;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHT,
            this.ribDM,
            this.ribNV,
            this.ribBCTK});
            this.ribbon.Size = new System.Drawing.Size(819, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 5;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 6;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Id = 7;
            this.btnChangePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.Image")));
            this.btnChangePass.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.LargeImage")));
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.Id = 8;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 9;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnMedGroup
            // 
            this.btnMedGroup.Caption = "Nhóm thuốc";
            this.btnMedGroup.Id = 10;
            this.btnMedGroup.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.medicinegroup;
            this.btnMedGroup.ImageOptions.LargeImage = global::DATN2023FINAL.Properties.Resources.medicinegroup;
            this.btnMedGroup.Name = "btnMedGroup";
            this.btnMedGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMedGroup_ItemClick);
            // 
            // btnMed
            // 
            this.btnMed.Caption = "Thuốc";
            this.btnMed.Id = 11;
            this.btnMed.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.medicine;
            this.btnMed.ImageOptions.LargeImage = global::DATN2023FINAL.Properties.Resources.medicine;
            this.btnMed.Name = "btnMed";
            this.btnMed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMed_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 15;
            this.btnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.Image")));
            this.btnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.LargeImage")));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Nhà cung cấp";
            this.btnSupplier.Id = 16;
            this.btnSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.ImageOptions.Image")));
            this.btnSupplier.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.ImageOptions.LargeImage")));
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupplier_ItemClick);
            // 
            // btnEmp
            // 
            this.btnEmp.Caption = "Nhân viên";
            this.btnEmp.Id = 17;
            this.btnEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.ImageOptions.Image")));
            this.btnEmp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.ImageOptions.LargeImage")));
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmp_ItemClick);
            // 
            // btnNhapTuNCC
            // 
            this.btnNhapTuNCC.Caption = "Nhập từ \r\nnhà cung cấp";
            this.btnNhapTuNCC.Id = 19;
            this.btnNhapTuNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapTuNCC.ImageOptions.Image")));
            this.btnNhapTuNCC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapTuNCC.ImageOptions.LargeImage")));
            this.btnNhapTuNCC.Name = "btnNhapTuNCC";
            this.btnNhapTuNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapTuNCC_ItemClick);
            // 
            // btnSale
            // 
            this.btnSale.Caption = "Bán thuốc";
            this.btnSale.Id = 20;
            this.btnSale.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.sale;
            this.btnSale.ImageOptions.LargeImage = global::DATN2023FINAL.Properties.Resources.sale;
            this.btnSale.Name = "btnSale";
            this.btnSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSale_ItemClick);
            // 
            // btnTraNCC
            // 
            this.btnTraNCC.Caption = "Trả \r\nNhà cung cấp";
            this.btnTraNCC.Id = 21;
            this.btnTraNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTraNCC.ImageOptions.Image")));
            this.btnTraNCC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTraNCC.ImageOptions.LargeImage")));
            this.btnTraNCC.Name = "btnTraNCC";
            this.btnTraNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraNCC_ItemClick);
            // 
            // btnDonViTinh
            // 
            this.btnDonViTinh.Caption = "Đơn vị tính";
            this.btnDonViTinh.Id = 23;
            this.btnDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonViTinh.ImageOptions.Image")));
            this.btnDonViTinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonViTinh.ImageOptions.LargeImage")));
            this.btnDonViTinh.Name = "btnDonViTinh";
            this.btnDonViTinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonViTinh_ItemClick);
            // 
            // btnAccount
            // 
            this.btnAccount.Caption = "QL Tài khoản";
            this.btnAccount.Id = 24;
            this.btnAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.ImageOptions.Image")));
            this.btnAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.ImageOptions.LargeImage")));
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccount_ItemClick);
            // 
            // btnBCDoanhthu
            // 
            this.btnBCDoanhthu.Caption = "BC Doanh thu";
            this.btnBCDoanhthu.Id = 25;
            this.btnBCDoanhthu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBCDoanhthu.ImageOptions.Image")));
            this.btnBCDoanhthu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBCDoanhthu.ImageOptions.LargeImage")));
            this.btnBCDoanhthu.Name = "btnBCDoanhthu";
            this.btnBCDoanhthu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCDoanhthu_ItemClick);
            // 
            // btnBCDoanhsoNV
            // 
            this.btnBCDoanhsoNV.Caption = "Doanh số \r\nbán hàng nhân viên";
            this.btnBCDoanhsoNV.Id = 26;
            this.btnBCDoanhsoNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBCDoanhsoNV.ImageOptions.Image")));
            this.btnBCDoanhsoNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBCDoanhsoNV.ImageOptions.LargeImage")));
            this.btnBCDoanhsoNV.Name = "btnBCDoanhsoNV";
            this.btnBCDoanhsoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCDoanhsoNV_ItemClick);
            // 
            // btnBCThuocduoiMT
            // 
            this.btnBCThuocduoiMT.Caption = "Thuốc dưới ĐM tồn";
            this.btnBCThuocduoiMT.Id = 27;
            this.btnBCThuocduoiMT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBCThuocduoiMT.ImageOptions.Image")));
            this.btnBCThuocduoiMT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBCThuocduoiMT.ImageOptions.LargeImage")));
            this.btnBCThuocduoiMT.Name = "btnBCThuocduoiMT";
            this.btnBCThuocduoiMT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCThuocduoiMT_ItemClick);
            // 
            // btnBCThuocsapHH
            // 
            this.btnBCThuocsapHH.Caption = "Thuốc sắp hết hạn";
            this.btnBCThuocsapHH.Id = 28;
            this.btnBCThuocsapHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBCThuocsapHH.ImageOptions.Image")));
            this.btnBCThuocsapHH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBCThuocsapHH.ImageOptions.LargeImage")));
            this.btnBCThuocsapHH.Name = "btnBCThuocsapHH";
            this.btnBCThuocsapHH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCThuocsapHH_ItemClick);
            // 
            // btnBCNhapXuatTon
            // 
            this.btnBCNhapXuatTon.Caption = "BC Nhập - Xuất - Tồn";
            this.btnBCNhapXuatTon.Id = 29;
            this.btnBCNhapXuatTon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBCNhapXuatTon.ImageOptions.Image")));
            this.btnBCNhapXuatTon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBCNhapXuatTon.ImageOptions.LargeImage")));
            this.btnBCNhapXuatTon.Name = "btnBCNhapXuatTon";
            this.btnBCNhapXuatTon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCNhapXuatTon_ItemClick);
            // 
            // ribHT
            // 
            this.ribHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribUser,
            this.ribDB});
            this.ribHT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribHT.ImageOptions.Image")));
            this.ribHT.Name = "ribHT";
            this.ribHT.Text = "HỆ THỐNG";
            // 
            // ribUser
            // 
            this.ribUser.ItemLinks.Add(this.btnLogOut);
            this.ribUser.ItemLinks.Add(this.btnLogin);
            this.ribUser.ItemLinks.Add(this.btnChangePass);
            this.ribUser.Name = "ribUser";
            this.ribUser.Text = "Cá Nhân";
            // 
            // ribDB
            // 
            this.ribDB.ItemLinks.Add(this.btnBackup);
            this.ribDB.ItemLinks.Add(this.btnRestore);
            this.ribDB.Name = "ribDB";
            this.ribDB.Text = "Dữ Liệu";
            // 
            // ribDM
            // 
            this.ribDM.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribMed,
            this.ribDoitac,
            this.ribTaiKhoan});
            this.ribDM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribDM.ImageOptions.Image")));
            this.ribDM.Name = "ribDM";
            this.ribDM.Text = "DANH MỤC";
            // 
            // ribMed
            // 
            this.ribMed.ItemLinks.Add(this.btnMedGroup);
            this.ribMed.ItemLinks.Add(this.btnMed);
            this.ribMed.ItemLinks.Add(this.btnDonViTinh);
            this.ribMed.Name = "ribMed";
            this.ribMed.Text = "Thuốc";
            // 
            // ribDoitac
            // 
            this.ribDoitac.ItemLinks.Add(this.btnCustomer);
            this.ribDoitac.ItemLinks.Add(this.btnSupplier);
            this.ribDoitac.ItemLinks.Add(this.btnEmp);
            this.ribDoitac.Name = "ribDoitac";
            this.ribDoitac.Text = "Đối Tác";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.ItemLinks.Add(this.btnAccount);
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "Tài Khoản";
            // 
            // ribNV
            // 
            this.ribNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribNhap,
            this.ribSale,
            this.ribDoitra});
            this.ribNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribNV.ImageOptions.Image")));
            this.ribNV.Name = "ribNV";
            this.ribNV.Text = "NGHIỆP VỤ";
            // 
            // ribNhap
            // 
            this.ribNhap.ItemLinks.Add(this.btnNhapTuNCC);
            this.ribNhap.Name = "ribNhap";
            this.ribNhap.Text = "Nhập";
            // 
            // ribSale
            // 
            this.ribSale.ItemLinks.Add(this.btnSale);
            this.ribSale.Name = "ribSale";
            this.ribSale.Text = "Bán";
            // 
            // ribDoitra
            // 
            this.ribDoitra.ItemLinks.Add(this.btnTraNCC);
            this.ribDoitra.Name = "ribDoitra";
            this.ribDoitra.Text = "Đổi - Trả";
            // 
            // ribBCTK
            // 
            this.ribBCTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribReportType});
            this.ribBCTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribBCTK.ImageOptions.Image")));
            this.ribBCTK.Name = "ribBCTK";
            this.ribBCTK.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // ribReportType
            // 
            this.ribReportType.ItemLinks.Add(this.btnBCDoanhthu);
            this.ribReportType.ItemLinks.Add(this.btnBCDoanhsoNV);
            this.ribReportType.ItemLinks.Add(this.btnBCThuocduoiMT);
            this.ribReportType.ItemLinks.Add(this.btnBCThuocsapHH);
            this.ribReportType.ItemLinks.Add(this.btnBCNhapXuatTon);
            this.ribReportType.Name = "ribReportType";
            this.ribReportType.Text = "Báo Cáo - Thống Kê";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(819, 24);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::DATN2023FINAL.Properties.Resources.mainbackground;
            this.ClientSize = new System.Drawing.Size(819, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::DATN2023FINAL.Properties.Resources.iconmain;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ỨNG DỤNG QUẢN LÝ THUỐC CHO NHÀ THUỐC TƯ NHÂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribUser;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribMed;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnMedGroup;
        private DevExpress.XtraBars.BarButtonItem btnMed;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribDoitac;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.BarButtonItem btnEmp;
        private DevExpress.XtraBars.BarButtonItem btnNhapTuNCC;
        private DevExpress.XtraBars.BarButtonItem btnSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBCTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribReportType;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribDoitra;
        private DevExpress.XtraBars.BarButtonItem btnTraNCC;
        private DevExpress.XtraBars.BarButtonItem btnDonViTinh;
        private DevExpress.XtraBars.BarButtonItem btnAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnBCDoanhthu;
        private DevExpress.XtraBars.BarButtonItem btnBCDoanhsoNV;
        private DevExpress.XtraBars.BarButtonItem btnBCThuocduoiMT;
        private DevExpress.XtraBars.BarButtonItem btnBCThuocsapHH;
        private DevExpress.XtraBars.BarButtonItem btnBCNhapXuatTon;
    }
}