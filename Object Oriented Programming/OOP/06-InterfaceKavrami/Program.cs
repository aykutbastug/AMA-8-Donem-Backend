namespace _06_InterfaceKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calisan calisan = new Calisan();
            Personel personel = new Personel();
            personel.Adi = "Aykut";
            personel.Soyadi = "Baştuğ";
            personel.GorevAta();
            personel.GorevTamamla();


            Koordinator koordinator = new Koordinator();
            koordinator.Adi = "Hasan";
            koordinator.Soyadi = "Çalışkan";
            koordinator.GorevAta();
            koordinator.GorevTamamla();
            koordinator.ToplantiPlanla();
            koordinator.ToplantiYap();


            Mudur mudur = new Mudur();
            mudur.Adi = "Betül";
            mudur.Soyadi = "Çalışkan";
            mudur.ToplantiYap();


            Asistan asistan = new Asistan();
            asistan.Adi = "Emel";
            asistan.Soyadi = "Sayın";
            asistan.ToplantiPlanla();
        }
    }
}
