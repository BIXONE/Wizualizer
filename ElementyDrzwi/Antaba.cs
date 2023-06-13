namespace Wizualizer.ElementyDrzwi;

public class Antaba
{
    public string Model { get; set; }
    public string Kolor { get; set; }

    public double AntabaSzerokość { get; }
    public double AntabaWysokość { get; }
    public double AntabaParametrX { get; }
    public double AntabaParametrY { get; }

    public Antaba(string kolor, string wysokość, double wysokośćWPrzyldze = 0d, string model = "")
    {
        Kolor = kolor + " Okucia";
        AntabaParametrX = 155d;
        AntabaParametrY = wysokośćWPrzyldze;
        AntabaSzerokość = 35d;

        switch (wysokość)
        {
            case "1800": AntabaWysokość = 1800d; break;
            case "1600": AntabaWysokość = 1600d; break;
            case "1200": AntabaWysokość = 1200d; break;
            case "600": AntabaWysokość = 600d; break;
            default:
                break;
        }
    }
}
