using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractClassveMethods
{
    //nesnesi oluşturulamayan (new'lenemeyen) sadece miras alınabilen soyut sınıflar demektir.
    abstract class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodGetir()
        {
            return "Barkod=" + this.Barkod;
        }

        //mutlaka public erişim belirleyicisi olmak zorundadır
        //mutlaka içinde bulunduğu sınıf absract olması gerekiyor
        //hiç bir şekilde kod bloğu bulunmaz
        //miras alınan sınıfta override edilerek kod bloğunun oluşturulması zorunludur
        public abstract void BarkodYaz();
        public abstract string Birlestir(string deger1, string deger2);
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
