namespace Wizualizer.ModeleDrzwi.Lutter;

public class Lutter1 : Drzwi
{
    protected double RoztawPasków { get; set; }

    protected double InoxZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxZewZaokrąglenieStronaPrzylgowa { get; set; }
    Prostokąt InoxGeometriaStronaPrzylgowa { get; set; }

    protected double InoxZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxZewWysokośćStronaFelcowa { get; set; }
    protected double InoxZewZaokrąglenieStronaFelcowa { get; set; }
    Prostokąt InoxGeometriaStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }

    public Lutter1(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        RoztawPasków = 406;

        InoxZewSzerokośćStronaPrzylgowa = Skrzydło.SzerokośćWPrzyldze - 9 * 2;
        InoxZewWysokośćStronaPrzylgowa = 25.4;
        InoxZewZaokrąglenieStronaPrzylgowa = 1;

        InoxZewSzerokośćStronaFelcowa = Skrzydło.SzerokośćWPrzyldze - (9 + PrzylgaBoczna) * 2;
        InoxZewWysokośćStronaFelcowa = InoxZewWysokośćStronaPrzylgowa;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;

        if (Skrzydło.Technologia == "Thermo Hot 78" || Skrzydło.Technologia == "Thermo Hot 88")
        {
            InoxZewSzerokośćStronaFelcowa = Skrzydło.SzerokośćWPrzyldze - (100 + PrzylgaBoczna) * 2;
        }

        InoxGeometriaStronaPrzylgowa = new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa, nazwaModelu: NazwaModelu);
        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[4];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = (Skrzydło.SzerokośćWPrzyldze - InoxZewSzerokośćStronaPrzylgowa) / 2d;
        double odsunięcieInoxOdKrawędziY = RoztawPasków;

        for (int i = 0; i < paths.Length; i++)
        {
            if (ZewIsTrue == false)
            {
                odsunięcieInoxOdKrawędziX = (Skrzydło.SzerokośćWPrzyldze - InoxZewSzerokośćStronaFelcowa) / 2d;
            }
            paths[i] = new()
            {
                Data = InoxGeometriaStronaPrzylgowa.RegionFigury,
                StrokeThickness = 0,
                Fill = InoxTekstura.TeksturaObcięta,
                Stretch = Stretch.Fill,
                Width = InoxZewSzerokośćStronaPrzylgowa * SkalaParametr,
                Height = InoxZewWysokośćStronaPrzylgowa * SkalaParametr,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieInoxOdKrawędziY + (Skrzydło.WysokośćWPrzyldze - 3 * RoztawPasków) / 2d - InoxZewWysokośćStronaPrzylgowa / 2) * SkalaParametr)
            };
            if (ZewIsTrue == false)
            {
                paths[i].Data = InoxGeometriaStronaFelcowa.RegionFigury;
                paths[i].Width = InoxZewSzerokośćStronaFelcowa * SkalaParametr;
            }

            // Sam szkielet
            paths[i].Stroke = Brushes.Black;
            paths[i].StrokeThickness = 1;
            paths[i].Fill = Brushes.Transparent;

            grid.Children.Add(paths[i]);
        }
        DrzwiWarstwy["Inox"].Child = grid;
    }

    protected override void RysujSzkło()
    {
    }

    public override void GenerujDXF()
    {
    }
}
