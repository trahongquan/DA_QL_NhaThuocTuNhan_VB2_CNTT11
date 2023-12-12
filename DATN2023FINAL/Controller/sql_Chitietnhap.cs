using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Chitietnhap
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadCTHDN(string ma)
        {
            return conn.GetTable("SELECT M_ID, M_Name, M_Dat, M_ImUnit, M_GTQD, M_Quantity," +
                "M_ImPrice, DIFS_Total FROM DetailImpFromSupp WHERE IFS_ID = '" + ma + "'");           
        }
        public DataTable TT_TraNCC(string idNCC)
        {
            return conn.GetTable("WITH tb1 AS (SELECT M_ID AS ID FROM DetailImpFromSupp a JOIN ImpFromSupp b ON a.IFS_ID = b.IFS_ID WHERE b.S_ID = '"+idNCC+"' GROUP BY M_ID), " +
                "tb2 AS (SELECT M_ID AS ID, M_Name AS NameM, M_Dat AS Dat, M_ImUnit AS Unit, M_GTQD AS QD, M_Quantity AS SL, M_ImPrice AS Price FROM Medicine) " +
                "SELECT tb2.* FROM tb1 JOIN tb2 ON tb2.ID = tb1.ID");
        }
        public void insert(tblChitietnhap cthdn)
        {
            string sql = string.Format("INSERT INTO DetailImpFromSupp VALUES ('" + cthdn.IdHD + "', '" + cthdn.IdM + "', " +
                    "N'" + cthdn.MName + "', N'" + cthdn.MBatch + "', '" + cthdn.MDat + "', '" + cthdn.MQuantity + "', N'" + cthdn.MImUnit + "', '" + cthdn.MGTQD + "'," +
                    "'" + cthdn.MPrice + "', '" + cthdn.MImPrice + "', '" + cthdn.Total + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM DetailImpFromSupp WHERE IFS_ID = '" + hdID + "'";
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
        public bool CheckKey(string str1, string str2)
        {
            string sql = "SELECT M_ID FROM DetailImpFromSupp WHERE M_ID = '"
                + str1 + "' AND DIFS_ID = '" + str2 + "'";
           
            DataTable table = new DataTable();
            table = conn.GetTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public DataTable TTInHDN(string idHD)
        {
           string sql = "SELECT a.IFS_ID, a.IFS_Time, a.IFS_Total, b.S_Name, b.S_Address, b.S_Phonenumber, c.Fullname FROM ImpFromSupp AS a, Supplier AS b," +
                " Employee AS c WHERE a.IFS_ID = N'" + idHD + "' AND a.S_ID = b.S_ID AND a.E_ID = c.E_ID";
            return conn.GetTable(sql);
        }
        public DataTable TTCTHDN(string idHD)
        {
            string sql = "SELECT a.IFS_ID, a.IFS_Time, a.IFS_Total, b.M_ID, b.M_Name, b.M_ImUnit, b.M_Quantity, b.M_ImPrice*b.M_GTQD as Dongia, b.DIFS_Total, " +
                "c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber FROM ImpFromSupp as a, DetailImpFromSupp as b, Employee as c, Supplier as d " +
                "WHERE a.IFS_ID = '" + idHD + "' and a.IFS_ID = b.IFS_ID and c.E_ID = a.E_ID and d.S_ID = a.S_ID";
            return conn.GetTable(sql);
        }
        
    }
}
