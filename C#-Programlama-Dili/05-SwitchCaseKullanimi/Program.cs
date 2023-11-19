namespace _05_SwitchCaseKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sayi1 = 9;

            //switch (sayi1)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı bir değer girdiniz..");
            //        break;

            //}



            //kullanıcıda bir ay girmesini isteyelim. girdiği ayın mevsimini geriye dönelim.
            //Aralık => Aralık ayı kış mevsimindedir

            Console.WriteLine("bir ay giriniz");
            string ay=Console.ReadLine();
  

            Console.WriteLine("Bir ay giriniz..");
            string girilenAy = Console.ReadLine();

            switch (girilenAy)
            {
                case "Aralık":
                case "Ocak":
                case "Şubat":
                    Console.WriteLine($"{girilenAy} ayı KIŞ mevsimindedir.");
                    break;

                case "Mart":
                case "Nisan":
                case "Mayıs":
                    Console.WriteLine(girilenAy + " ayı İLKBAHAR mevsimindedir");
                    break;

                case "Haziran":
                case "Temmuz":
                case "Ağustos":
                    Console.WriteLine($"{girilenAy} ayı YAZ mevsimindedir.");
                    break;

                case "Eylül":
                case "Ekim":
                case "Kasım":
                    Console.WriteLine($"{girilenAy} ayı SONBAHAR mevsimindedir.");
                    break;

                default:
                    Console.WriteLine("Hatalı bir değer girdiniz");
                    break;
            }

            Console.WriteLine("Bir ay giriniz..");
            girilenAy = Console.ReadLine();
            if (girilenAy == "Aralık" || girilenAy == "Ocak" || girilenAy == "Şubat")
                Console.WriteLine($"{girilenAy} ayı KIŞ mevsimindedir.");

            else if (girilenAy == "Mart" || girilenAy == "Nisan" || girilenAy == "Mayıs")
                Console.WriteLine($"{girilenAy} ayı İLKBAHAR mevsimindedir.");

            else if (girilenAy == "Haziran" || girilenAy == "Temmuz" || girilenAy == "Ağustos")
                Console.WriteLine($"{girilenAy} ayı YAZ mevsimindedir.");

            else if (girilenAy == "Eylül" || girilenAy == "Ekim" || girilenAy == "Kasım")
                Console.WriteLine($"{girilenAy} ayı SONBAHAR mevsimindedir.");

            else
                Console.WriteLine("Hatalı bir değer girdiniz"); 

        }
    }
}
