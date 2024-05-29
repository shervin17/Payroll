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
        public decimal SSS_deduction { get; set; }
        public decimal SSS_comShare { get; set; }
        public decimal Philhealth_deduction { get; set; }
        public decimal Philhealth_comShare { get; set; }
        public decimal PagIbigDeduction { get; set; }   
        public decimal PagIbig_ComShare { get; set; }   
        public decimal Total_benefits_Deduction { get; set; }
        public decimal netPay { get; set; }


        public override string ToString()
        {
            return $"TransactionID: {TransactionID}, " +
                   $"Employee_ID: {Employee_ID}, " +
                   $"PayrollPeriod: {PayrollPeriod}, " +
                   $"ApproxSalary: {ApproxSalary}, " +
                   $"OT_pay: {OT_pay}, " +
                   $"Workdays: {Workdays}, " +
                   $"DaysAbsent: {DaysAbsent}, " +
                   $"TotalMinsLate: {TotalMinsLate}, " +
                   $"LateDeductions: {LateDeductions}, " +
                   $"TaxableIncome: {TaxableIncome}, " +
                   $"WithholdingTax: {WithholdingTax}, " +
                   $"VLUsed: {VLUsed}, " +
                   $"SLUsed: {SLUsed}, " +
                   $"TotalIncentive: {TotalIncentive}, " +
                   $"SSS: {SSS}, " +
                   $"Philhealth: {Philhealth}, " +
                   $"PagIbig: {PagIbig}, " +
                   $"Remarks: {Remarks}, " +
                   $"SSS_deduction: {SSS_deduction}, " +
                   $"SSS_comShare: {SSS_comShare}, " +
                   $"Philhealth_deduction: {Philhealth_deduction}, " +
                   $"Philhealth_comShare: {Philhealth_comShare}, " +
                   $"PagIbigDeduction: {PagIbigDeduction}, " +
                   $"PagIbig_ComShare: {PagIbig_ComShare}, " +
                   $"Total_benefits_Deduction: {Total_benefits_Deduction}, " +
                   $"netPay: {netPay}";
        }

    }

}