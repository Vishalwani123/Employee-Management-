using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage ew = new EmployeeWage();

            Console.WriteLine();
            Console.WriteLine("Employee Wage System : ");

            Console.WriteLine();
            Console.WriteLine(" Checking Employee Attendance...");
            bool isPresent = ew.IsEmployeePresent();
            Console.WriteLine(isPresent ? "Employee is Present" : "Employee is Absent");

            if (isPresent)
            {
                Console.WriteLine("Calculating Daily Wage...");
                int dailyWage = ew.CalculateDailyWage(EmployeeWage.FullDayHours);
                Console.WriteLine($"Daily Wage: {dailyWage}");
            }

            Console.WriteLine();
            Console.WriteLine("Adding Part-Time Employee & Calculating Daily Wage...");
            int partTimeWage = ew.CalculateDailyWage(EmployeeWage.PartTimeHours);
            Console.WriteLine($"Part-Time Daily Wage: {partTimeWage}");

            Console.WriteLine();
            Console.WriteLine("Calculating Monthly Wage...");
            int monthlyWage = ew.CalculateMonthlyWage();
            Console.WriteLine($"Monthly Wage (Full-Time): {monthlyWage}");

            Console.WriteLine();
            Console.WriteLine("Calculating Wages Till Condition of Total Hours/Days...");
            int conditionalWage = ew.CalculateWageWithConditions();
            Console.WriteLine($"Wages Till Condition Met: {conditionalWage}");

        }
    }
}
