namespace Wizualizer.Figury;

public class WąskiPasekDoProstokąta
{
    public double Szerokość { get; }
    public double Wysokość { get; }
    public double PromieńZaokrągleniaPozytywny { get; set; }
    public double PromieńZaokrągleniaNegatywny { get; set; }

    public WąskiPasekDoProstokąta(double szerokość, double wysokość, double promieńZaokrągleniaPozytywny = 0d, double promieńZaokrągleniaNegatywny = 0d)
    {
        Szerokość = szerokość;
        Wysokość = wysokość;
        PromieńZaokrągleniaPozytywny = promieńZaokrągleniaPozytywny;
        PromieńZaokrągleniaNegatywny = promieńZaokrągleniaNegatywny;
    }
}
