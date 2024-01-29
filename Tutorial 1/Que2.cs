using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question2    
    {
        public static void que2()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd. ");
                }
                Console.ReadLine();
            }
        }
    }
}
