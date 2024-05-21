using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollV1
{
    public class DTR
    {
       
        public int Employee_ID { get; set; }
        public DateTime Date { get; set; }  

        public DateTime Time_in { get; set; }
        public DateTime Time_out { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return $"DTR id= {Employee_ID}, date={Date}, Time_in= {Time_in} Time_out={Time_out} completed= {status}.";
        }
    }
}
