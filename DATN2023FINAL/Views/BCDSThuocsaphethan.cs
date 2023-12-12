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
    public partial class BCDSThuocsaphethan : DevExpress.XtraEditors.XtraForm
    {
        sql_Baocao bc = new sql_Baocao();
        int songay = 0;
        float tongDT = 0;
        public BCDSThuocsaphethan()
        {
            InitializeComponent();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DataTable ds = bc.BaoCaoThuocSapHetHan(songay);
            if (ds != null)
            {
                int cout = ds.Rows.Count;
                for (int i = 0; i < cout; i++)
                {
                    tongDT += float.Parse(ds.Rows[i]["TriGia"].ToString());
                }
                lbTong.Text = tongDT.ToString();
            }
            else
                lbTong.Text = "";
            rptDanhsachthuocsaphethan rp = new rptDanhsachthuocsaphethan(this);
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
            tongDT = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCDSThuocsaphethan_Load(object sender, EventArgs e)
        {
            ckb30.Checked = true;
            ckb60.Checked = false;
            ckb90.Checked = false;
        }

        private void ckb90_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb90.Checked)
            {
                songay = 90;
                ckb30.Checked = false;
                ckb60.Checked = false;
            }
                
        }

        private void ckb60_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb60.Checked)
            {
                songay = 60;
                ckb30.Checked = false;
                ckb90.Checked = false;
            }
        }

        private void ckb30_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb30.Checked)
            {
                songay = 30;
                ckb90.Checked = false;
                ckb60.Checked = false;
            }
        }
    }
}