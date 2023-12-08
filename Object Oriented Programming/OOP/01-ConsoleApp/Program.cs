using _02_ClassLibrary;

namespace _01_ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Araba nesne = new Araba();
			nesne.Marka = "Opel";
			nesne.Model = "Corsa";
			nesne.MaksimumHiz = 180;

			Console.WriteLine("Arabanın Markası:" + nesne.Marka);
            Console.WriteLine(nesne.Marka  + " aracındaki Yolcu Sayısı :" + nesne._suankiYolcuSayisi);
			


            Araba nesne2 = new Araba(3);
			nesne2.Marka = "Fiat";
			nesne2.Model = "Linea";
			nesne2.MaksimumHiz = 180;
			nesne2.Ilerle();
			nesne2.KapilariKilitle();
			Console.WriteLine(nesne2.Marka + " aracındaki Yolcu Sayısı :" + nesne2._suankiYolcuSayisi);



			Kisi kisi = new Kisi(123);
			kisi.Adi = "Aykut";
			kisi.Soyadi = "BAŞTUĞ";
			kisi.Dogumtarihi = DateTime.Today.AddYears(-38);


            Console.WriteLine("Kişi Bilgileri");
            Console.WriteLine("Kimlik No=" + kisi.TcKimlikNo);
			Console.WriteLine("Adı Soyadı=" + kisi.AdiSoyadiGetir());
			Console.WriteLine("Doğum tarihi=" + kisi.Dogumtarihi.ToShortDateString());


			Console.Clear();
			Personel.Adi = "Aykut";
			Personel.Soyadi = "Soyadı";

            Console.WriteLine("Personel Bilgileri = " + Personel.Adi + " " + Personel.Soyadi);


			Ogretmen ogretmen = new Ogretmen();
			ogretmen.Adi = "Aykut";
			Ogretmen.Soyadi = "BAŞTUĞ";


			Console.Clear();
			Sirket sirket = new Sirket();
			sirket.PostaKodu = 34560;
			sirket.Adi = "Acunmedya Akademi";
            Console.WriteLine("Şirket Adı = " + sirket.Adi);


            //Console.Clear();
			Kare kare = new Kare();
			kare.KenarUzunlugu = 120;
            Console.WriteLine("Kenar Uzunluğu=" + kare.KenarUzunlugu);



			Console.Clear();
			Elektronik elektronik = new Elektronik("12313", "asasd");
			//elektronik.ya


			Telefon telefon = new Telefon("12313", "asasd");
			telefon.RAM = "12 GB";
			telefon.CPU = "Snapdrogan";
			telefon.Renk = "Siyah";
			
        }

	}



	//Kare isimli bir classs olsun
	//KenarUzunlugu isimli propery olsun
	//KenarUzunlugu dolu olasak şekilde nesne oluşturabileyim (ctor)
	//Karenin alanini hesaplayıp dönen bir metot olsun
	//Karenin kenar uzunluğu kullanıcı ekrandan girebilsin, girdikten sonra karenin alanını hesaplayan metot ile ekrana yazdırsın



}
