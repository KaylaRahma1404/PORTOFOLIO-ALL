using System;
namespace cara_membuat_array
{
    class program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[6] { "putra", "caca", "rey", "keyra", "dika" , "hasna" };
            Console.WriteLine("\n Nama yang anda masukan adalah :");
            for (int a = 0; a < 6; a++)
            {
                Console.WriteLine(a + "" + nama[a] + "");
            }
            Console.ReadLine();

        }
    }
}
