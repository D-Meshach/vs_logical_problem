using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Perfect_number
    {
        public static void perfect_number()
        {

            Console.WriteLine("Enter the number to check");
            int input = Convert.ToInt32(Console.ReadLine());
            int accumulator = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    accumulator += i;
                }
            }
            if (accumulator == input)
            {
                Console.Write("The  Number " + input + " is perfect");
            }
            else
            {
                Console.WriteLine("The Number " + input + " is not perfect");
            }

        }

    }

}

