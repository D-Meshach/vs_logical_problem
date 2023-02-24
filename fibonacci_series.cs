using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Logical
{
    public class fibonacci_series
    {

        public static void fibonacci() {
            int temp=0;
            Console.WriteLine("Enter the count for number of iterations");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[2];
            temp = 1;
            ar[0] = 0;
            ar[1] = 1;
            Console.WriteLine("The Fibonacci series are");
            Console.WriteLine(0);
            for (int i =0; i < num-1; i++)
            {
                temp = ar[1] + ar[0];
                ar[0] = ar[1];
                ar[1] = temp;

                Console.WriteLine(temp);
               
                

            }

        }

    }
}
