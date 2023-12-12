using DATN2023FINAL.Controller;
using System;
using System.Windows.Forms;

namespace DATN2023FINAL.Views
{
    public partial class MedicineGroupForm : DevExpress.XtraEditors.XtraForm
    {
        private sql_MedicineGroup cmg = new sql_MedicineGroup();
        public MedicineGroupForm()
        {
            InitializeComponent();
        }

        private void MedicineGroupForm_Load(object sender, EventArgs e)
        {
            dgvMedicineGroup.DataSource = cmg.LoadMedicineGroup();
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvMedicineGroup.DataSource = cmg.LoadByKeyWord(txtFind.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailMedicineGroupForm f = new DetailMedicineGroupForm();
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            dgvMedicineGroup.DataSource = cmg.LoadMedicineGroup();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicineGroup.Rows.Count >= 1)
            {
                if (dgvMedicineGroup.SelectedRows.Count > 0)
                {
                    DetailMedicineGroupForm f = new DetailMedicineGroupForm(this);
                    f.btnAddOrEdit.Text = "Sửa";
                    f.txtMa.Text = dgvMedicineGroup.SelectedRows[0].Cells[0].Value.ToString();
                    f.txtTen.Text = dgvMedicineGroup.SelectedRows[0].Cells[1].Value.ToString();

                    f.ShowDialog();
                    dgvMedicineGroup.DataSource = cmg.LoadMedicineGroup();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn Nhóm thuốc để sửa!");
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