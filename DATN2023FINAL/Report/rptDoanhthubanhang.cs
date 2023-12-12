using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptDoanhthubanhang : DevExpress.XtraReports.UI.XtraReport
    {
        BCDoanhthu frm = new BCDoanhthu();
        public rptDoanhthubanhang()
        {
            InitializeComponent();
        }
        public rptDoanhthubanhang(BCDoanhthu f)
        {
            InitializeComponent();
            this.frm = f;
        }
        public void BindData()
        {
            DateTime d1 = Convert.ToDateTime(frm.dtpStartDay.Value);
            DateTime d2 = Convert.ToDateTime(frm.dtpEndDay.Value);
            DateTime d3 = Convert.ToDateTime(DateTime.Now);
            lbNgayThangNam.Text = "Từ ngày " + d1.Day + "/" + d1.Month + "/" + d1.Year + " đến ngày " + d2.Day + "/" + d2.Month + "/" + d2.Year;
            colM_ID.DataBindings.Add("Text", DataSource, "M_ID");
            colM_Name.DataBindings.Add("Text", DataSource, "M_Name");
            colDVT.DataBindings.Add("Text", DataSource, "M_BasicUnit");
            colSL.DataBindings.Add("Text", DataSource, "SLBan");
            colDoanhthu.DataBindings.Add("Text", DataSource, "DoanhThu");
            colTotal.Text = frm.lbTongDT.Text;
            colNgayLapBC.Text = "Ngày " + d3.Day + " tháng " + d3.Month + " năm " + d3.Year;
            //colTenNV.Text = ;
        }
    }
}
