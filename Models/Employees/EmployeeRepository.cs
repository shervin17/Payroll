using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace PayrollV1.Models
{
    public class EmployeeRepository : Repository<Models.Employee.Employee, int>
    {
        SqlConnection _connection;
        SqlCommand _command;
        Models.Employee.Employee employee = new Models.Employee.Employee();     

        private static EmployeeRepository _instance = new EmployeeRepository();
        

        private EmployeeRepository() {
         
        }
        public static EmployeeRepository Instance() { 
        return _instance==null? new EmployeeRepository() : _instance;
        }

        public int GetLatestID()
        {
            int id = 0;
            try
            {
                _connection = DBConnection.getConnection();
                Debug.WriteLine("connection inside GetLatestID: " + _connection.State);
                _command = new SqlCommand();
                _command.Connection = _connection;
                _command.CommandText = "Select top 1 employee_ID from employee order by employee_ID desc";
                using (SqlDataReader reader=_command.ExecuteReader()) {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            id = (int) reader["employee_ID"];
                        }
                    }
                }
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            { _connection.Close();
            }
            return id;
        }
        public int AddEmployee(Models.Employee.Employee employee) {
            int result = 0;

            try {
                _connection=DBConnection.getConnection();             
                _command = new SqlCommand();
                _command.Connection = _connection;
                string query = @"INSERT INTO employee  VALUES (@first_name, @last_name, @date_of_birth, @position,
                                @hourly_rate, @salary,@salary_per_yer, @hired_date, @middle_name)";
                _command.CommandText = query;
                _command.Parameters.AddWithValue("@first_name", employee.First_name);
                _command.Parameters.AddWithValue("@last_name", employee.Last_name);
                _command.Parameters.AddWithValue("@date_of_birth", employee.Date_of_birth);
                _command.Parameters.AddWithValue("@position", employee.Position);
                _command.Parameters.AddWithValue("@hourly_rate", employee.Hourly_rate);
                _command.Parameters.AddWithValue("@salary", employee.Salary);
                _command.Parameters.AddWithValue("@salary_per_yer", employee.Salary_per_yer);
                _command.Parameters.AddWithValue("@hired_date", employee.Hired_date);
                _command.Parameters.AddWithValue("@middle_name", employee.Middle_name);
                _connection.Open();

                result = _command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
            _connection.Close();
            }


            return result;
        }
    }
}
