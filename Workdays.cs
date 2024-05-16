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
    }
}