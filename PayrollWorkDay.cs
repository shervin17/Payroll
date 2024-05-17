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

        public override string ToString()
        {
            return "[PayrollWorkDay: "+ this.Payroll_period_ID + "\t"+ Date_from + "\t" + Date_to + "\t" + Date + "\t"+
                Rate +"\t"+ Comment;
        }
    }
}