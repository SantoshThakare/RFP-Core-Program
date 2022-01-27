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

            double heads = 0;
            double tails = 0;
            {
                Console.WriteLine("Enter your No. of times to flip coin");
                double num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++) ;
                {
                    Random rand = new Random();
                    int result = rand.Next(0, 2);


                    if (result > 0)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }

                }
            }
                Console.WriteLine("Percentage of Head " + (Heads * 100 / 10));
                Console.WriteLine("Percentage of Tail " + (Tails * 100 / 10));
                Console.ReadKey();


            
        }   
    }
}
