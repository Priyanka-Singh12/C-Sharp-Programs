using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class GetAndSet
    {

        private int id;
        private string name;
        private string city;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        static void Main(string[] args)
        {
            GetAndSet obj = new GetAndSet();
            obj.Name = "Priyanka";
            obj.City = "Pune";
            obj.Id = 12;

            Console.WriteLine(obj.Id + " "+obj.Name+"  " + obj.City);
            
        }
    }
}
