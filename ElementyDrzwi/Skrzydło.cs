namespace Wizualizer.ElementyDrzwi;

public class Skrzydło
{
    public bool KierunekisRight { get; }

    public string Technologia { get; }
    public string SkrzydłoKolor { get; }
    public string InoxKolor { get; }
    public string SzkłoKolor { get; }

    public double SzerokośćWPrzyldze { get; }
    public double WysokośćWPrzyldze { get; }

    public Skrzydło(string technologia, string ościeżnica, bool kierunekPrawy, string szerokość, string wysokość, string poszycieKolor, string inoxKolor, string szkłoKolor)
    {
        Technologia = technologia;
        KierunekisRight = kierunekPrawy;
        SkrzydłoKolor = poszycieKolor;
        InoxKolor = inoxKolor;
        SzkłoKolor = szkłoKolor;

        switch (szerokość.ToUpper())
        {
            case "80N":
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 898d - 77;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 890d - 77;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = 927d - 78;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = 937d - 78;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 875d - 54d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 890d - 55d;
                    }
                }
                break;
            case "80":
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 948d - 77;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 962d - 77;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = 977d - 78;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = 987d - 78;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 925d - 54d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 940d - 55d;
                    }
                }
                break;
            case "90N":
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 998d - 77;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 1012d - 77;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = 1027d - 78;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = 1037d - 78;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 975d - 54d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 990d - 55d;
                    }
                }
                break;
            case "90":
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 971d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 985d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = 998d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = 1008d;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 1025d - 54d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 1040d - 55d;
                    }
                }
                break;
            case "100":
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 1148d - 77;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 1162d - 77;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = 1177d - 78;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = 1187d - 78;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = 1125d - 54d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = 1140d - 55d;
                    }
                }
                break;
            default:
                if (int.TryParse(szerokość, out int result))
                {
                    if (ościeżnica == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = result - 77;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = result - 77;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWPrzyldze = result - 78;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWPrzyldze = result - 78;
                    }
                    else if (ościeżnica == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWPrzyldze = result - 54;
                        else if (technologia == "Thermo 78")
                            SzerokośćWPrzyldze = result - 55;
                    }
                }
                else
                    SzerokośćWPrzyldze = 100d;
                break;
        }

        if (wysokość == "200")
        {
            if (technologia == "Thermo 64")
                WysokośćWPrzyldze = 2035d;
            else if (technologia == "Thermo 78")
                WysokośćWPrzyldze = 2035d;
            else if (technologia == "Thermo Hot 78")
                WysokośćWPrzyldze = 2051d;
            else if (technologia == "Thermo Hot 88")
                WysokośćWPrzyldze = 2051d;
        }
        else if (int.TryParse(wysokość, out int result))
        {
            if (ościeżnica == "Aluminiowa")
            {
                if (technologia == "Thermo 64")
                    WysokośćWPrzyldze = result - 54;
                else if (technologia == "Thermo 78")
                    WysokośćWPrzyldze = result - 54;
                else if (technologia == "Thermo Hot 78")
                    WysokośćWPrzyldze = result - 53;
                else if (technologia == "Thermo Hot 88")
                    WysokośćWPrzyldze = result - 53;
            }
            else if (ościeżnica == "Stalowa")
            {
                if (technologia == "Thermo 64")
                    WysokośćWPrzyldze = result - 43;
                else if (technologia == "Thermo 78")
                    WysokośćWPrzyldze = result - 43;
            }
        }
        else
            WysokośćWPrzyldze = 1000d;
    }
}
