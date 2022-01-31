using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class flipcoin
    {
        public void toss()
        {
            const double CHECK = 0.5;

            double heads = 0;
            double tails = 0;
            {
                Console.WriteLine("Enter your No. of times to flip coin");
                 int result = Convert.ToInt32(Console.ReadLine());
               
                for (int i = 0; i < result; i++);
                {
                    Random random = new Random();
                    double option = random.NextDouble();


                    if (option < CHECK)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }

                }
            }
                Console.WriteLine("Percentage of Head " + (heads /(heads+tails) * 100));
                Console.WriteLine("Percentage of Tail " + (tails/(heads+tails) * 100));
                Console.ReadKey();


            
        }   
    }
}
