using System;

namespace PayrollV1
{
    public class PagIbigContributionCalculator
    {
        private const decimal MinContribution = 200m;
        private const decimal EmployerRate = 0.02m;
        private const decimal EmployeeRateBelow1500 = 0.01m;
        private const decimal EmployeeRateAbove1500 = 0.02m;

        public static PagIbigContribution GetPagIbigContribution(decimal income)
        {
            decimal contributionRate = income >= 1500m ? EmployeeRateBelow1500 : EmployeeRateAbove1500;

            // Calculate employee contribution
            decimal employeeContribution = income * contributionRate;
            if (employeeContribution < MinContribution)
            {
                employeeContribution = MinContribution;
            }

            // Calculate employer contribution
            decimal employerContribution = employeeContribution > MinContribution ? income * EmployerRate : MinContribution;

            // Calculate total contribution
            decimal totalContribution = employeeContribution + employerContribution;

            PagIbigContribution pagIbigContribution = new PagIbigContribution()
            {
                EmployeeShare =Math.Round(employeeContribution,2),
                EmployerShare = Math.Round(employerContribution,2),
                TotalContribution = Math.Round(totalContribution,2),
            };

            return pagIbigContribution;
        }
    }

    public class PagIbigContribution
    {
        public decimal EmployeeShare { get; set; }
        public decimal EmployerShare { get; set; }
        public decimal TotalContribution { get; set; }
    }
}
