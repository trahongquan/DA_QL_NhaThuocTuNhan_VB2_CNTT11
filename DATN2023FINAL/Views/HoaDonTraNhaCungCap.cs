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
using DATN2023FINAL.Controller;
using DATN2023FINAL.Models;
using DATN2023FINAL.Report;
using DevExpress.XtraReports.UI;

namespace DATN2023FINAL.Views
{
    public partial class HoaDonTraNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        sql_HoadontraNCC tncc = new sql_HoadontraNCC();
        sql_Nhap nhap = new sql_Nhap();
        sql_Chitietnhap ctnhap = new sql_Chitietnhap();
        sql_ChitiettraNCC cttncc = new sql_ChitiettraNCC();
        sql_Medicine cmed = new sql_Medicine();
        sql_Supplier sqlSupp = new sql_Supplier();
        tblHoadontraNCC hdtncc = new tblHoadontraNCC();
        tblChitiettraNCC cthdtncc = new tblChitiettraNCC();
       
        

        float tongtien = 0;
        public HoaDonTraNhaCungCap()
        {
            InitializeComponent();
        }

        private void HoaDonTraNhaCungCap_Load(object sender, EventArgs e)
        {
            //Load dữ liệu HĐ trả nhà cung cấp
            dgvHoadontraNCC.DataSource = tncc.LoadHDTNCC();
            //fill combobox nhà cung cấp
            cmbNCC.DataSource = sqlSupp.FillCombo();
            cmbNCC.ValueMember = "S_ID";
            cmbNCC.DisplayMember = "S_Name";
            //cmbNCC.DisplayMember = "S_ID";
            dgvDetailTra.Visible = false;
            LockControll();
        }
        public void ResetControll()
        {
            dtpNgayTra.Enabled = true;
            cmbNCC.Enabled = true;

            txtSLTra.Enabled = true;
            btnSave.Enabled = true;
            btnPrint.Enabled = true;
            btnCancel.Enabled = true;
            btnTra.Enabled = true;
            dgvThuocTuNCC.Enabled = true;
            dgvDSThuocTra.Enabled = true;

            txtMaHDTra.Text = tncc.LoadID();
            txtE_ID.Text = DangNhapForm.IDEmp;
            cmbNCC.SelectedIndex = -1;
            dtpNgayTra.Value = DateTime.Now;
            ResetDataGridview();
            
            txtTotal.Text = String.Empty;
            lbMoneyChar.Text = "Bằng chữ: ";
        }
        public void LockControll()
        {
            dtpNgayTra.Enabled = false;
            cmbNCC.Enabled = false;

            txtSLTra.Enabled = false;
            btnTra.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = false;
            dgvThuocTuNCC.Enabled = false;
            dgvDSThuocTra.Enabled = false;
            
            ResetDataGridview();

            txtE_ID.Text = String.Empty;
            txtMaHDTra.Text = String.Empty;
            txtTotal.Text = String.Empty;
            dtpNgayTra.Value = DateTime.Now;
            lbMoneyChar.Text = "Bằng chữ: ";
            cmbNCC.SelectedIndex = -1;
        }
        public void ResetDataGridview()
        {
            dgvThuocTuNCC.DataSource = null;
            dgvDetailTra.Visible = false;
            if (dgvDSThuocTra.Visible == false)
            {
                dgvDSThuocTra.Visible = true;
                dgvDSThuocTra.Rows.Clear();
            }
            else
            {
                dgvDSThuocTra.Rows.Clear();
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
        private void btnFillter_Click(object sender, EventArgs e)
        {
            dgvHoadontraNCC.DataSource = tncc.LoadHDNByDay(DateTime.Parse(dtpStartDay.Text), DateTime.Parse(dtpEndDay.Text));
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvHoadontraNCC.DataSource = tncc.LoadByKeyWord(txtFind.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvHoadontraNCC.DataSource = tncc.LoadHDTNCC();

            LockControll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                cttncc.delete(dgvHoadontraNCC.CurrentRow.Cells[0].Value.ToString());
                tncc.delete(dgvHoadontraNCC.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xoá!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Chưa thể xoá!", "Lỗi");
            }
            dgvHoadontraNCC.DataSource = tncc.LoadHDTNCC();
            LockControll();
        }
        private void cmbNCC_TextChanged(object sender, EventArgs e)
        {
            if (cmbNCC.SelectedIndex == -1)
            {
                dgvThuocTuNCC.Visible = false;
            }
            else
            {
                dgvThuocTuNCC.Visible = true;
                dgvThuocTuNCC.DataSource = ctnhap.TT_TraNCC(cmbNCC.SelectedValue.ToString());
                dgvThuocTuNCC.Columns[0].HeaderText = "Mã Thuốc";
                dgvThuocTuNCC.Columns[1].HeaderText = "Tên Thuốc";
                dgvThuocTuNCC.Columns[2].HeaderText = "Hạn SD";
                dgvThuocTuNCC.Columns[3].HeaderText = "ĐVT";
                dgvThuocTuNCC.Columns[4].HeaderText = "Quy đổi";
                dgvThuocTuNCC.Columns[5].HeaderText = "Số lượng";
                dgvThuocTuNCC.Columns[6].HeaderText = "Đơn giá";
            }
            dgvDSThuocTra.Rows.Clear();
        }

        private void txtSLTra_TextChanged(object sender, EventArgs e)
        {
            float sl, qd, gn, tt;
            if (txtQuyDoi.Text == "")
                qd = 0;
            else
                qd = float.Parse(txtQuyDoi.Text);
            if (txtSLTra.Text == "")
                sl = 0;
            else
                sl = float.Parse(txtSLTra.Text);
            if (txtDonGia.Text == "")
                gn = 0;
            else
                gn = float.Parse(txtDonGia.Text);
            tt = sl * qd * gn;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (txtM_ID.Text == "")
            {
                MessageBox.Show("Hãy chọn thuốc cần trả!", "Thông báo");
            }
            else if (txtSLTra.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng trả!", "Thông báo");
                txtSLTra.Focus();
            }
            else if (int.Parse(txtSLTra.Text) <= 0)
            {
                MessageBox.Show("Số lượng trả phải lớn hơn 0!", "Thông báo");
                txtSLTra.Focus();
            }
            else if (int.Parse(txtSLTra.Text) > int.Parse(dgvThuocTuNCC.CurrentRow.Cells[5].Value.ToString())/int.Parse(dgvThuocTuNCC.CurrentRow.Cells[4].Value.ToString()))
            {
                MessageBox.Show("Số lượng thuốc này tại nhà thuốc hiện không đủ số lượng trả!\nNhập lại số lượng trả!", "Thông báo");
                txtSLTra.Focus();
            }
            else
            {
                int count = 0;
                for (int i = 0; i < dgvDSThuocTra.Rows.Count - 1; i++)
                {
                    if (txtM_ID.Text == dgvDSThuocTra.Rows[i].Cells[0].Value.ToString())
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    DataGridViewRow newRow = (DataGridViewRow)dgvDSThuocTra.Rows[0].Clone();
                    newRow.Cells[0].Value = txtM_ID.Text;
                    newRow.Cells[1].Value = txtM_Name.Text;
                    newRow.Cells[2].Value = txtDVTra.Text;
                    newRow.Cells[3].Value = txtSLTra.Text;
                    newRow.Cells[4].Value = (float.Parse(txtDonGia.Text)*float.Parse(txtQuyDoi.Text)).ToString();
                    newRow.Cells[5].Value = txtThanhTien.Text;
                    dgvDSThuocTra.Rows.Add(newRow);
                    ResetValueThuoc();
                }
                else
                {
                    MessageBox.Show("Thuốc này đã có trong hoá đơn!\nVui lòng chọn lại thuốc!", "Thông báo");
                    ResetValueThuoc();
                }
            }
        }

        private void ResetValueThuoc()
        {
            txtM_ID.Text = "";
            txtM_Name.Text = "";
            txtDVTra.Text = "";
            txtSLTra.Text = "";
            txtDonGia.Text = "";
            txtQuyDoi.Text = "";
            txtThanhTien.Text = "";
        }

        private void dgvHoadontraNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMoneyChar.Text = "Bằng chữ: ";
            btnPrint.Enabled = true;
            txtMaHDTra.Text = dgvHoadontraNCC.SelectedRows[0].Cells[0].Value.ToString();
            cmbNCC.Text = sqlSupp.getNameByID(dgvHoadontraNCC.SelectedRows[0].Cells[1].Value.ToString());
            dtpNgayTra.Text = dgvHoadontraNCC.SelectedRows[0].Cells[2].Value.ToString();
            txtE_ID.Text = dgvHoadontraNCC.SelectedRows[0].Cells[3].Value.ToString();
            txtTotal.Text = dgvHoadontraNCC.SelectedRows[0].Cells[4].Value.ToString();

            dgvDetailTra.DataSource = cttncc.LoadCTHD_TNCC(dgvHoadontraNCC.SelectedRows[0].Cells[0].Value.ToString());
            dgvDetailTra.Visible = true;
            dgvDetailTra.Enabled = false;
            dgvDSThuocTra.Visible = false;
            lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            cmbNCC.Enabled = false;
        }

        private void dgvDSThuocTra_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvDSThuocTra.CurrentCell.RowIndex;
            if (dgvDSThuocTra.Rows.Count == 1)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (index >= dgvDSThuocTra.Rows.Count - 1)
                    MessageBox.Show("Hàng trống, Không thể xoá!", "Thông báo");
                else
                    dgvDSThuocTra.Rows.RemoveAt(index);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ResetControll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stock1, stock2, sumstock;
            
            if (cmbNCC.Text == "")
                MessageBox.Show("Chưa chọn nhà cung cấp!", "Thông báo");
            else if (dgvDSThuocTra.Rows.Count == 1)
            {
                MessageBox.Show("Danh sách trả thuốc đang trống!", "Thông báo");
            }
            else
            {
                for (int i = 0; i < dgvDSThuocTra.Rows.Count - 1; i++)
                {
                    tongtien += float.Parse(dgvDSThuocTra.Rows[i].Cells[5].Value.ToString());
                }
                txtTotal.Text = tongtien.ToString();
                hdtncc.RsID = txtMaHDTra.Text;
                hdtncc.SID = cmbNCC.SelectedValue.ToString();
                hdtncc.RsTime = DateTime.Parse(dtpNgayTra.Text);
                hdtncc.EID = txtE_ID.Text;
                hdtncc.RsTotal = float.Parse(txtTotal.Text);
                try
                {
                    tncc.insert(hdtncc);
                    tongtien = 0;
                }
                catch { }
                try
                {
                    for (int i = 0; i < dgvDSThuocTra.Rows.Count - 1; i++)
                    {
                        cthdtncc.RsID = txtMaHDTra.Text;
                        cthdtncc.MID = dgvDSThuocTra.Rows[i].Cells[0].Value.ToString();
                        cthdtncc.MName = dgvDSThuocTra.Rows[i].Cells[1].Value.ToString();
                        cthdtncc.DvTra = dgvDSThuocTra.Rows[i].Cells[2].Value.ToString();
                        cthdtncc.SlTra = Convert.ToInt32(dgvDSThuocTra.Rows[i].Cells[3].Value.ToString());
                        cthdtncc.DonGia = float.Parse(dgvDSThuocTra.Rows[i].Cells[4].Value.ToString());
                        cthdtncc.TTien = float.Parse(dgvDSThuocTra.Rows[i].Cells[5].Value.ToString());
                        cttncc.insert(cthdtncc);

                        stock1 = Convert.ToInt32(dgvDSThuocTra.Rows[i].Cells[3].Value.ToString()) * cmed.GetSoQuyDoi(dgvDSThuocTra.Rows[i].Cells[0].Value.ToString());
                        stock2 = cmed.GetSLTon(dgvDSThuocTra.Rows[i].Cells[0].Value.ToString());
                        sumstock = stock2 - stock1;
                        cmed.UpdateSLTon(dgvDSThuocTra.Rows[i].Cells[0].Value.ToString(), sumstock);        
                    }
                    MessageBox.Show("Lưu hoá đơn thành công!", "Thông báo");

                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    cmbNCC.Enabled = false;
                    lbMoneyChar.Text += ChuyenSoSangChuoi(float.Parse(txtTotal.Text));
                    dgvHoadontraNCC.DataSource = tncc.LoadHDTNCC();
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
            DataTable ds = cttncc.TTInHDTNCC(txtMaHDTra.Text);
            rptHoadontraNCC rp = new rptHoadontraNCC(this);
            rp.DataSource = ds;
            rp.BindData();
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThuocTuNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtM_ID.Text = dgvThuocTuNCC.CurrentRow.Cells[0].Value.ToString();
            txtM_Name.Text = dgvThuocTuNCC.CurrentRow.Cells[1].Value.ToString();
            txtDVTra.Text = dgvThuocTuNCC.CurrentRow.Cells[3].Value.ToString();
            txtQuyDoi.Text = dgvThuocTuNCC.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvThuocTuNCC.CurrentRow.Cells[6].Value.ToString();
        }
    }
}