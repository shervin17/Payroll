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

namespace PayrollV1
{
    public partial class viewAndUpdateEmployee : Form
    {
        EmployeeRepository employeeRepository = EmployeeRepository.Instance();
        DataTable dataTable = new DataTable();
        Models.Employee.Employee employee;
        public viewAndUpdateEmployee()
        {
            InitializeComponent();
            dataTable.Columns.Add("employee_ID", typeof(int));
            dataTable.Columns.Add("first_name", typeof(string));
            dataTable.Columns.Add("last_name", typeof(string));
            dataTable.Columns.Add("date_of_birth", typeof(DateTime));
            dataTable.Columns.Add("position",typeof(string));
            dataTable.Columns.Add("hourly_rate",typeof(decimal));
            dataTable.Columns.Add("salary",typeof(decimal));
            dataTable.Columns.Add("salary_per_year",typeof(decimal));
            dataTable.Columns.Add("hired_date",typeof(string));
            dataTable.Columns.Add("middle_name",typeof(string));
            dataTable.Columns.Add("employment_status", typeof(string));

        }

        private void button1_Click(object sender, EventArgs e)
        {   //search using ID
            int employee_id = int.Parse(textBox1.Text);
            employee = employeeRepository.findById(employee_id);
            dataTable.Rows.Clear();
            if (employee != null)
            {
                dataTable.Rows.Add(getDataRow());
                dataGridView1.DataSource = dataTable;
            }
            else {
                MessageBox.Show("no record found");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {   //search all
            dataTable.Rows.Clear();
            List<Models.Employee.Employee> employees=employeeRepository.findAll();

            foreach (var employee in employees) {
            this.employee = employee;
            DataRow row= getDataRow();
            dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
            employee = null;
        }
        private DataRow getDataRow() {

            DataRow data = dataTable.NewRow();
            data["employee_id"] = employee.Employee_ID;
            data["first_name"] = employee.First_name;
            data["last_name"] = employee.Last_name;
            data["date_of_birth"] = employee.Date_of_birth;
            data["position"] = employee.Position;
            data["hourly_rate"] = employee.Hourly_rate;
            data["salary"] = employee.Salary;
            data["salary_per_year"] = employee.Salary_per_yer;
            data["hired_date"] = employee.Hired_date;
            data["middle_name"] = employee.Middle_name;
            data["employment_status"] = employee.Employment_status;
            return data;

        }

        private void viewAndUpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(employee != null)
            {
               new UpdateEmployee(employee).ShowDialog();

            }
        }
    }
}
