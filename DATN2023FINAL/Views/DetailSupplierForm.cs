using System;
using DATN2023FINAL.Controller;
using System.Windows.Forms;
using DATN2023FINAL.Models;

namespace DATN2023FINAL.Views
{
    public partial class DetailSupplierForm : DevExpress.XtraEditors.XtraForm
    {
        SupplierForm frmS = new SupplierForm();
        HoaDonNhapForm frmHDN = new HoaDonNhapForm();
        sql_Supplier cSupplier = new sql_Supplier();
        public DetailSupplierForm()
        {
            InitializeComponent();
            txtMa.Enabled = false;
            txtMa.Text = cSupplier.LoadID();
        }
        public DetailSupplierForm(SupplierForm f)
        {
            InitializeComponent();
            this.frmS = f;
            txtMa.Enabled = false;
        }
        public DetailSupplierForm(HoaDonNhapForm f)
        {
            InitializeComponent();
            this.frmHDN = f;
            txtMa.Enabled = false;
            txtMa.Text = cSupplier.LoadID();
        }
        private void DetailSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (btnAddOrEdit.Text == "Sửa")
            {
                tblSupplier supplier = new tblSupplier();
                supplier.SupplierId = txtMa.Text;
                supplier.SupplierName = txtTen.Text;
                supplier.SupplierPhone = mtbPhone.Text;
                supplier.SupplierAddress = txtAddress.Text;
                if (txtTen.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        cSupplier.edit(supplier);
                        this.Close();
                        MessageBox.Show("Đã sửa!", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Chưa thể sửa", "Lỗi");
                    }                 
                }
            }
            else if (btnAddOrEdit.Text == "Thêm")
            {
                tblSupplier supplier = new tblSupplier();
                supplier.SupplierId = txtMa.Text;
                supplier.SupplierName = txtTen.Text;
                supplier.SupplierPhone = mtbPhone.Text;
                supplier.SupplierAddress = txtAddress.Text;
                if (txtTen.Text == "" || mtbPhone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        cSupplier.insert(supplier);
                        this.Close();
                        MessageBox.Show("Đã thêm!", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Chưa thể thêm", "Lỗi");
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