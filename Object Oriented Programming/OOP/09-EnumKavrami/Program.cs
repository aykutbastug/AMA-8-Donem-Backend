namespace _09_EnumKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Roller.Yonetici.ToString());
            Console.WriteLine((int)RollerYeni2.SonKullanici);


            Roller rol = Roller.Satici;
            if (rol == Roller.SonKullanici)
                Console.WriteLine("Son kullanıcı");
            else if (rol == Roller.Satici)
                Console.WriteLine("Satıcı");

            Console.Clear();

            int[] degerler = (int[])Enum.GetValues(typeof(Roller));
            foreach (var item in degerler)
            {
                //Console.WriteLine(item);
                Console.WriteLine($"{Enum.GetName(typeof(Roller), item)} - {item}");
            }


            Console.WriteLine("---------");

            string[] isimler = Enum.GetNames(typeof(Roller));
            foreach (var item in isimler)
            {
                //Console.WriteLine(item);
                Roller _rol = (Roller)Enum.Parse(typeof(Roller), item);
                Console.WriteLine($"{item} - {(int)_rol}");
            }





            Console.WriteLine("---------RollerYeni");

            string[] isimler2 = Enum.GetNames(typeof(RollerYeni));
            foreach (var item in isimler2)
            {
                //Console.WriteLine(item);
                RollerYeni _rol = (RollerYeni)Enum.Parse(typeof(RollerYeni), item);
                Console.WriteLine($"{item} - {(int)_rol}");
            }

        }
    }

    enum Roller
    {
        Yonetici,
        SonKullanici,
        Satici
    }

    enum RollerYeni
    {
        Admin = 10,
        User = 5,
        Seller = 30
    }

    enum RollerYeni2
    {
        Yonetici = 10,
        SonKullanici = 15,
        Satici,
        Alici
    }
}
