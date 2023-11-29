namespace _10_Break_Continue_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break = Döngünün içerisinden çıkmak istediğimiz zaman kullanılır.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 3)
            //    {
            //        break;
            //    }

            //    //break;
            //}

            //Console.WriteLine("Bitti");


            //int a = 0;
            //while (a < 20)
            //{
            //    if (a == 10)
            //        break;

            //    Console.WriteLine(a);
            //    a++;
            //}



            //continue = döngüde bir sonraki adıma geçmek için kullanılır.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 5 || i == 8)
            //        continue;

            //    Console.WriteLine("Merhaba");

            //    //..
            //    //n
            //    //..
            //}



            int a = 0;
            while (a < 15)
            {
                if (a == 5)
                {
                    a++;
                    continue;
                }

                Console.WriteLine(a);
                a++;
            }



        }
    }
}
