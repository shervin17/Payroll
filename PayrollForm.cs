using PayrollV1.Models;
using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        LeavesRepo leavesRepo = new LeavesRepo();
        Employee_leaves_records leaves;
        int allowed_incentive_days;
        private int no_of_incentives;
        private IncentiveUse incentiveUse;
        PayrollTransactions payrollTransaction;
        PayrollTransactionRepository payrollTransactionRepository= new PayrollTransactionRepository();

        public PayrollForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*displayWithholdingTax();*/

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
            if (employee1 == null)
                return;
            if (leaves.Remaining_VL == 0) { 
             VL_numeric.Enabled = false;
            }
            if (leaves.Remaining_SL == 0) { 
             SLnumeric.Enabled = false;
            }
            leaves_label.Text = "leaves: VL : " + (int)leaves.Remaining_VL + "  SL : " + (int)leaves.Remaining_SL + " ";
            payrollCalculator = new PayrollCalculator(employee1);
            dtr_List = dtrRepo.retrieveAllDTR(selected_payroll_period, employee1.Employee_ID);
            workdays = WorkDaysRepository.findByPayrollPeriod(selected_payroll_period);
            workdays_field.Text = workdays.Count.ToString();
            allowed_incentive_days = (workdays.Count - dtr_List.Count);
            days_absent_field.Text = allowed_incentive_days.ToString();
            
            grosspay = payrollCalculator.computeTaxableIncome(dtr_List, workdays);
            Monthly_field.Text = grosspay.Total_Income.ToString();
            decimal taxable = grosspay.Total_Income - grosspay.total_late_deductions;
            income_field.Text = taxable.ToString();
            OTPay_field.Text = grosspay.Total_OverTime_Pay.ToString();
            displayWithholdingTax();
            late_field.Text = grosspay.Total_late_in_mins.ToString();
            late_deductions_field.Text = grosspay.total_late_deductions.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {   //search ID button;
            int.TryParse(id_field.Text, out int id);
            EmployeeRepository employeeRepository = EmployeeRepository.Instance();
            employee1= employeeRepository.findById(id);
            leaves = leavesRepo.findById(employee1.Employee_ID);
            dataGridView1.DataSource = new List<Employee_leaves_records>() { leaves };
            setFields();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
           selected_payroll_period= payroll_Periods[index];
           

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void days_absent_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void non_working__day_incentve_ValueChanged(object sender, EventArgs e)
        {
            
            incentive_amount_label.Text = "incentive amount : " + non_working__day_incentve.Value * employee1.Hourly_rate * 8;
            
        }//disregard

        private void non_working__day_incentve_ValueChanged_1(object sender, EventArgs e)
        {


            no_of_incentives = (int)(non_working__day_incentve.Value + SLnumeric.Value + VL_numeric.Value);
            if(VL_numeric.Value > leaves.Remaining_VL)
            {
                VL_numeric.Value = 0;
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(VL_numeric, "cannot exceed available VLs");
                
            }

            if (SLnumeric.Value > leaves.Remaining_SL)
            {
                SLnumeric.Value = 0;
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(SLnumeric, "cannot exceed available SLs");
            }

            if (no_of_incentives > allowed_incentive_days) {
                MessageBox.Show("you can only put incentives " + allowed_incentive_days + " times");
                non_working__day_incentve.Value = 0;
                SLnumeric.Value = 0;
                VL_numeric.Value = 0;
                no_of_incentives = 0;
            
            }
            if (no_of_incentives > 0)
            {
                incentive_amount_label.Text = "incentive amount : " + no_of_incentives * employee1.Hourly_rate * 8;
            }
            else {
                incentive_amount_label.Text = "incentive amount : ";
            }


        }

        private void incentive_amount_label_Click(object sender, EventArgs e)
        {

        }

        private void apply_incentivesBTN_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("this may consume vl or sl. proceed?","apply leaves?",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Cancel) {
                return;
            }
            decimal total_incentives = (no_of_incentives * employee1.Hourly_rate * 8);
            total_incentivesTB.Text = total_incentives.ToString();
            decimal adjustedMonthly = grosspay.Total_Income + total_incentives;
            adjMonthly.Text = adjustedMonthly.ToString();
            decimal adjTaxable = adjustedMonthly - grosspay.total_late_deductions;
            adjTaxable_field.Text = adjTaxable.ToString();


            //update the adj withholding tax
         
            WithholdingTaxCalculator calculator = new WithholdingTaxCalculator();
            decimal result = calculator.getSemiMonthlyTax(adjTaxable);
            decimal adjustedWithholdingTax = result;
            adjWttax.Text= adjustedWithholdingTax.ToString();

            decimal net_pay = adjTaxable - adjustedWithholdingTax;
            net_pay_field.Text= net_pay.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Transact Payroll? ", "Proceed?",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Cancel) {
                return;
            }
            if (AddPayrollTransaction() > 0) {
                MessageBox.Show("payroll transaction saved");
                if(incentiveUse!=null)
                {
                    Employee_leaves_records forUpdate = new Employee_leaves_records()
                    {
                        Employee_ID = leaves.Employee_ID,
                        Accrued_sick_leave= leaves.Accrued_sick_leave,
                        Accrued_vacation_leave= leaves.Accrued_vacation_leave,
                        Remaining_VL = leaves.Remaining_VL - incentiveUse.VLused,
                        Remaining_SL = leaves.Remaining_SL - incentiveUse.SLused,
                        Records_updated_date= leaves.Records_updated_date,
                        Start_date= leaves.Start_date,
                    };
                    if (leavesRepo.Update(forUpdate) > 0) {
                        MessageBox.Show("leaves updated");
                    }
                    
                }
            }
        }
        private int AddPayrollTransaction() {
            int affectedRows = 0;


            if (no_of_incentives == 0)
            {
                payrollTransaction = new PayrollTransactions() {
                    Employee_ID = employee1.Employee_ID,
                    PayrollPeriod = selected_payroll_period.Payroll_Period_ID,
                    ApproxSalary = Math.Round(decimal.Parse(Monthly_field.Text),2),
                OT_pay= Math.Round(decimal.Parse(OTPay_field.Text),2),
                Workdays= int.Parse(workdays_field.Text),
                DaysAbsent= int.Parse(days_absent_field.Text),
                TotalMinsLate= int.Parse(late_field.Text),
                LateDeductions=Math.Round(decimal.Parse(late_deductions_field.Text), 2),
                TaxableIncome= Math.Round(decimal.Parse(income_field.Text), 2),
                WithholdingTax= Math.Round(decimal.Parse(tax_field.Text), 2),
                Remarks = remarksTB.Text,
                };
            }
            else
            {
                payrollTransaction = new PayrollTransactions() {
                    Employee_ID = employee1.Employee_ID,
                    PayrollPeriod = selected_payroll_period.Payroll_Period_ID,
                    ApproxSalary =Math.Round(decimal.Parse(adjMonthly.Text)),
                    OT_pay = Math.Round(decimal.Parse(OTPay_field.Text),2),
                    Workdays = int.Parse(workdays_field.Text),
                    DaysAbsent = int.Parse(days_absent_field.Text),
                    TotalMinsLate = int.Parse(late_field.Text),
                    LateDeductions = Math.Round(decimal.Parse(late_deductions_field.Text), 2),
                    TaxableIncome = Math.Round(decimal.Parse(adjTaxable_field.Text),2),
                    WithholdingTax = Math.Round(decimal.Parse(adjWttax.Text),2),
                    VLUsed= int.Parse(VL_numeric.Value.ToString()),
                    SLUsed= int.Parse(SLnumeric.Value.ToString()),
                    TotalIncentive=Math.Round(decimal.Parse(total_incentivesTB.Text),2),
                    Remarks=remarksTB.Text,
                };
                incentiveUse = new IncentiveUse() 
                {
                    VLused= int.Parse(VL_numeric.Value.ToString()),
                    SLused = int.Parse(SLnumeric.Value.ToString())
                };
            }
            MessageBox.Show(payrollTransaction.ToString());

            if (incentiveUse != null) { 
                MessageBox.Show(incentiveUse.ToString());
            }
           affectedRows=payrollTransactionRepository.Add(payrollTransaction);

            return affectedRows;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage selectedTabPage = tabControl.SelectedTab;
            if (selectedTabPage != tabPage2)
                return;

            if (selected_payroll_period == null || payroll_Periods == null)          
                return;
            int limit = payroll_Periods.IndexOf(selected_payroll_period);
            if(limit == 0)
            {
                MessageBox.Show("theres no payroll period before selected payroll period");
                return;
            }
            previousPayrollCB.Items.Clear();

            for (int i = 0; i < limit; i++)
            { 
                previousPayrollCB.Items.Add(payroll_Periods[i]);
            }
        }
    }


    public class IncentiveUse {
        public int VLused { get; set; }
        public int SLused { get; set; }

        public override string ToString() {

            return " IncentiveUse [ VLused= " + VLused + ", SLused =" + SLused + " ] "; 
        }
    }
    }
    



