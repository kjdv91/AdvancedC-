using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRAdministration
{
    public enum EmployeeType {
        Teacher,
        HeadOfDeparment,
        DeputyHeadMaster,
        HeadMaster
    }
    public class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);
            foreach (IEmployee employee in employees)
            {
                totalSalaries += employee.Salary;
            }
            Console.WriteLine($"Total Anual salaries (incluiding bonus): {totalSalaries}");
            Console.WriteLine($"Total Anual Salaries: {employees.Sum(x => x.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData (List<IEmployee> employees)
        {
            IEmployee teacherOne = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Klark", 400000);
            employees.Add(teacherOne);

            IEmployee headOfDeparment = new HeadOfDeparment
            {
                Id = 2,
                FirstName = "Lucas",
                LastName = "Sosa",
                Salary = 33000
            };

            employees.Add(headOfDeparment);

            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 3, "Franklin", "Congo", 5500);

            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 4,
                FirstName = "Damien",
                LastName = "Jones",
                Salary = 8000

            };

            employees.Add(headMaster);
            

            



        }
    }


    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class HeadOfDeparment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public static class EmployeeFactory
    {
        // una clase estatica no puede ser instanciada
        public static IEmployee GetEmployeeInstance
            (EmployeeType employeeType, int id, string firstName,
            string lastName, decimal salary
            )
        {
            IEmployee employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                    
                    break;

                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                    break;

                case EmployeeType.HeadOfDeparment:
                    employee = new HeadOfDeparment
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;

                case EmployeeType.HeadMaster:
                    employee = new HeadMaster
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                default:
                    break;
            }
            return employee;
        }

    }
}
