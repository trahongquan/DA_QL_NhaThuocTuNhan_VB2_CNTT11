using DATN2023FINAL.Views;
using System;

namespace DATN2023FINAL.Report
{
    public partial class rptHoaDonNhap : DevExpress.XtraReports.UI.XtraReport
    {
        HoaDonNhapForm frm = new HoaDonNhapForm();
        public rptHoaDonNhap()
        {
            InitializeComponent();
        }
        public rptHoaDonNhap(HoaDonNhapForm f)
        {
            InitializeComponent();
            this.frm = f;
        }
        public void BindData()
        {
            string[] str = frm.lbMoneyChar.Text.Split(':');
            string bangchu = str[1].Trim();
            DateTime d = Convert.ToDateTime(frm.dtpNgayNhap.Value);
            lbSoHD.DataBindings.Add("Text", DataSource, "IFS_ID");
            lbNgayThangNam.Text = "Ngày " +d.Day+ " tháng " +d.Month+ " năm " +d.Year;
            lbNCC.DataBindings.Add("Text", DataSource, "S_Name");
            lbDiaChi.DataBindings.Add("Text", DataSource, "S_Address");
            lbSDT.DataBindings.Add("Text", DataSource, "S_Phonenumber");
            lbTenNV.DataBindings.Add("Text", DataSource, "Fullname");
            colTongTien.DataBindings.Add("Text", DataSource, "IFS_Total");
            colThanhToan.DataBindings.Add("Text", DataSource, "IFS_Total");
            colMaThuoc.DataBindings.Add("Text", DataSource, "M_ID");
            colTenThuoc.DataBindings.Add("Text", DataSource, "M_Name");
            colDonVi.DataBindings.Add("Text", DataSource, "M_ImUnit");
            colSLNhap.DataBindings.Add("Text", DataSource, "M_Quantity");
            colGiaNhap.DataBindings.Add("Text", DataSource, "Dongia");
            colThanhTien.DataBindings.Add("Text", DataSource, "DIFS_Total");
            colBangChu.Text = bangchu.ToUpper();
        }

    }
}
