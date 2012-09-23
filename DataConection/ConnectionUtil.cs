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
            //String strConn = "Data Source=GUSTAVO-PC;Initial Catalog=AgendaFW2GSG37571;Integrated Security=True";
            //String strConn = "Data Source=GUSTAVO-NET;Initial Catalog=AgendaFW2GSG37571;Integrated Security=True";
            String strConn = "Data Source=localhost;Initial Catalog=AgendaFW2GSG37571;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strConn);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return connection;
        }

        public void CloseConnection()
        {
            SqlConnection con = OpenConnection();
            con.Close();
        }

        
    }
}
