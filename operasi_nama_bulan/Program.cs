using System;
using System.ComponentModel.Design;

class OperasiNamaBulan
{
    static void Main()
    {
        int nobulan;
        string s, bulan = "";

        Console.WriteLine("Menentukan Nama Bulan ");
        Console.Write("Masukan Nomor Bulan : ");
        s = Console.ReadLine();
        nobulan = int.Parse(s);

        if (nobulan == 1)
        {
            bulan = "Januari";
        }
        else if (nobulan == 2)
        {
            bulan = "Februari";
        }
        else if (nobulan == 3)
        {
            bulan = "Maret";
        }
        else if (nobulan == 4)
        {
            bulan = " April";
        }
        else if (nobulan == 5)
        {
            bulan = "Mei";
        }
        else if (nobulan == 6)
        {
            bulan = "Juni";
        }
        else if (nobulan == 7)
        {
            bulan = "Juli";
        }
        else if (nobulan == 8)
        {
            bulan = "Agustus";
        }
        else if (nobulan == 9)
        {
            bulan = "September";
        }
        else if (nobulan == 10)
        {
            bulan = "Oktober";
        }
        else if (nobulan == 11)
        {
            bulan = "November";
        }
        else if (nobulan == 12)
        {
            bulan = "Desember";
        }
        else
        {
            Console.WriteLine("Maaf kode salah...");
        }
        // menampilkan hasil
        if(bulan.Length !=0)
        {
            Console.WriteLine("Bulan ke-" + nobulan + "adalah" + bulan);
        }
        else
        {
            Console.WriteLine("Tidak ada bulan ke -" + nobulan);
        }
    }
}
