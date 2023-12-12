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
    public partial class DetailMedicineGroupForm : DevExpress.XtraEditors.XtraForm
    {
        MedicineGroupForm frmMG = new MedicineGroupForm();
        ThemMoiThuocForm frmThemThuoc = new ThemMoiThuocForm();
        sql_MedicineGroup cmg = new sql_MedicineGroup();
        public DetailMedicineGroupForm()
        {
            InitializeComponent();
            txtMa.Enabled = false;
            txtMa.Text = cmg.LoadID().ToString();
        }
        public DetailMedicineGroupForm(MedicineGroupForm f)
        {
            InitializeComponent();
            this.frmMG = f;
            txtMa.Enabled = false;
        }
        public DetailMedicineGroupForm(ThemMoiThuocForm f)
        {
            InitializeComponent();
            this.frmThemThuoc = f;
            txtMa.Enabled = false;
            txtMa.Text = cmg.LoadID().ToString();
        }

        private void DetailMedicineGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (btnAddOrEdit.Text == "Sửa")
            {
                tblMedicineGroup mg = new tblMedicineGroup();
                mg.MGID = Int32.Parse(txtMa.Text);
                mg.MGName = txtTen.Text;
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống tên nhóm thuốc", "Thông Báo");
                }
                else
                {
                    try
                    {
                        cmg.edit(mg);
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
                tblMedicineGroup mg = new tblMedicineGroup();
                mg.MGName = txtTen.Text;
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống tên nhóm thuốc", "Thông Báo");
                }
                else
                {
                    try
                    {
                        cmg.insert(mg);
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