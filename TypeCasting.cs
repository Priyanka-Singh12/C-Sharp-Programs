using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class TypeCasting
   {
        int i = 45;
        double store;
        public TypeCasting() //Default Constructor
        {
            Console.WriteLine("Implicit Typecasting");
            store = i; i = 68;      // Automatically,Storing small value in larger datatype variable.
            Console.WriteLine("Addition of two values is "+(store + i));
            Console.WriteLine("Explicit Typecasting");
            i =(int) store;        //Manually,storing larger variable in small variable.
            Console.WriteLine("Substraction of two values is " + (i - store));
        }

        public void data()
        {
            double num1 = 23.4;
            int num2 = 23;
            num1 = num2;
            Console.WriteLine(num1 + "= No Data loss,since the number was 23"); //double can easily store integer type value 
            num1 = 23.4; num2 = (int)num1;
            Console.WriteLine(num2 + "= Data is lost actual number is 23.4"); //while storing 23.4 in integer type variable there was a loss of 0.4;

        }

        static void Main()
        {
            TypeCasting obj = new TypeCasting();
            obj.data();
        }


    }
}
