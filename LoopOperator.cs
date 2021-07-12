using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class LoopOperator
    {
        public void naturalNumbers(int n)   //While Loop
        {
            int i = 1;
            Console.WriteLine("Printing 1 to 10 Natural Numbers");
            while(i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void table(int num)  //do while loop
        {
            int i=1;
            Console.WriteLine("Table of", num);

            do
            {
                if (i == 6)
                {
                    continue;
                    Console.WriteLine(num + "*" + i + "=" + (num * i));

                }                                              //using continue.
                
                 i++;

            } while (i <= 10);
        }
        public void even(int start_value,int end_value)   //for loop+if statement+Nested loop.
        {

            Console.WriteLine("Even Number :");
           for(int i=start_value;i<=end_value;i++)
            {
               
                if (i % 2 == 0)
                    Console.WriteLine(i);   
            }
           
        }

        public void addition(int num1,int num2)  //Urinary operator
        {
            num1++;
            ++num2;
            num1 = num2;
            Console.WriteLine("Addition = "+(num1 + num2));

        }

        public void grade(double percentage) //if-else ladder.
        {
            if (percentage > 90)
                Console.WriteLine("A Grade");
            else if (percentage>=70 &&percentage <= 90) //Relational Operator
                Console.WriteLine("B Grade");
            else if (percentage <=50 && percentage >=69)
                Console.WriteLine("C Grade");
            else if (percentage >=49)
                Console.WriteLine("Rewrite the Test");
        }

        public void operation(int num1,int num2)  //Switch Statement
        {
            Console.WriteLine("Enter the Operation you want to perform");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch(operation)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers = "+(num1 + num2));
                    break;                                                          //break usuage.
                case 2: 
                    Console.WriteLine("Substraction of two numbers = "+(num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Division of two numbers = "+(num1 / num2));
                    break;
                case 4:
                    Console.WriteLine("Multiplication of two numbers = "+(num1 * num2));
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
            

            
        }

        public void foreeach()     //for each loop
        {
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }
        }

            public void operat()   //bitwise operator
        {
            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            

            Console.WriteLine(a&b);
            Console.WriteLine(a|b);
            Console.WriteLine(a^b);
            Console.WriteLine(a>>2);
            Console.WriteLine(a<<2);
            Console.WriteLine(~a);

        }

        void nonPrimitive()
        {
            
            string[] stringarr;

            stringarr = new string[3] { "Element 1", "Element 2", "Element 3" };

            Console.WriteLine(stringarr[0]);
            Console.WriteLine(stringarr[1]);
            Console.WriteLine(stringarr[2]);
        }

        void ter()  //ternary operator
        {
           
                int number = 2;
                bool isEven;

                isEven = (number % 2 == 0) ? true : false;

                Console.WriteLine(isEven);
            
        }
        public void vote()   //goto and label
        {
        ineligible:
            Console.WriteLine("Your are not eligible to Vote");

            Console.WriteLine("To Recheck enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("Your Eligible to vote");
            }

        }
          
        static void Main()
        {
            LoopOperator obj2 = new LoopOperator();
            obj2.naturalNumbers(17);
            obj2.even(12, 25);
            obj2.addition(13, 16);
            obj2.grade(78.56);
            obj2.operation(23, 45);
            obj2.vote();
            obj2.table(6);

        }


    }
}
