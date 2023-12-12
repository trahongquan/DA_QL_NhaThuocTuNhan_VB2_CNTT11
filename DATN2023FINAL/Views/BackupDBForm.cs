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
    public partial class BackupDBForm : DevExpress.XtraEditors.XtraForm
    {
        DBConnection conn = new DBConnection();
        public BackupDBForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathLocation.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnection.getConnection();
            //string database = conn.Database.ToString();
            string database = conn.GetDatabaseName();
            if (txtPathLocation.Text == string.Empty)
            {
                MessageBox.Show("Hãy chọn vị trí để lưu file backup!");
            }
            else
            {
                try
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK ='" + txtPathLocation.Text + "\\" + "databaseMedicineStore" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    //conn.Open();
                    //SqlCommand command = new SqlCommand(cmd, conn);
                    //command.ExecuteNonQuery();
                    conn.RunSQL(cmd);
                    MessageBox.Show("Sao Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //conn.Close();
                    btnBackup.Enabled = false;
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