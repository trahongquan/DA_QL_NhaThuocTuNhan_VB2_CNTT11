using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptDoanhsoNV : DevExpress.XtraReports.UI.XtraReport
    {
        BCDoanhsobanhangNV frm = new BCDoanhsobanhangNV();

        public rptDoanhsoNV()
        {
            InitializeComponent();
        }
        public rptDoanhsoNV(BCDoanhsobanhangNV f)
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
            colE_ID.DataBindings.Add("Text", DataSource, "E_ID");
            colE_Name.DataBindings.Add("Text", DataSource, "Fullname");
            colSLHD.DataBindings.Add("Text", DataSource, "SLHDB");
            colDSo.DataBindings.Add("Text", DataSource, "DSo");

            colTotal.Text = frm.lbTongDT.Text;
            
            colNgayLapBC.Text = "Ngày " + d3.Day + " tháng " + d3.Month + " năm " + d3.Year;
            //colTenNV.Text = ;
        }
    }
}
