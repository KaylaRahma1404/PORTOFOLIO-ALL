using System;
class keyramochice
{
    static void Main()
    {
        bool pemesanan = true;
        string jawaban;
        int nobox;
        string s, namapaketbox = "";
        
        do
        {
            Console.WriteLine("======================KEYMOCHICE========================= ");
            Console.WriteLine(" 1. Caramel mochi =  15.000");
            Console.WriteLine(" 2. Ice green tea =  12.000");
            Console.WriteLine(" 3. Ice coklat =  15.000");
            Console.WriteLine(" 4. Ice taro = 14.000");
            Console.WriteLine(" 5. Box 1 = Caramel mochi + ice green tea = 15.000 + 12.000 = 27.000 ");
            Console.WriteLine(" 6. Box 2 = Caramel mochi + ice coklat =  15.000 + 15.000 = 30.000 ");
            Console.WriteLine(" 7. Box 3 = Caramel mochi + ice taro =  15.000 + 14.000 = 29.000 ");
            Console.WriteLine(" 8. Box spesial = Caramel mochi + ice green tea + ice coklat + ice taro = 15.000 + 12.000 +15.000 +14.000 = 56.000 ");

            Console.Write("Masukan  nomor paket box : ");
            s = Console.ReadLine();//string 1
            nobox = int.Parse(s);//integer 1

            
            switch (nobox)
            {
                case 1: namapaketbox = " Caramel Mochi = 15.000"; break;
                case 2: namapaketbox = " Ice Green tea = 12.000";break;
                case 3: namapaketbox = " Ice Coklat = 15.000";break;
                case 4: namapaketbox = " Ice Taro = 14.000";break;
                case 5: namapaketbox = "Box 1 = Caramel mochi + ice green tea = 15.000 + 12.000 = 27.000"; break;
                case 6: namapaketbox = "Box 2 = Caramel mochi + ice coklat = 15.000 + 15.000 = 30.000"; break;
                case 7: namapaketbox = "Box 3 =  Caramel mochi + ice taro = 15.000 + 14.000 = 29.000"; break;
                case 8: namapaketbox = "Box spesial =  Caramel mochi + ice green tea + ice coklat + ice taro = 15.000 + 12.000 +15.000 +14.000 = 56.000"; break;

                    
                default: //else-false
                    Console.WriteLine("Maaf Persanan Anda tidak tersedia");
                    break;

              
            }

            if (pemesanan)
            {
                Console.WriteLine (" Box ke- " + nobox  + " adalah " + namapaketbox);
                Console.WriteLine("Apakah anda ingin melanjutkan pembelian lain? (Y/N)");
                jawaban = Console.ReadLine().ToLower();
                if  (jawaban != "y")
                {
                    
                    Console.WriteLine("Terimakasih sudah mengunjungi KEYMOCHICE");
                    pemesanan = false;

                }
                
                
                Console.WriteLine("===========================================================================================");
            }
        } while (pemesanan);
    }
}
