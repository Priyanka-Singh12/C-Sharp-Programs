using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{
    class ExceptionEg2
    {
        public void showException()
        {
            try
            {
                int[] ar = { 1, 2, 3, 4, 5 };

                for (int i = 0; i <= ar.Length; i++)
                    Console.WriteLine(ar[i]);
            }
            catch (IndexOutOfRangeException )
            {
                Console.WriteLine("Index is out of range");
            }

            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
    class ExceptionEg7
    {
        static void Main()
        {
            ExceptionEg2 obj = new ExceptionEg2();
            obj.showException();
        }
    }
}
