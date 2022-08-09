using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class PrimeNumber
    {
        public static void PrimeNumberSolution()
        {
            int n,  m = 0 ;
            Console.Write("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            
            
                if (m == 0)
                {
                    Console.Write("Number is  not   Prime.");
                    
                   
                }
            else
            {
                Console.Write("Number is  Prime.");

            }
        }
            
              
        }
    }
    

