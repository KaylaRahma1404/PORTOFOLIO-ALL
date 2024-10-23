using System;
class Balok
{
    static void Main()
    {
        //inisialisasi variabel--input 
        int panjang = 5, lebar = 4, tinggi = 10;

        //inisialisasi dinamis--proses
        int Volume_Balok = panjang * lebar * tinggi;

        //menampilkan informasi program 
        Console.WriteLine("Volume Balok");

        //menampilkan nilai variabel
        Console.WriteLine("Panjang = " + panjang);
        Console.WriteLine("Lebar   = " + lebar);
        Console.WriteLine("Tinggi  = " + tinggi);

        //menampilkan hasil peritungan--output
        Console.WriteLine("Volume Balok = " + Volume_Balok);
        //Console.Read();
    }
}
