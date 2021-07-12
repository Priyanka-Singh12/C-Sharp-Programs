using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
         interface InterfaceEx
         {
           public void showView();
            
         }

         interface ex2
         {
           public void showDetails();
           
         }

        interface ex3 : InterfaceEx, ex2
        {
            public void showcase();
            
        }


        public class Testt : InterfaceEx, ex2, ex3
        {
        public void showView()
        {
            Console.WriteLine("Interface Method 1");
        }
        public void showDetails()
        {
            Console.WriteLine("Interface Method 2");
        }
    
        public void showcase()
        {
        Console.WriteLine("Interface Method 3");
        }
    
        public void show()
            {
                Console.WriteLine("Hi Everyone");
            }
        }

        public abstract class Testting : Testt, InterfaceEx, ex2, ex3
        {
            public abstract void showCase();
           
        }
    

    class Result
    {
        static void Main(String[] args)
        {
            Testt obj = new Testt();
                obj.show();
                //obj.showCase();
                obj.showView();
                obj.showDetails();
                obj.showcase();
               
                
        }
    }
}

