namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan; // declare (tanımlama) 
            insan = new Insan(); // initialization (obje oluşturma)
            //insan.kimlikNo = "1234";
            //Console.WriteLine("Kimlik No: " + insan.kimlikNo);
            insan.SetAdi("Ali");
            string adi = insan.GetAdi();
            Console.WriteLine(adi); // Ali
            Insan yeniInsan = new Insan(); // yeni Insan tipinde obje oluşturulur, iki tane obje
            yeniInsan.SetAdi("Bilal");
            Console.WriteLine(yeniInsan.GetAdi()); // Bilal
            yeniInsan.SetSoyadi("Cancan");
            string yeniInsanSoyadi = yeniInsan.GetSoyadi();
            Console.WriteLine(yeniInsanSoyadi);
            Insan yepYeniInsan = new Insan();
            yepYeniInsan.SetAdi("Yağmur" + " ");
            yepYeniInsan.SetSoyadi("Arslan" + " ");
            yepYeniInsan.SetKimlikNo("12345678901");
            string text = yepYeniInsan.GetAdi() + " " + yepYeniInsan.GetSoyadi() + " (" + yepYeniInsan.GetKimlikNo() + ")";
            Console.WriteLine(text);




        }
    }

    class Insan
    {
        string _adi; // field (alan)
        string soyadi; //field

        string kimlikNo; // field

        public void SetAdi(string adi) // behaivor
        {
            _adi = adi;
        }

        public string GetAdi()
        {
            return _adi;
        }

        public void SetSoyadi(string soyadi)
        {
            this.soyadi = soyadi;
        }
        public string GetSoyadi()
        {
            return soyadi;
        }
        public void SetKimlikNo(string kimlikNo)
        {
            this.kimlikNo = kimlikNo;
        }
        public string GetKimlikNo()
        {
            return kimlikNo;
        }
    }
     
    
}