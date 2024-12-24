using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class VariableStatic
    {
        class Counter
        {
            // Variable Static
            public static int totalCount = 0;

            // Counstructor 
            public Counter()
            {
                totalCount++;
            }

            // Metode Static untuk menampilkan jumlah object
            public static void Display()
            {
                Console.WriteLine(totalCount);
            }
        }

        //public static void Main()
        //{
        //    // Buat object
        //    Counter o1 = new Counter();
        //    Counter o2 = new Counter();
        //    Counter o3 = new Counter();

        //    // Memanggil metode static untuk menampilkan jumlah objek
        //    Counter.Display();
        //}
    }
}

/*
 Penjelasan:
    1. Variable Static adalah variable yang di deklarasikan dengan keyword static dalam sebuah kelas.
    2. Variable ini dimiliki bersama oleh semua instance dari kelas, artinya nilai nya sama untuk semua objek yang dibuat dari kelas tersebut.
    3. Variable static diakses langsung melalui nama kelas tanpa memerlukan objek.
*/
