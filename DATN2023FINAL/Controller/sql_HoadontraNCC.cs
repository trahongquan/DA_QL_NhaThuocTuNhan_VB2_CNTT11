using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_HoadontraNCC
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadHDTNCC()
        {
            return conn.GetTable("SELECT RS_ID, S_ID, RS_Time, E_ID, RS_Total FROM ReturnSupplier");
        }
        public DataTable LoadHDNByDay(DateTime startday, DateTime endday)
        {
            return conn.GetTable("SELECT RS_ID, S_ID, RS_Time, E_ID, RS_Total FROM ReturnSupplier WHERE RS_Time BETWEEN '" + startday + "' AND '" + endday + "'");
        }
        public void insert(tblHoadontraNCC tncc)
        {
            string sql = string.Format("INSERT INTO ReturnSupplier VALUES (DEFAULT, '" + tncc.SID + "', '" + tncc.RsTime + "', " +
                     "'" + tncc.EID + "', '" +tncc.RsTotal + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM ReturnSupplier WHERE RS_ID = '" + hdID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM ReturnSupplier WHERE RS_ID OR E_ID like '%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT RS_ID FROM ReturnSupplier ORDER BY RS_ID DESC");
            if (temp != null)
            {
                ma = "PTNCC";
                int id = Int32.Parse(temp.Substring(5, 4)) + 1;
                if (id < 10)
                    ma = ma + "000";
                if (9 < id && id < 100)
                    ma = ma + "00";
                if (99 < id && id < 1000)
                    ma = ma + "0";
                if (999 < id && id < 10000)
                    ma = ma + "";
                ma += id.ToString();
            }
            else
            {
                ma = "PTNCC0001";
            }
            return ma.ToString();
        }
        public string getID_HDN(string idHD)
        {
            return conn.GetValueString("SELECT IFS_ID FROM ReturnSupplier WHERE RS_ID = '" + idHD + "'");
        }
        public string getID_NCC(string idHD)
        {
            return conn.GetValueString("SELECT S_ID FROM ReturnSupplier WHERE RS_ID = '" + idHD + "'");
        }

        //public DataTable TTHDN(string s1)
        //{
        //    string sql = "SELECT a.IFS_ID, a.IFS_Time, a.IFS_Total, c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber FROM ImpFromSupp as a, Employee as c, Supplier as d where a.IFS_ID = '" + s1 + "' and c.E_ID = a.E_ID and d.S_ID = a.S_ID";
        //    return conn.GetTable(sql);
        //}
    }
}
