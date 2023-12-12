using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_ChitiettraNCC
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadCTHD_TNCC(string ma)
        {
            return conn.GetTable("SELECT M_ID, M_Name, M_Unit, M_QuantityReturn," +
                "M_ImPrice, DRS_Total FROM DetailReturnSupplier WHERE RS_ID = '" + ma + "'");
        }

        public void insert(tblChitiettraNCC tnccct)
        {
            string sql = string.Format("INSERT INTO DetailReturnSupplier VALUES ('" + tnccct.RsID + "', '" + tnccct.MID + "', " +
                    "N'" + tnccct.MName + "', N'" +tnccct.DvTra + "', '" + tnccct.SlTra + "', '" + tnccct.DonGia + "', '" + tnccct.TTien + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM DetailReturnSupplier WHERE RS_ID = '" + hdID + "'";
            conn.RunSQL(sql);
        }

        public DataTable LayTTThuoc(string diekien)
        {
            return conn.GetTable("SELECT M_ID, M_Name, M_Dat, M_ImUnit, M_GTQD, M_ImPrice FROM Medicine" + diekien);
        }
        public DataTable LayTTSupplier(string dieukien)
        {
            return conn.GetTable("SELECT * FROM Supplier" + dieukien);
        }
       
        public DataTable TTInHDTNCC(string idHD)
        {
            string sql = "select a.RS_ID, a.RS_Total, a.S_ID, b.M_ID, b.M_Name, b.M_Unit, " +
                "b.M_QuantityReturn, b.M_ImPrice, b.DRS_Total, c.Fullname, d.S_Name, d.S_Address, " +
                "d.S_Phonenumber from ReturnSupplier as a, DetailReturnSupplier as b, Employee as c, " +
                "Supplier as d where a.RS_ID = '" + idHD + "' and a.RS_ID = b.RS_ID and c.E_ID = a.E_ID and a.S_ID = d.S_ID";
            return conn.GetTable(sql);
        }
    }
}
