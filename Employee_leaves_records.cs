using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollV1
{
    public class Employee_leaves_records
    {
        public int Employee_ID { get; set; }
        public decimal Accrued_sick_leave { get; set; }
        public decimal Accrued_vacation_leave { get;set; }

        public decimal Remaining_SL { get; set; }
        public decimal Remaining_VL { get; set;}
        public DateTime Records_updated_date { get; set; }
        public DateTime Start_date { get; set; }
    }
}
