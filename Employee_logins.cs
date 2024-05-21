namespace PayrollV1
{
    public class Employee_logins
    {
            public int employee_ID { get; set; }
            public string username { get; set; }
            public string password { get; set; }

        public override string ToString()
        {
            return $"Employee Logins [ {employee_ID}, {username} ,{password} ]";
        }
    }
}