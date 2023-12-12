using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Windows.Forms;
using DATN2023FINAL.Report;
using DevExpress.XtraReports.UI;

namespace DATN2023FINAL.Views
{
    public partial class HoaDonBanForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Sale sale = new sql_Sale();
        sql_ChitietSale sqlctsale = new sql_ChitietSale();
        sql_Employee cemp = new sql_Employee();
        sql_Customer sqlCust = new sql_Customer();
        tblSale hdb = new tblSale();
        tblChitietSale ctsale = new tblChitietSale();
        sql_Medicine cmed = new sql_Medicine();
        float tongtien = 0;

        public HoaDonBanForm()
        {
            InitializeComponent();
        }

        private void HoaDonBanForm_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu
            dgvHDBH.DataSource = sale.LoadHDB();
            //fill combobox mã thuốc
            cmbM_ID.DataSource = sqlctsale.LayTTThuoc("");
            cmbM_ID.ValueMember = "M_ID";
            cmbM_ID.DisplayMember = "M_Name";
            //fill combobox Khách hàng
            cmbC_ID.DataSource = sqlctsale.LayTTCustomer("");
            cmbC_ID.ValueMember = "C_ID";
            cmbC_ID.DisplayMember = "C_Name";
            dgvDetailBan.Visible = false;
            LockControll();
        }
        public void ResetControll()
        {
            dtpNgayBan.Enabled = true;
            cmbC_ID.Enabled = true;
            cmbM_ID.Enabled = true;
            txtSLBan.Enabled = true;
            btnAdd_C.Enabled = true;
            btnSave.Enabled = true;
            btnPrint.Enabled = true;
            btnCancel.Enabled = true;
            dgvDSThuocBan.Enabled = true;
            btnAddToBill.Enabled = true;
            txtMaHDB.Text = sale.LoadID();
            txtE_ID.Text = DangNhapForm.IDEmp;
            txtE_Name.Text = cemp.getNameByID(txtE_ID.Text);
            cmbC_ID.Text = String.Empty;
            ResetDataGridview();
            txtC_Address.Text = String.Empty;
            txtC_Name.Text = String.Empty;
            txtTuoi.Text = String.Empty;
            txtGioitinh.Text = String.Empty;
            mtbC_Phone.Text = String.Empty;
            txtTotal.Text = String.Empty;
            dtpNgayBan.Value = DateTime.Now;
            lbMoneyChar.Text = "Bằng chữ: ";
        }
        public void LockControll()
        {
            dtpNgayBan.Enabled = false;
            cmbC_ID.Enabled = false;
            cmbM_ID.Enabled = false;
            txtSLBan.Enabled = false;
            btnAdd_C.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = false;
            btnAddToBill.Enabled = false;
            dgvDSThuocBan.Enabled = false;
            ResetDataGridview();
            txtC_Address.Text = String.Empty;
            txtC_Name.Text = String.Empty;
            txtTuoi.Text = String.Empty;
            txtGioitinh.Text = String.Empty;
            mtbC_Phone.Text = String.Empty;
            txtTotal.Text = String.Empty;
            dtpNgayBan.Value = DateTime.Now;
            lbMoneyChar.Text = "Bằng chữ: ";
            txtMaHDB.Text = String.Empty;
            txtE_ID.Text = String.Empty;
            txtE_Name.Text = String.Empty;
            cmbC_ID.SelectedIndex = -1;
            cmbM_ID.SelectedIndex = -1;
        }
        public void ResetDataGridview()
        {
            dgvDetailBan.Visible = false;
            if (dgvDSThuocBan.Visible == false)
            {
                dgvDSThuocBan.Visible = true;
                dgvDSThuocBan.Rows.Clear();
            }
            else
            {
                dgvDSThuocBan.Rows.Clear();
            }
        }
        #region Số sang Chữ
        //123 => một trăm hai ba đồng
        //1,123,000=>một triệu một trăm hai ba nghìn đồng
        //1,123,345,000 => một tỉ một trăm hai ba triệu ba trăm bốn lăm ngàn đồng
        static string[] mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private static string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so % 10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi == 1)
                {
                    chuoi += " mốt";
                }
            }
            else if (chuc == 1)
            {//Số hàng chục từ 10-19
                chuoi = " mười";
                if (donvi == 1)
                {
                    chuoi += " một";
                }
            }
            else if (daydu && donvi > 0)
            {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                chuoi = " lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private static string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so / 100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private static string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so / 1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin 
            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public static string ChuyenSoSangChuoi(float so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((float)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }
        #endregion
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvHDBH.DataSource = sale.LoadByKeyWord(txtFind.Text);
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            dgvHDBH.DataSource = sale.LoadHDBByDay(DateTime.Parse(dtpStartDay.Text), DateTime.Parse(dtpEndDay.Text));
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvHDBH.DataSource = sale.LoadHDB();
            LockControll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                sqlctsale.delete(dgvHDBH.CurrentRow.Cells[0].Value.ToString());
                sale.delete(dgvHDBH.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xoá!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá!", "Lỗi");
            }
            dgvHDBH.DataSource = sale.LoadHDB();
            LockControll();
        }

        private void btnAdd_C_Click(object sender, EventArgs e)
        {
            DetailCustomerForm f = new DetailCustomerForm(this);
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            //fill combobox Khách hàng
            cmbC_ID.DataSource = sqlctsale.LayTTCustomer("");
            cmbC_ID.ValueMember = "C_ID";
            cmbC_ID.DisplayMember = "C_Name";
            cmbC_ID.SelectedIndex = -1;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ResetControll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stock1, stock2, sumstock;
            if (cmbC_ID.Text == "")
                MessageBox.Show("Không được bỏ trống thông tin Khách hàng!", "Thông báo");
            else if (dgvDSThuocBan.Rows.Count == 1)
            {
                MessageBox.Show("Danh sách thuốc bán đang trống!", "Thông báo");
            }
            else
            {
                for (int i = 0; i < dgvDSThuocBan.Rows.Count - 1; i++)
                {
                    tongtien += float.Parse(dgvDSThuocBan.Rows[i].Cells[5].Value.ToString());
                }
                txtTotal.Text = tongtien.ToString();
                hdb.Sale_ID = txtMaHDB.Text;
                hdb.Sale_Time = DateTime.Parse(dtpNgayBan.Text);
                hdb.E_ID = txtE_ID.Text;
                hdb.C_ID = cmbC_ID.SelectedValue.ToString();
                hdb.Sale_Total = float.Parse(txtTotal.Text);
                try
                {
                    sale.insert(hdb);
                    tongtien = 0;
                }
                catch { }
                try
                {
                    for (int i = 0; i < dgvDSThuocBan.Rows.Count - 1; i++)
                    {
                        ctsale.Dsale_ID = txtMaHDB.Text;
                        ctsale.M_ID = dgvDSThuocBan.Rows[i].Cells[0].Value.ToString();
                        ctsale.M_Name = dgvDSThuocBan.Rows[i].Cells[1].Value.ToString();
                        ctsale.M_SaleUnit = dgvDSThuocBan.Rows[i].Cells[2].Value.ToString();
                        ctsale.M_SaleQuantity = Convert.ToInt32(dgvDSThuocBan.Rows[i].Cells[3].Value.ToString());             
                        ctsale.M_SalePrice = float.Parse(dgvDSThuocBan.Rows[i].Cells[4].Value.ToString());
                        ctsale.Total = float.Parse(dgvDSThuocBan.Rows[i].Cells[5].Value.ToString());
                        stock1 = Convert.ToInt32(dgvDSThuocBan.Rows[i].Cells[3].Value.ToString());
                        stock2 = cmed.GetSLTon(dgvDSThuocBan.Rows[i].Cells[0].Value.ToString());
                        sumstock = stock2 - stock1;
                        cmed.UpdateSLTon(dgvDSThuocBan.Rows[i].Cells[0].Value.ToString(), sumstock);
                        sqlctsale.insert(ctsale);
                    }
                    MessageBox.Show("Lưu hoá đơn thành công!", "Thông báo");

                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    cmbC_ID.Enabled = false;
                    lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
                    dgvHDBH.DataSource = sale.LoadHDB();
                    LockControll();
                }
                catch
                {
                    MessageBox.Show("Hoá đơn chưa được lưu!", "Lỗi");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockControll();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable ds2 = sqlctsale.TTCTHDB(txtMaHDB.Text);
            rptHoaDonBan rp = new rptHoaDonBan(this);
            rp.DataSource = ds2;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvHDBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMoneyChar.Text = "Bằng chữ: ";
            btnPrint.Enabled = true;
            txtMaHDB.Text = dgvHDBH.SelectedRows[0].Cells[0].Value.ToString();
            dtpNgayBan.Text = dgvHDBH.SelectedRows[0].Cells[1].Value.ToString();
            txtE_ID.Text = dgvHDBH.SelectedRows[0].Cells[2].Value.ToString();
            cmbC_ID.Text = dgvHDBH.SelectedRows[0].Cells[3].Value.ToString();
            txtTotal.Text = dgvHDBH.SelectedRows[0].Cells[4].Value.ToString();

            txtE_Name.Text = cemp.getNameByID(txtE_ID.Text);
            txtC_Name.Text = sqlCust.getNameByID(cmbC_ID.Text);
            txtTuoi.Text = sqlCust.getAgeByID(cmbC_ID.Text).ToString();
            txtGioitinh.Text = sqlCust.getGenderByID(cmbC_ID.Text);
            txtC_Address.Text = sqlCust.getAddressByID(cmbC_ID.Text);
            mtbC_Phone.Text = sqlCust.getPhoneByID(cmbC_ID.Text);
            dgvDetailBan.DataSource = sqlctsale.LoadCTHDB(dgvHDBH.SelectedRows[0].Cells[0].Value.ToString());
            dgvDetailBan.Visible = true;
            dgvDetailBan.Enabled = false;
            dgvDSThuocBan.Visible = false;
            lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            cmbC_ID.Enabled = false;
        }

        private void dgvDSThuocBan_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvDSThuocBan.CurrentCell.RowIndex;
            if (dgvDSThuocBan.Rows.Count == 1)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (index >= dgvDSThuocBan.Rows.Count - 1)
                    MessageBox.Show("Hàng trống, Không thể xoá!", "Thông báo");
                else
                    dgvDSThuocBan.Rows.RemoveAt(index);
            }
        }

        private void cmbC_ID_TextChanged(object sender, EventArgs e)
        {
            if (cmbC_ID.SelectedIndex == -1)
            {
                txtC_Name.Text = String.Empty;
                txtC_Address.Text = String.Empty;
                mtbC_Phone.Text = String.Empty;
                txtTuoi.Text = String.Empty;
                txtGioitinh.Text = String.Empty;
            }
            else
            {
                txtC_Name.Text = sqlCust.getNameByID(cmbC_ID.SelectedValue.ToString());
                txtC_Address.Text = sqlCust.getAddressByID(cmbC_ID.SelectedValue.ToString());
                mtbC_Phone.Text = sqlCust.getPhoneByID(cmbC_ID.SelectedValue.ToString());
                txtTuoi.Text = sqlCust.getAgeByID(cmbC_ID.SelectedValue.ToString()).ToString();
                txtGioitinh.Text = sqlCust.getGenderByID(cmbC_ID.SelectedValue.ToString());
            }
        }

        private void cmbM_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbM_ID.SelectedIndex == -1)
            {
                txtM_Name.Text = String.Empty;
                txtM_Dat.Text = String.Empty;
                txtM_DVB.Text = String.Empty;
                txtSLTon.Text = String.Empty;
                txtSLBan.Text = String.Empty;
                txtGiaBan.Text = String.Empty;
                txtThanhTien.Text = String.Empty;
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = sqlctsale.LayTTThuoc(" WHERE M_ID='" + cmbM_ID.SelectedValue.ToString() + "'");
                    txtM_Name.Text = dt.Rows[0]["M_Name"].ToString();
                    txtM_Dat.Text = dt.Rows[0]["M_Dat"].ToString();
                    txtM_DVB.Text = dt.Rows[0]["M_BasicUnit"].ToString();
                    txtSLTon.Text = dt.Rows[0]["M_Quantity"].ToString();
                    txtGiaBan.Text = dt.Rows[0]["M_Price"].ToString();
                }
                catch { }

            }
        }
        private void txtSLBan_TextChanged(object sender, EventArgs e)
        {
            float sl, gb, tt;
            if (txtSLBan.Text == "")
                sl = 0;
            else
                sl = float.Parse(txtSLBan.Text);
            if (txtGiaBan.Text == "")
                gb = 0;
            else
                gb = float.Parse(txtGiaBan.Text);
            tt = sl * gb;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (cmbM_ID.Text == "")
            {
                MessageBox.Show("Hãy chọn thuốc cần bán!", "Thông báo");
                cmbM_ID.Focus();
            }
            else if (txtSLBan.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng bán!", "Thông báo");
                txtSLBan.Focus();
            }
            else if (int.Parse(txtSLBan.Text) <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0!", "Thông báo");
                txtSLBan.Focus();
            }
            else if (int.Parse(txtSLBan.Text) > int.Parse(txtSLTon.Text))
            {
                MessageBox.Show("Số lượng thuốc này tại nhà thuốc hiện không đủ số lượng bán!\nNhập lại số lượng bán!", "Thông báo");
                txtSLBan.Focus();
            }
            else
            {
                int count = 0;
                for(int i = 0; i < dgvDSThuocBan.Rows.Count - 1; i++)
                {
                    if(cmbM_ID.SelectedValue.ToString() == dgvDSThuocBan.Rows[i].Cells[0].Value.ToString())
                    {
                        count = count + 1;
                    }
                }
                if(count == 0)
                {
                    DataGridViewRow newRow = (DataGridViewRow)dgvDSThuocBan.Rows[0].Clone();
                    newRow.Cells[0].Value = cmbM_ID.SelectedValue.ToString();
                    newRow.Cells[1].Value = txtM_Name.Text;
                    newRow.Cells[2].Value = txtM_DVB.Text;
                    newRow.Cells[3].Value = txtSLBan.Text;
                    newRow.Cells[4].Value = txtGiaBan.Text;
                    newRow.Cells[5].Value = txtThanhTien.Text;
                    dgvDSThuocBan.Rows.Add(newRow);
                    ResetValueThuoc();
                    cmbM_ID.Focus();
                }
                else
                {
                    MessageBox.Show("Thuốc này đã có trong hoá đơn!\nVui lòng chọn lại thuốc!", "Thông báo");
                    ResetValueThuoc();
                    cmbM_ID.Focus();
                }
                
            }
        }

        private void ResetValueThuoc()
        {
            cmbM_ID.Text = "";
            txtM_Name.Text = "";
            txtM_Dat.Text = "";
            txtM_DVB.Text = "";
            txtSLTon.Text = "";
            txtSLBan.Text = "";
            txtGiaBan.Text = "";
            txtThanhTien.Text = "";
        }
    }
}