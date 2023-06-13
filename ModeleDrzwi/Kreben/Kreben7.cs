namespace Wizualizer.ModeleDrzwi.Kreben;

public class Kreben7 : Drzwi
{
    protected double ParametrOtworu { get; set; }
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

    protected double PasekInoxSzerokośćStronaPrzylgowa { get; set; }
    protected double PasekInoxWysokośćStronaPrzylgowa { get; set; }
    protected double PasekInoxZaokrągleniePozytywneStronaPrzylgowa { get; set; }
    protected double PasekInoxZaokrąglenieNegatywneStronaPrzylgowa { get; set; }

    protected double PasekInoxSzerokośćStronaFelcowa { get; set; }
    protected double PasekInoxWysokośćStronaFelcowa { get; set; }
    protected double PasekInoxZaokrągleniePozytywneStronaFelcowa { get; set; }
    protected double PasekInoxZaokrąglenieNegatywneStronaFelcowa { get; set; }

    Tekstura InoxTekstura { get; set; }
    Prostokąt SzkłoGeometria { get; set; }
    Tekstura SzkłoTekstura { get; set; }

    public Kreben7(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        OdsunięcieOdOsi = 0;
        ParametrOtworu = 588;

        OtwórSzerokość = Skrzydło.SzerokośćWPrzyldze - ParametrOtworu;
        OtwórWysokość = 80;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        InoxZewSzerokośćStronaPrzylgowa = OtwórSzerokość + 2 * 20;
        InoxZewWysokośćStronaPrzylgowa = OtwórWysokość + 2 * 35;
        InoxZewZaokrąglenieStronaPrzylgowa = 1;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2 * 15;
        InoxWewWysokośćStronaPrzylgowa = OtwórWysokość - 2 * 15;
        InoxWewZaokrąglenieStronaPrzylgowa = 0;
        OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa = 35;
        OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa = (InoxZewWysokośćStronaPrzylgowa - InoxWewWysokośćStronaPrzylgowa) / 2d;

        InoxZewSzerokośćStronaFelcowa = InoxZewSzerokośćStronaPrzylgowa;
        InoxZewWysokośćStronaFelcowa = InoxZewWysokośćStronaPrzylgowa;
        InoxZewZaokrąglenieStronaFelcowa = InoxZewZaokrąglenieStronaPrzylgowa;
        InoxWewSzerokośćStronaFelcowa = InoxWewSzerokośćStronaPrzylgowa;
        InoxWewWysokośćStronaFelcowa = InoxWewWysokośćStronaPrzylgowa;
        InoxWewZaokrąglenieStronaFelcowa = InoxWewZaokrąglenieStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiXStronaFelcowa = OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa;
        OdsunięcieInoxWewWzględemOsiYStronaFelcowa = OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa;

        PasekInoxSzerokośćStronaPrzylgowa = (Skrzydło.SzerokośćWPrzyldze - InoxZewSzerokośćStronaPrzylgowa - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa) / 2;
        PasekInoxWysokośćStronaPrzylgowa = 15d;
        PasekInoxZaokrągleniePozytywneStronaPrzylgowa = 1d;
        PasekInoxZaokrąglenieNegatywneStronaPrzylgowa = 1d;

        PasekInoxSzerokośćStronaFelcowa = (Skrzydło.SzerokośćWPrzyldze - InoxZewSzerokośćStronaFelcowa - 2 * OdległośćInoxOdKrawędziStronaFelcowa - 2 * PrzylgaBoczna) / 2;
        PasekInoxWysokośćStronaFelcowa = PasekInoxWysokośćStronaPrzylgowa;
        PasekInoxZaokrągleniePozytywneStronaFelcowa = PasekInoxZaokrągleniePozytywneStronaPrzylgowa;
        PasekInoxZaokrąglenieNegatywneStronaFelcowa = PasekInoxZaokrąglenieNegatywneStronaPrzylgowa;

        InoxGeometriaStronaPrzylgowa = new(new ProstokątZPaskamiBocznymi(
            new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa),
            new WąskiPasekDoProstokąta(PasekInoxSzerokośćStronaPrzylgowa, PasekInoxWysokośćStronaPrzylgowa, PasekInoxZaokrągleniePozytywneStronaPrzylgowa, PasekInoxZaokrąglenieNegatywneStronaPrzylgowa),
            new WąskiPasekDoProstokąta(PasekInoxSzerokośćStronaPrzylgowa, PasekInoxWysokośćStronaPrzylgowa, PasekInoxZaokrągleniePozytywneStronaPrzylgowa, PasekInoxZaokrąglenieNegatywneStronaPrzylgowa), PraweIsTrue),
            new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa + PasekInoxSzerokośćStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa),
            PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxGeometriaStronaFelcowa = new(new ProstokątZPaskamiBocznymi(
            new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa),
            new WąskiPasekDoProstokąta(PasekInoxSzerokośćStronaFelcowa, PasekInoxWysokośćStronaFelcowa, PasekInoxZaokrągleniePozytywneStronaFelcowa, PasekInoxZaokrąglenieNegatywneStronaFelcowa),
            new WąskiPasekDoProstokąta(PasekInoxSzerokośćStronaFelcowa, PasekInoxWysokośćStronaFelcowa, PasekInoxZaokrągleniePozytywneStronaFelcowa, PasekInoxZaokrąglenieNegatywneStronaFelcowa), !PraweIsTrue),
            new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa + PasekInoxSzerokośćStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa),
            !PraweIsTrue, nazwaModelu: NazwaModelu);

        InoxTekstura = new(InoxKolor, Skrzydło.SzerokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[4];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = OdległośćInoxOdKrawędziStronaPrzylgowa;
        double odsunięcieInoxOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 730) / 3d;

        for (int i = 0; i < paths.Length; i++)
        {
            paths[i] = new()
            {
                Data = InoxGeometriaStronaPrzylgowa.KombinacjaFigur,
                StrokeThickness = 0,
                Fill = InoxTekstura.TeksturaObcięta,
                Stretch = Stretch.Fill,
                Width = (Skrzydło.SzerokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa) * SkalaParametr,
                Height = InoxZewWysokośćStronaPrzylgowa * SkalaParametr,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Left

            };
            if (ZewIsTrue == false)
            {
                paths[i].Data = InoxGeometriaStronaFelcowa.KombinacjaFigur;
                paths[i].Width = (Skrzydło.SzerokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaFelcowa - 2 * PrzylgaBoczna) * SkalaParametr;
                odsunięcieInoxOdKrawędziX = OdległośćInoxOdKrawędziStronaFelcowa + PrzylgaBoczna;
            }
            //// Sam szkielet
            //paths[i].Stroke = Brushes.Black;
            //paths[i].StrokeThickness = 1;
            //paths[i].Fill = Brushes.Transparent;

            paths[i].Margin = new Thickness(odsunięcieInoxOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieInoxOdKrawędziY + 365 - InoxZewWysokośćStronaPrzylgowa / 2) * SkalaParametr);

            grid.Children.Add(paths[i]);
        }
        DrzwiWarstwy["Inox"].Child = grid;
    }

    protected override void RysujSzkło()
    {
        Path[] paths = new Path[4];
        Grid grid = new();
        double odsunięcieSzkłoOdKrawędziX = (Skrzydło.SzerokośćWPrzyldze - SzkłoSzerokość) / 2d + OdsunięcieOdOsi;
        double odsunięcieSzkłoOdKrawędziY = (Skrzydło.WysokośćWPrzyldze - 730) / 3d;

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
                Margin = new Thickness(odsunięcieSzkłoOdKrawędziX * SkalaParametr, 0d, 0d, (i * odsunięcieSzkłoOdKrawędziY + 365 - SzkłoWysokość / 2) * SkalaParametr)
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
