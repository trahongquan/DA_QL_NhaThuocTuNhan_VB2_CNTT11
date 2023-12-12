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
    public partial class UnitForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Donvitinh c_Unit = new sql_Donvitinh();
        public UnitForm()
        {
            InitializeComponent();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            dgvUnit.DataSource = c_Unit.LoadDonvitinh();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvUnit.DataSource = c_Unit.LoadByKeyWord(txtFind.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailUnitForm f = new DetailUnitForm();
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            dgvUnit.DataSource = c_Unit.LoadDonvitinh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUnit.Rows.Count >= 1)
            {
                if (dgvUnit.SelectedRows.Count > 0)
                {
                    DetailUnitForm f = new DetailUnitForm(this);
                    f.btnAddOrEdit.Text = "Sửa";
                    f.txtMa.Text = dgvUnit.SelectedRows[0].Cells[0].Value.ToString();
                    f.txtTen.Text = dgvUnit.SelectedRows[0].Cells[1].Value.ToString();

                    f.ShowDialog();
                    dgvUnit.DataSource = c_Unit.LoadDonvitinh();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn ĐVT để sửa!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}