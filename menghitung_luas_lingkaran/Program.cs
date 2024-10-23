using System;
class Lingkaran
{
    static void main()
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




    
