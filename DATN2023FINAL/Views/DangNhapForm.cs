using DATN2023FINAL.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class DangNhapForm : DevExpress.XtraEditors.XtraForm
    {
        public static int code;
        public static string IDEmp = "";
        public static string suppended = "";
        public static string user = "";
        DataTable dt = new DataTable();

        sql_Account account = new sql_Account();
        public DangNhapForm()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IDEmp = account.getEmpID(txtUser.Text, txtPass.Text);
            dt = account.getSuppended(txtUser.Text);
            foreach(DataRow dr in dt.Rows)
            {
                suppended = dr["Suppended"].ToString();
            }          
            code = account.getRol(txtUser.Text, txtPass.Text);
            user = txtUser.Text;
            if(suppended == "True")
            {
                MessageBox.Show("Tài khoản đang bị đình chỉ, bạn không được đăng nhập!!", "Thông báo");
            }
            else
            {
                if (code == 1)
                {
                    this.Hide();
                    MainForm f = new MainForm();
                    f.Show();
                    MessageBox.Show("Đăng nhập thành công!\n Bạn là Admin!", "Thông báo");
                }
                else if(code == 2)
                {
                    this.Hide();
                    MainForm f = new MainForm();
                    f.Show();
                    MessageBox.Show("Đăng nhập thành công!\n Bạn là nhân viên bán thuốc!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo");
                    txtPass.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPass.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}