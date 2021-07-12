using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class MethodOverriding
    {

        

        class Bank
        {
            public virtual float  rateInterest()
            {
                float iR = 4.7f;
                return iR;
            }

        }

        class ICIC :Bank
        {
            public override float rateInterest()
                {
                float iR = 7.5f;
                  Console.WriteLine("Rate of Interest" +iR);
                return iR;
                }
        }

        class SBI : Bank
        {
            public  override float rateInterest()
            {
                float iR = 8.5f;
                Console.WriteLine("Rate of Interest " + iR);
                    return iR;
            }
        }



        static void Main(String[] args)
        {
            Bank obj = new Bank();
            float a=obj.rateInterest();
            Console.WriteLine(a);
            Bank obj1 = new ICIC();
            obj1.rateInterest();
            ICIC obj2 = new ICIC();
            obj2.rateInterest();
            Bank obj3 = new SBI();
            obj3.rateInterest();


        }
    }
}
