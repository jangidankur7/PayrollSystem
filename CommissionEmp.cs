using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class CommissionEmp : Employee
    {
        double sale;
        double comRate = 0.10;

        public  CommissionEmp(string EmpName, int EmpId, int age, double sale) : base(EmpName, EmpId, age)
        {
            this.sale = sale;
        }

        
        public override double getSal()
        {
            if (this.sale*comRate < 20000)
            {
                return 20000;
            }
            else
            return Math.Round(sale * comRate);
        }
        
        public override string ToString()
        {
            return "Employee name: " + EmpName + ", " + "EmpID: " + EmpId + ", " + "Age: " + age + ", " + "Salary: " + getSal();
        }
    }
}
