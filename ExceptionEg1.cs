using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{
    class ExceptionEg1
    {
        public void showException()
        {

            string[] names = { "Dog", "Cat", "Fish" };
            Object[] objs = (Object[])names;

            try
            {
                Object obj = (Object)13;
                objs[2] = obj;
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("Array is mismatched");
            }

            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }

    class ExceptionEg8
    {
        static void Main()
        {
            ExceptionEg1 obj = new ExceptionEg1();
            obj.showException();
        }
    }
}
