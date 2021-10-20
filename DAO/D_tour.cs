using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_tour
    {
        DataConnection connect = new DataConnection();

       public DataTable GetListTour()
        {
            connect.OpenConnect();
            DataTable dataTable = new DataTable();
            string querySql = "SELECT * FROM [tourdulich].[dbo].[tour]";

            SqlCommand command = new SqlCommand(querySql, connect.conn );

            dataTable.Load(command.ExecuteReader());

            connect.CloseConnect();

            return dataTable;

        }

        
        





    }
}
