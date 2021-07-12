using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class StackEg
    {

        static public void Main()
        {

            Stack obj = new Stack();

          
            obj.Push("12");
            obj.Push("C-sharp");
            obj.Push("4.8f");
            obj.Push("23.56");

            Console.WriteLine("Total elements present in"+" obj : {0}", obj.Count);

            obj.Pop();

           
            Console.WriteLine("Total elements present in " +"obj: {0}", obj.Count);

            obj.Clear();

            
            Console.WriteLine("Total elements present in " + "obj: {0}", obj.Count);

        }
    }
}

