class Mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public void NyalaMesin()
    {
        System.Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " nyalamesin");
    }
    public void MatiMesin()
    {
        System.Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " matimesin");
    }
}

class Toyota : Mobil
{
    public Toyota()
    {
merk = "Toyota";
    }
}
class Agya : Toyota
{
    public Agya()
    {
        tipe = "Agya";
    }
}

class Innova : Toyota
{
    public Innova()
    {
        tipe = "Innova";
    }
}

class Avanza : Toyota
{
    public Avanza()
    {
        tipe = "Avanza";
    }
    public void NyalakanLampu()
    {
        System.Console.WriteLine("Lampu mobil " + merk + " bertipe " + tipe + " menyalakan lampu mobil");
    }
}

class Daihatsu : Mobil
{
    public Daihatsu()
    {
        merk = "Daihatsu";
    }
}
class Ayla : Daihatsu
{
    public Ayla()
    {
        tipe = "Ayla";
    }
}

class Xenia : Daihatsu
{
    public Xenia()
    {
        tipe = "Xenia";
    }
}
class Honda : Mobil
{
    public Honda()
    {
        merk = "Honda";
    }
}

class Brio : Honda
{
    public Brio()
    {
        tipe = "Brio";
    }
}

class Civic : Honda
{
    public Civic()
    {
        tipe = "Civic";
    }
    public void VtecKickedin()
    {
        System.Console.WriteLine("Ngeeeng Wooosh!!");
    }
}
class Ban
{ public string merk; }

class Michelin : Ban
{
    public Michelin()
    {  merk = "Michelin"; }
}

class Bridgestone : Ban
{
    public Bridgestone()
    { merk = "Bridgestone"; }
}

class Program
{
    public static void Main(string[] args)
    {
        Mobil mobil1 = new Agya();
        mobil1.ban = new Michelin();
        mobil1.NyalaMesin();
        mobil1.MatiMesin();
        mobil1.merk = "Michelin";
        Console.WriteLine ("Merk roda Mobil:" + mobil1.merk);
        Avanza mobil2 = new Avanza();
        mobil2.ban = new Bridgestone();
        mobil2.NyalakanLampu();
        Civic civic1 = new Civic();
        civic1.ban = new Bridgestone();
    }
}