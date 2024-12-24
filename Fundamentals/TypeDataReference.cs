using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fundamentals
{
    internal class TypeDataReference
    {
        public class Person
        {
            public string Name;
            public int Age;

            public void Introduce()
            {
                Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
            }
        }


        //public static void Main()
        //{
        //    Person p1 = new Person();
        //    p1.Name = "Farid Rhamadhan Darari";
        //    p1.Age = 28;
        //    p1.Introduce();
        //}
    }
}

/*
Jenis-Jenis tipe data reference:
    1. Class
    2. Interface
    3. String
    4. Array
    5. Delegate
    6. Dynamic
 */
