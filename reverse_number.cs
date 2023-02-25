using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class reverse_number
    {

        public static void reverse() {
             Console.WriteLine("Enter minimum 4 digit number to reverse the number");
            int num =Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(result);

        }

    }
}
