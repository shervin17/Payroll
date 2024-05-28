using PayrollV1.Models.Employee;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public class PayrollCalculator
    {
        private readonly TimeSpan shift_start= new TimeSpan(8,0,0);
        private readonly TimeSpan shift_end= new TimeSpan(17,0,0);
        private readonly int regular_shift_hr = 8;
        decimal hourly_rate;
        private readonly double mandatory_break_mins=60;

        public PayrollCalculator(Employee employee) {
            hourly_rate = employee.Hourly_rate;
        
        }
       
        public Grosspay computeTaxableIncome(List<DTR> dTRs,List<Workdays>  workDaysList)
        {
            decimal OT_Pay = 0;
            Debug.WriteLine(hourly_rate);
            decimal OT_Pay_Total = 0;
            decimal taxable_income = 0;
            int Total_late_mins = 0;
            decimal late_deductions = 0;
            int Total_OT_mins = 0;

            foreach (var dtr in dTRs)
            {
                foreach (var workday in workDaysList)
                {
                    if (dtr.Date.CompareTo(workday.Date) == 0)
                    {
                        DateTime expected = dtr.Date.Add(shift_start);
                        DateTime actual = dtr.Time_in;

                        int lateMins= GetLateMins(expected, actual);
                        if (lateMins > 0) {
                            Total_late_mins += lateMins;
                            late_deductions+=computeLateDeduction(lateMins);
                        }

                        int OTmins = getOTmins(dtr);
                        if (OTmins > 0) 
                        {
                            Total_OT_mins += OTmins;
                            OT_Pay = computeOTpay(OTmins);
                            OT_Pay_Total += OT_Pay*workday.Rate;
                        }


                        taxable_income += ((hourly_rate * regular_shift_hr) + OT_Pay) * workday.Rate;
                        OT_Pay = 0;
                        break;
                    }

                }
            }


            Grosspay grosspay = new Grosspay() {
                Total_Income = Math.Round(taxable_income, 2),
                Total_OT_in_mins = Total_OT_mins,
                Total_OverTime_Pay = Math.Round(OT_Pay_Total, 2),
                total_late_deductions = Math.Round(late_deductions, 2),
                Total_late_in_mins = Total_late_mins,
            };

            return grosspay ;
        }



        public int getOTmins(DTR dTR)
        {  
            DateTime current_date= dTR.Date;
            DateTime current_shift_end= current_date.Add(shift_end);
            int OT_mins=(int) (dTR.Time_out- current_shift_end).TotalMinutes;
            if (OT_mins < 60)
                return 0;
            return OT_mins;
        }
        public int GetLateMins(DateTime expected, DateTime actual) {

            TimeSpan lateness = actual - expected;

            int late_mins = (int)lateness.TotalMinutes;

            if (late_mins <= 5) {

                return 0;
            }  

            return late_mins;
        }
        public decimal computeLateDeduction(int minutes) {
            decimal deduction_per_minute = Math.Round(hourly_rate / 60);
            return deduction_per_minute * minutes;
        }

        public decimal computeOTpay(int minutes) {
            decimal rate_per_30mins = hourly_rate / 2;
            int payable_30_mins_instances = minutes / 30;
            return payable_30_mins_instances * rate_per_30mins;
        }
    }

    public class Grosspay { 
    public decimal Total_OverTime_Pay { get; set; }
    public decimal Total_Income { get; set; }

    public int Total_OT_in_mins { get; set; }

    public int Total_late_in_mins { get;set; }

    public decimal total_late_deductions { get; set; }  
        override
        public string ToString() {

            return " Grosspay [ "+ Total_OverTime_Pay + ", " + Total_Income + ", " + Total_OT_in_mins +" ]";
                }
    }
}

//HoursWorked , OT hoursWorked, 
//late is for every 15 mins late ,  ot is for evert 30 mins, 