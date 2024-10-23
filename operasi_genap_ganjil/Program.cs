using System;
class OperasiGenapGanjil
{

    static void Main()
    {
        int x;
        string s;
        Console.Clear();
        Console.Write("Masukan bilangan bulat : ");
        s = Console.ReadLine();
        x = int.Parse(s);

        if ((x % 2) == 0)
        {
            Console.WriteLine(x + " adalah bilangan genap");
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine(x + "adalah bilangan ganjil");
            Environment.Exit(1);
        }
    }
}





