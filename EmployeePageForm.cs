using PayrollV1.Models.Employee;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class EmployeePageForm : Form
    {
        Employee employee1;
        public EmployeePageForm()
        {
            InitializeComponent();
            
        }

        private void EmployeePageForm_Load(object sender, EventArgs e)
        {
            employee1 = LoggedInEmployee.Logged_in_employee;
            user_label.Text = user_label.Text + employee1.First_name + " " + employee1.Last_name;
        }

        private void timeInTimeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void log_outBTN_Click(object sender, EventArgs e)
        {
            Dispose();
            LoggedInEmployee.Logged_in_employee = null;
            new Employee_login_form().Show();
        }

        private void viewDTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ViewDTRForm obj = new ViewDTRForm();
            obj.TopLevel = false;
            obj.BringToFront();
            panel1.Controls.Add(obj);
            obj.Show();
        }
    }
}
