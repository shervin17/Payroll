using PayrollV1.Models;
using PayrollV1.SubForms;
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
    public partial class AdminPage : Form  
    {
        Admin admin;
        public AdminPage(Admin admin)
        {
            InitializeComponent();
        this.admin = admin;
        label1.Text += admin.Firstname + " "+ admin.Lastname;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            new Login().Show();
        }

        private void createEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeGenerator em = new EmployeeGenerator();
            em.TopLevel = false;
            em.BringToFront();
            main_panel.Controls.Add(em);
            em.Show();
        }

        private void viewAndUpdatePayrollPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAndUpdatePayrollPeriod obj = new viewAndUpdatePayrollPeriod();
            obj.TopLevel = false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();
        }

        private void createPayrollWorkdaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createPayrollWorkdays obj = new createPayrollWorkdays();
            obj.TopLevel = false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();
        }

        private void viewAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAndUpdateEmployee obj = new viewAndUpdateEmployee();
            obj.TopLevel = false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee obj = new DeleteEmployee();
            obj.TopLevel= false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();
        }

        private void generateLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountGenerator obj = new AccountGenerator();
            obj.TopLevel = false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();
        }

        private void userCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPassword obj = new ResetPassword();
            obj.TopLevel = false;
            obj.BringToFront();
            main_panel.Controls.Add(obj);
            obj.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
