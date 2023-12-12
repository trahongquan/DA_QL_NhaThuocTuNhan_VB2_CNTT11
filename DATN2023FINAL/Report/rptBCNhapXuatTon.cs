using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptBCNhapXuatTon : DevExpress.XtraReports.UI.XtraReport
    {
        BCNhapXuatTon frm = new BCNhapXuatTon();
        public rptBCNhapXuatTon()
        {
            InitializeComponent();
        }
        public rptBCNhapXuatTon(BCNhapXuatTon f)
        {
            InitializeComponent();
            this.frm = f; ;
        }
        public void BindData()
        {
            DateTime d1 = Convert.ToDateTime(frm.dtpStartDay.Value);
            DateTime d2 = Convert.ToDateTime(frm.dtpEndDay.Value);

            lbNgayThangNam.Text = "Từ ngày " + d1.Day + "/" + d1.Month + "/" + d1.Year + " đến ngày " + d2.Day + "/" + d2.Month + "/" + d2.Year;
            colM_ID.DataBindings.Add("Text", DataSource, "M_ID");
            colM_Name.DataBindings.Add("Text", DataSource, "M_Name");
            colM_Unit.DataBindings.Add("Text", DataSource, "DVT");
            colTonDK.DataBindings.Add("Text", DataSource, "TonDK");
            colNhapTK.DataBindings.Add("Text", DataSource, "NhapTK");
            colXuatTK.DataBindings.Add("Text", DataSource, "XuatTK");
            colTonCK.DataBindings.Add("Text", DataSource, "TonCK");

            //colTenNV.Text = ;
        }
    }
}
