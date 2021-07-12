using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Delegates
{
    class DelegateEx
    {


			public delegate void addnum(int a, int b);  //Declaration
			public delegate void subnum(int a, int b);

			
			public void sum(int a, int b)
			{
				Console.WriteLine("(10+60)={0}", a + b);
			}

	
		    public void subtract(int a, int b)
		    {
			    Console.WriteLine("(100-20)={0}", a - b);
		    }
			
			public static void Main(String[] args)
			{

				
				DelegateEx obj = new DelegateEx();

				
				addnum del_obj1 = new addnum(obj.sum);   //Delegate Instantiation
				subnum del_obj2 = new subnum(obj.subtract);

				
				del_obj1(10, 60);
				del_obj2(100, 20);

				
			}
		}
	}



