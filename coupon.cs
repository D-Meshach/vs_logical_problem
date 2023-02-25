using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class coupon
    {
        public static void coupons() {

            Console.WriteLine("Generating Random numbers between 10 to 99");
            Console.WriteLine("Enter the number of 2 digit coupons to be generated");
            int count = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            var ar = new ArrayList(); 
            for (int i = 0; i <count; i++)
            {

               int rand_coupon = random.Next(10, 100);
                ar.Add(rand_coupon);
                int dup_cnt = 0;
                Console.WriteLine("Generated Coupon:  "+ar[i]);
                for (int j = 0; j < i; j++) {

                    if (ar[j].Equals(ar[i]))
                    {


                        Console.WriteLine("duplicate:  " + ar[i]+"by j=" + ar[j]);

                    }
                    
                    

                }
               

                /*int j = 0;
                while (j < i) { 
                
                }*/

            }
           





        }
    

    }
}
