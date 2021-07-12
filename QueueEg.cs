using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class QueueEg
    {

        public static void Main()
        {

            
            Queue obj = new Queue();
 
            obj.Enqueue("My");
            obj.Enqueue("name");
            obj.Enqueue("is");
            obj.Enqueue("Priyanka");
            obj.Enqueue("Singh");

            
            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(obj.Count);

            Console.WriteLine("Beginning Item is: " + obj.Peek());
        }
    }
}
