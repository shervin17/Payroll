using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class PayrollForm : Form
    {
        Employee employee1;
        PayrollCalculator payrollCalculator;
        List<Payroll_Period> payroll_Periods = new List<Payroll_Period>();
        PayrollPeriodRepo payrollPeriodRepo = new PayrollPeriodRepo();
        Payroll_Period selected_payroll_period;
        List<DTR> dtr_List= new List<DTR>();
        DTRrepository dtrRepo= DTRrepository.getInstance();
        Grosspay grosspay= new Grosspay();
        List<Workdays> workdays = new List<Workdays>();
        WorkDaysRepository WorkDaysRepository = new WorkDaysRepository();
        public PayrollForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayWithholdingTax();

        }

        private void displayWithholdingTax() {

            decimal.TryParse(income_field.Text, out decimal value);
            WithholdingTaxCalculator calculator = new WithholdingTaxCalculator();
            decimal result = calculator.getSemiMonthlyTax(value);
            tax_field.Text = result.ToString();

        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            /* setFields();*/
            payroll_Periods = payrollPeriodRepo.findAll();
            comboBox1.Items.AddRange(payroll_Periods.ToArray());




        }

        private void setFields() {
            id_field.Text = employee1.Employee_ID.ToString();
            fname_field.Text = employee1.First_name;
            midname_field.Text = employee1.Middle_name;
            lname_field.Text = employee1.Last_name;
            position_field.Text = employee1.Position;
            hourly_Rate_field.Text = employee1.Hourly_rate.ToString();
            salary_field.Text = employee1.Salary.ToString();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            int.TryParse(id_field.Text, out int id);
            EmployeeRepository employeeRepository = EmployeeRepository.Instance();
            employee1= employeeRepository.findById(id);
            setFields();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
           selected_payroll_period= payroll_Periods[index];

            if (employee1 == null)
                return;
            payrollCalculator= new PayrollCalculator(employee1);
           dtr_List  =dtrRepo.retrieveAllDTR(selected_payroll_period,employee1.Employee_ID);
            workdays= WorkDaysRepository.findByPayrollPeriod(selected_payroll_period);

            grosspay = payrollCalculator.computeTaxableIncome(dtr_List, workdays);
            Monthly_field.Text=grosspay.Total_Income.ToString();
            decimal taxable =grosspay.Total_Income - grosspay.total_late_deductions;
            income_field.Text= taxable.ToString();
            OTPay_field.Text = grosspay.Total_OverTime_Pay.ToString();
            displayWithholdingTax();
            late_field.Text= grosspay.Total_late_in_mins.ToString();
            late_deductions_field.Text= grosspay.total_late_deductions.ToString();
        }
    }
}
