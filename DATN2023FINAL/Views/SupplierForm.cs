using DATN2023FINAL.Controller;
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
    public partial class SupplierForm : DevExpress.XtraEditors.XtraForm
    {
        private sql_Supplier cSupplier = new sql_Supplier();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = cSupplier.LoadSupplier();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = cSupplier.LoadByKeyWord(txtFind.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailSupplierForm f = new DetailSupplierForm();
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            dgvSupplier.DataSource = cSupplier.LoadSupplier();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.Rows.Count >= 1)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    DetailSupplierForm f = new DetailSupplierForm(this);
                    f.btnAddOrEdit.Text = "Sửa";
                    f.txtMa.Text = dgvSupplier.SelectedRows[0].Cells[0].Value.ToString();
                    f.txtTen.Text = dgvSupplier.SelectedRows[0].Cells[1].Value.ToString();                  
                    f.mtbPhone.Text = dgvSupplier.SelectedRows[0].Cells[2].Value.ToString();
                    f.txtAddress.Text = dgvSupplier.SelectedRows[0].Cells[3].Value.ToString();

                    f.ShowDialog();
                    dgvSupplier.DataSource = cSupplier.LoadSupplier();
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
            string cID = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            try
            {
                cSupplier.delete(cID);
                MessageBox.Show("Đã xoá!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá", "Lỗi");
            }
            
            dgvSupplier.DataSource = cSupplier.LoadSupplier();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}