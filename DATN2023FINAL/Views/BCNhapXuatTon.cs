using DATN2023FINAL.Controller;
using DATN2023FINAL.Report;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class BCNhapXuatTon : DevExpress.XtraEditors.XtraForm
    {
        sql_Baocao bc = new sql_Baocao();
        public BCNhapXuatTon()
        {
            InitializeComponent();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            dt1 = DateTime.Parse(dtpStartDay.Text);
            dt2 = DateTime.Parse(dtpEndDay.Text);
            DataTable ds = bc.BaoCaoNhapXuatTon(dt1, dt2);

            rptBCNhapXuatTon rp = new rptBCNhapXuatTon(this);
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}