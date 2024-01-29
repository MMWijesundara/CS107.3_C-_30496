using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question4
    {
        public static void que4()
        {
            Console.WriteLine("Enter value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result;
            result = fib(num);
            Console.WriteLine("Fibonacci value of "+num+" is "+result);
            Console.ReadLine();
           
        }


        public static int fib(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1 || num == 2)
            {
                return 1;
            }

            else
            {
                return fib(num - 1) + fib(num - 2);
            }
        }
    }
}
