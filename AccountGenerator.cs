using PayrollV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollV1
{
    public partial class AccountGenerator : Form
    {
        EmployeeRepository employeeRepository = EmployeeRepository.Instance();
        Models.Employee.Employee employee;
        Employee_logins login;
        Employee_loginsRepo employee_LoginsRepo= new Employee_loginsRepo();
        private string username;
        private string default_password;

        public AccountGenerator()
        {
            InitializeComponent();
            listView1.Columns.Add("employee_ID",100,HorizontalAlignment.Center);
            listView1.Columns.Add("firstname", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("lastname",100, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }
        
        private void searchBTN_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int employee_ID = int.Parse(textBox1.Text);
            employee= employeeRepository.findById(employee_ID);
            if (employee == null) {
                MessageBox.Show("no record found");
            }
            ListViewItem listViewItem = new ListViewItem(employee?.Employee_ID.ToString());
            listViewItem.SubItems.Add(employee?.First_name);
            listViewItem.SubItems.Add(employee?.Last_name);
            listView1.Items.Add(listViewItem);
            

        }


        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                username = employee.Last_name.Replace(' ', '_') + '.' + employee.Employee_ID.ToString();
                default_password = employee.Last_name + "@Password123";
                int id = employee.Employee_ID;

                login = new Employee_logins
                {
                    username = username,
                    password = default_password,
                    employee_ID = id
                };
            }
            DialogResult dialogRes = MessageBox.Show($"Generate logins , username = {username} password = {default_password} ?", "Generate logins"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogRes.Equals(DialogResult.Yes))
            {
                List<Employee_logins> employee_Logins = new List<Employee_logins>();
                employee_Logins.Add(login);
                int result = employee_LoginsRepo.AddAll(employee_Logins);
            }
            else {

                Dispose();
            }
            
        }

        private void AccountGenerator_Load(object sender, EventArgs e)
        {

        }
    }


}
