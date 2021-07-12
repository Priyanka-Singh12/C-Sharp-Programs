using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practical.Non_Generic_Collection
{
    class HastableEg
    {
		static public void Main()
		{

			
			Hashtable hashtable1 = new Hashtable();

			hashtable1.Add("A1", "Collection");
			hashtable1.Add("A2", "HashTable");
			hashtable1.Add("A3", "key,value");

			Console.WriteLine("Key and Value pairs from my_hashtable1:");

			foreach (DictionaryEntry obj in hashtable1)
			{
				Console.WriteLine("{0} and {1} ", obj.Key, obj.Value);
			}
		}
	}

}

