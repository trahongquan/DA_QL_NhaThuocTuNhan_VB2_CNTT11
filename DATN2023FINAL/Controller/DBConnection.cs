using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATN2023FINAL.Controller
{
    public class DBConnection
    {
        public static SqlConnection connect;
        public DBConnection()
        {

        }
        public void MoKetNoi()
        {
            if(DBConnection.connect == null)
                DBConnection.connect = new SqlConnection(@"Data Source=DESKTOP-M0KCUVC\SQLEXPRESS;Database=MedicineStore;Integrated Security=True;User ID=sa;Password=150992");
            if(DBConnection.connect.State != ConnectionState.Open)
                DBConnection.connect.Open();
        }
        public void DongKetNoi()
        {
            if(DBConnection.connect != null)
            {
                if (DBConnection.connect.State == ConnectionState.Open)
                    DBConnection.connect.Close();
            }
        }
        //insert, update, delete
        public void RunSQL(string stringSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(stringSQL, connect);
                cmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetTable(string strSQL)//select
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }           
        }
        public DataTable GetTable(string procName, DateTime d1, DateTime d2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procName, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tungay", d1);
                cmd.Parameters.AddWithValue("@Denngay", d2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public string GetValueString(string strSQL)//select
        {
            string kq = null;
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                kq = rd.GetString(0);
            }           
            DongKetNoi();
            return kq;
        }
        public int GetValueInt(string strSQL)//select
        {
            int kq = 0;
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                kq = rd.GetInt32(0);
            }           
            DongKetNoi();
            return kq;
        }
        public DateTime GetValueDateTime(string strSQL)//select
        {
            DateTime kq = DateTime.Now;
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                kq = rd.GetDateTime(0);
            }
            DongKetNoi();
            return kq;
        }
        public string GetDatabaseName()
        {
            string str = null;
            try
            {
                MoKetNoi();
                str = DBConnection.connect.Database.ToString();
                DongKetNoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return str;
        }
    }
}
