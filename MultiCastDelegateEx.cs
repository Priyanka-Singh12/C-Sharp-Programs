using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Delegates
{
    class MultiCastDelegateEx
    {
        public delegate void add(int a,int b);

        public void Main()
        {
            TestDe de = new TestDe();
            add dd = new add(de.addNum);
            add dd1 = de.subNum;
            add dd2 = de.mulNum;
            add dd3 = de.divNum;

            add ddd4 = dd + dd1 + dd2 + dd3;
            dd(67, 88);

            Console.WriteLine(ddd4);


        }


    }

    class TestDe
    {
       public void addNum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void subNum(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public void mulNum(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void divNum(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }


}
