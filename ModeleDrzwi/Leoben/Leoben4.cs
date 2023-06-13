namespace Wizualizer.ModeleDrzwi.Leoben;

public class Leoben4 : Drzwi
{
    protected double ParametrOtworu { get; set; }
    protected double OdsunięcieOdOsi { get; set; }

    protected double OtwórSzerokość { get; set; }
    protected double OtwórWysokość { get; set; }
    protected double OtwórZaokrąglenie { get; set; }

    protected double SzkłoSzerokość { get; set; }
    protected double SzkłoWysokość { get; set; }
    protected double SzkłoZaokrąglenie { get; set; }

    //Duży inox przylga
    protected double InoxZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxZewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double InoxWewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxWewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxWewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa { get; set; }
    RóżnicaProstokątów InoxGeometriaStronaPrzylgowa { get; set; }

    //Mały inox przylga
    protected double InoxMałyZewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxMałyZewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxMałyZewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double InoxMałyWewSzerokośćStronaPrzylgowa { get; set; }
    protected double InoxMałyWewWysokośćStronaPrzylgowa { get; set; }
    protected double InoxMałyWewZaokrąglenieStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxMałyWewWzględemOsiXStronaPrzylgowa { get; set; }
    protected double OdsunięcieInoxMałyWewWzględemOsiYStronaPrzylgowa { get; set; }

    //Duży inox felc
    protected double InoxZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxZewWysokośćStronaFelcowa { get; set; }
    protected double InoxZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxWewWysokośćStronaFelcowa { get; set; }
    protected double InoxWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxWewWzględemOsiYStronaFelcowa { get; set; }
    RóżnicaProstokątów InoxGeometriaStronaFelcowa { get; set; }

    //Mały inox felc
    protected double InoxMałyZewSzerokośćStronaFelcowa { get; set; }
    protected double InoxMałyZewWysokośćStronaFelcowa { get; set; }
    protected double InoxMałyZewZaokrąglenieStronaFelcowa { get; set; }
    protected double InoxMałyWewSzerokośćStronaFelcowa { get; set; }
    protected double InoxMałyWewWysokośćStronaFelcowa { get; set; }
    protected double InoxMałyWewZaokrąglenieStronaFelcowa { get; set; }
    protected double OdsunięcieInoxMałyWewWzględemOsiXStronaFelcowa { get; set; }
    protected double OdsunięcieInoxMałyWewWzględemOsiYStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }
    Prostokąt SzkłoGeometria { get; set; }
    Tekstura SzkłoTekstura { get; set; }

    public Leoben4(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        OdsunięcieOdOsi = 92.5d;
        ParametrOtworu = 470;

        OtwórSzerokość = Skrzydło.SzerokośćWPrzyldze - ParametrOtworu;
        OtwórWysokość = 80;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        //Mały inox przylga
        InoxMałyZewSzerokośćStronaPrzylgowa = OtwórWysokość + 2 * 20;
        InoxMałyZewWysokośćStronaPrzylgowa = OtwórWysokość + 2 * 35;
        InoxMałyZewZaokrąglenieStronaPrzylgowa = 1;
        InoxMałyWewSzerokośćStronaPrzylgowa = 50;
        InoxMałyWewWysokośćStronaPrzylgowa = 20;
        InoxMałyWewZaokrąglenieStronaPrzylgowa = 0;
        OdsunięcieInoxMałyWewWzględemOsiXStronaPrzylgowa = (InoxMałyZewSzerokośćStronaPrzylgowa - InoxMałyWewSzerokośćStronaPrzylgowa) / 2d;
        OdsunięcieInoxMałyWewWzględemOsiYStronaPrzylgowa = (InoxMałyZewWysokośćStronaPrzylgowa - InoxMałyWewWysokośćStronaPrzylgowa) / 2d;

        //Duży inox przylga
        InoxZewSzerokośćStronaPrzylgowa = Skrzydło.SzerokośćWPrzyldze - ParametrOtworu + (Skrzydło.SzerokośćWPrzyldze - OtwórSzerokość) / 2 + 20 - OdsunięcieOdOsi + InoxMałyZewSzerokośćStronaPrzylgowa - 35 - OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxZewWysokośćStronaPrzylgowa = OtwórWysokość + 2 * 35;
        InoxZewZaokrąglenieStronaPrzylgowa = 1;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2d * 15;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2d * 15;
        InoxWewZaokrąglenieStronaPrzylgowa = 0;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = InoxMałyZewSzerokośćStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (InoxZewWysokośćStronaPrzylgowa - InoxWewWysokośćStronaPrzylgowa) / 2d; ;

        //Mały inox felc
        InoxMałyZewSzerokośćStronaFelcowa = InoxMałyZewSzerokośćStronaPrzylgowa;
        InoxMałyZewWysokośćStronaFelcowa = InoxMałyZewWysokośćStronaPrzylgowa;
        InoxMałyZewZaokrąglenieStronaFelcowa = InoxMałyZewZaokrąglenieStronaPrzylgowa;
        InoxMałyWewSzerokośćStronaFelcowa = InoxMałyWewSzerokośćStronaPrzylgowa;
        InoxMałyWewWysokośćStronaFelcowa = InoxMałyWewWysokośćStronaPrzylgowa;
        InoxMałyWewZaokrąglenieStronaFelcowa = InoxMałyWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxMałyWewWzględemOsiXStronaFelcowa = OdsunięcieInoxMałyWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxMałyWewWzględemOsiYStronaFelcowa = OdsunięcieInoxMałyWewWzględemOsiYStronaPrzylgowa;

        //Duży inox felc
        InoxZewSzerokośćStronaFelcowa = Skrzydło.SzerokośćWPrzyldze - ParametrOtworu + (Skrzydło.SzerokośćWPrzyldze - OtwórSzerokość) / 2 + 20 - OdsunięcieOdOsi + InoxMałyZewSzerokośćStronaPrzylgowa - 35 - OdległośćInoxOdKrawędziStronaFelcowa - PrzylgaBoczna;
        InoxZewWysokośćStronaFelcowa = InoxZewWysokośćStronaPrzylgowa;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa;

        //Wycięcie duże
        InoxGeometriaStronaPrzylgowa = new(new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);

        //Wycięcie małe
        InoxGeometriaStronaPrzylgowa = new(InoxGeometriaStronaPrzylgowa, new Prostokąt(InoxMałyWewSzerokośćStronaPrzylgowa, InoxMałyWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxMałyWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxMałyWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxMałyWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(InoxGeometriaStronaFelcowa, new Prostokąt(InoxMałyWewSzerokośćStronaFelcowa, InoxMałyWewWysokośćStronaFelcowa, !PraweIsTrue, InoxMałyWewZaokrąglenieStronaFelcowa, OdsunięcieInoxMałyWewWzględemOsiXStronaFelcowa, OdsunięcieInoxMałyWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[4];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = Skrzydło.SzerokośćWPrzyldze - InoxZewSzerokośćStronaPrzylgowa - OdległośćInoxOdKrawędziStronaPrzylgowa;
        double odsunięcieInoxOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 600) / 3d;

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
                Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieInoxOdKrawędziY + 300d - InoxZewWysokośćStronaPrzylgowa / 2) * SkalaParametr)
            };
            if (ZewIsTrue == false)
            {
                paths[i].Data = InoxGeometriaStronaFelcowa.KombinacjaFigur;
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
        Path[] paths = new Path[4];
        Grid grid = new();
        double odsunięcieSzkłoOdKrawędziX = (Skrzydło.SzerokośćWPrzyldze - SzkłoSzerokość) / 2d + OdsunięcieOdOsi;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 600) / 3d;

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
