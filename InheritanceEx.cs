using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class InheritanceEx
    {
        static void Main(string[] args)
        {
            Test1 obj = new Test1();
            obj.show();
            Test2 obj1 = new Test2();
            obj1.disp();
            obj1.show();
            Test3 obj2 = new Test3();
            obj2.disp();
            obj2.show();
            obj2.display();
            Test4 obj3 = new Test4();
            obj3.disp();
            obj3.show();
            obj3.display();
            obj3.displayDetails();
            //Test4 obj5 = new Test3();
            //Test5 obj4 = new Test2();
        }


    }

    class Test1
    {
        public void show()
        {
            Console.WriteLine("Parent Class");
        }
       
    }

    class Test2:Test1
    {
       public void disp()
        {
            Console.WriteLine("Child Class 1");
        }
    }
    class Test3:Test2
    {
       public void display()
        {
            Console.WriteLine("Child Class 2");
        }
    }

    class Test4 : Test3
    {
        public void displayDetails()
        {
            Console.WriteLine("Child Class 3");
        }
    }
    class Test5: Test4
    {
        public void displayDetail()
        {
            Console.WriteLine("Child Class 4");
        }
    }
}
