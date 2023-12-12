using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Donvitinh
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadDonvitinh()
        {
            return conn.GetTable("SELECT * FROM Donvitinh");
        }

        public void insert(tblDonvitinh dvt)
        {
            string sql = string.Format("INSERT INTO Donvitinh VALUES (N'" + dvt.Name + "')");
            conn.RunSQL(sql);
        }

        public void edit(tblDonvitinh dvt)
        {
            string sql = string.Format("UPDATE Donvitinh SET U_Name = N'" + dvt.Name + "' WHERE U_ID = '" + dvt.ID + "'");
            conn.RunSQL(sql);
        }
        public void delete(string uID)
        {
            string sql = "DELETE FROM Donvitinh WHERE U_ID = '" + uID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Donvitinh WHERE U_Name like N'%" + keyword + "%'");
        }
        public int LoadID()
        {
            int ma = 0;
            int temp = conn.GetValueInt("SELECT U_ID FROM Donvitinh ORDER BY U_ID DESC");
            if(temp != 0)
            {
                ma = temp + 1;
            }
            else
            {
                ma = 1;
            }
           
            return ma;
        }
    }
}
