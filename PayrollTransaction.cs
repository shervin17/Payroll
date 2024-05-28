using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollV1
{
public class PayrollTransactions
    { 
        //18 fields
        public int TransactionID { get; set; }
        public int Employee_ID { get; set; }
        public int PayrollPeriod { get; set; }
        public decimal ApproxSalary { get; set; }
        public decimal OT_pay { get; set; }
        public int Workdays { get; set; }
        public int DaysAbsent { get; set; }
        public int TotalMinsLate { get; set; }
        public decimal LateDeductions { get; set; }
        public decimal TaxableIncome { get; set; }
        public decimal WithholdingTax { get; set; }
        public int VLUsed { get; set; }
        public int SLUsed { get; set; }
        public decimal TotalIncentive { get; set; }
        public decimal SSS { get; set; }
        public decimal Philhealth { get; set; }
        public decimal PagIbig { get; set; }
        public string Remarks { get; set; }

        public override string ToString()
        {
            return $"Transaction ID: {TransactionID}\n" +
                   $"Employee ID: {Employee_ID}\n" +
                   $"Payroll Period: {PayrollPeriod}\n" +
                   $"Approximate Salary: {ApproxSalary}\n" +
                   $"OT Pay: {OT_pay}\n" +
                   $"Workdays: {Workdays}\n" +
                   $"Days Absent: {DaysAbsent}\n" +
                   $"Total Minutes Late: {TotalMinsLate}\n" +
                   $"Late Deductions: {LateDeductions}\n" +
                   $"Taxable Income: {TaxableIncome}\n" +
                   $"Withholding Tax: {WithholdingTax}\n" +
                   $"Vacation Leave Used: {VLUsed}\n" +
                   $"Sick Leave Used: {SLUsed}\n" +
                   $"Total Incentive: {TotalIncentive}\n" +
                   $"SSS: {SSS}\n" +
                   $"Philhealth: {Philhealth}\n" +
                   $"PagIbig: {PagIbig}\n" +
                   $"Remarks: {Remarks}";
        }

    }

}