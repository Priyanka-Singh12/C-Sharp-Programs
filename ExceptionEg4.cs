using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{
    class ExceptionEg4
    {
        public void showException()
        {
            string str=null;

            try
            {
                if (str.Length > 0)
                    Console.WriteLine(str);
            }

            catch(NullReferenceException)
            {
                Console.WriteLine("The value of string is null");
            }

            finally
            {
                Console.WriteLine("finally is executed");
            }
        }

    }

    class ExceptionEg5
    {
        static void Main()
        {
            ExceptionEg4 obj = new ExceptionEg4();
            obj.showException();
        }
    }
}
