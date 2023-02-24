using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String i = "y";
            while (i == "y") {
                Console.WriteLine("Enter option \n 1)Fibonacci Series \n  \nEnter option here-");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1: fibonacci_series.fibonacci(); break;
                    default: Console.WriteLine("Enter a valid statement"); break;

                }
                Console.WriteLine("Do you wish to continue (y/n)?");
                i= Convert.ToString(Console.ReadLine());


            }

            

        }
    }
}
