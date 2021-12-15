using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee ID");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name of Employee");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());

            Employee emp = null;

            if(age < 18 || age > 60)
            {
                Console.WriteLine("Age must be between 18 and 60");
            }
            else
            {
                Console.WriteLine("Chose Type of Employee : 1.Salaried \n 2.Hourly Employee \n 3. Commissioned Employee \n4. Salaried + Commission Empliyee");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("You chose Salaried Employee");
                        Console.WriteLine("Enter Weekly Base Salary of Employee");
                        double wbs = double.Parse(Console.ReadLine());

                        emp = new SalariedEmp(name, id, age, wbs);
                        Console.WriteLine(emp.ToString());
                        Console.WriteLine("------------------------");
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.WriteLine("Ypu chose Hourly Employee");
                        Console.WriteLine("Enter Hourly Wage between 200 and 400");
                        int wage = int.Parse(Console.ReadLine());

                        if(wage > 400 || wage < 200)
                        {
                            Console.WriteLine("Wage is not in limit");
                        }
                        else
                        {
                           
                            Console.WriteLine("Enter Working hours");
                            double hr = double.Parse(Console.ReadLine());
                            emp = new HourlyEmp(name, id, age, wage, hr);
                            Console.WriteLine(emp.ToString());
                            
                        }
                        Console.WriteLine("--------------");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("You chose Commissioned Employee");
                        Console.WriteLine("Commission Rate is 10% fixed");
                        Console.WriteLine( "Enter Total sale");

                        double sa = double.Parse(Console.ReadLine());

                        emp = new CommissionEmp(name, id, age, sa);
                        Console.WriteLine(emp.ToString());
                        Console.WriteLine();
                        Console.WriteLine("----------------");
                        break;

                    case 4:
                        Console.WriteLine("You chose Salary+ Commissioned Emp");
                        Console.WriteLine("Enter Base salary");
                        double sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter toal sales");
                        double sale = double.Parse(Console.ReadLine());

                        emp = new SalComEmp(name, id, age, sal, sale);

                        Console.WriteLine(emp.ToString());
                        break;

                    default:
                        Console.WriteLine("Wrong Option");
                        break;


                }
            }
        }
    }
}
