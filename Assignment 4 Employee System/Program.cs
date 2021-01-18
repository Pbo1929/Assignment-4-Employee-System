using System;

namespace Assignment_4_Employee_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Toy = new Employee("Toy", new DateTime(2004, 1, 18),"Student",13);
            Toy.SetJob("Plumber");
            Toy.SetSalary(6);
            Toy.SetName("Fake Toy");
            Console.WriteLine(Toy.GetMonthlySalary());
            Console.WriteLine(Toy.isBirthday());
            Console.WriteLine(Toy.GetYearsUntilRetirement());

            Employee Ankit = new Employee("Ankit", new DateTime(2004, 10, 25), "Pilot", 1231);
            Console.WriteLine(Employee.EmployeeCount);
        }
    }
}
