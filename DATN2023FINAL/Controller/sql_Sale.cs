using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Sale
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadHDB()
        {
            return conn.GetTable("SELECT * FROM Sale");
        }
        public DataTable LoadHDBByDay(DateTime startday, DateTime endday)
        {
            return conn.GetTable("SELECT * FROM Sale WHERE SAL_Time BETWEEN '" + startday + "' AND '" + endday + "'");
        }
        public void insert(tblSale hdb)
        {
            string sql = string.Format("INSERT INTO Sale VALUES (DEFAULT, '" + hdb.Sale_Time + "', '" + hdb.E_ID + "', '" + hdb.C_ID + "', '" + hdb.Sale_Total + "')");
            conn.RunSQL(sql);
        }

        public void delete(string hdID)
        {
            string sql = "DELETE FROM Sale WHERE SAL_ID = '" + hdID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Sale WHERE SAL_ID OR E_ID OR C_ID like '%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT SAL_ID FROM Sale ORDER BY SAL_ID DESC");
            if (temp != null)
            {
                ma = "HDB";
                int id = Int32.Parse(temp.Substring(3, 7)) + 1;
                if (id < 10)
                    ma = ma + "000000";
                if (9 < id && id < 100)
                    ma = ma + "00000";
                if (99 < id && id < 1000)
                    ma = ma + "0000";
                if (999 < id && id < 10000)
                    ma = ma + "000";
                if (9999 < id && id < 100000)
                    ma = ma + "00";
                if (99999 < id && id < 1000000)
                    ma = ma + "0";
                if (999999 < id && id < 10000000)
                    ma = ma + "";
                ma += id.ToString();
            }
            else
            {
                ma = "HDB0000001";
            }
            return ma.ToString();
        }
        public string getIDCustomer(string idHD)
        {
            return conn.GetValueString("SELECT C_ID FROM ImpFromSupp WHERE SAL_ID = '" + idHD + "'");
        }
        
    }
}
