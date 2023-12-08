using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{
    internal class Sirket
    {
        public string Adi { get; set; } = "Codeove";
        public string? Adres { get; set; }



        private int _PostaKodu;

        public int PostaKodu
        {
            get { return _PostaKodu; }
            set { _PostaKodu = value; }
        }


        //public int GetPostaKodu()
        //{
        //    return _PostaKodu;
        //}

        //public void SetPostaKodu(int value)
        //{
        //    _PostaKodu = value;
        //}

    }

    class Kare
    {
        private int _KenarUzunlugu;

        public int KenarUzunlugu
        {
            get 
            { 
                return _KenarUzunlugu;
            }
            set 
            {
                if (value > 100)
                    value = 100;

                _KenarUzunlugu = value; 
            }
        }

    }
}
