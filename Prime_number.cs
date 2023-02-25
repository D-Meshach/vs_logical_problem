using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logical
{
    public class Prime_number
    {
        public static void prime_number() {
            Console.WriteLine("Enter the number to find");
            int num = Convert.ToInt32(Console.ReadLine());
            int count=0;
            for (int i = 1; i <= num; i++) 
            {
                if (num % i == 0) {
                    count++;
                }
            
            }
            if (count > 2)
            {
                Console.WriteLine("It is not prime number");
            }
            else 
            {
                Console.WriteLine("It is a prime number");
            }

        }

       

    }
}
