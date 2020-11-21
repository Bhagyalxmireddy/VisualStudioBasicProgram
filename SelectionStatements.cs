using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstVisualStudioProject
{
    class SelectionStatements
    {
        static void Main()
        {
            int a ;
            Console.WriteLine("enter a number :");
            a = Convert.ToInt32(Console.ReadLine());
            if(a < 0)
            {
                Console.WriteLine("entered value is negative");
            }
            else
            {
                Console.WriteLine("entered value is positive");
            }
        }
    }
}
