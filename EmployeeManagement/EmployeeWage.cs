using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class EmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHours = 8;
        public const int PartTimeHours = 8;
        public const int WorkingDaysPerMonth= 20;
        public const int MaxWorkingHours = 100;

        private Random random = new Random();

        public bool IsEmployeePresent()
        {
            return random.Next(0, 2) == 1;
        }
        public int CalculateDailyWage(int workingHours)
        {
            return WagePerHour * workingHours;
        }
        public int CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                int workingHours = GetWorkingHoursForDay();
                totalWage += CalculateDailyWage(workingHours);
            }

            return totalWage;
        }
        public int CalculateWageWithConditions()
        {
            int totalWage = 0, totalHours = 0, totalDays = 0;

            while (totalHours < MaxWorkingHours && totalDays < WorkingDaysPerMonth)
            {
                totalDays++;
                int workingHours = GetWorkingHoursForDay();
                totalHours += workingHours;
                totalWage += CalculateDailyWage(workingHours);
            }

            return totalWage;
        }
        private int GetWorkingHoursForDay()
        {
            int attendance = random.Next(0, 3);

            switch (attendance)
            {
                case 1: return FullDayHours; 
                case 2: return PartTimeHours; 
                default: return 0; 
            }
        }
    }
}
