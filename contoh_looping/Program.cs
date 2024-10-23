using System;
class Contoh_looping
{
    static void Main()
    {
        Console.Clear();
        int i;
        i = 1;
        Console.WriteLine("Contoh Latihan Looping dengan DO - WHILE");
        while (i > 10)
        {
            Console.WriteLine(i + "ganjil");
            i = i + 1;
        }
        if ((i %= 2) == 0)

    }
}

