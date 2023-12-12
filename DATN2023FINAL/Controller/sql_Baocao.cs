using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Controller
{
    public class sql_Baocao
    {
        DBConnection conn = new DBConnection();

        public DataTable BaoCaoDoanhThu(DateTime startday, DateTime endday)
        {
            string sql = ";WITH k AS (SELECT m.M_ID, m.M_Name, m.M_BasicUnit, mg.MG_Name " +
                "FROM Medicine m JOIN MedicineGroup mg ON mg.MG_ID = m.M_IDG), " +
                "n AS (SELECT M_ID, Sum(M_QuantitySale) AS SLBan, Sum(DS_Total) AS DoanhThu " +
                "FROM DetailSale a JOIN Sale b ON a.SAL_ID = b.SAL_ID " +
                "WHERE b.SAL_Time BETWEEN '" + startday + "' AND '" + endday + "' GROUP BY M_ID) " +
                "SELECT k.*, SLBan, DoanhThu FROM n JOIN k ON k.M_ID = n.M_ID";
            return conn.GetTable(sql);
        }
        public DataTable BaoCaoDoanhSoNV(DateTime startday, DateTime endday)
        {
            //string sql = "select distinct Sale.E_ID, Employee.Fullname, Count(Sale.SAL_ID) as SLHDB, Sum(Sale.SAL_Total) as DSo" +
            //    " from Sale inner join Employee on Employee.E_ID = Sale.E_ID" +
            //    " where Sale.SAL_Time between '" + startday + "' AND '" + endday + "'" +
            //    " group by Sale.E_ID, Employee.Fullname" +
            //    " order by Sale.E_ID";
            return conn.GetTable("m_DoanhSoNV", startday, endday);
        }
        public DataTable BaoCaoThuocDuoiDMT()
        {
            string sql = "select M_ID as Ma, M_Name as Ten, M_BasicUnit as DV, M_DMT as DM, M_Quantity as SLThucTe, ABS(M_Quantity - M_DMT) as ChenhLech " +
                "from Medicine where M_Quantity < M_DMT";
            return conn.GetTable(sql);
        }
        public DataTable BaoCaoThuocSapHetHan(int songay)
        {
            string sql = "select M_ID as Ma, M_Name as Ten, M_BasicUnit as DV, M_Batch as TenLo, M_Dat as HSD, M_Quantity as SLCon, M_ImPrice as GiaNhap, (M_Quantity*M_ImPrice) as TriGia " +
                "from Medicine " +
                "where DATEDIFF(day, getdate(), M_Dat) < '" + songay + "'";
            return conn.GetTable(sql);
        }
        public DataTable BaoCaoNhapXuatTon(DateTime startday, DateTime endday)
        {
            return conn.GetTable("m_XuatNhapTon", startday, endday);   
        }
    }
}
