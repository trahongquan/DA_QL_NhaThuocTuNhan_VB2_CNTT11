using DATN2023FINAL.Views;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DATN2023FINAL.Report
{
    public partial class rptHoadontraNCC : DevExpress.XtraReports.UI.XtraReport
    {
        HoaDonTraNhaCungCap frm = new HoaDonTraNhaCungCap();
        public rptHoadontraNCC()
        {
            InitializeComponent();
        }
        public rptHoadontraNCC(HoaDonTraNhaCungCap f)
        {
            InitializeComponent();
            this.frm = f;
        }
        public void BindData()
        {
            string[] str = frm.lbMoneyChar.Text.Split(':');
            string bangchu = str[1].Trim();
            DateTime d = Convert.ToDateTime(frm.dtpNgayTra.Value);
            lbSoHD.DataBindings.Add("Text", DataSource, "RS_ID");
            lbNgayThangNam.Text = "Ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            lbNCC.DataBindings.Add("Text", DataSource, "S_Name");
            lbDiaChi.DataBindings.Add("Text", DataSource, "S_Address");
            lbSDT.DataBindings.Add("Text", DataSource, "S_Phonenumber");
            lbTenNV.DataBindings.Add("Text", DataSource, "Fullname");
            colTongTien.DataBindings.Add("Text", DataSource, "RS_Total");
            colThanhToan.DataBindings.Add("Text", DataSource, "RS_Total");
            colMaThuoc.DataBindings.Add("Text", DataSource, "M_ID");
            colTenThuoc.DataBindings.Add("Text", DataSource, "M_Name");
            colDonVi.DataBindings.Add("Text", DataSource, "M_Unit");
            colSLTra.DataBindings.Add("Text", DataSource, "M_QuantityReturn");
            colDonGia.DataBindings.Add("Text", DataSource, "M_ImPrice");
            colThanhTien.DataBindings.Add("Text", DataSource, "DRS_Total");
            colBangChu.Text = bangchu.ToUpper();
        }

    }
}
