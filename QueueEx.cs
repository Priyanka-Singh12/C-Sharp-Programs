using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Generic_Collection
{
    class QueueEx
    {

        static void Main()
        {
            Queue<string> que= new Queue<string>();
            que.Enqueue("My");
            que.Enqueue("name");
            que.Enqueue("is");
            que.Enqueue("Priyanka");
            que.Enqueue("Singh");

            Console.WriteLine("Total elements: {0}", que.Count); 

            if (que.Count > 0)
                Console.WriteLine(que.Peek());
            

            Console.WriteLine("Total elements: {0}", que.Count);
        }
    }
}
