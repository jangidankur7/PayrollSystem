using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class SalariedEmp : Employee
    {
        double EmpSalary;

        public SalariedEmp(string EmpName, int EmpId, int age, double EmpSalary) : base(EmpName, EmpId, age)
        {
            this.EmpSalary = EmpSalary;
        }

        public override double getSal()
        {
            if (this.EmpSalary < 4000)
                return 4000;
            else if (this.EmpSalary > 20000)
                return 20000;
            else
                return this.EmpSalary;

        }

        public override string ToString()
        {
           return "Employee name: " + EmpName + ", " + "EmpID: " + EmpId + ", " + "Age: " + age + ", " + "Salary: " + getSal();
        }
    }
}
