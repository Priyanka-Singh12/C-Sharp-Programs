using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{ 
    public class Inheritance
    { 
            public Inheritance()
            {
                Console.WriteLine("Parent Constructor.");
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }
        public class ChildClass : Inheritance
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
            public static void Main(string[] args)
            {
                ChildClass child = new ChildClass();
                child.print();
            }
        }
    }

