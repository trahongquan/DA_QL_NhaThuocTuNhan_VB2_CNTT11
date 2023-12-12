using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class AccountForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Account account = new sql_Account();
        sql_Employee sqlEmp = new sql_Employee();
        public AccountForm()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = account.LoadAccount();
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
            ////fill combobox Nhân viên
            //cmbE_ID.DataSource = sqlEmp.LayTTNV();
            //cmbE_ID.ValueMember = "E_ID";
            //cmbE_ID.DisplayMember = "Fullname";
            ////cmbE_ID.Text = String.Empty;
            //cmbE_ID.SelectedIndex = -1;
            cmbE_ID.Visible = true;
            txtE_ID.Visible = false;
            LockControll();
        }
        public void ResetControll()
        {
            txtUser.Text = String.Empty;
            txtPass.Text = String.Empty;
            txtPer.Text = String.Empty;
            cmbSuppended.Text = String.Empty;
            cmbE_ID.SelectedIndex = -1;
            txtE_ID.Text = String.Empty;
        }
        public void LockControll()
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtPer.Enabled = false;
            cmbSuppended.Enabled = false;
            cmbE_ID.Enabled = false;
        }
        public void UnlockControll()
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtPer.Enabled = true;
            cmbSuppended.Enabled = true;
            cmbE_ID.Enabled = true;
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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = account.LoadByKeyWord(txtFind.Text);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UnlockControll();
            int count = dgvAccount.Rows.Count;
            int count1 = sqlEmp.DemNV();
            if(count == count1)
            {
                MessageBox.Show("Nhân viên đã được cấp đủ tài khoản rồi!!", "Thông báo");
                //btnSave.Enabled = true;
                LockControll();
            }
            else
            {
                //fill combobox Nhân viên
                cmbE_ID.DataSource = sqlEmp.LayTTNV();
                cmbE_ID.ValueMember = "E_ID";
                cmbE_ID.DisplayMember = "Fullname";
                //cmbE_ID.Text = String.Empty;
                cmbE_ID.SelectedIndex = -1;
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                txtUser.Enabled = true;
                cmbE_ID.Enabled = true;
                cmbE_ID.Visible = true;
                txtE_ID.Visible = false;
                cmbE_ID.SelectedIndex = -1;
                txtUser.Text = String.Empty;
                txtPass.Text = String.Empty;
                txtPer.Text = String.Empty;
                cmbSuppended.Text = String.Empty;
                txtFind.Text = String.Empty;
                ckbPass.Checked = false;
            }                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "" || txtPass.Text == "" || txtPer.Text == "" || cmbE_ID.SelectedValue.ToString() == "" || cmbSuppended.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
            }
            else
            {
                string temp = cmbSuppended.Text;
                tblAccount acc = new tblAccount();
                acc.Username = txtUser.Text;
                acc.Password = txtPass.Text;
                acc.E_ID = cmbE_ID.SelectedValue.ToString();
                acc.Permission = int.Parse(txtPer.Text);
                if (temp == "True")
                    acc.Suppended = true;
                else
                    acc.Suppended = false;
                try
                {
                    account.insert(acc);
                    MessageBox.Show("Đã thêm!", "Thông báo");
                    btnCancel_Click(sender, e);
                    LockControll();
                }
                catch
                {
                    MessageBox.Show("Chưa thể thêm", "Lỗi");
                }

                dgvAccount.DataSource = account.LoadAccount();
                cmbE_ID.DataSource = sqlEmp.LayTTNV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "" || txtPass.Text == "" || txtPer.Text == "" || txtE_ID.Text == "" || cmbSuppended.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
            }
            else if(txtUser.Text == "admin" && cmbSuppended.Text == "True")
            {
                MessageBox.Show("Không được đình chỉ tài khoản ADMIN", "Thông Báo");
            }
            else
            {
                string temp = cmbSuppended.Text;
                tblAccount acc = new tblAccount();
                acc.Username = txtUser.Text;
                acc.Password = txtPass.Text;
                acc.E_ID = txtE_ID.Text;
                acc.Permission = int.Parse(txtPer.Text);
                if (temp == "True")
                    acc.Suppended = true;
                else
                    acc.Suppended = false;
                try
                {
                    account.edit(acc);
                    MessageBox.Show("Đã sửa!", "Thông báo");
                    btnCancel_Click(sender, e);
                    LockControll();
                }
                catch
                {
                    MessageBox.Show("Chưa thể sửa", "Lỗi");
                }
                cmbE_ID.Visible = true;
                txtE_ID.Visible = false;
                dgvAccount.DataSource = account.LoadAccount();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string username = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            
            if (username == "admin")
            {
                MessageBox.Show("Không được quyền xoá tài khoản này!!", "Thông báo");
            }
            else
            {
                try
                {
                    account.delete(username);
                    MessageBox.Show("Đã xoá!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Chưa thể xoá", "Lỗi");
                }
            }
            ResetControll();
            dgvAccount.DataSource = account.LoadAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtUser.Text = String.Empty;
            txtPass.Text = String.Empty;
            cmbE_ID.Text = String.Empty;
            txtPer.Text = String.Empty;
            txtFind.Text = String.Empty;
            ckbPass.Checked = false;
            cmbSuppended.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
            txtUser.Enabled = false;
            txtE_ID.Visible = true;
            cmbE_ID.Visible = false;
            txtPass.Enabled = true;
            txtPer.Enabled = true;
            cmbSuppended.Enabled = true;
            txtE_ID.Enabled = false;

            txtUser.Text = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
            txtPass.Text = dgvAccount.SelectedRows[0].Cells[1].Value.ToString();
            txtE_ID.Text = dgvAccount.SelectedRows[0].Cells[2].Value.ToString();
            txtPer.Text = dgvAccount.SelectedRows[0].Cells[3].Value.ToString();
            cmbSuppended.Text = dgvAccount.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}