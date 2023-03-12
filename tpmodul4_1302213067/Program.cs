internal class KodePos
{
    public string[] kelurahan = { "Batununggal", "A. Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari",
        "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    public int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

    public int getKodePos_1302213067(string x)
    {
        int i = 0;
        while (i < kelurahan.Length)
        {
            if (kelurahan[i] == x)
            {
                return kodePos[i];
            }
            i++;
        }
        return -1;
    }
}


class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kp.getKodePos_1302213067("Batununggal"));
        Console.WriteLine("Kode Pos A. Kujangsari: " + kp.getKodePos_1302213067("A. Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + kp.getKodePos_1302213067("Mengger"));
        Console.WriteLine("Kode Pos Wates: " + kp.getKodePos_1302213067("Wates"));
        Console.WriteLine("Kode Pos Cijaura: " + kp.getKodePos_1302213067("Cijaura"));
        Console.WriteLine("Kode Pos Jatisari: " + kp.getKodePos_1302213067("Jatisari"));
        Console.WriteLine("Kode Pos Margasari: " + kp.getKodePos_1302213067("Margasari"));
        Console.WriteLine("Kode Pos Sekejati: " + kp.getKodePos_1302213067("Sekejati"));
        Console.WriteLine("Kode Pos Kebonwaru: " + kp.getKodePos_1302213067("Kebonwaru"));
        Console.WriteLine("Kode Pos Maleer: " + kp.getKodePos_1302213067("Maleer"));
        Console.WriteLine("Kode Pos Samoja: " + kp.getKodePos_1302213067("Samoja"));



    }
}
