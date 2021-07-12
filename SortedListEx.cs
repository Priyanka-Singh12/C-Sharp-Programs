using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Generic_Collection
{
    class SortedListEx
    {

        static void Main()
        {
            SortedList<int, string> obj = new SortedList<int, string>()
                                   {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            for (int i = 0; i < obj.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", obj.Keys[i], obj.Values[i]);
            }
        }
    }
}
