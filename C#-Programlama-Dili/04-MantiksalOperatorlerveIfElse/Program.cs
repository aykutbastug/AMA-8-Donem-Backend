namespace _04_MantiksalOperatorlerveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı adınızı giriniz :");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi girin :");
            string sifre = Console.ReadLine();


            //if (kullaniciAdi == "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}


            //if (kullaniciAdi != "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}


            //if (kullaniciAdi == "aykut")
            //    Console.WriteLine("Kullanıcı adı doğru");
            //else
            //    Console.WriteLine("Kullanıcı adı hatalı");


            //if (sifre == "123")
            //    Console.WriteLine("Şifre doğru");
            //else
            //    Console.WriteLine("Şifre hatalı");



            //if (kullaniciAdi == "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");

            //    if (sifre == "123")
            //        Console.WriteLine("Şifre doğru");
            //    else
            //        Console.WriteLine("Şifre hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}


            //if (kullaniciAdi == "aykut" && sifre == "123")
            //    Console.WriteLine("Giriş başarılı");
            //else
            //    Console.WriteLine("Kullanıcı adı veya şifresi hatalı");


            if (kullaniciAdi != "aykut" || sifre != "123")
                Console.WriteLine("Kullanıcı adı veya şifresi hatalı");
            else
                Console.WriteLine("Giriş yaptınız");






            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string degisken1 = Console.ReadLine();
            if (degisken1 == "E" || degisken1 == "e")
                Console.WriteLine("Evet");
            else
                Console.WriteLine("Hayır");

        }
    }
}
