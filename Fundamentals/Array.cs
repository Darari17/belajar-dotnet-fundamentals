using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Array
    {
        static void CetakArray(int[] arr)
        {
            Console.WriteLine("Isi Array Satu Dimensi:");
            foreach (int n in arr)
            {
                Console.WriteLine(arr);
            }
        }

        public static void Main()
        {
            // 1. Array Satu Dimensi
            int[] arraySatuDimensi = { 10, 20, 30, 40, 50 }; // Deklarasi dan inisialisasi langsung
            Console.WriteLine("=== Array Satu Dimensi ===");
            for (int i = 0; i < arraySatuDimensi.Length; i++) // Mengakses menggunakan indeks
            {
                Console.WriteLine($"Elemen ke-{i}: {arraySatuDimensi[i]}");
            }

            // 2. Array Dua Dimensi
            int[,] arrayDuaDimensi = { { 1, 2 }, { 3, 4 } }; // Deklarasi array 2D
            Console.WriteLine("\n=== Array Dua Dimensi ===");
            for (int i = 0; i < 2; i++) // Iterasi baris
            {
                for (int j = 0; j < 2; j++) // Iterasi kolom
                {
                    Console.Write(arrayDuaDimensi[i, j] + " "); // Menampilkan elemen
                }
                Console.WriteLine(); // Pindah ke baris berikutnya
            }

            // 3. Menggunakan Array Sebagai Parameter Method
            int[] angka = { 5, 10, 15, 20, 25 }; // Array contoh
            Console.WriteLine("\n=== Array Sebagai Parameter ===");
            CetakArray(angka); // Memanggil method CetakArray

            // 4. Array dengan Foreach
            string[] namaBuah = { "Apel", "Jeruk", "Mangga" }; // Deklarasi array string
            Console.WriteLine("\n=== Array dengan Foreach ===");
            foreach (string buah in namaBuah) // Iterasi setiap elemen dalam array
            {
                Console.WriteLine("Nama Buah: " + buah);
            }

            // 5. Array Dinamis
            Console.WriteLine("\n=== Array Dinamis (Input dari User) ===");
            Console.Write("Masukkan jumlah elemen array: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Input jumlah elemen
            int[] arrayDinamis = new int[n]; // Membuat array dinamis

            // Mengisi array dari input user
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Masukkan elemen ke-{i + 1}: ");
                arrayDinamis[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Menampilkan array hasil input user
            Console.WriteLine("\nIsi Array Dinamis:");
            foreach (int elemen in arrayDinamis)
            {
                Console.WriteLine(elemen);
            }
        }
    }
}

/*
PENJELASAN:

    1. Array Satu Dimensi:
        Array arraySatuDimensi dideklarasikan dan diinisialisasi langsung.
        Elemen diakses menggunakan indeks dalam perulangan for.

    2. Array Dua Dimensi:
        Array arrayDuaDimensi adalah matriks 2x2.
        Elemen diakses menggunakan dua indeks [baris, kolom] dalam perulangan bersarang.

    3. Array sebagai Parameter:
        Method CetakArray menerima parameter berupa array dan mencetak isinya menggunakan foreach.

    4. Array dengan Foreach:
        Array namaBuah digunakan dalam perulangan foreach untuk mencetak setiap elemen.

    5. Array Dinamis:   
        Ukuran array ditentukan berdasarkan input user.
        Elemen array diisi melalui input user menggunakan perulangan for.
 */