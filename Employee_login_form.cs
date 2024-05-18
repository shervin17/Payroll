using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class Employee_login_form : Form
    {
        Employee_loginsRepo loginsRepo = new Employee_loginsRepo();
        List<Employee_logins> employee_loginList = new List<Employee_logins>();
        EmployeeRepository employeeRepository = EmployeeRepository.Instance();
        Employee employee;

        public Employee_login_form()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            employee = null;
            string username = username_Field.Text;
            string password= password_Field.Text;
            int found_ID = 0;
            employee_loginList.ForEach(element => {
                if (element.username == username && element.password == password)
                {
                    found_ID = element.employee_ID;
                    employee= employeeRepository.findById(found_ID);
                    if(employee != null )
                    {
                        LoggedInEmployee.Logged_in_employee= employee;
                        new EmployeePageForm().Show();
                        Hide();
                    }
                }
            });
            if (found_ID == 0) {
                MessageBox.Show("invalid username or password");
            }
        }

        private void Employee_login_form_Load(object sender, EventArgs e)
        {
            employee_loginList=loginsRepo.findAll();
            username_Field.Text = "Hanks.1060";
            password_Field.Text = "Hanks@Password123";
        }

        private void username_Field_TextChanged(object sender, EventArgs e)
        {
            if (username_Field.Text.Trim() == "") {
                errorProvider1.SetError(username_Field, "please enter username");
            }

        }

        private void password_Field_TextChanged(object sender, EventArgs e)
        {
            if (password_Field.Text.Trim() == "")
            {
                errorProvider2.SetError(password_Field, "please enter password");
            }
        }
    }
}
