using DATN2023FINAL.Controller;
using System;
using System.Data;
using DATN2023FINAL.Report;
using DevExpress.XtraReports.UI;

namespace DATN2023FINAL.Views
{
    public partial class BCDoanhsobanhangNV : DevExpress.XtraEditors.XtraForm
    {
        sql_Baocao bc = new sql_Baocao();
        float tongDT = 0;
        public BCDoanhsobanhangNV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            dt1 = DateTime.Parse(dtpStartDay.Text);
            dt2 = DateTime.Parse(dtpEndDay.Text);
            DataTable ds = bc.BaoCaoDoanhSoNV(dt1, dt2);
            if (ds != null)
            {
                int cout = ds.Rows.Count;
                for (int i = 0; i < cout; i++)
                {
                    tongDT += float.Parse(ds.Rows[i]["DSo"].ToString());
                }
                lbTongDT.Text = tongDT.ToString();
            }
            else
                lbTongDT.Text = "";
            rptDoanhsoNV rp = new rptDoanhsoNV(this);
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
            tongDT = 0;
        }
    }
}