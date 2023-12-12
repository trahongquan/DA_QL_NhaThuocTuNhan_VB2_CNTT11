using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Windows.Forms;
using DATN2023FINAL.Report;
using DevExpress.XtraReports.UI;

namespace DATN2023FINAL.Views
{
    public partial class HoaDonNhapForm : DevExpress.XtraEditors.XtraForm
    {
        sql_Supplier cs = new sql_Supplier();
        sql_Chitietnhap ccthdn = new sql_Chitietnhap();
        sql_Nhap chdn = new sql_Nhap();
        sql_Employee cemp = new sql_Employee();
        sql_Medicine cmed = new sql_Medicine();
        tblHoadonnhap hdn = new tblHoadonnhap();
        tblChitietnhap cthdn = new tblChitietnhap();
        float tongtien = 0;
        public HoaDonNhapForm()
        {
            InitializeComponent();           
        }

        private void HoaDonNhapForm_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu
            dgvPhieuNhap.DataSource = chdn.LoadHDN();
            //dgvDSThuocNhap.DataSource = null;
            //fill combobox mã thuốc
            cmbM_ID.DataSource = ccthdn.LayTTThuoc("");
            cmbM_ID.ValueMember = "M_ID";
            cmbM_ID.DisplayMember = "M_Name";
            //fill combobox nhà cung cấp
            cmbS_ID.DataSource = ccthdn.LayTTSupplier("");
            cmbS_ID.ValueMember = "S_ID";
            cmbS_ID.DisplayMember = "S_Name";
            dgvDetailNhap.Visible = false;
            LockControll();
        }
     
