using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class BoxingUnBoxing
    {

        int i = 23;

        public void boxing()
        {

            Object iobj = i; //Boxing.
            i = 56;

            Console.WriteLine("Type value = "+iobj);
            Console.WriteLine("Type value = "+i);

        }

        public void unboxing(Object iobj)
        {
            int j = Convert.ToInt32(iobj);                           //UnBoxing.

            Console.WriteLine("Type value = "+iobj);
            Console.WriteLine("Type value = "+j);

        }

        static void Main()
        {
            
            BoxingUnBoxing obj = new BoxingUnBoxing();
            obj.boxing();
            obj.unboxing(23.56);
        }
    }
}
