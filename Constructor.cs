using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Constructor
    {
       
        static Constructor()
        {
            int bonus = 12;
            bonus++;
            Console.WriteLine("Bonus = "+bonus);
        }

        public Constructor(int a, int b)
        {

            Console.WriteLine(" Addition = " + (a + b));
        }
        static void Main(string[] args)
        {
            Constructor obj = new Constructor(5, 6);
        }
    }
}
