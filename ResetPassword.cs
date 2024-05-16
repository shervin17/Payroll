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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void searchAllBtn_Click(object sender, EventArgs e)
        {
            employee_loginsList = repo.findAll().ToList();
        }
    }
}
