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
    public partial class MedicineForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Medicine c_Medicine = new sql_Medicine();
        public MedicineForm()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            //btnCancel.Enabled = false;
            txtMaNT.Enabled = false;
            txtMaThuoc.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtGiaBan.Enabled = false;
            txtDMT.Enabled = false;
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            dgvMedicine.DataSource = c_Medicine.LoadMedicine();
        }

        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNT.Text = dgvMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMaThuoc.Text = dgvMedicine.SelectedRows[0].Cells[1].Value.ToString();
            txtTenThuoc.Text = dgvMedicine.SelectedRows[0].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvMedicine.SelectedRows[0].Cells[12].Value.ToString();
            txtDMT.Text = dgvMedicine.SelectedRows[0].Cells[14].Value.ToString();
            txtGiaBan.Enabled = true;
            txtDMT.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvMedicine.DataSource = c_Medicine.LoadByKeyWord(txtFind.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Medicine med = new Medicine();
            //med.IDG = dgvMedicine.SelectedRows[0].Cells[0].Value.ToString();
            //med.ID = dgvMedicine.SelectedRows[0].Cells[1].Value.ToString();
            //med.Name = dgvMedicine.SelectedRows[0].Cells[2].Value.ToString();
            //med.SDK = dgvMedicine.SelectedRows[0].Cells[3].Value.ToString();
            //med.TPC = dgvMedicine.SelectedRows[0].Cells[4].Value.ToString();
            //med.HL = dgvMedicine.SelectedRows[0].Cells[5].Value.ToString();
            //med.Package = dgvMedicine.SelectedRows[0].Cells[6].Value.ToString();
            //med.NuocSX = dgvMedicine.SelectedRows[0].Cells[7].Value.ToString();
            //med.BasicUnit = dgvMedicine.SelectedRows[0].Cells[8].Value.ToString();
            //med.Batch = dgvMedicine.SelectedRows[0].Cells[9].Value.ToString();
            //med.Dat = Convert.ToDateTime(dgvMedicine.SelectedRows[0].Cells[10].Value.ToString());
            //med.Quantity = Convert.ToInt32(dgvMedicine.SelectedRows[0].Cells[11].Value.ToString());
            //txtGiaBan.Text = dgvMedicine.SelectedRows[0].Cells[12].Value.ToString();
            //txtDMT.Text = dgvMedicine.SelectedRows[0].Cells[14].Value.ToString();
            if (txtGiaBan.Text == "" || txtDMT.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
            }
            else
            {
                string mID = txtMaThuoc.Text;
                float price = float.Parse(txtGiaBan.Text);
                int dmt = int.Parse(txtDMT.Text);
                try
                {
                    c_Medicine.update(mID, price, dmt);
                    MessageBox.Show("Đã sửa!", "Thông báo");
                    btnCancel_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Chưa thể sửa", "Lỗi");
                }
                
                dgvMedicine.DataSource = c_Medicine.LoadMedicine();               
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                c_Medicine.delete(txtMaThuoc.Text);
                MessageBox.Show("Đã xoá!", "Thông báo");
                btnCancel_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá", "Lỗi");
            }
            
            dgvMedicine.DataSource = c_Medicine.LoadMedicine();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            //btnCancel.Enabled = false;
            txtMaNT.Enabled = false;
            txtMaThuoc.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtGiaBan.Enabled = false;
            txtDMT.Enabled = false;
            txtMaNT.Text = "";
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGiaBan.Text = "";
            txtDMT.Text = "";
            txtFind.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemMoiThuocForm f = new ThemMoiThuocForm();
            f.ShowDialog();
            dgvMedicine.DataSource = c_Medicine.LoadMedicine();
        }
    }
}