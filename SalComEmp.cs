using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class SalComEmp : Employee
    {
        double baseSalary;
        double Sales;
        double ComRate = 0.10;

        public SalComEmp(string EmpName, int EmpId, int age, double baseSalary ,double Sales) : base(EmpName, EmpId, age)
        {
            this.baseSalary = baseSalary;
            this.Sales = Sales;
        }


        public override double getSal()
        {
            double sal = this.baseSalary + (this.Sales * this.ComRate);
            if (sal > 20000)
                return 20000;
            else
                return Math.Round(sal);

        }
        public override string ToString()
        {
            return "Employee name: " + EmpName + ", " + "EmpID: " + EmpId + ", " + "Age: " + age + ", " + "Salary: " + getSal();
        }
    }
}
