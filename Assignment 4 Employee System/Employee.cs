using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_Employee_System
{
    class Employee
    {
        private string Name;
        private int Age;
        private DateTime Dob;
        private string Job;
        private double Salary;

        public static int EmployeeCount;
        private static int RetirementAge = 65;

        public Employee(string _Name, int _Age, DateTime _Dob, string _Job, double _Salary)
        {
            this.Name = _Name;
            this.Age = _Age;
            this.Salary = _Salary;
            this.Job = _Job;
            Dob = _Dob;

            //EmployeeCount = EmployeeCount + 1
            //EmployeeCount += 1;
            EmployeeCount++; // These are all the same!

        }

        public double GetMonthlySalary()
        {
            double MonthlySalary = Salary / 12;
            return MonthlySalary;
        }

        public bool isBirthday()
        {
            int month = Dob.Month;
            int day = Dob.Day;

            if(month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetAge()
        {
                               //2021 - 2004 = 17
            Age = DateTime.Now.Year - Dob.Year;
        }

        public int GetYearsUntilRetirement()
        {
            SetAge();

            // 65 - 17 = 48
            int YearsUntilRetirement = RetirementAge - Age;
            return YearsUntilRetirement;
        }

        public string GetInformation()
        {
            string information = Name + Age + Job + Salary;
            return information;
        }

        //mutator methods
        public void SetJob(string newJob)
        {
            Job = newJob;
        }
        public void SetSalary(double newSalary)
        {
            Salary = newSalary;
        }

        public void SetName(string newName)
        {
            Name = newName;
        }
    }
}
