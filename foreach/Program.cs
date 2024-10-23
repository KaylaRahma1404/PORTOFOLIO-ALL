using System;
class Contoh_Foreach
{
    static void Main()
{
    // mendeklarasikan dan menginisialisasi array
    Console.Clear();
    // elemen 1 2 3 4 5
    int[] data = { 45, 50, 55, 60, 65, 70 };//elemen dalam array
                                        // index 0 1 2 3 4 5
    int jumlah;
    double ratarata;
    jumlah = 0;
    foreach (int elemen in data)
    {
        jumlah = jumlah + elemen;
    }
    ratarata = (double)jumlah / data.Length;
    Console.WriteLine("Data yang ada pada array (45, 50, 55, 60, 65, 70v) :");
    Console.WriteLine("Total Nilai = " + jumlah);
    Console.WriteLine("Rata-rata = " + ratarata);
}
}

