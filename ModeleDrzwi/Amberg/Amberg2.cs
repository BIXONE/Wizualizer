namespace Wizualizer.ModeleDrzwi.Amberg;

public class Amberg2 : Drzwi
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

    public Amberg2(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        OtwórSzerokość = 320d;
        OtwórWysokość = 80d;
        OtwórZaokrąglenie = 8d;

        SzkłoSzerokość = OtwórSzerokość - 8d;
        SzkłoWysokość = OtwórWysokość - 8d;
        SzkłoZaokrąglenie = 0d;

        InoxZewSzerokośćStronaPrzylgowa = 460d;
        InoxZewWysokośćStronaPrzylgowa = Skrzydło.WysokośćWPrzyldze - 300d;
        InoxZewZaokrąglenieStronaPrzylgowa = 1d;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2d * 15d;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2d * 15d;
        InoxWewZaokrąglenieStronaPrzylgowa = 0d;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = 35d;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = 35d;

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
            new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, 450d - (Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaPrzylgowa) / 2 - InoxWewWysokośćStronaPrzylgowa / 2),
            PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(
            new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa),
            new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, 450d - (Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaFelcowa) / 2 - InoxWewWysokośćStronaFelcowa / 2),
            !PraweIsTrue, nazwaModelu: NazwaModelu);

        double środkiInoxówOdDolnejPrzylgi = (Skrzydło.WysokośćWPrzyldze - 900d) / 4;

        for (int i = 1; i < 5; i++)
        {
            InoxGeometriaStronaPrzylgowa = new(
                InoxGeometriaStronaPrzylgowa,
                new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, 450d - (Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaPrzylgowa) / 2 - InoxWewWysokośćStronaPrzylgowa / 2 + i * środkiInoxówOdDolnejPrzylgi),
                PraweIsTrue, nazwaModelu: NazwaModelu);

            InoxGeometriaStronaFelcowa = new(
                InoxGeometriaStronaFelcowa,
                new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, 450d - (Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaFelcowa) / 2 - InoxWewWysokośćStronaFelcowa / 2 + i * środkiInoxówOdDolnejPrzylgi),
                !PraweIsTrue, nazwaModelu: NazwaModelu);
        }

        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path path;
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = 200d;

        path = new()
        {
            Data = InoxGeometriaStronaPrzylgowa.KombinacjaFigur,
            StrokeThickness = 0,
            Fill = InoxTekstura.TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = InoxZewSzerokośćStronaPrzylgowa * SkalaParametr,
            Height = InoxZewWysokośćStronaPrzylgowa * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, ((Skrzydło.WysokośćWPrzyldze - InoxZewWysokośćStronaPrzylgowa) / 2) * SkalaParametr)
        };

        // Sam szkielet
        //path.Stroke = Brushes.Black;
        //path.StrokeThickness = 1;
        //path.Fill = Brushes.Transparent;

        grid.Children.Add(path);

        DrzwiWarstwy["Inox"].Child = grid;
    }

    protected override void RysujSzkło()
    {
        Path[] paths = new Path[5];
        Grid grid = new();
        double odsunięcieSzybyOdKrawędziX = 385d - SzkłoSzerokość / 2d;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 900d) / 4;

        for (int i = 0; i < paths.Length; i++)
        {
            paths[i] = new();
            paths[i].Data = SzkłoGeometria.RegionFigury;
            paths[i].StrokeThickness = 0;
            paths[i].Fill = SzkłoTekstura.TeksturaObcięta;
            paths[i].Stretch = Stretch.Fill;
            paths[i].Width = SzkłoSzerokość * SkalaParametr;
            paths[i].Height = SzkłoWysokość * SkalaParametr;
            paths[i].VerticalAlignment = VerticalAlignment.Bottom;
            paths[i].HorizontalAlignment = HorizontalAlignment.Left;

            if (i == 0)
                paths[i].Margin = new Thickness(odsunięcieSzybyOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 450d - SzkłoWysokość / 2) * SkalaParametr);
            else if (i == 1)
                paths[i].Margin = new Thickness(odsunięcieSzybyOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 450d - SzkłoWysokość / 2) * SkalaParametr);
            else if (i == 2)
                paths[i].Margin = new Thickness(odsunięcieSzybyOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 450d - SzkłoWysokość / 2) * SkalaParametr);
            else if (i == 3)
                paths[i].Margin = new Thickness(odsunięcieSzybyOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 450d - SzkłoWysokość / 2) * SkalaParametr);
            else if (i == 4)
                paths[i].Margin = new Thickness(odsunięcieSzybyOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 450d - SzkłoWysokość / 2) * SkalaParametr);

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
