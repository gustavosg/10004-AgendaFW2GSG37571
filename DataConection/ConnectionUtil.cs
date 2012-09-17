using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Data.Util;


namespace Data.DataConnection
{
    public class ConnectionUtil : Singleton<ConnectionUtil>
    {
        /// <summary>
        /// Open a connection
        /// </summary>
        /// <returns>Connection to a DataBase</returns>
        public SqlConnection OpenConnection()
        {
            String strConn = "Data Source=GUSTAVO-PC;Initial Catalog=AgendaFW2GSG37571;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strConn);
            connection.Open();
            return connection;
        }

        public void CloseConnection(SqlConnection con)
        {
            con.Close();
        }

        
    }
}
