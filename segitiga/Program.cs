using System;
class Segitiga
{
    static void Main()
    {
        int alas, tinggi;
        //menampilkan informasi program
        Console.WriteLine("Luas Segitiga")

        //menampilkan nilai variabel
        Console.Write("Alas = ");
        alas = int .Parse(Console.ReadLine());
        Console.Write("Tinggi = ");
        tinggi = int .Parse(Console.ReadLine());

        //inisialisasi dinamis
        int luas_segitiga = alas + tinggi / 2;

        //menampilkan hasil perhitungan
        Console.WriteLine("Luas Segitiga = " + luas_segitiga);
        //Console.Read();

    }
}


