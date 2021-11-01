using System;
using System.Data.SqlClient;

namespace DAO
{
    public class DataConnection
    {
        public SqlConnection conn;
        private string connString = @"Data Source=Ninh\SQLEXPRESS;Initial Catalog=tourdulich;Integrated Security=True";

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
