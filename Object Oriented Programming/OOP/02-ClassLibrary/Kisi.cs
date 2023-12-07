public class Kisi
{
    public int TcKimlikNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public DateTime Dogumtarihi { get; set; }
	
	public Kisi(int kimlikNo)
    {
        TcKimlikNo = kimlikNo;
    }



    public string AdiSoyadiGetir()
    {
        return this.Adi + " " + this.Soyadi;
    }
}

public static class Personel
{
    public static string Adi { get; set; }
    public static string Soyadi { get; set; }
}

public class Ogretmen
{
	public string Adi { get; set; }
	public static string Soyadi { get; set; }
}