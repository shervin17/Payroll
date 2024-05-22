using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;

namespace PayrollV1
{
    public partial class ViewDTRForm : Form
    {
        List<Payroll_Period> payrollPeriodList= new List<Payroll_Period>();
        PayrollPeriodRepo payrollPeriodRepo= new PayrollPeriodRepo();
        Payroll_Period selected;
        public ViewDTRForm()
        {
            InitializeComponent();
        }

        private void ViewDTRForm_Load(object sender, EventArgs e)
        {
            period_options.Items.Clear();
            period_options.Focus();
            payrollPeriodList = payrollPeriodRepo.findAll();
            payrollPeriodList.ForEach(element => {
                period_options.Items.Add(element);

            });
        }

        private void period_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = period_options.SelectedIndex;
            selected = payrollPeriodList[selected_index];
            

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("date from: ");
            stringBuilder.Append(selected.Date_from);
            stringBuilder.Append("    date to: ");
            stringBuilder.Append(selected.Date_to);
            label_date.Text=stringBuilder.ToString();
            
            using(SqlConnection connection= DBConnection.getConnection())
            {

                string sql = "select * from dtr where date between @dateFrom and @dateTo and employee_ID = @empID";
                var obj = new {
                    dateFrom = selected.Date_from,
                    dateTo = selected.Date_to,
                    empID = LoggedInEmployee.Logged_in_employee.Employee_ID
                };
              List<DTR> list=  connection.Query<DTR>(sql, obj).ToList();
                if(list.Count > 0)
                {
                    dataGridView1.DataSource = list;
                }
            }
        }
    }
}
