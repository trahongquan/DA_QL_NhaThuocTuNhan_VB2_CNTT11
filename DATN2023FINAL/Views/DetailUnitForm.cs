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
    public partial class DetailUnitForm : DevExpress.XtraEditors.XtraForm
    {
        UnitForm frmU = new UnitForm();
        ThemMoiThuocForm frmThemThuoc = new ThemMoiThuocForm();
        sql_Donvitinh c_Unit = new sql_Donvitinh();
        public DetailUnitForm()
        {
            InitializeComponent();
            txtMa.Enabled = false;
            txtMa.Text = c_Unit.LoadID().ToString();
        }
        public DetailUnitForm(UnitForm f)
        {
            InitializeComponent();
            this.frmU = f;
            txtMa.Enabled = false;
        }
        public DetailUnitForm(ThemMoiThuocForm f)
        {
            InitializeComponent();
            this.frmThemThuoc = f;
            txtMa.Enabled = false;
            txtMa.Text = c_Unit.LoadID().ToString();
        }
        private void DetailUnitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (btnAddOrEdit.Text == "Sửa")
            {
                tblDonvitinh dvt = new tblDonvitinh();
                dvt.ID = Int32.Parse(txtMa.Text);
                dvt.Name = txtTen.Text;
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        c_Unit.edit(dvt);
                        this.Close();
                        MessageBox.Show("Đã sửa!", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Chưa thể sửa", "Lỗi");
                    }                    
                }
            }
            else if (btnAddOrEdit.Text == "Thêm")
            {
                tblDonvitinh dvt = new tblDonvitinh();
                dvt.Name = txtTen.Text;
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin", "Thông Báo");
                }
                else
                {
                    try
                    {
                        c_Unit.insert(dvt);
                        this.Close();
                        MessageBox.Show("Đã thêm!", "Thông Báo");
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