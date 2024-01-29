using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question5
    {
        public static void que5()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            if (num < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine(num + " x " + i + "= " + result);
                }
            }

            Console.ReadLine();
        }
    }
}
