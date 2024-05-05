using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollV1
{
    public partial class Login : Form   
    {
        SqlConnection connection;
        SqlCommand command;
        string sql_query;
        List<Admin> admins= new List<Admin>();
        private Admin admin1;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username= usernameTB.Text;
            string password= passwordTB.Text;

            connection= DBConnection.getConnection();
            try
            {
                sql_query = "select admin.admin_id,firstname,lastname from admin_login,admin where username ='" +
                    username + "' and password = '" + password + "'";
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql_query;
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int adminID = (int)reader["admin_id"];
                        string firstname = (string)reader["firstname"];
                        string lastname = (string)reader["lastname"];
                        Admin admin = new Admin
                        {
                            Admin_id = adminID,
                            Firstname = firstname,
                            Lastname = lastname,
                        };
                        admins.Add(admin);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
            connection.Close();
            }
            if (admins.Count > 0)
            {
                listView1.View = View.Details;
                listView1.Columns.Add("admin_id", 100, HorizontalAlignment.Center);
                listView1.Columns.Add("firstname", 100, HorizontalAlignment.Center);
                listView1.Columns.Add("lastname", 100, HorizontalAlignment.Center);
                admin1 = admins[0];

                ListViewItem item = new ListViewItem();
                item.Text = admin1.Admin_id.ToString();
                item.SubItems.Add(admin1.Firstname);
                item.SubItems.Add(admin1.Lastname);
                listView1.Items.Add(item);

                new AdminPage(admin1).Show();
                Hide();
            }
            else {
                MessageBox.Show("invalid username or pasword");
                usernameTB.Text = "";
                passwordTB.Text = "";
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void usernameTB_Validating(object sender, CancelEventArgs e)
        {
            
            if (usernameTB.Text.Trim() == "")
            {
                errorProvider1.SetError(usernameTB, "username is required");
            }
            if (passwordTB.Text.Trim()=="") {
                errorProvider2.SetError(passwordTB,"password is required");
            }
        }
    }
}
