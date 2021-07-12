using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Modifiers
    {
        static int number;   //Static Variable
        public readonly int number1;      //Read-Only Variable
        static void details(int b)
        {
            number = 5;  //Initializing Static Variable
  
            Console.WriteLine(number);
        }

        public Modifiers(int b)
        {
            number1 = b;
        }

        
           static void Main(String[] args)
        {
            Console.WriteLine("Static Variable = "+number);
            Modifiers obj = new Modifiers(5);
            Console.WriteLine("Read-Only Variable"+obj.number1);
            SealClass slc = new SealClass();
            int total=slc.add(8, 6);
            Console.WriteLine("Total = " + total);
            Phone p;
            p= new Version();
            p.display();


        }



    }

    public abstract class Phone
    {
        public abstract void display();

    }

    public class Version : Phone
    {
        public override void display()
        {
            Console.WriteLine("Version 2.0");
        }
    }
    sealed class SealClass
    {
        public int add(int no,int no1)
        {
            return no + no1;
        }
    }

    //class Add : SealClass
    //{

    //}

}
