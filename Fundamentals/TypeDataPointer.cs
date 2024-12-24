using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class TypeDataPointer
    {
        //public static void Main()
        //{
        //    int number = 42;
        //    int* ptr = &number;  // Pointer menunjuk ke alamat memori dari 'number'

        //    Console.WriteLine("Nilai dari number: " + number);
        //    Console.WriteLine("Alamat memori dari number: " + (ulong)ptr);
        //    Console.WriteLine("Nilai yang ditunjuk oleh ptr: " + *ptr);

        //    *ptr = 100;  // Mengubah nilai melalui pointer
        //    Console.WriteLine("Nilai number setelah diubah melalui pointer: " + number);
        //}
    }
}

/*
 Dalam C#, pointer adalah tipe data khusus yang menyimpan alamat memori dari variabel lain. Pointer memungkinkan akses langsung ke lokasi memori, sehingga berguna untuk pemrograman tingkat rendah, seperti pemrograman sistem atau interaksi dengan perangkat keras.

Untuk menggunakan pointer di C#, Anda perlu mengaktifkan kode unsafe (tidak aman) karena pointer dapat menyebabkan kesalahan memori jika tidak digunakan dengan benar.
 */
