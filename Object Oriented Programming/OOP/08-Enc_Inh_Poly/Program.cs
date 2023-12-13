namespace _08_Enc_Inh_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(20);
            Console.WriteLine("kenar uzunluğu=" + kare.KenarA);



            Kare kare2 = new Kare();
            Console.WriteLine("kenar uzunluğu=" + kare2.KenarA);

        }
    }

    public class Kare
    {
        //Encapsulation (kapsülleme) = classların içerisindeki fieldlara değer atama ve okuma işlemi sırasında araya girebilme işlemine denir. (Properties)
        //Inheritance (Miras Alma) = Interface ler yada normal classlar ile miras alarak classların öğerlerinin genişletilebilmesine denir.
        //Polymorphism (Çok biçimlilik) = bir metodun miras alınan sınıfta ezilerek (override) şeklinin yada görevinin değiştirilmesi işlemine denir. (virtual metohod, abstract method)


        private int _KenarA;

        public int KenarA
        {
            get { return _KenarA; }
            set { _KenarA = value; }
        }

        //public int GetKenarA()
        //{
        //    return _KenarA;
        //}

        public Kare()
        {

        }

        public Kare(int kenarUzunlugu)
        {
            this.KenarA =kenarUzunlugu;
        }
    }
}
