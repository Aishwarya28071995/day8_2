using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class EmployeeAttendance
    {
        static int WagePerHour = 20;
        
        public void getAttendance()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            CheckAttendance(number);
        }

        public static void CheckAttendance(int number)
        {
            int hours;
            if(number == 0)
            {
                Console.WriteLine("employee is absent");
                hours = 0
                CalculateSalary(hours);
            }
            else
            {
                Console.WriteLine("Employee is present");
                hours = 8;
                CalculateSalary(hours);
            }
        }

        public void CalculateSalary(int hours)
        {
            int salary = WagePerHour * hours;
            Console.WriteLine("Salary is " + salary);
        }
    }
}
