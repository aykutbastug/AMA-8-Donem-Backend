using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary
{

	//bu proje içerisinden erişebilir, fakat referans verilse dahi başka projelerden erişelemez
	//internal class ArabaOzel2
	//{

	//}

	public class Araba
	{
		//Fields (Değişkenler)
		private int _suankiHizi;
		public int _suankiYolcuSayisi;


        //Properties (Özellikler)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaksimumHiz { get; set; }



		//Events (Olaylar)
		public event EventHandler Calistirildi;



        //Constructors (Temel Yapı Oluşturucusu)
        public Araba()
        {
            
        }

        public Araba(int yolcuSayisi)
        {
            _suankiYolcuSayisi = yolcuSayisi;
        }


        //Methods (Metotlar)
        public void KapilariKilitle()
        {

        }
		public void KapilariKilitle(bool anahtarKontaktami)
		{

		}

        public void Ilerle()
        {

        }


        //Kisi isimli bir class olsun
        //KimlikNo, Adı, Soyadı, DoğumTarihi özellikleri olsun
        //Kisi sınıfını tcKimlikNo girmeden nesnesini oluşturmama izin vermesin.
	}
}
