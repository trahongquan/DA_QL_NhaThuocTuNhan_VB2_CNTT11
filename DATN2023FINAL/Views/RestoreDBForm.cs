using DATN2023FINAL.Controller;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class RestoreDBForm : DevExpress.XtraEditors.XtraForm
    {
        DBConnection conn = new DBConnection();
        public RestoreDBForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathLocation.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnection.getConnection();
            //string database = conn.Database.ToString();
            string database = conn.GetDatabaseName();
            //conn.Open();
            if (txtPathLocation.Text == String.Empty)
                MessageBox.Show("Hãy nhập đường dẫn đến file Backup dữ liệu!");
            else
            {
                try
                {
                    string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    //conn.Open();
                    //SqlCommand command1 = new SqlCommand(str1, conn);
                    //command1.ExecuteNonQuery();
                    conn.RunSQL(str1);
                    string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + txtPathLocation.Text + "' WITH REPLACE;";
                    //conn.Open();
                    //SqlCommand command2 = new SqlCommand(str2, conn);
                    //command2.ExecuteNonQuery();
                    conn.RunSQL(str2);
                    string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    //conn.Open();
                    //SqlCommand command3 = new SqlCommand(str3, conn);
                    //command3.ExecuteNonQuery();
                    conn.RunSQL(str3);
                    MessageBox.Show("Sao Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //conn.Close();
                    btnRestore.Enabled = false;
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "Ứng Dụng Quản Lý Thuốc Cho Nhà Thuốc Tư Nhân");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ứng Dụng Quản Lý Thuốc Cho Nhà Thuốc Tư Nhân");
                }
            }
        }
    }
}