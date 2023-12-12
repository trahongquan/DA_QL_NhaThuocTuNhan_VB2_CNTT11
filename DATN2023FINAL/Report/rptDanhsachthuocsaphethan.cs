using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptDanhsachthuocsaphethan : DevExpress.XtraReports.UI.XtraReport
    {
        BCDSThuocsaphethan frm = new BCDSThuocsaphethan();
        public rptDanhsachthuocsaphethan()
        {
            InitializeComponent();
        }
        public rptDanhsachthuocsaphethan(BCDSThuocsaphethan f)
        {
            InitializeComponent();
            this.frm = f;
        }
        public void BindData()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now);
            lbNgayThangNam.Text = "Ngày " + d.Day + "/" + d.Month + "/" + d.Year;
            colM_ID.DataBindings.Add("Text", DataSource, "Ma");
            colM_Name.DataBindings.Add("Text", DataSource, "Ten");
            colM_Unit.DataBindings.Add("Text", DataSource, "DV");
            colSolo.DataBindings.Add("Text", DataSource, "TenLo");
            colHSD.DataBindings.Add("Text", DataSource, "HSD");
            colThucTon.DataBindings.Add("Text", DataSource, "SLCon");
            colGiaNhap.DataBindings.Add("Text", DataSource, "GiaNhap");
            colGT.DataBindings.Add("Text", DataSource, "TriGia");

            colTotal.Text = frm.lbTong.Text;
            //colTenNV.Text = ;
        }
    }
}
