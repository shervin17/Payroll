using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace PayrollV1.Models.Employee
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string First_name { get; set; }

        public string Last_name { get; set; }

        public DateTime Date_of_birth { get; set; }
        
        public string Position { get; set; }

        public decimal Hourly_rate { get; set; }

        public decimal Salary { get; set; }

        public decimal Salary_per_yer { get; set; }

        public DateTime Hired_date { get; set; }

        public string Middle_name {get; set; }

        public string Employment_status { get; set; }

        public override string ToString()
        {
            return "[Employee {" + Employee_ID + " , " + First_name + " , " + Last_name + ", " + "and so on}]";
        }
    }
}
