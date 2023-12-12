using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using System;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Employee c_employee = new sql_Employee();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = c_employee.LoadEmployee();
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
            txtMa.Enabled = false;
            LockControll();
        }
        public void LockControll()
        {
            txtFullname.Enabled = false;
            dtpBirthday.Enabled = false;
            txtAddress.Enabled = false;
            mtbPhone.Enabled = false;
            cmbGender.Enabled = false;
        }
        public void UnlockControll()
        {
            txtFullname.Enabled = true;
            dtpBirthday.Enabled = true;
            txtAddress.Enabled = true;
            mtbPhone.Enabled = true;
            cmbGender.Enabled = true;
        }
        public void ResetTextBox()
        {
            txtFullname.Text = "";
            cmbGender.Text = "";
            mtbPhone.Text = "";
            txtAddress.Text = "";
            dtpBirthday.Value = DateTime.Now;
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = c_employee.LoadByKeyWord(txtFind.Text);
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UnlockControll();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtMa.Text = c_employee.LoadID();
            ResetTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblEmployee employee = new tblEmployee();
            employee.E_ID = txtMa.Text;
            employee.Fullname = txtFullname.Text;
            employee.Birthday = DateTime.Parse(dtpBirthday.Text);
            employee.Gender = cmbGender.Text;
            employee.PhoneNumber = mtbPhone.Text;
            employee.Addres = txtAddress.Text;
          
            if (txtFullname.Text == ""|| dtpBirthday.Text == "" || cmbGender.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
            }
            else
            {
                try
                {
                    c_employee.insert(employee);
                    MessageBox.Show("Đã thêm!", "Thông báo");
                    btnCancel_Click(sender, e);
                    LockControll();
                }
                catch
                {
                    MessageBox.Show("Chưa thể thêm", "Lỗi");
                }
                dgvEmployee.DataSource = c_employee.LoadEmployee();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tblEmployee employee = new tblEmployee();
            employee.E_ID = txtMa.Text;
            employee.Fullname = txtFullname.Text;
            employee.Birthday = DateTime.Parse(dtpBirthday.Text);
            employee.Gender = cmbGender.Text;
            employee.PhoneNumber = mtbPhone.Text;
            employee.Addres = txtAddress.Text;

            if (txtFullname.Text == "" || dtpBirthday.Text == "" || cmbGender.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
            }
            else
            {
                try
                {
                    c_employee.edit(employee);
                    MessageBox.Show("Đã sửa!", "Thông báo");
                    btnCancel_Click(sender, e);
                    LockControll();
                }
                catch
                {
                    MessageBox.Show("Chưa thể sửa", "Lỗi");
                }
                
                dgvEmployee.DataSource = c_employee.LoadEmployee();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string eID = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            string userName = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            if (userName.Trim() == "admin")
            {
                MessageBox.Show("Không được quyền xoá tài khoản này!!", "Thông báo");
            }
            else
            {
                try
                {
                    c_employee.delete(eID);
                    MessageBox.Show("Đã xoá!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Chưa thể xoá", "Lỗi");
                }
            }                            
            dgvEmployee.DataSource = c_employee.LoadEmployee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            UnlockControll();
            txtMa.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            txtFullname.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
            dtpBirthday.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            cmbGender.Text = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
            mtbPhone.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress.Text = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtMa.Enabled = false;
            txtMa.Text = "";
            LockControll();
            ResetTextBox();
        }
    }
}