using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;


namespace PayrollV1
{
    public class DTRrepository : Repository<DTR, int>
    {
        private static DTRrepository repository;
        private DTRrepository()
        {
        }

        public static DTRrepository getInstance()
        {
            if (repository == null)
            {
                repository = new DTRrepository();
            }
            return repository;
        }

        public DTR getDTR(int id, DateTime date, DateTime time_in)
        {
            DTR dTR = null;
            SqlConnection connection = DBConnection.getConnection();
            try
            {
                string query = "select * from  dtr where employee_ID = @ID and date= @date and time_in = @timeIN";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.Parameters.AddWithValue("@date", date.Date);
                sqlCommand.Parameters.AddWithValue("@timeIN", time_in);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        dTR = new DTR()
                        {
                            Employee_ID = (int)reader["employee_ID"],
                            Date = (DateTime)reader["date"],
                            Time_in = (DateTime)reader["time_in"],
                            Time_out = (DateTime)reader["time_out"],
                        };
                    }
                }
                else
                {
                    MessageBox.Show("nothing found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dTR;
        }
        public int UpdateDTR(DTR dtr)
        {
            int affectedRows = 0;
            using (SqlConnection connection = DBConnection.getConnection())
            {
                try
                {
                    string query = "UPDATE dtr SET time_out = @time_out , status = @status WHERE employee_ID = @employee_ID AND date = @date and time_in=@TI" ;
                    Debug.WriteLine(query+ dtr.Date);
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@time_out", dtr.Time_out);
                        sqlCommand.Parameters.AddWithValue("@status",dtr.status);
                        sqlCommand.Parameters.AddWithValue("@employee_ID", dtr.Employee_ID);
                        sqlCommand.Parameters.AddWithValue("@date", dtr.Date.Date);
                        sqlCommand.Parameters.AddWithValue("@TI", dtr.Time_in);
                        


                        affectedRows = sqlCommand.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Saved");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e.Message}");
                }
                finally
                {
                    connection.Close();
                   
                }
            }
            return affectedRows;
        }

    }


    
}
