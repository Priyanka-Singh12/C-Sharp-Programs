using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class SortedListEg
    {

        static void Main()
        {
            SortedList obj = new SortedList() {{ 3, "Three" },{ 1, "One"},{ 2, "Two"}};
                                   
                                        
            foreach (DictionaryEntry i in obj)
            {
                Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
            }
        }
    }
}
