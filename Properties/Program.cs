namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek;
            kopek = new Kopek();
            kopek.SetAdi("Uzay");
            kopek.SetYasi(3);
            string text = "Adı: " + kopek.GetAdi() + ", " + " Yaşı: " + kopek.GetYasi() + ", ";
            Console.Write(text);
            kopek.Irki = "Rus Finosu";
            Console.WriteLine($"Irkı: {kopek.Irki}");
            kopek.Kos();

            kopek = new Kopek();
            kopek.Irki = "Dogo Argertino";
            Console.WriteLine(kopek.Irki);
        }
    }
    class Kopek
    {
        string _adi; // field (alan)
        int _yasi;

        public string Irki { get; set; } // özellik, property

        public void SetAdi(string adi) // method (davranış)
        {
            _adi = adi;
        }
        public string GetAdi()
        {
            return _adi;
        }
        public void SetYasi(int yasi)
        {
            _yasi = yasi;
        }
        public int GetYasi()
        {
            return _yasi;
        }
        public void Kos()
        {
            Console.WriteLine(_adi + "(" + Irki + ") koşuyor....");
        }
        
    }
   

}