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
            int number = random.Next(0, 3);
            CheckAttendance(number);
        }

        public static void CheckAttendance(int number)
        {
            int hours;
            if(number == 0)
            {
                Console.WriteLine("employee is absent");
                hours = 0;
                CalculateSalary(hours);
            }
            else if(number==1)
            {
                Console.WriteLine("Employee is present part time");
                hours = 4;
                CalculateSalary(hours);
            }
            else
            {
                Console.WriteLine("Employee is present full time");
                hours = 8;
                CalculateSalary(hours);
            }
        }

        public static void CalculateSalary(int hours)
        {
            int salary = WagePerHour * hours;
            Console.WriteLine("Salary is " + salary);
        }
    }
}
