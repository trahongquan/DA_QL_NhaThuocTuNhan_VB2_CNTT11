using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_ChitietSale
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadCTHDB(string ma)
        {
            return conn.GetTable("SELECT M_ID, M_Name, M_Unit, M_QuantitySale, M_Price," +
                "DS_Total FROM DetailSale WHERE SAL_ID  = '" + ma + "'");
        }

        public void insert(tblChitietSale cthdb)
        {
            string sql = string.Format("INSERT INTO DetailSale VALUES ('" + cthdb.Dsale_ID + "', '" + cthdb.M_ID + "', " +
                    "N'" + cthdb.M_Name + "', N'" + cthdb.M_SaleUnit + "', '" + cthdb.M_SaleQuantity + "'," +
                    "'" + cthdb.M_SalePrice + "', '" + cthdb.Total + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM DetailSale WHERE SAL_ID = '" + hdID + "'";
            conn.RunSQL(sql);
        }

        public DataTable LayTTThuoc(string diekien)
        {
            return conn.GetTable("SELECT M_ID, M_Name, M_Dat, M_BasicUnit, M_Price, M_Quantity FROM Medicine" + diekien);
        }
        public DataTable LayTTCustomer(string dieukien)
        {
            return conn.GetTable("SELECT * FROM Customer" + dieukien);
        }
        public DataTable TTCTHDB(string idHD)
        {
            string sql = "SELECT a.SAL_ID, a.SAL_Total, b.M_Name, b.M_Unit, b.M_QuantitySale, b.M_Price, b.DS_Total," +
                " c.Fullname, d.C_Fullname, d.C_Age, d.C_Gender, d.C_Address, d.C_Phonenumber FROM Sale as a, DetailSale as b," +
                " Employee as c, Customer as d WHERE a.SAL_ID = '"+idHD+"' and a.SAL_ID = b.SAL_ID and c.E_ID = a.E_ID and d.C_ID = a.C_ID";
            return conn.GetTable(sql);
        }
    }
}
