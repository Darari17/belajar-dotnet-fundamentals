using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class VariableInstance
    {
        public class Person
        {
            // Variable Instance
            public string Name;
            public int Age;

            // Construcor untuk menginisialisasi variable instance
            public Person(string s, int i)
            {
                Name = s;
                Age = i;
            }

            // Metode untuk menampilkan informasi
            public void Display()
            {
                Console.WriteLine("Nama saya " + Name);
                Console.WriteLine("Umur Saya " + Age);
            }
        }

        //public static void Main()
        //{
        //    Person p = new Person("Farid Rhamadhan Darari", 8);
        //    p.Display();
        //}
    }
}

/*
Penjelasan:
    1. Variable Instance adalah variable yang di deklarasikan di dalam kelas tetapi diluar metode, konstruktorn, atau blok statis.
    2. Setiap objek yang dibuat dari kelas memiliki salinan tersendiri dari variable instance tersebut.
    3. Variable instance sering digunakan untuk menyimpan data yang spesifik dari suatu objek.
*/