using System;
class InputPredikat
{
    static void Main()
    {

        string inputPredikat;

        Console.WriteLine("=== Input Predikat ===");
        Console.WriteLine();
        Console.WriteLine("Keterangan: ");
        Console.WriteLine("BSH => Berkembang Sesuai Harapan");
        Console.WriteLine("B   => Berkembang");
        Console.WriteLine("MB  => Mulai Berkembang");
        Console.WriteLine("BB  => Belum Berkembang");
        Console.WriteLine();
        Console.WriteLine("Masukkan predikat :");
        inputPredikat = Console.ReadLine();

        if (inputPredikat == "BSH" || inputPredikat == "bsh")
        {
            Console.WriteLine("Predikat = BSH (Berkembang Sesuai Harapan)");
            Environment.Exit(1);
        }
        else if (inputPredikat == "B" || inputPredikat == "b")
        {
            Console.WriteLine("Predikat = B (Berkembang)");
            Environment.Exit(1);
        }
        else if (inputPredikat == "MB" || inputPredikat == "mb")
        {

            Console.WriteLine("Predikat = MB (Mulai Berkembang)");
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Predikat = BB (Belum Berkembang)");
            Environment.Exit(1);
        }

    }
}
