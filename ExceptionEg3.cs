using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{
    class ExceptionEg3
    {

        public void showDetails()
        {
            try
            {
                int a = 30, b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("Can't divide a number by 0");
            }

            finally
            {
                Console.WriteLine("finally is executed");
            }
        }

    }
        class ExceptionEg6
        {
            static void Main()
            {
                ExceptionEg3 obj = new ExceptionEg3();
                obj.showDetails();
            }
        }
    }
