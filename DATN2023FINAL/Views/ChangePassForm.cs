using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
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

namespace DATN2023FINAL.Views
{
    public partial class ChangePassForm : DevExpress.XtraEditors.XtraForm
    {
        public static string user;
        sql_Account sqlAcc = new sql_Account();
        public ChangePassForm()
        {
            InitializeComponent();
            txtOld.PasswordChar = '*';
            txtNew.PasswordChar = '*';
            txtSubmit.PasswordChar = '*';
            txtOld.Focus();
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            user = DangNhapForm.user;
        }
        private bool CheckValid()
        {
            if (this.txtOld.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu hiện tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOld.Focus();
                return false;
            }
            if (this.txtNew.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu mới không được phép rỗng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNew.Focus();
                return false;
            }
            return true;
        }
        private void ckbOld_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOld.Checked)
            {
                txtOld.PasswordChar = (char)0;
            }
            else
            {
                txtOld.PasswordChar = '*';
            }
        }

        private void ckbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNew.Checked)
            {
                txtNew.PasswordChar = (char)0;
            }
            else
            {
                txtNew.PasswordChar = '*';
            }
        }

        private void ckbSubmit_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSubmit.Checked)
            {
                txtSubmit.PasswordChar = (char)0;
            }
            else
            {
                txtSubmit.PasswordChar = '*';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string passOld = txtOld.Text;
                string passNew = txtNew.Text;
                string passSubmit = txtSubmit.Text;
                string strTemp = null;

                if (CheckValid())
                {
                    if (passNew == passSubmit)
                    {
                        //employee = c_employee.getEmployee(empID);
                        strTemp = sqlAcc.getPassByUsername(user);
                        if (strTemp == passOld)
                        {
                            //employee.Pass = passNew;
                            //c_employee.edit(employee);
                            sqlAcc.ChangePassWord(passNew, user);
                            MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu hiện tại không đúng. Vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtOld.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không đúng. Vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtSubmit.Text = "";
                        this.txtSubmit.Focus();
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Xảy lỗi: " + er.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}