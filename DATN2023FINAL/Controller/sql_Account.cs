using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Account
    {
        DBConnection conn = new DBConnection();
        //lấy dữ liệu
        public DataTable LoadAccount()
        {
            return conn.GetTable("SELECT * FROM Account");
        }
        //thêm
        public void insert(tblAccount acc)
        {
            string sql = string.Format("INSERT INTO Account VALUES ('" + acc.Username + "', '" + acc.Password + "', '" + acc.E_ID + "', " +
                   "'" + acc.Permission + "', '" + acc.Suppended + "')");
            conn.RunSQL(sql);
        }
        //sửa
        public void edit(tblAccount acc)
        {
            string sql = string.Format("UPDATE Account SET Pass = '" + acc.Password + "', Permission = '" + acc.Permission + "', Suppended = '" + acc.Suppended + "' WHERE Username = '" + acc.Username + "'");
            conn.RunSQL(sql);
        }

        //xoá
        public void delete(string key)
        {
            string sql = "DELETE FROM Account WHERE Username = '" + key + "'";
            conn.RunSQL(sql);
        }
        public int getRol(string username, string password)
        {
            string sql = "SELECT Permission FROM Account WHERE Username = '" + username + "' AND Pass = '" + password + "'";
            return conn.GetValueInt(sql);
        }
        public string getEmpID(string username, string password)
        {
            string sql = "SELECT E_ID FROM Account WHERE Username = '" + username + "' AND Pass = '" + password + "'";
            return conn.GetValueString(sql);
        }

        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Account WHERE Username like N'%" + keyword + "%'");
        }
        
        public string getPassByUsername(string key)
        {
            string sql = "SELECT Pass FROM Account WHERE Username = '" + key + "'";
            return conn.GetValueString(sql);
        }
        public void ChangePassWord(string _pass, string key)
        {
            string sql = "UPDATE Account SET Pass = '" + _pass + "' WHERE Username = '" + key + "'";
            conn.RunSQL(sql);
        }
        public DataTable getSuppended(string text)
        {
            string sql = "SELECT Permission, Suppended FROM Account WHERE Username = '" + text + "'";
            return conn.GetTable(sql);
        }
    }
}
