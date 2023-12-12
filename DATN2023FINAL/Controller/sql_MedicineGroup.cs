using DATN2023FINAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class sql_MedicineGroup
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadMedicineGroup()
        {
            return conn.GetTable("SELECT * FROM MedicineGroup");
        }
        public void insert(tblMedicineGroup mg)
        {
            string sql = "INSERT INTO MedicineGroup VALUES (N'" + mg.MGName + "')";
            conn.RunSQL(sql);
        }

        public void edit(tblMedicineGroup mg)
        {
            string sql = string.Format("UPDATE MedicineGroup SET MG_Name = N'" + mg.MGName + "' WHERE MG_ID = '" + mg.MGID + "'");
            conn.RunSQL(sql);
        }
        public void delete(string mgID)
        {
            string sql = "DELETE FROM MedicineGroup WHERE MG_ID = '" + mgID + "'";
            conn.RunSQL(sql);
        }
        public DataTable LoadByKeyWord(string keyword)
        {
            return conn.GetTable("SELECT * FROM MedicineGroup WHERE MG_Name like N'%" + keyword + "%'");
        }
        public int LoadID()
        {
            int ma = 0;
            int _temp = conn.GetValueInt("SELECT MG_ID FROM MedicineGroup ORDER BY MG_ID DESC");          
            if (_temp != 0)
            {
                ma = _temp + 1;
            }
            else
            {
                ma = 1;
            }
            
            return ma;
        }
        public void FillCombo(ComboBox cbo)
        {
            DataTable table = new DataTable();

            table = conn.GetTable("SELECT MG_ID, MG_Name FROM MedicineGroup");
            cbo.DataSource = table;
            cbo.ValueMember = "MG_ID"; //Trường giá trị
            cbo.DisplayMember = "MG_Name"; //Trường hiển thị
        }
    }
}
