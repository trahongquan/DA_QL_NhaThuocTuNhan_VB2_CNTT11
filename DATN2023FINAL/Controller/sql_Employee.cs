using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Employee
    {
        DBConnection conn = new DBConnection();
        //lấy dữ liệu
        public DataTable LoadEmployee()
        {
            return conn.GetTable("SELECT * FROM Employee");
        }
        //thêm
        public void insert(tblEmployee emp)
        {
            string sql = string.Format("INSERT INTO Employee VALUES (DEFAULT, N'" + emp.Fullname + "', '" + emp.Birthday + "', N'" + emp.Gender + "', '" + emp.PhoneNumber + "', N'" + emp.Addres + "')");
            conn.RunSQL(sql);
        }
        //sửa
        public void edit(tblEmployee emp)
        {
            string sql = string.Format("UPDATE Employee SET Fullname = N'" + emp.Fullname + "', Birthday = '" + emp.Birthday + "', Gender = N'" + emp.Gender + "', PhoneNumber = '" + emp.PhoneNumber + "'," +
                    "Addres = N'" + emp.Addres + "' WHERE E_ID = '" + emp.E_ID + "'");
            conn.RunSQL(sql);
        }
        //xoá
        public void delete(string empID)
        {
            string sql = "DELETE FROM Employee WHERE E_ID = '" + empID + "'";
            conn.RunSQL(sql);
        }

        public string getEmpID(string username, string password)
        {
            string sql = "SELECT E_ID FROM Employee WHERE Username = '" + username + "' AND Pass = '" + password + "'";
            return conn.GetValueString(sql);
        }

        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Employee WHERE Fullname like N'%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT E_ID FROM Employee ORDER BY E_ID DESC");
            if (temp != null)
            {
                ma = "NV";
                int id = Int32.Parse(temp.Substring(2, 3)) + 1;
                if (id < 10)
                    ma = ma + "00";
                if (9 < id && id < 100)
                    ma = ma + "0";
                if (99 < id && id < 1000)
                    ma = ma + "";
                ma += id.ToString();
            }
            else
            {
                ma = "NV001";
            }
            return ma.ToString();
        }
        public string getNameByID(string eID)
        {
            string sql = "SELECT Fullname FROM Employee WHERE E_ID = '" + eID + "'";
            return conn.GetValueString(sql);
        }
        
        public DataTable LayTTNV()
        {
            return conn.GetTable("SELECT E_ID, Fullname FROM Employee WHERE NOT EXISTS (SELECT E_ID FROM Account WHERE Employee.E_ID = Account.E_ID)");       
        }
        public int DemNV()
        {
            return conn.GetValueInt("SELECT COUNT(E_ID) FROM Employee");
        }
    }
}
