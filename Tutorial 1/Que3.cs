using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question3
    {
        public static void que3()
        {
            Console.WriteLine("Enter a postive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (number < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    result += i;
                }
            }

            Console.WriteLine("The sum of all the numbers are:" + result);
            Console.ReadLine();
        }
    }
}
