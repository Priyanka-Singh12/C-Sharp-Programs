using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class CheckString
    {

       

        

       static void Main(string[] args)
        {
            string str = "My name is Priyanka Singh!";
            string str1 = "I live in India";
            bool output;

            output = String.Compare(str, str1) == 0;

            Console.WriteLine("Compare Result = " + output);

            StringBuilder s = new StringBuilder("Checking String methods");

            s.Append("like StringBuilder");

            s.AppendLine("Have");
            s.Append("Good day");

            Console.WriteLine(s);

            s.Remove(5, 3);           //Remove

            Console.WriteLine(s);

            s.Replace("String", "Stringg");    //Replace
            Console.WriteLine(s);

            Console.WriteLine(str.ToUpper());    //Upper case
            Console.WriteLine(str.ToLower());        //Lower case

            Console.WriteLine("Concating two strings" + (str + str1));     //Concat method

            Console.WriteLine(String.Concat(str, str1));

            Console.WriteLine(str[0]);   //Acessing first character of the String

            int charPos = str.IndexOf("N");

            string str2 = str.Substring(charPos);     //SubString Method

            Console.WriteLine("Substring = "+str2);

            string str3 = string.Copy(str);                     //Copy Method

            Console.WriteLine("Copy Method of String " + str3);

            int number = 123;

            string str4 = number.ToString();                    //To String function

            Console.WriteLine("To String Method = " + str4);

            char[] ch = str.ToCharArray();                       //To CharArray Function

            foreach(char c in ch)
            {
                Console.WriteLine(c); 
            } 
            char[] str6 = str.ToCharArray();               
            Array.Reverse(str6);                                          //Reverse a String

            Console.WriteLine(new string(str6));

            string[] st = str.Split(" ");
            foreach(string m in st)
            {
                Console.WriteLine(m + " ");
            }




        }
       
    }
}
