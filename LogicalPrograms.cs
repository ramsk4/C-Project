using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LogicalPrograms
    {
        public static void FizzBuzz()
        {

            for (int i = 1; i < 100; i++)
            {

                if ( i % 3 == 0)
                {
                    Console.WriteLine("----\nFizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("----\nBuzz");
                }

                else 
                {
                    Console.WriteLine("----\n"+" "+i);
                }
            }

               
        }

        public static void GuessTheNumber()
        {
            Random random = new Random();
            int on = random.Next(1, 101);

            int un = 0;

            while(true)
            {
                Console.WriteLine("Gusess the number");
                un= Convert.ToInt32(Console.ReadLine());    

                if(un==on)
                {
                    Console.WriteLine("You Got the Wright Number");
                    break;
                }

                if (un < on)
                {
                    Console.WriteLine("You got lower");
                }

                if (un > on)
                {
                    Console.WriteLine("You got Higher");
                }


            }
        }
    }
}

