using System;
using System.Data.SqlClient;

namespace DAO
{
    public class DataConnection
    {
        public SqlConnection conn;
        private string connString = @"Data Source=LAPTOP-V66MEHQ2\SQLEXPRESS;Initial Catalog=tourdulich;Integrated Security=True";

        public void OpenConnect()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public void CloseConnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            
        }


    }
}
