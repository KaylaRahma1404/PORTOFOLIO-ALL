using System;
class NamaBulan
{
    static void Main()
    {
        int nobulan;
        string s, namabulan = "";
        Console.Clear();
        Console.Write("Masukan urutan nomor bulan:");
        s = Console.ReadLine();//string1
        nobulan = int.Parse(s);//integer1

        switch (nobulan)
        {
            case 1: namabulan = "Januari";break;
            case 2: namabulan = "Februari";break;
            case 3: namabulan = "Maret";break;
            case 4: namabulan = "April";break;
            case 5: namabulan = "Mei";break;
            case 6: namabulan = "Juni";break;
            case 7: namabulan = "Juli";break;
            case 8: namabulan = "Agustus";break;
            case 9: namabulan = "September";break;
            case 10: namabulan = "Oktober";break;
            case 11: namabulan = "November";break;
            case 12: namabulan = "Desember";break;

            default: //else-false
                Console.WriteLine("Maaf kode salah");
                break;
        }
        if (namabulan !="")
        {
            Console.WriteLine("Bulan ke-" + nobulan + "adalah" + namabulan);
        }
        else
        {
            Console.WriteLine("Tidak ada bulan ke-" + nobulan);
        }
    }
}
