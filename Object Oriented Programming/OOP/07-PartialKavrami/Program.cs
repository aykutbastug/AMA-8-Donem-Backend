namespace _07_PartialKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koordinat koordinat = new Koordinat();
            koordinat.X = 120;
            koordinat.Y = 50;
            koordinat.KoordinatYaz();
        }
    }

    partial class Koordinat
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    partial class Koordinat: IKoordinat
    {
        public void KoordinatOku(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void KoordinatYaz()
        {
            Console.WriteLine($"x={this.X};y={Y}");
        }
    }





    partial interface IKoordinat
    {
        void KoordinatOku(int x, int y);
    }

    partial interface IKoordinat
    {
        void KoordinatYaz();
    }
}
