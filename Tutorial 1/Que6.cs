﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Question6
    {
        public static void que6()
        {
            Console.WriteLine("Enter your exam marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Grade: ");

            if (marks < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (marks < 50)
            {
                Console.WriteLine("D");
            }
            else if (marks < 60)
            {
                Console.WriteLine("C");
            }
            else if (marks < 75)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
            Console.ReadLine();
        }
    }
}
