using System;
class Balok
{
    static void Main()
    {
        int panjang, lebar, tinggi;
        //menampilkan informasi program
        Console.WriteLine("Volume Balok");

        //menampilkan nilai variabel
        Console.Write("Panjang  = 22 ");
        panjang = int.Parse(Console.ReadLine());
        Console.Write("Lebar = 14 ");
        lebar = int.Parse(Console.ReadLine());
        Console.Write("Tinggi = 28 ");
        tinggi = int.Parse(Console.ReadLine());
        //inisialisasi dinamis
        int Volume_Balok = panjang * lebar * tinggi;

        //menampilkan hasil peritungan 
        Console.WriteLine("Volume Balok = " + Volume_Balok);
        //Console.Read();
        
