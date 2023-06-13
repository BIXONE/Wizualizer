namespace Wizualizer.ElementyDrzwi;

public class SzyldDolny
{
    bool AntabaIsTrue { get; set; }

    public string Kolor { get; set; }

    public double SzyldDolnySzerokość { get; }
    public double SzyldDolnyWysokość { get; }
    public double SzyldDolnyParametrX { get; }
    public double SzyldDolnyParametrY { get; }
    public double SzyldDolnyWysokośćKlamkiWSzyldzie { get; }

    public SzyldDolny(string kolor, bool antabaIsTrue)
    {
        Kolor = kolor + " Okucia";
        AntabaIsTrue = antabaIsTrue;

        SzyldDolnyParametrX = 68d;
        SzyldDolnyParametrY = 1020d;
        SzyldDolnyWysokośćKlamkiWSzyldzie = 120d;

        if (AntabaIsTrue)
        {
            SzyldDolnySzerokość = 33d;
            SzyldDolnyWysokość = 177d;
        }
        else
        {
            SzyldDolnySzerokość = 50d;
            SzyldDolnyWysokość = 200d;
        }
    }
}
