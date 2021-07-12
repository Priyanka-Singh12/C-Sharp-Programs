using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class BitArrayEg
    {
        //BitArray are of Fixed length.

        static void Main()
        {
            BitArray obj = new BitArray(3);

            obj[0] = false;
            obj[1] = true;
            obj[2] = false;


            Console.WriteLine(obj.Get(1));
        }

    }
}
