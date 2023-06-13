namespace Wizualizer.ElementyDrzwi;

public class SzyldGórny
{
    public string Kolor { get; set; }

    public double SzyldGórnySzerokość { get; }
    public double SzyldGórnyWysokość { get; }
    public double SzyldGórnyParametrX { get; }
    public double SzyldGórnyParametrY { get; }
    public double SzyldGórnyWysokośćWkładkiWSzyldzie { get; }

    public SzyldGórny(SzyldDolny szyldDolny)
    {
        Kolor = szyldDolny.Kolor;

        SzyldGórnySzerokość = szyldDolny.SzyldDolnySzerokość;
        SzyldGórnyWysokość = 120d;
        SzyldGórnyParametrX = szyldDolny.SzyldDolnyParametrX;
        SzyldGórnyParametrY = 1484d;
        SzyldGórnyWysokośćWkładkiWSzyldzie = 95d;
    }
}
