using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN2023FINAL.Controller;
using DATN2023FINAL.Report;
using DevExpress.XtraReports.UI;

namespace DATN2023FINAL.Views
{
    public partial class BCDoanhthu : DevExpress.XtraEditors.XtraForm
    {
        sql_Baocao bc = new sql_Baocao();
        float tongDT = 0;
        public BCDoanhthu()
        {
            InitializeComponent();
        }

        private void BCDoanhthu_Load(object sender, EventArgs e)
        {

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
            DataTable ds = bc.BaoCaoDoanhThu(dt1, dt2);
            if (ds != null)
            {
                int cout = ds.Rows.Count;
                for (int i = 0; i < cout; i++)
                {
                    tongDT += float.Parse(ds.Rows[i]["DoanhThu"].ToString());
                }
                lbTongDT.Text = tongDT.ToString();
            }
            else
                lbTongDT.Text = "";
            rptDoanhthubanhang rp = new rptDoanhthubanhang(this);
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
            tongDT = 0;
        }
    }
}