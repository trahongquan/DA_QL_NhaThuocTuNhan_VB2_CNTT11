using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptDanhsachthuocduoiDMT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhsachthuocduoiDMT()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now);
            lbNgayThangNam.Text = "Ngày " + d.Day + "/" + d.Month + "/" + d.Year;
            colM_ID.DataBindings.Add("Text", DataSource, "Ma");
            colM_Name.DataBindings.Add("Text", DataSource, "Ten");
            colM_Unit.DataBindings.Add("Text", DataSource, "DV");
            colDMT.DataBindings.Add("Text", DataSource, "DM");
            colThucTon.DataBindings.Add("Text", DataSource, "SLThucTe");
            colLechTon.DataBindings.Add("Text", DataSource, "ChenhLech");

            colNgayLapBC.Text = "Ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            //colTenNV.Text = ;
        }
    }
}
