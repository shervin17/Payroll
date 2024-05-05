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
    public partial class UpdateEmployee : Form
    {
        Employee employee;
        EmployeeRepository employeeRepository;
        
        public UpdateEmployee(Employee employee1)
        {
            InitializeComponent();
            employee = employee1;
            ID.Text = employee1.Employee_ID.ToString();
            fname.Text = employee1.First_name;
            lname.Text = employee1.Last_name;
            midname.Text = employee1.Middle_name;
            dob.Value = employee1.Date_of_birth;
            datehired.Value = employee1.Hired_date;
            posTB.Text = employee1.Position;
            monthlyTB.Text= employee1.Salary.ToString();
            hourlyTB.Text= employee1.Hourly_rate.ToString();
            yearlyTB.Text= employee1.Salary_per_yer.ToString();

              listView1.Columns.Add("employee_ID", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("first_name", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("last_name", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("middle_name", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("date of birth", 150, HorizontalAlignment.Center);
              listView1.Columns.Add("Position", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("Hourly_Rate", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("Salary", 100, HorizontalAlignment.Center);
              listView1.Columns.Add("Hired_date", 150, HorizontalAlignment.Center);
            employeeRepository = EmployeeRepository.Instance();
           
        }

   

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }



        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                decimal salary = decimal.Parse(monthlyTB.Text);
                hourlyTB.Text = (salary / 20 / 8).ToString();
                yearlyTB.Text = (salary * 12).ToString();

            }

        }

        private void save_draft_Click(object sender, EventArgs e)
        {  
            listView1.Items.Clear();
            
            DateTime db = dob.Value;
            DateTime hd = datehired.Value;
            employee = new Employee
            {
                Employee_ID = int.Parse(ID.Text),
                First_name = fname.Text,
                Last_name = lname.Text,
                Date_of_birth = db,
                Position = posTB.Text,
                Hourly_rate = decimal.Parse(hourlyTB.Text),
                Salary = decimal.Parse(monthlyTB.Text),
                Salary_per_yer = decimal.Parse(yearlyTB.Text),
                Hired_date = hd,
                Middle_name = midname.Text,
            };
            UpdateListView();
        }

        private void UpdateListView()
        {

              listView1.View = View.Details;



            ListViewItem item1 = new ListViewItem(employee.Employee_ID.ToString());
            item1.SubItems.Add(employee.First_name);
            item1.SubItems.Add(employee.Last_name);
            item1.SubItems.Add(employee.Middle_name);
            item1.SubItems.Add(employee.Date_of_birth.ToString());
            item1.SubItems.Add(employee.Position);
            item1.SubItems.Add(employee.Hourly_rate.ToString());
            item1.SubItems.Add(employee.Salary.ToString());
            item1.SubItems.Add(employee.Hired_date.ToString());
              listView1.Items.Add(item1);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (employee != null) { 
            int result= employeeRepository.Update(employee);
                if (result > 0)
                {
                    MessageBox.Show("record has been updated", "record saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    employee = null;
                }
                else {
                    MessageBox.Show("cannot update error found", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            employee = null;
        }
    }
}
