using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DATN2023FINAL.Controller
{
    public class sql_Nhap
    { 
        DBConnection conn = new DBConnection();
        public DataTable LoadHDN()
        {
            return conn.GetTable("SELECT IFS_ID, IFS_Time, E_ID, IFS_Total FROM ImpFromSupp");
        }
        public DataTable LoadHDNByDay(DateTime startday, DateTime endday)
        {
            return conn.GetTable("SELECT IFS_ID, IFS_Time, E_ID, IFS_Total FROM ImpFromSupp WHERE IFS_Time BETWEEN '" + startday + "' AND '" + endday + "'");
        }
        public void insert(tblHoadonnhap hdn)
        {
            string sql = string.Format("INSERT INTO ImpFromSupp VALUES (DEFAULT, '" + hdn.NgayNhap + "', '" + hdn.IdNV + "', " +
                     "'" + hdn.IdNCC + "', N'" + hdn.Note + "', '" + hdn.Total + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM ImpFromSupp WHERE IFS_ID = '" + hdID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM ImpFromSupp WHERE IFS_ID OR E_ID like '%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT IFS_ID FROM ImpFromSupp ORDER BY IFS_ID DESC");
            if (temp != null)
            {
                ma = "PN";
                int id = Int32.Parse(temp.Substring(2, 6)) + 1;
                if (id < 10)
                    ma = ma + "00000";
                if (9 < id && id < 100)
                    ma = ma + "0000";
                if (99 < id && id < 1000)
                    ma = ma + "000";
                if (999 < id && id < 10000)
                    ma = ma + "00";
                if (9999 < id && id < 100000)
                    ma = ma + "0";
                if (99999 < id && id < 1000000)
                    ma = ma + "";
                ma += id.ToString();
            }
            else
            {
                ma = "PN000001";
            }            
            return ma.ToString();
        }
        public string getIDSup(string idHD)
        {
            return conn.GetValueString("SELECT S_ID FROM ImpFromSupp WHERE IFS_ID = '" + idHD + "'");
        }
        public string getNoteByID(string idHD)
        {
            return conn.GetValueString("SELECT IFS_Note FROM ImpFromSupp WHERE IFS_ID = '" + idHD + "'");
        }
        public DateTime getNgayNhapByID(string idHD)
        {
            return conn.GetValueDateTime("SELECT IFS_Time FROM ImpFromSupp WHERE IFS_ID = '" + idHD + "'");
        }
        //public float TongTien()
        //{
        //    string query = "SELECT a.IFS_ID, SUM(b.DIFS_Total) AS TongTien FROM ImpFromSupp AS a INNER JOIN DetailImpFromSupp AS b WHERE a.IFS_ID = b.DIFS_ID GROUP BY a.IFS_ID";
        //    return float.Parse(conn.GetValueString(query));
        //}
        public DataTable TTHDN(string s1)
        {
            string sql = "SELECT a.IFS_ID, a.IFS_Time, a.IFS_Total, c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber FROM ImpFromSupp as a, Employee as c, Supplier as d where a.IFS_ID = '" + s1 + "' and c.E_ID = a.E_ID and d.S_ID = a.S_ID";
            return conn.GetTable(sql);
        }
    }
}
