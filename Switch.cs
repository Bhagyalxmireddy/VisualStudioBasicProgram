using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstVisualStudioProject
{
    class Switch
    {
         static void Main()
        {
            double x, y, z,a;
            Console.WriteLine("enter the X value: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the y value: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter a number:");
            a = (char)Console.Read();
            switch (a)
            {
                case 1:
                    z = x + y;
                    Console.WriteLine("{0} + {1} = {2}",x,y,z);
                    break;
                case 2:
                    z = x - y;
                    Console.WriteLine("{0} - {1} = {2}", x, y, z);
                    break;
                case 3:
                    z = x * y;
                    Console.WriteLine("{0} *  {1} = {2}", x, y, z);
                    break;
                case 4:
                    z = x / y;
                    Console.WriteLine("{0} / {1} = {2}", x, y, z);
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }

        }

    }
}
