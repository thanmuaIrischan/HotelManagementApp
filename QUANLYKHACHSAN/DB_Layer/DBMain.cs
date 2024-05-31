using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.DB_Layer
{
    public static class KTLogin
    {
        public static string username;
        public static string password;
        public static bool quanly;
    }

    public class DBMain
    {
        
        string connectionString = $"Data Source=LAPTOP-J7585LDJ\\HONGTHAM; Initial Catalog=QUANLYKHACHSAN;User ID={KTLogin.username};Password={KTLogin.password};";

        readonly SqlConnection conn = null;
        readonly SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(connectionString);
            comm = conn.CreateCommand();
        }
        
        
        public static string chuoiketnoi()
        {
            return $"Data Source=LAPTOP-J7585LDJ\\HONGTHAM; Initial Catalog=QUANLYKHACHSAN;User ID={KTLogin.username};Password={KTLogin.password};";
        }

        public static DataTable Docdulieu(string query)
        {
            //string chuoikn = $"Data Source=LAPTOP-J7585LDJ\\HONGTHAM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi());
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cmd.Dispose();
            conn.Close();
            return data;
        }
        public static int kiemtratext(string s)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi());
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                return 1;
            }
            else
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                return 0;
            }
        }
        public static string laychuoi(string s, string ra)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi());
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ra = reader.GetString(0);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            return ra;
        }
        public static object ExcuteScalar(string query)
        {
            object data = 0;
            SqlConnection conn = new SqlConnection(DBMain.chuoiketnoi());
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                data = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ExecuteScalar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public static int getListCount(string sl)
        {
            string query = string.Format(sl);

            return (int)ExcuteScalar(query);
        }
        
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        
    }
}
