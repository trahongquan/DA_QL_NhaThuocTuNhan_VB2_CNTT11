using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATN2023FINAL.Views;

namespace DATN2023FINAL.Report
{
    public partial class rptHoaDonBan : DevExpress.XtraReports.UI.XtraReport
    {
        HoaDonBanForm frm = new HoaDonBanForm();
        public rptHoaDonBan()
        {
            InitializeComponent();
        }
        public rptHoaDonBan(HoaDonBanForm f)
        {
            InitializeComponent();
            this.frm = f;
        }
        public void BindData()
        {
            string[] str = frm.lbMoneyChar.Text.Split(':');
            string bangchu = str[1].Trim();
            DateTime d = Convert.ToDateTime(frm.dtpNgayBan.Value);
            lbSoHD.DataBindings.Add("Text", DataSource, "SAL_ID");
            lbNgayThangNam.Text = "Ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            lbTenKH.DataBindings.Add("Text", DataSource, "C_Fullname");
            lbTuoi.DataBindings.Add("Text", DataSource, "C_Age");
            lbGioiTinh.DataBindings.Add("Text", DataSource, "C_Gender");
            lbDiaChi.DataBindings.Add("Text", DataSource, "C_Address");
            lbSDT.DataBindings.Add("Text", DataSource, "C_Phonenumber");
            lbTenNV.DataBindings.Add("Text", DataSource, "Fullname");
            colTongTien.DataBindings.Add("Text", DataSource, "SAL_Total");
            colThanhToan.DataBindings.Add("Text", DataSource, "SAL_Total");
            //colMaThuoc.DataBindings.Add("Text", DataSource, "M_ID");
            colTenThuoc.DataBindings.Add("Text", DataSource, "M_Name");
            colDonVi.DataBindings.Add("Text", DataSource, "M_Unit");
            colSLBan.DataBindings.Add("Text", DataSource, "M_QuantitySale");
            colGiaBan.DataBindings.Add("Text", DataSource, "M_Price");
            colThanhTien.DataBindings.Add("Text", DataSource, "DS_Total");
            colBangChu.Text = "(" + bangchu.ToLower() + ")";
        }

    }
}
