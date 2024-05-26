using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PayrollV1
{
    public class WorkDaysRepository : Repository <Workdays,int>
    {

        public List<Workdays> findByPayrollPeriod(Payroll_Period payroll_period) {

            List<Workdays> list = new List<Workdays>();

            SqlConnection sqlConnection = DBConnection.getConnection();
            string sql_Query = "select * from workdays where date between @dateFrom and @dateTo";

            using(sqlConnection)
            {
              list= sqlConnection.Query<Workdays>(sql_Query, 
                    new { 
                    @dateFrom =payroll_period.Date_from,
                    @dateTo =payroll_period.Date_to,
                    }).ToList();

            }

            return list;
        }


    }
}
