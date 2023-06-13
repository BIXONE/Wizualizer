namespace Wizualizer.ElementyDrzwi;

public class Ościeżnica
{
    public string OścieżnicaKolor { get; }
    public string OścieżnicaTyp { get; }

    public double SzerokośćWOśc { get; }
    public double WysokośćWOśc { get; }
    public double SzerokośćOŚC { get; set; }

    public Ościeżnica(string technologia, string profilOścieżnicy, string szerokość, string wysokość, string kolor)
    {
        OścieżnicaKolor = kolor;
        OścieżnicaTyp = profilOścieżnicy;
        if (technologia == "Thermo 64")
        {
            if (profilOścieżnicy == "Aluminiowa")
                SzerokośćOŚC = 64d;
            else if (profilOścieżnicy == "Stalowa")
                SzerokośćOŚC = 50d;
        }
        else if (technologia == "Thermo 78")
        {
            if (profilOścieżnicy == "Aluminiowa")
                SzerokośćOŚC = 64d;
            else if (profilOścieżnicy == "Stalowa")
                SzerokośćOŚC = 50d;
        }
        else if (technologia == "Thermo Hot 78" && profilOścieżnicy == "Aluminiowa")
        {
            SzerokośćOŚC = 79d;
        }
        else if (technologia == "Thermo Hot 88" && profilOścieżnicy == "Aluminiowa")
        {
            SzerokośćOŚC = 79d;
        }

        switch (szerokość.ToUpper())
        {
            case "80N":
                {
                    if (profilOścieżnicy == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 898d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 912d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWOśc = 927d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWOśc = 937d;
                    }
                    else if (profilOścieżnicy == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 875d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 890d;
                    }
                }
                break;
            case "80":
                {
                    if (profilOścieżnicy == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 948d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 962d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWOśc = 977d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWOśc = 987d;
                    }
                    else if (profilOścieżnicy == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 925d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 940d;
                    }
                }
                break;
            case "90N":
                {
                    if (profilOścieżnicy == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 998d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 1012d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWOśc = 1027d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWOśc = 1037d;
                    }
                    else if (profilOścieżnicy == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 975d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 990d;
                    }
                }
                break;
            case "90":
                {
                    if (profilOścieżnicy == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 1048d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 1062d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWOśc = 1077d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWOśc = 1087d;
                    }
                    else if (profilOścieżnicy == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 1025d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 1040d;
                    }
                }
                break;
            case "100":
                {
                    if (profilOścieżnicy == "Aluminiowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 1148d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 1162d;
                        else if (technologia == "Thermo Hot 78")
                            SzerokośćWOśc = 1177d;
                        else if (technologia == "Thermo Hot 88")
                            SzerokośćWOśc = 1187d;
                    }
                    else if (profilOścieżnicy == "Stalowa")
                    {
                        if (technologia == "Thermo 64")
                            SzerokośćWOśc = 1125d;
                        else if (technologia == "Thermo 78")
                            SzerokośćWOśc = 1140d;
                    }
                }
                break;
            default:
                if (int.TryParse(szerokość, out int result))
                {
                    SzerokośćWOśc = result;
                }
                else
                    SzerokośćWOśc = 100d;
                break;
        }

        if (wysokość == "200")
        {
            if (profilOścieżnicy == "Aluminiowa")
            {
                if (technologia == "Thermo 64")
                    WysokośćWOśc = 2089d;
                else if (technologia == "Thermo 78")
                    WysokośćWOśc = 2089d;
                else if (technologia == "Thermo Hot 78")
                    WysokośćWOśc = 2104d;
                else if (technologia == "Thermo Hot 88")
                    WysokośćWOśc = 2104d;
            }
            else if (profilOścieżnicy == "Stalowa")
            {
                if (technologia == "Thermo 64")
                    WysokośćWOśc = 2078d;
                else if (technologia == "Thermo 78")
                    WysokośćWOśc = 2078d;
            }
        }
        else if (int.TryParse(wysokość, out int result))
        {
            WysokośćWOśc = result;
        }
        else
            WysokośćWOśc = 1000d;
    }
}
