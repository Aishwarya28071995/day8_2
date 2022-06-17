using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class EmployeeAttendance
    {
        public void getAttendance()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            CheckAttendance(number);
        }

        public static void CheckAttendance(int number)
        {
            if(number == 0)
            {
                Console.WriteLine("employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
    }
}
