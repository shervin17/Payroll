using System;

namespace PayrollV1
{
    public class Payroll_Period
    {
        public int Payroll_Period_ID { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set;}

        override
        public string ToString() { 
        return "\t"+ Date_from.ToString("MM/dd/yyyy") + "\t :" + Date_to.ToString("MM/dd/yyyy") + " ";
        
        }
    }
}