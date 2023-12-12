using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Supplier
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadSupplier()
        {
            return conn.GetTable("SELECT * FROM Supplier");
        }

        public void insert(tblSupplier supplier)
        {
            string sql = string.Format("INSERT INTO Supplier VALUES (DEFAULT, N'" + supplier.SupplierName + "', '" + supplier.SupplierPhone + "', N'" + supplier.SupplierAddress + "')");
            conn.RunSQL(sql);
        }

        public void edit(tblSupplier supplier)
        {
            string sql = string.Format("UPDATE Supplier SET S_Name = N'" + supplier.SupplierName + "', S_Phonenumber = '" + supplier.SupplierPhone + "'," +
                    " S_Address = N'" + supplier.SupplierAddress + "' WHERE S_ID = '" + supplier.SupplierId + "'");
            conn.RunSQL(sql);
        }
        public void delete(string sID)
        {
            string sql = "DELETE FROM Supplier WHERE s_ID = '" + sID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Supplier WHERE S_Name like N'%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT S_ID FROM Supplier ORDER BY S_ID DESC");
            if (temp != null)
            {
                ma = "NCC";
                int id = Int32.Parse(temp.Substring(3, 3)) + 1;
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
                ma = "NCC001";
            }            
            return ma.ToString();
        }
        public DataTable FillCombo()
        {
            return conn.GetTable("SELECT S_ID, S_Name FROM Supplier");
        }
        public string getNameByID(string sID)
        {
            string sql = "SELECT S_Name FROM Supplier WHERE S_ID = '" + sID + "'";
            return conn.GetValueString(sql);
        }
        public string getPhoneByID(string sID)
        {
            string sql = "SELECT S_Phonenumber FROM Supplier WHERE S_ID = '" + sID + "'";
            return conn.GetValueString(sql);
        }
        public string getAddressByID(string sID)
        {
            string sql = "SELECT S_Address FROM Supplier WHERE S_ID = '" + sID + "'";
            return conn.GetValueString(sql);
        }
    }
}
