namespace Wizualizer.ModeleDrzwi.Samedan;

public class Samedan3 : Drzwi
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

    protected double InoxGóraZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxGóraZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxGóraZewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double InoxGóraWewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxGóraWewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxGóraWewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxGóraWewWzględemOsiXStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxGóraWewWzględemOsiYStronaPrzylgowa { get; set; }
    RóżnicaProstokątów InoxGóraGeometriaStronaPrzylgowa { get; set; }

    protected double InoxDółZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxDółZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxDółZewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double InoxDółWewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxDółWewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxDółWewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxDółWewWzględemOsiXStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxDółWewWzględemOsiYStronaPrzylgowa { get; set; }
    RóżnicaProstokątów InoxDółGeometriaStronaPrzylgowa { get; set; }

    protected double InoxZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxZewWysokośćStronaFelcowa { get; set; }
    protected double InoxZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxWewWysokośćStronaFelcowa { get; set; }
    protected double InoxWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiYStronaFelcowa { get; set; }
    RóżnicaProstokątów InoxGeometriaStronaFelcowa { get; set; }

    protected double InoxGóraZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxGóraZewWysokośćStronaFelcowa { get; set; }
    protected double InoxGóraZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxGóraWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxGóraWewWysokośćStronaFelcowa { get; set; }
    protected double InoxGóraWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxGóraWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxGóraWewWzględemOsiYStronaFelcowa { get; set; }
    RóżnicaProstokątów InoxGóraGeometriaStronaFelcowa { get; set; }

    protected double InoxDółZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxDółZewWysokośćStronaFelcowa { get; set; }
    protected double InoxDółZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxDółWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxDółWewWysokośćStronaFelcowa { get; set; }
    protected double InoxDółWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxDółWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxDółWewWzględemOsiYStronaFelcowa { get; set; }
    RóżnicaProstokątów InoxDółGeometriaStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }
    Prostokąt SzkłoGeometria { get; set; }
    Tekstura SzkłoTekstura { get; set; }

    public Samedan3(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        OdsunięcieOdOsi = Skrzydło.SzerokośćWPrzyldze / 2d;

        OtwórSzerokość = 140;
        OtwórWysokość = 140;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        InoxZewSzerokośćStronaPrzylgowa = OtwórSzerokość + 2 * 20;
        InoxZewWysokośćStronaPrzylgowa = OtwórWysokość + 2 * 20;
        InoxZewZaokrąglenieStronaPrzylgowa = 1;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2 * 15;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2 * 15;
        InoxWewZaokrąglenieStronaPrzylgowa = 0;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = (InoxZewSzerokośćStronaPrzylgowa - InoxWewSzerokośćStronaPrzylgowa) / 2d;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (InoxZewWysokośćStronaPrzylgowa - InoxWewWysokośćStronaPrzylgowa) / 2d;
        InoxGeometriaStronaPrzylgowa = new(new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxGóraZewSzerokośćStronaPrzylgowa = OtwórSzerokość + 2 * 20;
        InoxGóraZewWysokośćStronaPrzylgowa = 300 + OtwórWysokość / 2d + 20 - OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxGóraZewZaokrąglenieStronaPrzylgowa = 1;
        InoxGóraWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2 * 15;
        InoxGóraWewWysokośćStronaPrzylgowa = OtwórWysokość - 2 * 15;
        InoxGóraWewZaokrąglenieStronaPrzylgowa = 0;
        OdsunięcieInoxGóraWewWzględemOsiXStronaPrzylgowa = (InoxGóraZewSzerokośćStronaPrzylgowa - InoxGóraWewSzerokośćStronaPrzylgowa) / 2d;
        OdsunięcieInoxGóraWewWzględemOsiYStronaPrzylgowa = 35;
        InoxGóraGeometriaStronaPrzylgowa = new(new Prostokąt(InoxGóraZewSzerokośćStronaPrzylgowa, InoxGóraZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxGóraZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxGóraWewSzerokośćStronaPrzylgowa, InoxGóraWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxGóraWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxGóraWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxGóraWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxDółZewSzerokośćStronaPrzylgowa = InoxGóraZewSzerokośćStronaPrzylgowa;
        InoxDółZewWysokośćStronaPrzylgowa = InoxGóraZewWysokośćStronaPrzylgowa;
        InoxDółZewZaokrąglenieStronaPrzylgowa = InoxGóraZewZaokrąglenieStronaPrzylgowa;
        InoxDółWewSzerokośćStronaPrzylgowa = InoxGóraWewSzerokośćStronaPrzylgowa;
        InoxDółWewWysokośćStronaPrzylgowa = InoxGóraWewWysokośćStronaPrzylgowa;
        InoxDółWewZaokrąglenieStronaPrzylgowa = InoxGóraWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxDółWewWzględemOsiXStronaPrzylgowa = (InoxDółZewSzerokośćStronaPrzylgowa - InoxDółWewSzerokośćStronaPrzylgowa) / 2d;
        OdsunięcieInoxDółWewWzględemOsiYStronaPrzylgowa = InoxDółZewWysokośćStronaPrzylgowa - 35 - InoxDółWewWysokośćStronaPrzylgowa;
        InoxDółGeometriaStronaPrzylgowa = new(new Prostokąt(InoxDółZewSzerokośćStronaPrzylgowa, InoxDółZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxDółZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxDółWewSzerokośćStronaPrzylgowa, InoxDółWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxDółWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxDółWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxDółWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxZewSzerokośćStronaFelcowa = InoxZewSzerokośćStronaPrzylgowa;
        InoxZewWysokośćStronaFelcowa = InoxZewWysokośćStronaPrzylgowa;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa;
        InoxGeometriaStronaFelcowa = new(new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxGóraZewSzerokośćStronaFelcowa = OtwórSzerokość + 2 * 20;
        InoxGóraZewWysokośćStronaFelcowa = 300 + OtwórWysokość / 2d + 20 - OdległośćInoxOdKrawędziStronaFelcowa - PrzylgaGórna;
        InoxGóraZewZaokrąglenieStronaFelcowa = 1;
        InoxGóraWewSzerokośćStronaFelcowa = OtwórSzerokość - 2 * 15;
        InoxGóraWewWysokośćStronaFelcowa = OtwórSzerokość - 2 * 15;
        InoxGóraWewZaokrąglenieStronaFelcowa = 0;
        OdsunięcieInoxGóraWewWzględemOsiXStronaFelcowa = (InoxGóraZewSzerokośćStronaFelcowa - InoxGóraWewSzerokośćStronaFelcowa) / 2d;
        OdsunięcieInoxGóraWewWzględemOsiYStronaFelcowa = 35;
        InoxGóraGeometriaStronaFelcowa = new(new Prostokąt(InoxGóraZewSzerokośćStronaFelcowa, InoxGóraZewWysokośćStronaFelcowa, PraweIsTrue, InoxGóraZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxGóraWewSzerokośćStronaFelcowa, InoxGóraWewWysokośćStronaFelcowa, PraweIsTrue, InoxGóraWewZaokrąglenieStronaFelcowa, OdsunięcieInoxGóraWewWzględemOsiXStronaFelcowa, OdsunięcieInoxGóraWewWzględemOsiYStronaFelcowa), PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxDółZewSzerokośćStronaFelcowa = OtwórSzerokość + 2 * 20;
        InoxDółZewWysokośćStronaFelcowa = 300 + OtwórWysokość / 2d + 20 - OdległośćInoxOdKrawędziStronaFelcowaDół - PrzylgaDolna;
        InoxDółZewZaokrąglenieStronaFelcowa = 1;
        InoxDółWewSzerokośćStronaFelcowa = OtwórSzerokość - 2 * 15;
        InoxDółWewWysokośćStronaFelcowa = OtwórSzerokość - 2 * 15;
        InoxDółWewZaokrąglenieStronaFelcowa = 0;
        OdsunięcieInoxDółWewWzględemOsiXStronaFelcowa = (InoxDółZewSzerokośćStronaFelcowa - InoxDółWewSzerokośćStronaFelcowa) / 2d;
        OdsunięcieInoxDółWewWzględemOsiYStronaFelcowa = InoxDółZewWysokośćStronaFelcowa - 35 - InoxDółWewWysokośćStronaFelcowa;
        InoxDółGeometriaStronaFelcowa = new(new Prostokąt(InoxDółZewSzerokośćStronaFelcowa, InoxDółZewWysokośćStronaFelcowa, PraweIsTrue, InoxDółZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxDółWewSzerokośćStronaFelcowa, InoxDółWewWysokośćStronaFelcowa, PraweIsTrue, InoxDółWewZaokrąglenieStronaFelcowa, OdsunięcieInoxDółWewWzględemOsiXStronaFelcowa, OdsunięcieInoxDółWewWzględemOsiYStronaFelcowa), PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[5];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = OdsunięcieOdOsi - OtwórSzerokość / 2d - 20;
        double odsunięcieInoxOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 600) / 4d;

        for (int i = 0; i < paths.Length; i++)
        {
            if (i >= 1 && i <= 3)
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
                    Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieInoxOdKrawędziY + 300 - InoxZewWysokośćStronaPrzylgowa / 2d) * SkalaParametr)
                };
            }

            else if (i == 0)
            {
                paths[i] = new()
                {
                    Data = InoxDółGeometriaStronaPrzylgowa.KombinacjaFigur,
                    StrokeThickness = 0,
                    Fill = InoxTekstura.TeksturaObcięta,
                    Stretch = Stretch.Fill,
                    Width = InoxDółZewSzerokośćStronaPrzylgowa * SkalaParametr,
                    Height = InoxDółZewWysokośćStronaPrzylgowa * SkalaParametr,
                    VerticalAlignment = VerticalAlignment.Bottom,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, OdległośćInoxOdKrawędziStronaPrzylgowa * SkalaParametr)
                };
                if (ZewIsTrue == false)
                {
                    paths[i].Data = InoxDółGeometriaStronaFelcowa.KombinacjaFigur;
                    paths[i].Height = InoxDółZewWysokośćStronaFelcowa * SkalaParametr;
                    paths[i].Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (OdległośćInoxOdKrawędziStronaFelcowaDół + PrzylgaDolna) * SkalaParametr);
                }
            }
            else if (i == 4)
            {
                paths[i] = new()
                {
                    Data = InoxGóraGeometriaStronaPrzylgowa.KombinacjaFigur,
                    StrokeThickness = 0,
                    Fill = InoxTekstura.TeksturaObcięta,
                    Stretch = Stretch.Fill,
                    Width = InoxGóraZewSzerokośćStronaPrzylgowa * SkalaParametr,
                    Height = InoxGóraZewWysokośćStronaPrzylgowa * SkalaParametr,
                    VerticalAlignment = VerticalAlignment.Bottom,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieInoxOdKrawędziY + 300 - InoxZewWysokośćStronaPrzylgowa / 2d) * SkalaParametr)
                };
                if (ZewIsTrue == false)
                {
                    paths[i].Data = InoxGóraGeometriaStronaFelcowa.KombinacjaFigur;
                    paths[i].Height = InoxGóraZewWysokośćStronaFelcowa * SkalaParametr;
                }
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
        Path[] paths = new Path[5];
        Grid grid = new();
        double odsunięcieSzkłoOdKrawędziX = OdsunięcieOdOsi - OtwórSzerokość / 2d + 4;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 600) / 4d;

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
                Margin = new Thickness(odsunięcieSzkłoOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 300 - SzkłoWysokość / 2) * SkalaParametr)
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
