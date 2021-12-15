using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class HourlyEmp : Employee
    {
        double HourlyPay;
        double HoursWorked;
        double ExtraPay = 350;

        public HourlyEmp(string EmpName, int EmpId, int age, double HourlyPay, double HoursWorked) : base(EmpName, EmpId, age)
        {
            this.HourlyPay = HourlyPay;
            this.HoursWorked = HoursWorked;
        }

        public override double getSal()
        {
            double WeeklyHoursWorked = HoursWorked * 7;
           if (WeeklyHoursWorked < 30)
            {
                return 0;
            }
           else if (WeeklyHoursWorked > 50)
            {
                return 50*this.HourlyPay + (this.ExtraPay * 10);
            }
           if (WeeklyHoursWorked > 40)
            {
                return (this.HoursWorked * this.HourlyPay) + (40 - WeeklyHoursWorked) * this.ExtraPay;
            }
            else
            {
                return this.HoursWorked * this.HourlyPay;
            }
        }
        public override string ToString()
        {
            return "Employee name: " + EmpName + ", " + "EmpID: " + EmpId + ", " + "Age: " + age + ", " + "Salary: " + getSal();
        }
    }
}
