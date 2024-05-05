using NodaTime;
using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1.SubForms
{
    public partial class EmployeeGenerator : Form
    {
        private Employee employee;
        EmployeeRepository employeeRepository;
        int latest_id;
        public EmployeeGenerator()
        {
            InitializeComponent();
            EmployeeListView.Columns.Add("employee_ID", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("first_name", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("last_name", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("middle_name", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("date of birth", 150, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("Position", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("Hourly_Rate", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("Salary", 100, HorizontalAlignment.Center);
            EmployeeListView.Columns.Add("Hired_date", 150, HorizontalAlignment.Center);
            employeeRepository = EmployeeRepository.Instance();
            ResetForm();
        }

        private void EmployeeGenerator_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Dispose(); 
        }

        private void salaryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)

            {
                try
                {
                    decimal salary=decimal.Parse(salaryTB.Text);
                    hourly_rateTB.Text = (salary/20/8).ToString();
                    yearlySalaryTB.Text = (salary * 12).ToString();
                }
                catch (Exception ex)
                {
                    salaryError.SetError(salaryTB, ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            resetFields();
        }
        private void resetFields() {

            fnameTB.Text = "";
            lnameTB.Text = "";
            datehired.Value=DateTime.Now;
            postionCb.Text = "";
            hourly_rateTB.Text = "";
            salaryTB.Text = "";
            yearlySalaryTB.Text = "";
            dob.Value = DateTime.Now;
            midnameTB.Text = "";
        }
        private void ResetForm() {
            Debug.WriteLine("ResetForm entered:");
            int latest_id = employeeRepository.GetLatestID();
            idTB.Text = (latest_id + 10).ToString();
            EmployeeListView.Items.Clear();
            employee = null;
            
           
        }

        private void save_draft_Click(object sender, EventArgs e)
        {   
            EmployeeListView.Items.Clear();

            DateTime db = dob.Value;
            DateTime hd = datehired.Value;
            employee = new Employee {
                Employee_ID = int.Parse(idTB.Text),
                First_name = fnameTB.Text,
                Last_name = lnameTB.Text,
                Date_of_birth = db,
                Position = postionCb.Text,
                Hourly_rate = decimal.Parse(hourly_rateTB.Text),
                Salary= decimal.Parse(salaryTB.Text),
                Salary_per_yer= decimal.Parse(yearlySalaryTB.Text),
                Hired_date= hd,
                Middle_name=midnameTB.Text,
            };
            resetFields();        
            UpdateListView();

        }
        private void UpdateListView() {

            EmployeeListView.View = View.Details;



            ListViewItem item1 = new ListViewItem(employee.Employee_ID.ToString());
            item1.SubItems.Add(employee.First_name);
            item1.SubItems.Add(employee.Last_name);
            item1.SubItems.Add(employee.Middle_name);
            item1.SubItems.Add(employee.Date_of_birth.ToString());
            item1.SubItems.Add(employee.Position);
            item1.SubItems.Add(employee.Hourly_rate.ToString());
            item1.SubItems.Add(employee.Salary.ToString());
            item1.SubItems.Add(employee.Hired_date.ToString());
            EmployeeListView.Items.Add(item1);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {

            /* int rows = employeeRepository.AddEmployee(employee);*/
            int rows = employeeRepository.Add(employee);
            if (rows > 0) {
                MessageBox.Show("save sucessfully");
                Debug.WriteLine("a record has been saved");
               ResetForm();
               
            }
            Debug.WriteLine("rows affected: "+rows);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            EmployeeListView.Items.Clear();
            employee = null;


        }
    }
}
