using DATN2023FINAL.Controller;
using System;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private sql_Customer c_customer = new sql_Customer();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = c_customer.LoadCustomer();
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = c_customer.LoadByKeyWord(txtFind.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailCustomerForm f = new DetailCustomerForm();
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            dgvCustomer.DataSource = c_customer.LoadCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count >= 1)
            {
                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    DetailCustomerForm f = new DetailCustomerForm(this);
                    f.btnAddOrEdit.Text = "Sửa";
                    f.txtMa.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                    f.txtTen.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                    f.txtAge.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                    f.cmbGender.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                    f.mtbPhone.Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
                    f.txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[5].Value.ToString();

                    f.ShowDialog();
                    dgvCustomer.DataSource = c_customer.LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn Khách hàng để sửa!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string cID = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            try
            {
                c_customer.delete(cID);
                MessageBox.Show("Đã xoá!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá", "Lỗi");
            }
            dgvCustomer.DataSource = c_customer.LoadCustomer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}