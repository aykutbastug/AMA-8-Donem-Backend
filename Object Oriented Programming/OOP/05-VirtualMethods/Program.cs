namespace _05_VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
