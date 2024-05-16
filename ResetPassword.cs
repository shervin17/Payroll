using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class ResetPassword : Form
    {
        DataTable dt = new DataTable();
        Employee_loginsRepo repo = new Employee_loginsRepo();
        Employee_logins employee_Logins;
        List<Employee_logins> employee_loginsList;
        EmployeeRepository employeeRepository = EmployeeRepository.Instance();
        public ResetPassword()
        {
            InitializeComponent();
            dt.Columns.Add("Employee_ID",typeof(int));
            dt.Columns.Add("username",typeof(string));
            dt.Columns.Add("password",typeof(string));
            
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ResetBTN
            if (DialogResult.Yes == MessageBox.Show("reset to default password?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Employee em = employeeRepository.findById(employee_Logins.employee_ID);
                string temp_password = em.Last_name + "@Password123";
                Employee_logins temp_login = new Employee_logins()
                {
                    employee_ID = employee_Logins.employee_ID,
                    username = employee_Logins.username,
                    password = temp_password
                };

                if (repo.Update(temp_login) > 0)
                    MessageBox.Show("password has been set to default : " + temp_password);
             
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int id = int.Parse(ID_field.Text);
            employee_Logins= repo.findById(id);
            DataRow dr = GetRow(employee_Logins);
            dt.Rows.Add(dr);
            dataGridView1.DataSource= dt;

        }

        private void searchAllBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            employee_loginsList = repo.findAll().ToList();
            employee_loginsList.ForEach(em =>
            {
                DataRow dr = GetRow(em);
                dt.Rows.Add(dr);
            });
            dataGridView1.DataSource = dt;

        }
        private DataRow GetRow(Employee_logins em) { 
        
        DataRow dataRow= dt.NewRow();
            dataRow["Employee_ID"] = em.employee_ID;
            dataRow["username"]= em.username;
            dataRow["password"] = em.password;
         return dataRow;
        }
    }
}
