using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question1
    {
        public static void que1()
        {
            Console.WriteLine("Please enter the length: ");
            string length = Console.ReadLine();
            int InputLength = int.Parse(length);

            Console.WriteLine("Please enter the width: ");
            string width = Console.ReadLine();
            int InputWidth = int.Parse(width);

            int area = InputLength * InputWidth;


            Console.WriteLine("Area of the rectangle is : " + area);
            Console.ReadLine();
        }
    }
}
