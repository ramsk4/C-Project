using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public static void ReversTheGivenNumbers()
        {
            Console.WriteLine("Enter how meany nubers you want in array :");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] a= new int[length]; 

            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a numbers:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp =0;
            int j = a.Length - 1;

            for (int i=0; i <j; i++,j--)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }

            Console.WriteLine("Reverce Of Array...is...");
            for(int i=0; i < length;i++)
            {
                Console.WriteLine(a[i]);
                //int[] b= new int[length];
              //  b[i] = a[i];

            }
        }

        public static void ChekPalindormNumbers()
        {
            Console.WriteLine("Enter Numbers to revers:");
            int number = Convert.ToInt32(Console.ReadLine());

            int Reverse = 0, reminder, temp;

            temp = number;

            while (number > 0)
            {

                reminder = number % 10;
                Reverse= Reverse*10 + reminder;
                number = number / 10;   
            }

            if(temp== Reverse)
            {
                Console.WriteLine("this number is palindrome");
            }

            else
            {
                Console.WriteLine("Not Palindrome");

            }

        }

        public static void CheckEvenODD()
        {

            for (int i = 1; i < 11; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("Even numbers is:"+i);
                }

                else 
                {
                    Console.WriteLine("Odd numbers is:" + i);
                        
                }
            }

        }

        public static void Print10NumbersAndSqureOfThem()
        {


            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine("Number is" + i);

                Console.WriteLine("Squar of:"+i +"  is     :" + (i*i));


            }

        }
        
        public static void CountOfDigists()
        {
            Console.WriteLine("Enter the Number: ");
            int num =Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (num !=0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Number of digits in number is :" + count);

        }

        public static void AdditionOfDigits()
        {
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                sum = sum + (num % 10);
                num = num / 10;
            }
            Console.WriteLine("Sum of digits in number is :" + sum);

        }

    }


}
