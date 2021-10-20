using System;
using System.Data.SqlClient;

namespace DAO
{
    public class DataConnection
    {
        SqlConnection conn;
        private string connString = @"Data Source=LAPTOP-8JSOGGPT;Initial Catalog=tourdulich;Integrated Security=True";

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
