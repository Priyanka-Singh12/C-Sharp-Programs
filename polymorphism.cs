using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class polymorphism
{
     public void add() 
    {
        int a = 5, b = 6;
            Console.WriteLine(a+b);
    }

    public void add(int a,int b,int c)
    {
        Console.WriteLine(a+b+c);
    }

    public void add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void add(int a,float b)
    {
        Console.WriteLine(a + b);
    }

    static void Main(String[] args)
    {
        polymorphism obj = new polymorphism();
            obj.add();
            obj.add(2, 3.67f);
            obj.add(2, 3.8f);
            obj.add(2, 2, 2);

    }

}
}
