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

class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
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

        DoorMachine pintu = new DoorMachine();
        Console.WriteLine("Menjalankan simulasi perubahan state pintu:");
        pintu.BukaPintu();
        pintu.KunciPintu();

    }
}
