using System;
class KEYMOCHICE
{
    static void Main()
    {
        string Predikat, confirm;
        do
        {

            Console.WriteLine("========== KEYMOCHICE ==========");
            Console.WriteLine();
            int pilih;
            string masuk;
            Console.WriteLine("MENU");
            Console.WriteLine(" 1. Caramel mochi");
            Console.WriteLine(" 2. Ice green tea");
            Console.WriteLine(" 3. Ice coklat");
            Console.WriteLine(" 4. Ice taro");
            Console.WriteLine(" 5. Box setia = Caramel mochi + ice green tea ");
            Console.WriteLine(" 6. Box harapan= Caramel mochi + ice coklat  ");
            Console.WriteLine(" 7. Box tulus = Caramel mochi + ice taro ");
            Console.WriteLine(" 8. Box spesial = Caramel mochi + ice green tea + ice coklat + ice taro ");
            Console.Write("Masukan  nomor paket box : ");
            masuk = Console.ReadLine();
            pilih = Convert.ToInt32(masuk);
            if (pilih == 1)
            {
                Console.WriteLine("Caramel Mochi = 15.000");
            }
            else if (pilih == 2)
            {
                Console.WriteLine("Ice Green tea = 12.000");
            }
            else if (pilih == 3)
            {
                Console.WriteLine("Ice Coklat = 15.000");
            }
            else if (pilih == 4)
            {
                Console.WriteLine("Ice Taro = 14.000");
            }
            else if (pilih == 5)
            {
                Console.WriteLine("Box setia = Caramel mochi + ice green tea = 15.000 + 12.000 = 27.000");
            }
            else if (pilih == 6)
            {
                Console.WriteLine("Box harapan = Caramel mochi + ice coklat = 15.000 + 15.000 = 30.000");
            }
            else if (pilih == 7)
            {
                Console.WriteLine("Box tulus =  Caramel mochi + ice taro = 15.000 + 14.000 = 29.000");
            }
            else if (pilih == 8)
            {
                Console.WriteLine("Box spesial =  Caramel mochi + ice green tea + ice coklat + ice taro = 15.000 + 12.000 +15.000 +14.000 = 56.000");
            }
            else
            {
                Console.WriteLine("Maaf pesanan yang anda pilih tidak tersedia.");

                masuk = Console.ReadLine();
                pilih = Convert.ToInt32(masuk);
            }
            for (int i = 1; i > 0; i--) ;
            {
                for (int j = 1; j > 0; j++) ;
                {
                    Console.WriteLine("Apakah anda sudah yakin dengan pesanan ini?");
                    Console.WriteLine("1.ya");
                    Console.WriteLine("2.tidak");
                    Console.WriteLine("pilih");
                    masuk = Console.ReadLine();
                    pilih = Convert.ToInt32(masuk);
                    if (pilih == 1)
                    {

                        Console.WriteLine(" Selamat menikmati ");
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Masukan ulang pesanan anda");
                    }
                    masuk = Console.ReadLine();
                    pilih = Convert.ToInt32(masuk);
                    if (pilih == 1)
                    {
                        Console.WriteLine("Caramel Mochi = 15.000");
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Ice Green tea = 12.000");
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Ice Coklat = 15.000");
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Ice Taro = 14.000");
                    }
                    else if (pilih == 5)
                    {
                        Console.WriteLine("Box setia = Caramel mochi + ice green tea = 15.000 + 12.000 = 27.000");
                    }
                    else if (pilih == 6)
                    {
                        Console.WriteLine("Box harapan = Caramel mochi + ice coklat = 15.000 + 15.000 = 30.000");
                    }
                    else if (pilih == 7)
                    {
                        Console.WriteLine("Box tulus =  Caramel mochi + ice taro = 15.000 + 14.000 = 29.000");
                    }
                    else if (pilih == 8)
                    {
                        Console.WriteLine("Box spesial =  Caramel mochi + ice green tea + ice coklat + ice taro = 15.000 + 12.000 +15.000 +14.000 = 56.000");
                    }
                    else
                    {
                        Console.WriteLine("MAAF KODE SALAH, SILAHKAN COBA LAGI");
                    }
                }
            }
            Console.WriteLine("Apakah anda ingin memesan lagi?");
            Console.WriteLine("Iya/Tidak");
            confirm = Console.ReadLine();

            Console.Clear();

        } while (confirm == "iya/tidak");

    }
}
