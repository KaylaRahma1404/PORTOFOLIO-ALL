using System;
class OperasiPositifNegatifNetral 
{
    static void Main()
    {
        int x;
        string s;
        Console.Clear();
        Console.Write("Masukan bilangan : ");
        s = Console.ReadLine();
        x = int.Parse(s);

        if ((x + 0) > 0)
        {
            Console.WriteLine(x + "adalah bilangan Positif");
            Environment.Exit(1);
        }
        else if ((x - 0) < 0)
        {
            Console.WriteLine(x + "adalah bilangan Negatif");
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine(x + "adalah bilangan Netral");

        }
    }
}

