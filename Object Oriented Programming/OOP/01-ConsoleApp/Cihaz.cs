using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{

    //Inheritance(Kalıtım) = Miras alma işlemi
    //Bir class sadece bir tane classı miras alabilir.
    public class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodYaz()
        {
            return "Barkod=" + Barkod;
        }


        //bu metoda sadece miras alan class üzerinden erişilebilir
        protected void Yaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }


        public Cihaz(string barkod, string seriNo)
        {
            this.Barkod = barkod;
        }
    }


    public class Elektronik : Cihaz
    {
        public Elektronik(string barkod, string seriNo) : base(barkod, seriNo)
        {
        }

        public string CPU { get; set; }

        public string RAM { get; set; }

        public void SatinAl()
        {
            Yaz("sddasd");
        }
        
    }


    public class Telefon : Elektronik
    {
        public Telefon(string barkod, string seriNo) : base(barkod, seriNo)
        {
        }

        public string Renk { get; set; }
        public void AramaYap()
        {
            Console.WriteLine(base.BarkodYaz());
            Console.WriteLine("Aram Yapıldı");
        }
    }

    public class Bilgisayar : Elektronik
    {
        public Bilgisayar(string barkod, string seriNo) : base(barkod, seriNo)
        {
        }
    }

    public class Monitor : Cihaz
    {
        public Monitor(string barkod, string seriNo) : base(barkod, seriNo)
        {
        }
    }
}
