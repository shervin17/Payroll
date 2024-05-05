using System;

namespace PayrollV1
{
    public class PayrollPeriod
    {
        public int Payroll_Period_ID { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set;}
    }
}