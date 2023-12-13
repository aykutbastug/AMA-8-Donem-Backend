using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceKavrami
{
    public abstract class Calisan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

    public class Personel : Calisan, IGorev
    {
        public void GorevAta()
        {
            Console.WriteLine($"Personel Görev Ata = {Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Personel Görev Tamamla = {Adi} {Soyadi}");
        }
    }

    public class Koordinator : Calisan, IGorev, IToplanti, IPlanlama
    {
        public void GorevAta()
        {
            Console.WriteLine($"Koordinator Görev Ata = {Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Koordinator Görev Tamamla = {Adi} {Soyadi}");
        }

        public void ToplantiPlanla()
        {
            Console.WriteLine($"Koordinator Toplantı Planla = {Adi} {Soyadi}");
        }

        public void ToplantiYap()
        {
            Console.WriteLine($"Koordinator Toplantı Yap = {Adi} {Soyadi}");
        }
    }

    public class Asistan : Calisan, IPlanlama
    {
        public void ToplantiPlanla()
        {
            Console.WriteLine($"Asistan Toplantı Planla = {Adi} {Soyadi}");
        }
    }

    public class Mudur : Calisan, IToplanti
    {
        public void ToplantiYap()
        {
            Console.WriteLine($"Müdür Toplantı Yap = {Adi} {Soyadi}");
        }
    }


    public interface IGorev
    {
        void GorevAta();

        void GorevTamamla();
    }

    public interface IToplanti
    {
        void ToplantiYap();
    }

    public interface IPlanlama
    {
        void ToplantiPlanla();
    }
}



//toplantı planlama yapabilen bir Asistan sınıfı üretelim