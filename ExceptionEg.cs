using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{

    class ExceptionT
    {
        public void showexception()
        {
            int number = 0, number1 = 54,sum;

            try
            {
                sum=number/number1;
            }

            catch(DivideByZeroException e)   //Divide by Zero Exception

            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("finally is executed");
            }

        }
    }
    class ExceptionEg
    {
        static void Main()
        {
            ExceptionT obj = new ExceptionT();
            obj.showexception();
        }
    }
}