        public void ResetControll()
        {
            dtpNgayNhap.Enabled = true;
            cmbS_ID.Enabled = true;
            cmbM_ID.Enabled = true;
            txtSLNhap.Enabled = true;
            txtNote.Enabled = true;
            btnAdd_S.Enabled = true;
            btnThemThuocMoi.Enabled = true;
            btnSave.Enabled = true;
            btnPrint.Enabled = true;
            btnCancel.Enabled = true;
            dgvDSThuocNhap.Enabled = true;
            btnAddToBill.Enabled = true;
            txtMaPhieu.Text = chdn.LoadID();
            txtE_ID.Text = DangNhapForm.IDEmp;
            txtE_Name.Text = cemp.getNameByID(txtE_ID.Text);
            cmbS_ID.Text = String.Empty;
            ResetDataGridview();
            txtS_Address.Text = String.Empty;
            txtS_Name.Text = String.Empty;
            txtNote.Text = String.Empty;
            mtbS_Phone.Text = String.Empty;
            txtTotal.Text = String.Empty;
            dtpNgayNhap.Value = DateTime.Now;
            lbMoneyChar.Text = "Bằng chữ: ";
        }
        public void LockControll()
        {
            dtpNgayNhap.Enabled = false;
            cmbS_ID.Enabled = false;
            cmbM_ID.Enabled = false;
            txtSLNhap.Enabled = false;
            txtNote.Enabled = false;
            btnAdd_S.Enabled = false;
            btnThemThuocMoi.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = false;
            txtNote.Enabled = false;
            dgvDSThuocNhap.Enabled = false;
            btnAddToBill.Enabled = false;
            ResetDataGridview();
            txtS_Address.Text = String.Empty;
            txtS_Name.Text = String.Empty;
            txtNote.Text = String.Empty;
            mtbS_Phone.Text = String.Empty;
            txtTotal.Text = String.Empty;
            dtpNgayNhap.Value = DateTime.Now;
            lbMoneyChar.Text = "Bằng chữ: ";
            txtMaPhieu.Text = String.Empty;
            txtE_ID.Text = String.Empty;
            txtE_Name.Text = String.Empty;
            cmbS_ID.SelectedIndex = -1;
            cmbM_ID.SelectedIndex = -1;
        }
        public void ResetDataGridview()
        {
            dgvDetailNhap.Visible = false;
            if(dgvDSThuocNhap.Visible == false)
            {
                dgvDSThuocNhap.Visible = true;
                dgvDSThuocNhap.Rows.Clear();
            }
            else
            {
                dgvDSThuocNhap.Rows.Clear();
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = chdn.LoadByKeyWord(txtFind.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = chdn.LoadHDN();
            //ResetControll();
            LockControll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                ccthdn.delete(dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
                chdn.delete(dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xoá!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá!", "Lỗi");
            }
            dgvPhieuNhap.DataSource = chdn.LoadHDN();
            LockControll();
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = chdn.LoadHDNByDay(DateTime.Parse(dtpStartDay.Text), DateTime.Parse(dtpEndDay.Text));
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMoneyChar.Text = "Bằng chữ: ";
            btnPrint.Enabled = true;
            txtMaPhieu.Text = dgvPhieuNhap.SelectedRows[0].Cells[0].Value.ToString();
            dtpNgayNhap.Text = dgvPhieuNhap.SelectedRows[0].Cells[1].Value.ToString();
            txtE_ID.Text = dgvPhieuNhap.SelectedRows[0].Cells[2].Value.ToString();
            txtTotal.Text = dgvPhieuNhap.SelectedRows[0].Cells[3].Value.ToString();
            
            txtE_Name.Text = cemp.getNameByID(txtE_ID.Text);
            cmbS_ID.Text = chdn.getIDSup(txtMaPhieu.Text);
            txtS_Name.Text = cs.getNameByID(cmbS_ID.Text);
            txtS_Address.Text = cs.getAddressByID(cmbS_ID.Text);
            mtbS_Phone.Text = cs.getPhoneByID(cmbS_ID.Text);
            txtNote.Text = chdn.getNoteByID(txtMaPhieu.Text);
            dgvDetailNhap.DataSource = ccthdn.LoadCTHDN(dgvPhieuNhap.SelectedRows[0].Cells[0].Value.ToString());
            dgvDetailNhap.Visible = true;
            dgvDetailNhap.Enabled = false;
            dgvDSThuocNhap.Visible = false;
            lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            cmbS_ID.Enabled = false;
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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ResetControll();
        }
        private void btnAdd_S_Click(object sender, EventArgs e)
        {
            DetailSupplierForm f = new DetailSupplierForm(this);
            f.btnAddOrEdit.Text = "Thêm";
            f.ShowDialog();
            //fill combobox nhà cung cấp
            cmbS_ID.DataSource = ccthdn.LayTTSupplier("");
            cmbS_ID.ValueMember = "S_ID";
            cmbS_ID.DisplayMember = "S_Name";
            cmbS_ID.SelectedIndex = -1;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            int stock1, stock2, sumstock;
            //if (cmbS_ID.Text == ""|| txtS_Name.Text == ""|| txtS_Address.Text == "" || mtbS_Phone.Text == "")
            if (cmbS_ID.Text == "")
                MessageBox.Show("Không được bỏ trống thông tin nhà cung cấp!", "Thông báo");
            else if(dgvDSThuocNhap.Rows.Count == 1)
            {
                MessageBox.Show("Danh sách thuốc nhập đang trống!", "Thông báo");
            }
            else
            {
                for (int i = 0; i < dgvDSThuocNhap.Rows.Count - 1; i++)
                {
                    tongtien += float.Parse(dgvDSThuocNhap.Rows[i].Cells[7].Value.ToString());
                }
                txtTotal.Text = tongtien.ToString();
                hdn.IdHD = txtMaPhieu.Text;
                hdn.NgayNhap = DateTime.Parse(dtpNgayNhap.Text);
                hdn.IdNV = txtE_ID.Text;
                hdn.IdNCC = cmbS_ID.SelectedValue.ToString();
                hdn.Note = txtNote.Text;
                //hdn.Total = float.Parse(txtTotal.Text);
                hdn.Total = tongtien;
                try
                {
                    chdn.insert(hdn);
                    tongtien = 0;
                }
                catch  { }
                try
                {
                    for (int i = 0; i < dgvDSThuocNhap.Rows.Count - 1; i++)
                    {
                        cthdn.IdHD = txtMaPhieu.Text;
                        cthdn.IdM = dgvDSThuocNhap.Rows[i].Cells[0].Value.ToString();
                        cthdn.MName = dgvDSThuocNhap.Rows[i].Cells[1].Value.ToString();
                        
                        cthdn.MDat = Convert.ToDateTime(dgvDSThuocNhap.Rows[i].Cells[2].Value.ToString());
                        cthdn.MImUnit = dgvDSThuocNhap.Rows[i].Cells[3].Value.ToString();
                        cthdn.MGTQD = Convert.ToInt32(dgvDSThuocNhap.Rows[i].Cells[4].Value.ToString());
                        cthdn.MQuantity = Convert.ToInt32(dgvDSThuocNhap.Rows[i].Cells[5].Value.ToString());
                    
                        cthdn.MImPrice = float.Parse(dgvDSThuocNhap.Rows[i].Cells[6].Value.ToString());
                        cthdn.Total = float.Parse(dgvDSThuocNhap.Rows[i].Cells[7].Value.ToString());
                        stock1 = Convert.ToInt32(dgvDSThuocNhap.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(dgvDSThuocNhap.Rows[i].Cells[5].Value.ToString());
                        stock2 = cmed.GetSLTon(dgvDSThuocNhap.Rows[i].Cells[0].Value.ToString());
                        sumstock = stock1 + stock2;
                        cmed.UpdateSLTon(dgvDSThuocNhap.Rows[i].Cells[0].Value.ToString(), sumstock);
                        ccthdn.insert(cthdn);
                    }
                    MessageBox.Show("Lưu hoá đơn thành công!", "Thông báo");

                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    cmbS_ID.Enabled = false;
                    lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
                    dgvPhieuNhap.DataSource = chdn.LoadHDN();
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
            DataTable ds2 = ccthdn.TTCTHDN(txtMaPhieu.Text);
            rptHoaDonNhap rp = new rptHoaDonNhap(this);
            rp.DataSource = ds2;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbS_ID_TextChanged(object sender, EventArgs e)
        {
            if(cmbS_ID.SelectedIndex == -1)
            {
                txtS_Name.Text = null;
                txtS_Address.Text = null;
                mtbS_Phone.Text = null;
            }
            else
            {
                txtS_Name.Text = cs.getNameByID(cmbS_ID.SelectedValue.ToString());
                txtS_Address.Text = cs.getAddressByID(cmbS_ID.SelectedValue.ToString());
                mtbS_Phone.Text = cs.getPhoneByID(cmbS_ID.SelectedValue.ToString());
            }           
        }

        private void dgvDSThuocNhap_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvDSThuocNhap.CurrentCell.RowIndex;
            if (dgvDSThuocNhap.Rows.Count == 1)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (index >= dgvDSThuocNhap.Rows.Count-1)
                    MessageBox.Show("Hàng trống, Không thể xoá!", "Thông báo");
                else
                    dgvDSThuocNhap.Rows.RemoveAt(index);
            }
        }

        private void btnThemThuocMoi_Click(object sender, EventArgs e)
        {
            ThemMoiThuocForm f = new ThemMoiThuocForm();
            f.ShowDialog();
            //fill combobox mã thuốc
            cmbM_ID.DataSource = ccthdn.LayTTThuoc("");
            cmbM_ID.ValueMember = "M_ID";
            cmbM_ID.DisplayMember = "M_Name";
            cmbM_ID.SelectedIndex = -1;
        }

        private void cmbM_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbM_ID.SelectedIndex == -1)
            {
                txtM_Name.Text = String.Empty;
                txtM_Dat.Text = String.Empty;
                txtM_DVN.Text = String.Empty;
                txtQuydoi.Text = String.Empty;
                txtSLNhap.Text = String.Empty;
                txtGiaNhap.Text = String.Empty;
                txtThanhTien.Text = String.Empty;
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = ccthdn.LayTTThuoc(" WHERE M_ID='" + cmbM_ID.SelectedValue.ToString() + "'");
                    txtM_Name.Text = dt.Rows[0]["M_Name"].ToString();
                    txtM_Dat.Text = dt.Rows[0]["M_Dat"].ToString();
                    txtM_DVN.Text = dt.Rows[0]["M_ImUnit"].ToString();
                    txtQuydoi.Text = dt.Rows[0]["M_GTQD"].ToString();           
                    txtGiaNhap.Text = dt.Rows[0]["M_ImPrice"].ToString();                   
                }
                catch { }
                
            }
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            float sl, qd, gn, tt;
            if(txtQuydoi.Text == "")
                qd = 0;
            else
                qd = float.Parse(txtQuydoi.Text);
            if (txtSLNhap.Text == "")
                sl = 0;
            else
                sl = float.Parse(txtSLNhap.Text);
            if (txtGiaNhap.Text == "")
                gn = 0;
            else
                gn = float.Parse(txtGiaNhap.Text);
            tt = sl * qd * gn;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if(cmbM_ID.Text == "")
            {
                MessageBox.Show("Hãy chọn thuốc cần nhập!", "Thông báo");
                cmbM_ID.Focus();
            }
            else if(txtSLNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng nhập!", "Thông báo");
                txtSLNhap.Focus();
            }
            else if (int.Parse(txtSLNhap.Text) <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Thông báo");
                txtSLNhap.Focus();
            }
            else
            {
                int count = 0;
                for(int i = 0; i < dgvDSThuocNhap.Rows.Count - 1; i++)
                {
                    if(cmbM_ID.SelectedValue.ToString() == dgvDSThuocNhap.Rows[i].Cells[0].Value.ToString())
                    {
                        count = count + 1;
                    }
                }
                if(count == 0)
                {
                    DataGridViewRow newRow = (DataGridViewRow)dgvDSThuocNhap.Rows[0].Clone();
                    newRow.Cells[0].Value = cmbM_ID.SelectedValue.ToString();
                    newRow.Cells[1].Value = txtM_Name.Text;
                    newRow.Cells[2].Value = txtM_Dat.Text;
                    newRow.Cells[3].Value = txtM_DVN.Text;
                    newRow.Cells[4].Value = txtQuydoi.Text;
                    newRow.Cells[5].Value = txtSLNhap.Text;
                    newRow.Cells[6].Value = txtGiaNhap.Text;
                    newRow.Cells[7].Value = txtThanhTien.Text;
                    dgvDSThuocNhap.Rows.Add(newRow);
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
            txtM_DVN.Text = "";
            txtQuydoi.Text = "";
            txtSLNhap.Text = "";
            txtGiaNhap.Text = "";
            txtThanhTien.Text = "";
        }
    }
}