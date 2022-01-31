using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Leap_Year
    {
     public void next()
        {
            int year;
             string  a;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            a = year % 4 == 0 ? "year is leap " : " It is not leap year ";
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
