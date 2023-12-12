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
    public partial class DetailCustomerForm : DevExpress.XtraEditors.XtraForm
    {
        CustomerForm frmC = new CustomerForm();
        HoaDonBanForm frmHDB = new HoaDonBanForm();
        sql_Customer ccustomer = new sql_Customer();
        public DetailCustomerForm()
        {
            InitializeComponent();
            txtMa.Enabled = false;
            txtMa.Text = ccustomer.LoadID();
        }
        public DetailCustomerForm(CustomerForm f)
        {
            InitializeComponent();
            this.frmC = f;
            txtMa.Enabled = false;
        }
        public DetailCustomerForm(HoaDonBanForm f)
        {
            InitializeComponent();
            this.frmHDB = f;
            txtMa.Enabled = false;
            txtMa.Text = ccustomer.LoadID();
        }
        private void DetailCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (btnAddOrEdit.Text == "Sửa")
            {
                tblCustomer customer = new tblCustomer();
                customer.C_id = txtMa.Text;
                customer.C_name = txtTen.Text;
                customer.C_age = int.Parse(txtAge.Text);
                customer.C_gender = cmbGender.Text;
                customer.C_phone = mtbPhone.Text;
                customer.C_address = txtAddress.Text;
                if (txtTen.Text == "" || txtAge.Text == "" || cmbGender.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        ccustomer.edit(customer);
                        this.Close();
                        MessageBox.Show("Đã sửa", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Chưa thể sửa", "Lỗi");
                    }
                }
            }
            else if (btnAddOrEdit.Text == "Thêm")
            {
                tblCustomer customer = new tblCustomer();
                customer.C_id = txtMa.Text;
                customer.C_name = txtTen.Text;
                customer.C_age = int.Parse(txtAge.Text);
                customer.C_gender = cmbGender.Text;
                customer.C_phone = mtbPhone.Text;
                customer.C_address = txtAddress.Text;
                if (txtTen.Text == "" || txtAge.Text == "" || cmbGender.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        ccustomer.insert(customer);
                        this.Close();
                        MessageBox.Show("Đã thêm", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Chưa thể xoá", "Lỗi");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}