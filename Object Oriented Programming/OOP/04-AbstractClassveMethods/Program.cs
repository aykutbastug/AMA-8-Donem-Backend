namespace _04_AbstractClassveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cihaz cihaz = new Cihaz();
            Elektronik elektronik = new Elektronik();
            elektronik.Barkod = "12345578";
            elektronik.CPU = "cpu";
            elektronik.RAM = "memory";

            elektronik.BarkodYaz();
            string sonuc = elektronik.Birlestir("aykut", " baştuğ");
            Console.WriteLine(sonuc);
        }
    }
}
