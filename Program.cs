class KodePos
{
    private string[] kelurahan = { "Batununggal", "A. Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    private int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };


    public int GetKodePos(string namaKelurahan)
    {
        for (int i = 0; i < kelurahan.Length; i++)
        {
            if (kelurahan[i] == namaKelurahan)
                return kodePos[i];
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        int kode = kodePos.GetKodePos(kelurahan);

        if (kode != -1)
            Console.WriteLine($"Kode Pos untuk {kelurahan}: {kode}");
        else
            Console.WriteLine("Kode pos tidak ditemukan");

    }
}
