using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class DTRForm : Form
    {
        Employee employee;
        DTR dtr;
        EmployeeRepository employeeRepository= EmployeeRepository.Instance();
        Employee_loginsRepo loginsRepo = new Employee_loginsRepo();
        DTRrepository dtrRepo= DTRrepository.getInstance();
        string status= "incomplete";
        
        
        public DTRForm()
        {
            InitializeComponent();
            ID_field.Text = "1060";
            passwordField.Text = "Hanks@Password123";
        }

        private void DTRForm_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee = null;
            int.TryParse(ID_field.Text, out int id);
            string password = passwordField.Text;
            int found_ID = 0;
            List<Employee_logins> employee_loginList= loginsRepo.findAll();
            employee_loginList.ForEach(element => {
                if (element.employee_ID== id && element.password == password)
                {
                    found_ID = element.employee_ID;
                    employee = employeeRepository.findById(found_ID);
                    if (employee != null)
                    {
                        dtr = checkDTR(employee.Employee_ID,DateTime.Now);
                        Debug.WriteLine(dtr);
                        if (dtr == null && status == "incomplete") 
                        {
                            CaptureTimeIn();
                        }
                        else
                        {
                        if (dtr != null) {
                                CaptureTimeOut(dtr);
                            }
                            
                        }
                    }
                }
            });
            if (found_ID == 0)
            {
                MessageBox.Show("invalid username or password");
            }
        }
        private void CaptureTimeIn()
        {
            dtr = new DTR() {
                Employee_ID = employee.Employee_ID,
                Date = DateTime.Now,
                Time_in = DateTime.Now,
                Time_out = DateTime.Now,
                status= "incomplete",
            };

            List<DTR> myList = new List<DTR>();
            myList.Add(dtr);
            if (dtrRepo.AddAll(myList) > 0) {
                MessageBox.Show("time in saved");
                logsTB.Text = " time in saved " + dtr.ToString();
            }
            
        }

        private void CaptureTimeOut(DTR dtr_args)
        {

            DTR complete_DTR = dtr_args;
            complete_DTR.Time_out = DateTime.Now;
            complete_DTR.status = "completed";
            if (dtrRepo.UpdateDTR(complete_DTR) > 0)
            {
                MessageBox.Show("time out saved");
                logsTB.Text = " time out saved " + complete_DTR.ToString();
            }
           
        }
        private DTR checkDTR(int id,DateTime date) {
            DTR dtr = null;

            List<DTR> list= dtrRepo.findAll();
            Debug.WriteLine("checkpoint");
            list.ForEach(item => Debug.WriteLine(item));
            Debug.WriteLine(date);
            list.ForEach(item =>
            {
                if (item.Employee_ID == id && item.Date.Date == date.Date) {
                    if (item.status=="completed") {
                        MessageBox.Show("Seems like you have submitted your time in and time out");
                        string msg = $"time in: {item.Time_in.ToString()} and time out: {item.Time_out.ToString()}.";
                        logsTB.Text = msg;
                        status = "completed";
                        return;
                    }   
                    dtr=item;
                } 
            });
            MessageBox.Show((dtr == null).ToString());
            return dtr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DTRForm().Show();
            this.Hide();
            
        }
    }
}