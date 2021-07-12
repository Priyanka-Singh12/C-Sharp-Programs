using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class ListArray
    {

        static void Main()
        {
            ArrayList obj = new ArrayList();
            obj.Add(12); obj.Add("Priyanka"); obj.Add("Singh");     //Add method

            var obj2 = new ArrayList() { 12, "December", 1997 };     //Adding an array

            obj.AddRange(obj2);

            foreach(var r in obj)
                Console.WriteLine(r + " ");

            Console.WriteLine(obj2.Contains(12));          //Contain Method
           
        }
    }
}
