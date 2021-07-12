using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Generic_Collection
{
    class DictionaryEx
    {

		static public void Main()
		{
			Dictionary<int, string> obj =new Dictionary<int, string>();

			obj.Add(1123, "Generic Collection");
			obj.Add(1124, "Dictionary");
			obj.Add(1125, "Key/Value pair");

			foreach (KeyValuePair<int, string> obj1 in obj)
			{
				Console.WriteLine("{0} and {1}",obj1.Key, obj1.Value);
			}
			Console.WriteLine();
		}
	}

}

