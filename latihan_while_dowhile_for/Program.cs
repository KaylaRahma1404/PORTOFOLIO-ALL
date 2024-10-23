using System;
class Contoh_Looping
{
    static void Main()
    {
        int i;
        Console.WriteLine("Menggunakan while:");
        i = 10; // nilai awal
        while (i > 0) // nilai akhir
        {
            Console.Write(i);
            i--; // counter
        }
        Console.WriteLine();



        Console.WriteLine("Menggunakan do-while:");
        i = 10;// nilai awal
        do
        {
            Console.Write(i);
            i--; //counter
        } while (i > 0); // nilai akhir

        Console.WriteLine();

        Console.WriteLine("Menggunakan for:");
        i = 10;
        for (i = 10; i > 0; i--)
        {
            Console.Write(i + " ");
        }
    }
}








       
        


