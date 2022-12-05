using System.Security.Principal;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri;
            musteri = new Musteri();
            musteri.Adi = "Ali";
            musteri.Soyadi = "Arslan";
            musteri.KadinMi = false;
            musteri.KartNo = "1234 5678 9012 3456";
            Console.WriteLine(musteri.UnvanliTamAdi);
            Console.WriteLine(musteri.KartNo);


        }
    }

    class Musteri
    {

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool KadinMi { get; set; } = true;

        string _kartNo;
        public string KartNo
        {
            get
            {
                return "**** **** **** " + _kartNo.Substring(15);
            }
            set
            {
                _kartNo = value;
            }

        }
        //public string UnvanliTamAdi
        //{
        //    get
        //    {
        //        if (KadinMi)
        //            return "Bayan " + Adi + " " + Soyadi;
        //        return "Bay " + Adi + " " + Soyadi;
        //    }

        //}

        public string UnvanliTamAdi => (KadinMi ? "Bayan " : "Bay ") + Adi + " " + Soyadi; // get

    }


}