namespace Wizualizer.ElementyDrzwi;

public class Klamka
{
    public string Model { get; set; }
    public string Kolor { get; set; }

    public double KlamkaSzerokość { get; }
    public double KlamkaWysokość { get; }

    public Klamka(string kolor, string model = "")
    {
        Kolor = kolor;
        Model = model;
        KlamkaSzerokość = 25d;
        KlamkaWysokość = 120d;
    }
}