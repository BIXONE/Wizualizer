namespace Wizualizer.ModeleDrzwi.Leimen;

public class Leimen3 : Drzwi
{
    protected double OdsunięcieOdOsi { get; set; }
    protected double OdsunięcieOdOsi2 { get; set; }

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

    public Leimen3(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
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
            OtwórWysokość = 1430d;
        else if (Skrzydło.WysokośćWPrzyldze > 1900d && Skrzydło.WysokośćWPrzyldze <= 2000d)
            OtwórWysokość = 1530d;
        else if (Skrzydło.WysokośćWPrzyldze > 2000d && Skrzydło.WysokośćWPrzyldze <= 2100d)
            OtwórWysokość = 1630d;
        else if (Skrzydło.WysokośćWPrzyldze > 2100d && Skrzydło.WysokośćWPrzyldze <= 2200d)
            OtwórWysokość = 1730d;
        else if (Skrzydło.WysokośćWPrzyldze > 2200d && Skrzydło.WysokośćWPrzyldze <= 2300d)
            OtwórWysokość = 1830d;
        else if (Skrzydło.WysokośćWPrzyldze > 2300d && Skrzydło.WysokośćWPrzyldze <= 2800d)
            OtwórWysokość = 1930d;

        OdsunięcieOdOsi = 302;
        OtwórSzerokość = 165;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        InoxZewSzerokośćStronaPrzylgowa = OdsunięcieOdOsi + OtwórSzerokość / 2d + 20 - OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxZewWysokośćStronaPrzylgowa = Skrzydło.WysokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxZewZaokrąglenieStronaPrzylgowa = 1d;
        InoxWewSzerokośćStronaPrzylgowa = 50;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2d * 15d;
        InoxWewZaokrąglenieStronaPrzylgowa = 0d;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = InoxZewSzerokośćStronaPrzylgowa - 20 - OtwórSzerokość + 15;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (Skrzydło.WysokośćWPrzyldze - OtwórWysokość) / 2d - OdległośćInoxOdKrawędziStronaPrzylgowa + 15;

        InoxZewSzerokośćStronaFelcowa = OdsunięcieOdOsi + OtwórSzerokość / 2d + 20 - OdległośćInoxOdKrawędziStronaFelcowa - PrzylgaBoczna;
        InoxZewWysokośćStronaFelcowa = Skrzydło.WysokośćWPrzyldze - OdległośćInoxOdKrawędziStronaFelcowa - PrzylgaGórna - OdległośćInoxOdKrawędziStronaFelcowaDół - PrzylgaDolna;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = InoxZewSzerokośćStronaFelcowa - 20 - OtwórSzerokość + 15;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = (Skrzydło.WysokośćWPrzyldze - OtwórWysokość) / 2d - PrzylgaDolna - OdległośćInoxOdKrawędziStronaFelcowaDół + 15;

        double OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa2 = InoxZewSzerokośćStronaPrzylgowa - 35 - InoxWewSzerokośćStronaPrzylgowa;
        double OdsunięcieInoxWewWzględemOsiXStronaFelcowa2 = InoxZewSzerokośćStronaFelcowa - 35 - InoxWewSzerokośćStronaFelcowa;

        InoxGeometriaStronaPrzylgowa = new(new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaPrzylgowa = new(InoxGeometriaStronaPrzylgowa, new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa2, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(InoxGeometriaStronaFelcowa, new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa2, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[1];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = OdległośćInoxOdKrawędziStronaPrzylgowa;
        double odsunięcieInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaPrzylgowa;

        if (ZewIsTrue == false)
        {
            odsunięcieInoxOdKrawędziX = OdległośćInoxOdKrawędziStronaFelcowa + PrzylgaBoczna;
            odsunięcieInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaFelcowaDół + PrzylgaDolna;
        }
        for (int i = 0; i < paths.Length; i++)
        {
            paths[i] = new()
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
            if (ZewIsTrue == false)
            {
                paths[i].Data = InoxGeometriaStronaFelcowa.KombinacjaFigur;
                paths[i].Height = InoxZewWysokośćStronaFelcowa * SkalaParametr;
                paths[i].Width = InoxZewSzerokośćStronaFelcowa * SkalaParametr;
            }

            // Sam szkielet
            //paths[i].Stroke = Brushes.Black;
            //paths[i].StrokeThickness = 1;
            //paths[i].Fill = Brushes.Transparent;

            grid.Children.Add(paths[i]);
        }
        DrzwiWarstwy["Inox"].Child = grid;
    }

    protected override void RysujSzkło()
    {
        Path[] paths = new Path[1];
        Grid grid = new();
        double odsunięcieSzkłoOdKrawędziX = OdsunięcieOdOsi - SzkłoSzerokość / 2;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - SzkłoWysokość) / 2;

        for (int i = 0; i < paths.Length; i++)
        {
            paths[i] = new()
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

            grid.Children.Add(paths[i]);
        }
        DrzwiWarstwy["Szkło"].Child = grid;
    }

    public override void GenerujDXF()
    {
        InoxGeometriaStronaPrzylgowa.ZapiszPlikDXF();
        InoxGeometriaStronaFelcowa.ZapiszPlikDXF();
    }
}
