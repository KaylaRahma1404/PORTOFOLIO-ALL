using System;
class InputPredikatDenganNilai
{
    static void Main()
    {
        string strNilai;
        int nilai;

        Console.WriteLine("=== Input Predikat Dengan Nilai ===");
        Console.WriteLine();
        Console.WriteLine("Keterangan Nilai: ");
        Console.WriteLine("A = 90 - 100");
        Console.WriteLine("B = 80 - 89");
        Console.WriteLine("C = 70 - 79");
        Console.WriteLine("D = 60 - 69");
        Console.WriteLine("E < 60");
        Console.WriteLine();

        Console.Write("Masukkan Nilai untuk Mengetahui Predikatnya (0 - 100) : ");
        strNilai = Console.ReadLine();
        nilai = int.Parse(strNilai);

        if (nilai < 60)
        {
            Console.WriteLine("Nilai Predikatnya adalah E");
            Console.WriteLine("Tingkatkan lagi belajarnya untuk mendapatkan nilai yang lebih baik");
            Console.WriteLine();
            Environment.Exit(1);
        }
        else if ((nilai >= 60) && (nilai <= 69))
        {
            Console.WriteLine("Nilai Predikatnya adalah D");
            Console.WriteLine("Terus tingkatkan lagi belajarnya ");
            Console.WriteLine();
            Environment.Exit(1);
        }
        else if ((nilai >= 70) && (nilai <= 79))
        {
            Console.WriteLine("Nilai Predikatnya adalah C");
            Console.WriteLine("Nilai yang kurang baik, tetapi jika belajarnya lebih giat lagi, maka akan mendapatkan nilai yang lebih baik");
            Environment.Exit(1);
        }
        else if ((nilai >= 80) && (nilai <= 89))
        {
            Console.WriteLine("Nilai Predikatnya adalah B");
            Console.WriteLine("Nilai yang cukup baik, jika perlu lebih giat lagi belajarnya");
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Nilai Predikatnya adalah A");
            Console.WriteLine("Nilai yang sangat baik, terus pertahankan!");
            Environment.Exit(1);
        }

    }
}



