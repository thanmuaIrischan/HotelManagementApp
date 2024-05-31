using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using QUANLYKHACHSAN.DB_Layer;

namespace QUANLYKHACHSAN.BS_Layer
{
    public class BLSys_Users
    {
        string connectionString = "";

        readonly SqlConnection conn = null;
        readonly SqlCommand comm = null;

        public BLSys_Users()
        {
            connectionString = "Data Source=LAPTOP-J7585LDJ\\HONGTHAM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            comm = conn.CreateCommand();
        }
        
        
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public SqlConnection getConnection
        {
            get
            {
                return conn;
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