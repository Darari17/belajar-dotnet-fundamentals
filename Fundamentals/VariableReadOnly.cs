using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class VariableReadOnly
    {
        public class Person
        {
            // Variable Readonly
            public readonly string Name;
            public readonly int Age;

            // Constructor
            public Person(string name, int age)
            {
                // Inisialisasi variable readonly
                Name = name;
                Age = age;
            }

            // Metode untuk menampilkan informasi
            public void Display() 
            {
                Console.WriteLine("Nama: " + Name);
                Console.WriteLine("Umur: " + Age);
            }
        }

        //public static void Main()
        //{
        //    Person p1 = new Person("Farid", 28);
        //    Person p2 = new Person("Rhamadhan", 23);
        //    Person p3 = new Person("Darari", 18);

        //    p1.Display();
        //    p2.Display();
        //    p3.Display();
        //}
    }
}

/*
 Penjelasan:
    1. Variable Readonly adalah variable yang nilainya hanya bisa di inisialisasi:
        - Saat deklarasi
        - Di dalam konstruktor kelas
    2. Berbeda dengan const, variable readonly memungkinkan inisialisasi nilai yang diketahui saat runtime (bukan hanya nilai tetap di waktu kopilasi)
    3. Nilainya tidak dapat berubah setelah di inisialisasi
 */