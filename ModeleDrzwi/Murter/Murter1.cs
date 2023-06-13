namespace Wizualizer.ModeleDrzwi.Murter;

public class Murter1 : Drzwi
{
    protected double OtwórSzerokość { get; set; }
    protected double OtwórWysokość { get; set; }
    protected double OtwórZaokrąglenie { get; set; }

    protected double SzkłoSzerokość { get; set; }
    protected double SzkłoWysokość { get; set; }
    protected double SzkłoZaokrąglenie { get; set; }

    protected double InoxZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxZewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double InoxWewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxWewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxWewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa { get; set; }
    RóżnicaProstokątów InoxGeometriaStronaPrzylgowa { get; set; }

    protected double InoxZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxZewWysokośćStronaFelcowa { get; set; }
    protected double InoxZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxWewWysokośćStronaFelcowa { get; set; }
    protected double InoxWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiYStronaFelcowa { get; set; }
    RóżnicaProstokątów InoxGeometriaStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }
    Prostokąt SzkłoGeometria { get; set; }
    Tekstura SzkłoTekstura { get; set; }

    public Murter1(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        if (Skrzydło.WysokośćWPrzyldze >= 1000d && Skrzydło.WysokośćWPrzyldze <= 1900d)
            OtwórWysokość = 1030d;
        else if (Skrzydło.WysokośćWPrzyldze > 1900d && Skrzydło.WysokośćWPrzyldze <= 2000d)
            OtwórWysokość = 1130d;
        else if (Skrzydło.WysokośćWPrzyldze > 2000d && Skrzydło.WysokośćWPrzyldze <= 2100d)
            OtwórWysokość = 1230d;
        else if (Skrzydło.WysokośćWPrzyldze > 2100d && Skrzydło.WysokośćWPrzyldze <= 2200d)
            OtwórWysokość = 1330d;
        else if (Skrzydło.WysokośćWPrzyldze > 2200d && Skrzydło.WysokośćWPrzyldze <= 2300d)
            OtwórWysokość = 1430d;
        else if (Skrzydło.WysokośćWPrzyldze > 2300d && Skrzydło.WysokośćWPrzyldze <= 2800d)
            OtwórWysokość = 1530d;

        OtwórSzerokość = 80d;
        OtwórZaokrąglenie = 8d;

        SzkłoSzerokość = OtwórSzerokość - 8d;
        SzkłoWysokość = OtwórWysokość - 8d;
        SzkłoZaokrąglenie = 0d;

        InoxZewSzerokośćStronaPrzylgowa = 460d;
        InoxZewWysokośćStronaPrzylgowa = OtwórWysokość + 2 * 285d;
        InoxZewZaokrąglenieStronaPrzylgowa = 1d;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2d * 15d;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2d * 15d;
        InoxWewZaokrąglenieStronaPrzylgowa = 0d;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = 35d;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (InoxZewWysokośćStronaPrzylgowa - InoxWewWysokośćStronaPrzylgowa) / 2d;

        InoxZewSzerokośćStronaFelcowa = InoxZewSzerokośćStronaPrzylgowa;
        InoxZewWysokośćStronaFelcowa = InoxZewWysokośćStronaPrzylgowa;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa;

        InoxGeometriaStronaPrzylgowa = new(
            new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), 
            new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), 
            PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxGeometriaStronaFelcowa = new(
            new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), 
            new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), 
            !PraweIsTrue, nazwaModelu: NazwaModelu);
        
        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path paths;
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = 200d;
        double odsunięcieInoxOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaPrzylgowa) / 2d;

        paths = new()
        {
            Data = InoxGeometriaStronaPrzylgowa.KombinacjaFigur,
            StrokeThickness = 0,
            Fill = InoxTekstura.TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = InoxZewSzerokośćStronaPrzylgowa * SkalaParametr,
            Height = InoxZewWysokośćStronaPrzylgowa * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, odsunięcieInoxOdKrawędziY * SkalaParametr)
        };

        // Sam szkielet
        //paths.Stroke = Brushes.Black;
        //paths.StrokeThickness = 1;
        //paths.Fill = Brushes.Transparent;

        grid.Children.Add(paths);

        DrzwiWarstwy["Inox"].Child = grid;
    }

    protected override void RysujSzkło()
    {
        Path paths;
        Grid grid = new();
        double odsunięcieSzkłoOdKrawędziX = 260d - SzkłoSzerokość / 2d;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - SzkłoWysokość) / 2d;

        paths = new()
        {
            Data = SzkłoGeometria.RegionFigury,
            StrokeThickness = 0,
            Fill = SzkłoTekstura.TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = SzkłoSzerokość * SkalaParametr,
            Height = SzkłoWysokość * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(odsunięcieSzkłoOdKrawędziX * SkalaParametr, 0d, 0d, odsunięcieSzkłoOdKrawędziY * SkalaParametr)
        };

        grid.Children.Add(paths);

        DrzwiWarstwy["Szkło"].Child = grid;
    }

    public override void GenerujDXF()
    {
        InoxGeometriaStronaPrzylgowa.ZapiszPlikDXF();
        InoxGeometriaStronaFelcowa.ZapiszPlikDXF();
    }
}
