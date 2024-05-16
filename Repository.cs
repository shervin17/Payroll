using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace PayrollV1
{

    public class Repository<T, K>
    {
        SqlConnection _connection;
        SqlCommand _command;
        List<T> list;

        public Repository()
        {
            _connection = DBConnection.getConnection();
        }


        public T findById(K id)
        {
            T instance = default(T); // Initialize instance with default value

            list = findAll();
            foreach (T item in list)
            {
                // Assuming the first property of T is used for comparison
                PropertyInfo firstProperty = typeof(T).GetProperties()[0];
                object value = firstProperty.GetValue(item);

                // Check if the value of the first property matches the given id
                if (value.Equals(id))
                {
                    instance = item;
                    break; // Exit the loop once a match is found
                }
            }
            return instance;
        }


        public List<T> findAll()
            {
                list = new List<T>();
                try
                {
                    string typeName = typeof(T).ToString();
                    string tableName = typeName.Substring(typeName.LastIndexOf('.') + 1); // Extract substring after the last period

                    using (_connection=DBConnection.getConnection())
                    {
                    using (_command=new SqlCommand())
                    {
                        _command.Connection = _connection;
                        _command.CommandText = "select * from " + tableName;
                          
                        using (SqlDataReader reader = _command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    T item = Activator.CreateInstance<T>(); // Create instance of type T

                                    // Iterate over all properties of T
                                    PropertyInfo[] properties = typeof(T).GetProperties();
                                    foreach (PropertyInfo property in properties)
                                    {
                                        // Check if reader contains column with the same name as property
                                        if (reader[property.Name] != DBNull.Value)
                                        {
                                            // Set property value from reader
                                            property.SetValue(item, reader[property.Name]);
                                        }
                                    }

                                    list.Add(item);
                                }
                            }
                            else
                            {
                                MessageBox.Show("null search");
                            }
                        }
                       
                    }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
                return list;
            }
        public int Add(T item)
        {   
            int result = 0;
            string typeName = typeof(T).ToString();
            string tableName = typeName.Substring(typeName.LastIndexOf('.') + 1);

            PropertyInfo[] properties = typeof(T).GetProperties();

    
            PropertyInfo[] propertiesExceptFirst = properties.Skip(1).ToArray();

            string columns = string.Join(", ", propertiesExceptFirst.Select(p => p.Name));

            string parameterPlaceholders = string.Join(", ", propertiesExceptFirst.Select(p => "@" + p.Name));


            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameterPlaceholders})";
            try
            {
                using (_connection = DBConnection.getConnection())
                {
                    using (_command = new SqlCommand())
                    {
                        _command.Connection = _connection;
                        _command.CommandText = query;
                          
                        // Assuming _command is a SqlCommand, add parameters for each property (excluding the first property)
                        foreach (PropertyInfo property in propertiesExceptFirst)
                        {
                            _command.Parameters.AddWithValue("@" + property.Name, property.GetValue(item));
                        }

                        // Execute the query
                        result = _command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Generic Exception: " + e.Message);
            }
            finally {
                Debug.WriteLine(_connection.State);
            }
            return result;
        }
        public int AddAll(List<T> items)
        {
            int result = 0;
            string typeName = typeof(T).ToString();
            string tableName = typeName.Substring(typeName.LastIndexOf('.') + 1);
            PropertyInfo[] properties = typeof(T).GetProperties();

            string sql_query = $"insert into {tableName} values ";
            List<string> placeholders = properties.Select(p => "@" + p.Name).ToList();
            string row_values = "(" + string.Join(",", placeholders) + ")";
            sql_query += row_values;
            Debug.WriteLine(sql_query);
            SqlTransaction transaction = null;
            try
            {
                _connection = DBConnection.getConnection();
                transaction = _connection.BeginTransaction();
                _command = new SqlCommand();
                _command.Connection = _connection;
                _command.Transaction = transaction;

                foreach (var item in items)
                {
                    _command.CommandText = sql_query; // insert into table values ( rows...)
                    _command.Parameters.Clear(); // Clear parameters from previous iteration
                    foreach (var property in properties)
                    {
                        string parameterName = "@" + property.Name;
                        object propertyValue = property.GetValue(item);
                        _command.Parameters.AddWithValue(parameterName, propertyValue);
                    }
                    result += _command.ExecuteNonQuery();
                }
                transaction.Commit();
                MessageBox.Show("saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Roll back the transaction in case of an error
                transaction?.Rollback();
            }
            finally
            {
                // Dispose of the command object
                _command?.Dispose();
                // Dispose of the transaction object
                transaction?.Dispose();
                // Close the connection
                _connection?.Close();
            }

            return result;
        }




        public int Update(T item)
        {   
            int result = 0;
            string typeName = typeof(T).ToString();
            string tableName = typeName.Substring(typeName.LastIndexOf('.') + 1);
            string query = $"Update {tableName} set ";
            PropertyInfo[] properties = typeof(T).GetProperties(); //properties array will contain metadata about all
                                                                   //the properties of the type T, such as their names, types, access levels
            string columns = string.Join(", ", properties.Select(p => p.Name));
            string parameterPlaceholders = string.Join(", ", properties.Select(p => "@" + p.Name));

            string[] fields = columns.Split(new string[] { ", " }, StringSplitOptions.None);
            string[] placeHolders= parameterPlaceholders.Split(new string[] { ", " }, StringSplitOptions.None);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(query);
            int length = fields.Length;
            for (int i = 1; i < length; i++)
            {
                stringBuilder.Append(fields[i] + " = " + placeHolders[i]);
                if (i < length - 1)
                    stringBuilder.Append(", ");
            }

            stringBuilder.Append($" where {fields[0]} = {placeHolders[0]}");
           string update_query=stringBuilder.ToString();
           Debug.WriteLine(update_query);
            try
            {

                using (_connection = DBConnection.getConnection())
                {
                    using (_command = new SqlCommand())
                    {
                        _command.Connection = _connection;
                        _command.CommandText = update_query;
                        for(int i =0; i < fields.Length; i++)
                        {    
                            _command.Parameters.AddWithValue(placeHolders[i], properties[i].GetValue(item));
                        }
                      result=  _command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally {
                Debug.WriteLine("displaying connection inside finally block:"+_connection.State);
                if (_connection.State == System.Data.ConnectionState.Open) { 
                  _connection.Close();
                }
            }

            return result;
        }

        public int DeleteById(K id) {
 
            int result = 0;
            string typeName = typeof(T).ToString();
            string tableName = typeName.Substring(typeName.LastIndexOf('.') + 1);
            PropertyInfo[] propertyInfos = typeof(T).GetProperties();
            string query = $"delete from {tableName} where {propertyInfos[0].Name} = @Id";
            using( _connection = DBConnection.getConnection())
            {
                using (_command = new SqlCommand()) { 
                _command.Connection= _connection;
                _command.CommandText= query;
                    _command.Parameters.AddWithValue("@Id",id);
                  
                result = _command.ExecuteNonQuery();
                
                }

            }
            return result;
        }
    }
}

