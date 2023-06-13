namespace Wizualizer.ModeleDrzwi.Langen;

public class Langen5 : Drzwi
{
    protected double OdsunięcieOdOsi { get; set; }
    
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

    protected double PasekInoxOdsunięcie { get; set; }
    protected double PasekInoxZaokrąglenie { get; set; }

    protected double PasekInoxSzerokośćStronaPrzylgowa { get; set; }
    protected double PasekInoxWysokośćStronaPrzylgowa { get; set; }
    protected Prostokąt PasekInoxGeometriaInoxGeometriaStronaPrzylgowa { get; set; }

    protected double PasekInoxSzerokośćStronaFelcowa { get; set; }
    protected double PasekInoxWysokośćStronaFelcowa { get; set; }
    protected Prostokąt PasekInoxGeometriaInoxGeometriaStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }
    Tekstura PasekInoxTekstura { get; set; }
    Prostokąt SzkłoGeometria { get; set; }
    Tekstura SzkłoTekstura { get; set; }

    public Langen5(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
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

        OdsunięcieOdOsi = 260;
        OtwórSzerokość = 80;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        InoxZewSzerokośćStronaPrzylgowa = OtwórSzerokość + 2 * 20d;
        InoxZewWysokośćStronaPrzylgowa = Skrzydło.WysokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxZewZaokrąglenieStronaPrzylgowa = 1d;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2d * 15d;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2d * 15d;
        InoxWewZaokrąglenieStronaPrzylgowa = 0d;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = (InoxZewSzerokośćStronaPrzylgowa - InoxWewSzerokośćStronaPrzylgowa) / 2d;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (Skrzydło.WysokośćWPrzyldze - OtwórWysokość) / 2d - OdległośćInoxOdKrawędziStronaPrzylgowa + 15;

        InoxZewSzerokośćStronaFelcowa = OtwórSzerokość + 2 * 20d;
        InoxZewWysokośćStronaFelcowa = Skrzydło.WysokośćWPrzyldze - OdległośćInoxOdKrawędziStronaFelcowa - PrzylgaGórna - OdległośćInoxOdKrawędziStronaFelcowaDół - PrzylgaDolna;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = (Skrzydło.WysokośćWPrzyldze - OtwórWysokość) / 2d - PrzylgaDolna - OdległośćInoxOdKrawędziStronaFelcowaDół + 15;

        PasekInoxOdsunięcie = 15;
        PasekInoxZaokrąglenie = InoxZewZaokrąglenieStronaPrzylgowa;

        PasekInoxSzerokośćStronaPrzylgowa = 15;
        PasekInoxWysokośćStronaPrzylgowa = InoxZewWysokośćStronaPrzylgowa;

        PasekInoxSzerokośćStronaFelcowa = PasekInoxSzerokośćStronaPrzylgowa;
        PasekInoxWysokośćStronaFelcowa = InoxZewWysokośćStronaFelcowa;

        InoxGeometriaStronaPrzylgowa = new(new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);
        PasekInoxGeometriaInoxGeometriaStronaPrzylgowa = new(PasekInoxSzerokośćStronaPrzylgowa, PasekInoxWysokośćStronaPrzylgowa, PraweIsTrue, PasekInoxZaokrąglenie, nazwaModelu: "Pasek");
        PasekInoxGeometriaInoxGeometriaStronaFelcowa = new(PasekInoxSzerokośćStronaFelcowa, PasekInoxWysokośćStronaFelcowa, !PraweIsTrue, PasekInoxZaokrąglenie, nazwaModelu: "Pasek");
        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        PasekInoxTekstura = new(InoxKolor, PasekInoxSzerokośćStronaPrzylgowa, PasekInoxWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[1];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = OdsunięcieOdOsi - InoxZewSzerokośćStronaPrzylgowa / 2;
        double odsunięcieInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaPrzylgowa;

        Path[] pathPaskiInox = new Path[3];
        double odsunięciePaskiInoxOdKrawędziX = OdsunięcieOdOsi + InoxZewSzerokośćStronaPrzylgowa / 2d + PasekInoxOdsunięcie;
        double odsunięciePaskiInoxOdKrawędziY = odsunięcieInoxOdKrawędziY;

        for (int i = 0; i < paths.Length; i++)
        {
            if (ZewIsTrue == false)
            {
                odsunięcieInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaFelcowaDół + PrzylgaDolna;
            }
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
            }

            // Sam szkielet
            //paths[i].Stroke = Brushes.Black;
            //paths[i].StrokeThickness = 1;
            //paths[i].Fill = Brushes.Transparent;

            grid.Children.Add(paths[i]);
        }

        for (int i = 0; i < pathPaskiInox.Length; i++)
        {
            if (ZewIsTrue == false)
            {
                odsunięciePaskiInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaFelcowaDół + PrzylgaDolna;
            }
            pathPaskiInox[i] = new()
            {
                Data = PasekInoxGeometriaInoxGeometriaStronaPrzylgowa.RegionFigury,
                StrokeThickness = 0,
                Fill = PasekInoxTekstura.TeksturaObcięta,
                Stretch = Stretch.Fill,
                Width = PasekInoxSzerokośćStronaPrzylgowa * SkalaParametr,
                Height = PasekInoxWysokośćStronaPrzylgowa * SkalaParametr,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness((odsunięciePaskiInoxOdKrawędziX + i * (PasekInoxSzerokośćStronaPrzylgowa + PasekInoxOdsunięcie)) * SkalaParametr, 0d, 0d, odsunięciePaskiInoxOdKrawędziY * SkalaParametr)
            };
            if (ZewIsTrue == false)
            {
                pathPaskiInox[i].Data = PasekInoxGeometriaInoxGeometriaStronaFelcowa.RegionFigury;
                pathPaskiInox[i].Height = PasekInoxWysokośćStronaFelcowa * SkalaParametr;
            }
            // Sam szkielet
            //pathPaskiInox[i].Stroke = Brushes.Black;
            //pathPaskiInox[i].StrokeThickness = 1;
            //pathPaskiInox[i].Fill = Brushes.Transparent;

            grid.Children.Add(pathPaskiInox[i]);
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
