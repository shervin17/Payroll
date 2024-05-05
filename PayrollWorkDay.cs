using System;


namespace PayrollV1
{
    public class PayrollWorkDay
    {
        public int Payroll_period_ID { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set; }
        public DateTime Date {  get; set; }
        public decimal Rate { get; set; }   
        public string Comment { get; set; }
    }
}