using System;
using System.Runtime.CompilerServices;

namespace PayrollV1
{
    public class Workdays
    {
       public int Payroll_period_ID { get; set; }
       public DateTime Date { get; set; }
       public  decimal Rate { get; set; }
       public string comment { get; set; }

        public override string ToString()
        {
            return ""+ Payroll_period_ID + "\t" + Date.ToString()  + "\t" + Rate.ToString() + "\t" + comment;
        }
    }

}