using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace PayrollV1
{
    public class PayrollTransactionRepository: Repository<PayrollTransactions,int>
    {

        public decimal getPayrollPeriodNetPayByID(int employee_id, int payroll_period) {
            decimal taxableIncome = 0m;
            try {
            using(SqlConnection conn= DBConnection.getConnection())
                {
                    string query= "select TaxableIncome from PayrollTransactions " +
                        "where Employee_ID = @empID and PayrollPeriod = @payrollPeriodID";
                    var parameters = new { empID = employee_id, payrollPeriodID = payroll_period };

                     taxableIncome= conn.QueryFirstOrDefault<decimal>(query, parameters);

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return taxableIncome;
        }
    }
}
