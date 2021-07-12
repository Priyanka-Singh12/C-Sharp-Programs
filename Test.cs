using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Test
    {
        int number = 56;
        void check()
        {
            int number = 67;                                          //Global and Local
            Console.WriteLine("Variable Perferred" +number);
        }

        void uniary()    //prefix and postFix
        {
            Console.WriteLine("PostFix = "+number++);
            Console.WriteLine(++number+" = Prefix ");
        }
        public void grade(double percentage) //if-else ladder.
        {
            if (percentage > 90)
                Console.WriteLine("A Grade");
            else if (percentage >= 70 && percentage <= 90)
                Console.WriteLine("B Grade");
            else if (percentage <= 50 && percentage >= 69)
                Console.WriteLine("C Grade");
            else if (percentage <= 49)
                Console.WriteLine("Rewrite the Test");
        }

        public void operation(int num1, int num2)  //Switch Statement
        {
            Console.WriteLine("Enter the Operation you want to perform");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers = " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Substraction of two numbers = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Division of two numbers = " + (num1 / num2));
                    break;
                case 4:
                    Console.WriteLine("Multiplication of two numbers = " + (num1 * num2));
                    break;
                default:
                    Console.WriteLine("Invalid inpur");
                    break;



            }

        } 
        static void Main(string[] args)
            {
                Test obj = new Test();
                obj.check();
                obj.uniary();
                obj.grade(76.8);
                obj.operation(23,45);
            }

        }
    }

