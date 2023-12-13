using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_VirtualMethods
{
    abstract class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodGetir()
        {
            return "Barkod=" + this.Barkod;
        }

        //kod bloğu olan fakat istenirse miras alınan sınıf üzerinden override komutu ile yeniden kod bloğu oluşturabilir
        //miras alınan sınıfta override edilme zorunluluğu yoktur
        public virtual void BarkodYaz()
        {
            Console.WriteLine("base sınıftan geldi =" + BarkodGetir());
        }
        public virtual string Birlestir(string deger1, string deger2)
        {
            return "base sınıftan geldi =" + deger1 + deger2;
        }
    }

    class Elektronik : Cihaz
    {
        public string CPU { get; set; }
        public string RAM { get; set; }


        public override void BarkodYaz()
        {
            Console.WriteLine(BarkodGetir());
        }

        public override string Birlestir(string deger1, string deger2)
        {
            return deger1 + deger2;
        }
    }
}
