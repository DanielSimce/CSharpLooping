using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            /* do
             {
                 Console.WriteLine("{0}", i++);

             } while (i <= 10);
             */


            /* while (i <= 10)
             {
                 Console.WriteLine($"{i++}");
             }
             */

            /*for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) 
                    continue;
                Console.WriteLine(i);
              
            }
            */

            bool numbersOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            Console.WriteLine("Numbers must be greater than 10!");
            while (!numbersOK)
            {
                WriteLine("Give me a number:");
                var1 = Convert.ToDouble(ReadLine());
                WriteLine("Give me another number:");
                var2 = Convert.ToDouble(ReadLine());
                if ((var1 > 10) && (var2 > 10))
                {
                    numbersOK = true;
                    
                }
                else
                {
                    WriteLine("Try again!!!");
                }
            }
            WriteLine($"You entered {var1} and {var2}.");
            ReadLine();
        }




      
                
        
    }

}
