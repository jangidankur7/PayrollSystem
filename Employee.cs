using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    abstract class Employee
    {
        protected string EmpName;
        protected int EmpId;
        protected int age;

        public  Employee(string EmpName, int EmpId, int age)
        {
            this.EmpName = EmpName;
            this.EmpId = EmpId;
            this.age = age;

        }
        public abstract double getSal();
    }
}
