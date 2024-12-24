using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class VariableConst
    {
        // Variable Const
        const double PI = 3.14159;
        const string appName = "Belajar C#";

        //public static void Main()
        //{
        //    double radius = 5.0;
        //    double area = PI * radius * radius;

        //    Console.WriteLine("Selamat datang di " + appName);
        //    Console.WriteLine("Luas lingkaran dengan jari-jari " + radius + " adalah " + area);
        //}
    }
}

/*
 Penjelasan:
    1. Variable konstanta / Const adalah variable yang nilainya tidak dapat diubah setelah di deklarasikan.
    2. Dideklarasikan menggunakan keywor const
    3. Harus diinisialisasi saat di deklarasikan.
    4. Bersifat statik secara implisit, artinya hanya ada satu salinan di seluruh program.
    5. Digunakan untuk nilai yang tidak dapat berubah seperti nilai matematis, string tetap, atau konfigurasi.
 */