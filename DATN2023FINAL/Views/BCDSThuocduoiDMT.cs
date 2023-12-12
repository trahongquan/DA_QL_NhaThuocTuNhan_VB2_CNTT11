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
    public partial class BCDSThuocduoiDMT : DevExpress.XtraEditors.XtraForm
    {
        sql_Baocao bc = new sql_Baocao();

        public BCDSThuocduoiDMT()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DataTable ds = bc.BaoCaoThuocDuoiDMT();

            rptDanhsachthuocduoiDMT rp = new rptDanhsachthuocduoiDMT();
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }
    }
}