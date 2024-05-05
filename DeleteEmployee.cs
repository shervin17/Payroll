using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace PayrollV1
{
    public partial class DeleteEmployee : Form
    {
        EmployeeRepository employeeRepository = EmployeeRepository.Instance();
        DataTable dataTable = new DataTable();
        Employee employee;
        DataRow dataRow;
        int id;
        public DeleteEmployee()
        {
            InitializeComponent();
            dataTable.Columns.Add("employee_ID", typeof(int));
            dataTable.Columns.Add("first_name", typeof(string));
            dataTable.Columns.Add("last_name", typeof(string));
            dataTable.Columns.Add("date_of_birth", typeof(DateTime));
            dataTable.Columns.Add("position", typeof(string));
            dataTable.Columns.Add("hourly_rate", typeof(decimal));
            dataTable.Columns.Add("salary", typeof(decimal));
            dataTable.Columns.Add("salary_per_year", typeof(decimal));
            dataTable.Columns.Add("hired_date", typeof(string));
            dataTable.Columns.Add("middle_name", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            dataTable.Rows.Clear();
            dataGridView2.DataSource = null;
            deleteBtn.Enabled = false;
            id = int.Parse(textBox1.Text);
            employee=employeeRepository.findById(id);
            if(employee == null){
                MessageBox.Show("Record not found!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataRow = getDataRow();
            dataTable.Rows.Add(dataRow);
            dataGridView1.DataSource = dataTable;
        }
        private DataRow getDataRow()
        {

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
            return data;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            if (employee == null) {
                MessageBox.Show("Cannot delete, please supply the employee a valid employee ID");
                return;
            }
           DialogResult result= MessageBox.Show("A record will be deleted. Do you wish to proceed?","Delete record?",MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return;
            }
           
          int rowsAffected= employeeRepository.DeleteById(id);
            if (rowsAffected > 0)
                MessageBox.Show("A record has been deleted successfully");
            else
                MessageBox.Show("Sorry an error has occured","Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridView2.DataSource = null;
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            deleteBtn.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {   //save as draft
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = dataTable;
            deleteBtn.Enabled = true;
        }

        private void reset_MouseEnter(object sender, EventArgs e)
        {
            reset.BackColor = Color.MidnightBlue;
            reset.ForeColor = Color.AliceBlue;
            reset.FlatAppearance.BorderColor = Color.White;
        }

        private void reset_MouseLeave(object sender, EventArgs e)
        {
            reset.BackColor = Color.AliceBlue;
            reset.ForeColor = Color.MidnightBlue;
            reset.FlatAppearance.BorderColor = Color.MidnightBlue;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            employee = null;
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            employee = null;
            textBox1.Text = "";
            dataGridView2.DataSource = dataTable;
        }
    }
}
