using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Customer
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadCustomer()
        {
            return conn.GetTable("SELECT * FROM Customer");
        }

        public void insert(tblCustomer customer)
        {
            string sql = string.Format("INSERT INTO Customer VALUES (DEFAULT, N'" + customer.C_name + "', '" + customer.C_age + "', " +
                     "N'" + customer.C_gender + "', '" + customer.C_phone + "', N'" + customer.C_address + "')");
            conn.RunSQL(sql);
        }

        public void edit(tblCustomer customer)
        {
            string sql = string.Format("UPDATE Customer SET C_Fullname = N'" + customer.C_name + "', C_Age = '" + customer.C_age + "', C_Gender = " +
                    "N'" + customer.C_gender + "', C_Phonenumber = '" + customer.C_phone + "', C_Address = N'" + customer.C_address + "' WHERE C_ID = '" + customer.C_id + "'");
            conn.RunSQL(sql);
        }
        public void delete(string cID)
        {
            string sql = "DELETE FROM Customer WHERE C_ID = '" + cID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Customer WHERE C_Fullname like N'%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT C_ID FROM Customer ORDER BY C_ID DESC");
            if(temp != null)
            {
                ma = "KH";
                int id = Int32.Parse(temp.Substring(2, 7)) + 1;
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
                ma = "KH0000001";
            }
            
            return ma.ToString();
        }
        public string getNameByID(string cID)
        {
            string sql = "SELECT C_Fullname FROM Customer WHERE C_ID = '" + cID + "'";
            return conn.GetValueString(sql);
        }
        public string getPhoneByID(string cID)
        {
            string sql = "SELECT C_Phonenumber FROM Customer WHERE C_ID = '" + cID + "'";
            return conn.GetValueString(sql);
        }
        public string getAddressByID(string cID)
        {
            string sql = "SELECT C_Address FROM Customer WHERE C_ID = '" + cID + "'";
            return conn.GetValueString(sql);
        }
        public int getAgeByID(string cID)
        {
            string sql = "SELECT C_Age FROM Customer WHERE C_ID = '" + cID + "'";
            return conn.GetValueInt(sql);
        }
        public string getGenderByID(string cID)
        {
            string sql = "SELECT C_Gender FROM Customer WHERE C_ID = '" + cID + "'";
            return conn.GetValueString(sql);
        }
    }
}
