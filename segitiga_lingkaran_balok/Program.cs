using System;
class Balok
{
    static void Main()
    {
        int panjang, lebar, tinggi;
        //menampilkan informasi program
        Console.WriteLine("Volume Balok");

        //menampilkan nilai variabel
        Console.Write("Panjang  = ");
        panjang = int.Parse(Console.ReadLine());
        Console.Write("Lebar  = ");
        lebar = int.Parse(Console.ReadLine());
        Console.Write("Tinggi  = ");
        tinggi = int.Parse(Console.ReadLine());
        //inisialisasi dinamis
        int Volume_Balok = panjang * lebar * tinggi;

        //menampilkan hasil perhitungan
        Console.WriteLine("Volume Balok = " + Volume_Balok);
        //Console.Read();


        {
            Console.WriteLine("-------");

            int alas, Tinggi;
            //menampilkan informasi program
            Console.WriteLine("Luas Segitiga");

            //menampilkan nilai variabel
            Console.Write("Alas  = ");
            alas = int.Parse(Console.ReadLine());
            Console.Write("Tinggi  = ");
            Tinggi = int.Parse(Console.ReadLine());

            //inisialisasi dinamis
            int Luas_Segitiga = alas * Tinggi / 2;

            //menampilkan hasil perhitungan
            Console.WriteLine("Luas Segitiga = " + Luas_Segitiga);
            //Console.Read();


            {
                Console.WriteLine("-----");


                const float Phi = 3.14f;

                Console.WriteLine("== PROGRAM LUAS LINGKARAN ==");
                Console.Write("Input jari-jari: ");
                int r = int.Parse(Console.ReadLine());

                var luas = Phi * r * r;

                Console.WriteLine($"Luas Lingkaran = {luas}");

            }
        }

    }
}


