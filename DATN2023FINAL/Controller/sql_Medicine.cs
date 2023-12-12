using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_Medicine
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadMedicine()
        {
            return conn.GetTable("SELECT M_IDG, M_ID, M_Name, M_SDK, M_TPC, M_HL, M_Package, M_NuocSX, M_BasicUnit," +
                "M_Batch, M_Dat, M_Quantity, M_Price, M_ImPrice, M_DMT FROM Medicine");
        }

        public void insert(tblMedicine med)
        {
            string sql = string.Format("INSERT INTO Medicine VALUES ('" + med.IDG + "', DEFAULT, N'" + med.Name + "', '" + med.SDK + "'," +
                    "N'" + med.TPC + "', '" + med.HL + "', N'" + med.Package + "', N'" + med.NuocSX + "', N'" + med.BasicUnit + "', N'" + med.Batch + "'," +
                    "'" + med.Dat + "', '" + med.Quantity + "', N'" + med.ImUnit + "', '" + med.GTQD + "', '" + med.Price + "', '" + med.ImPrice + "'," +
                    "'" + med.DMT + "')");
            conn.RunSQL(sql);
        }

        public void edit(tblMedicine med)
        {
            string sql1 = string.Format("UPDATE Medicine SET M_Price = '" + med.Price + "', M_DMT = '" + med.DMT + "' WHERE M_ID = '" + med.ID + "'");
            conn.RunSQL(sql1);
        }
        public void delete(string mID)
        {
            string sql = "DELETE FROM Medicine WHERE M_ID = '" + mID + "'";
            conn.RunSQL(sql);
        }
        public void update(string mID, float var1, int var2)
        {
            string sql = string.Format("UPDATE Medicine SET M_Price = '" + var1 + "', M_DMT = '" + var2 + "' WHERE M_ID = '" + mID + "'");
            conn.RunSQL(sql);
        }
     
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM Medicine WHERE M_ID OR M_Name like N'%" + keyword + "%'");
        }
        public string LoadID()
        {
            string ma = "";
            string temp = conn.GetValueString("SELECT M_ID FROM Medicine ORDER BY M_ID DESC");
            if (temp != null)
            {
                ma = "MED";
                int id = Int32.Parse(temp.Substring(3, 6)) + 1;
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
                ma = "MED000001";
            }

            return ma.ToString();
        }
        public void FillCombo(ComboBox cbo)
        {            
            DataTable table = new DataTable();
            table = conn.GetTable("SELECT M_ID, M_Name FROM Medicine");
            cbo.DataSource = table;
            cbo.ValueMember = "M_ID"; //Trường giá trị
            cbo.DisplayMember = "M_Name"; //Trường hiển thị
        }
        public void FillComboByIDGroup(ComboBox cbo, string mgID)
        {
            DataTable table = new DataTable();
            table = conn.GetTable("SELECT M_ID, M_Name FROM Medicine WHERE M_IDG = '" + mgID + "'");
            cbo.DataSource = table;
            cbo.ValueMember = "M_ID"; //Trường giá trị
            cbo.DisplayMember = "M_Name"; //Trường hiển thị
        }
        public int GetSoQuyDoi(string idM)
        {
            string sql = "SELECT M_GTQD FROM Medicine WHERE M_ID = '" + idM + "'";
            return conn.GetValueInt(sql);
        }
        public int GetSLTon(string dieukien)
        {
            string sql = "SELECT M_Quantity FROM Medicine WHERE M_ID = '" + dieukien + "'";
            return conn.GetValueInt(sql);
        }
        public void UpdateSLTon(string mID, int var1)
        {
            string sql = string.Format("UPDATE Medicine SET M_Quantity = '" + var1 + "' WHERE M_ID = '" + mID + "'");
            conn.RunSQL(sql);
        }
    }
}
