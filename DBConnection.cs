using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PayrollV1
{
    public class DBConnection
    {
        private static string conString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private static SqlConnection connection;

            private DBConnection()
            {


            }

            public static SqlConnection getConnection()
            { 
                connection = new SqlConnection(conString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }


        }
    }


