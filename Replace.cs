using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Replace
    {
        public void name()
        {

            Console.WriteLine("Enter the name and name length should be greater than 3");
            string name = Console.ReadLine();
            int value = name.Length;
            if (value  > 3)
            {
                Console.WriteLine("Hello " + name + " How are you?");
            }
            else
            {
                Console.WriteLine("name length should be greater than 3");
            }
            Console.ReadLine();
        }
    }
}
