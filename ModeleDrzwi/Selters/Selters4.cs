﻿namespace Wizualizer.ModeleDrzwi.Selters;

public class Selters4 : Drzwi
{
    protected double OdsunięcieOdOsi { get; set; }

    protected double OtwórSzerokość { get; set; }
    protected double OtwórWysokość { get; set; }
    protected double OtwórZaokrąglenie { get; set; }

    protected double SzkłoSzerokość { get; set; }
    protected double SzkłoWysokość { get; set; }
    protected double SzkłoZaokrąglenie { get; set; }

    protected double InoxWewSzerokość1 { get; set; }
    protected double InoxWewWysokość1 { get; set; }
    protected double InoxWewZaokrąglenie1 { get; set; }

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

    public Selters4(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szyldGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
        : base(ościeżnica, skrzydło, szyldDolny, klamka, szyldGórny, antaba, antabaIsTrue, praweIsTrue, zewIsTrue, szyldGórnyIsTrue, inoxKolor, ościeżnicaIsTrue)
    {
        GeometriaModelu();
        RysujSzkło();
        RysujInox();
    }

    protected void GeometriaModelu()
    {
        OdsunięcieOdOsi = 320;
        OtwórSzerokość = 140;
        OtwórWysokość = 1604;
        OtwórZaokrąglenie = 8;

        SzkłoSzerokość = OtwórSzerokość - 8;
        SzkłoWysokość = OtwórWysokość - 8;
        SzkłoZaokrąglenie = 0;

        InoxWewSzerokość1 = OtwórSzerokość - 2d * 15d;
        InoxWewWysokość1 = 1155;
        InoxWewZaokrąglenie1 = 0;

        InoxZewSzerokośćStronaPrzylgowa = OtwórSzerokość + 2 * 20d;
        InoxZewWysokośćStronaPrzylgowa = Skrzydło.WysokośćWPrzyldze - 2 * OdległośćInoxOdKrawędziStronaPrzylgowa;
        InoxZewZaokrąglenieStronaPrzylgowa = 1d;
        InoxWewSzerokośćStronaPrzylgowa = OtwórSzerokość - 2d * 15d;
        InoxWewWysokośćStronaPrzylgowa = 35d;
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

        InoxGeometriaStronaPrzylgowa = new(new Prostokąt(InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, PraweIsTrue, InoxZewZaokrąglenieStronaPrzylgowa), new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
        InoxGeometriaStronaFelcowa = new(new Prostokąt(InoxZewSzerokośćStronaFelcowa, InoxZewWysokośćStronaFelcowa, !PraweIsTrue, InoxZewZaokrąglenieStronaFelcowa), new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);

        for (int i = 1; i < 23; i++)
        {
            if(i == 3)
            {
                InoxGeometriaStronaPrzylgowa = new(InoxGeometriaStronaPrzylgowa, new Prostokąt(InoxWewSzerokość1, InoxWewWysokość1, PraweIsTrue, InoxWewZaokrąglenie1, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, i * 70 + OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
                InoxGeometriaStronaFelcowa = new(InoxGeometriaStronaFelcowa, new Prostokąt(InoxWewSzerokość1, InoxWewWysokość1, !PraweIsTrue, InoxWewZaokrąglenie1, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, i * 70 + OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);
                i = 20;
            }

            InoxGeometriaStronaPrzylgowa = new(InoxGeometriaStronaPrzylgowa, new Prostokąt(InoxWewSzerokośćStronaPrzylgowa, InoxWewWysokośćStronaPrzylgowa, PraweIsTrue, InoxWewZaokrąglenieStronaPrzylgowa, OdsunięcieInoxWewWzględemOsiXStronaPrzylgowa, i * 70 + OdsunięcieInoxWewWzględemOsiYStronaPrzylgowa), PraweIsTrue, nazwaModelu: NazwaModelu);
            InoxGeometriaStronaFelcowa = new(InoxGeometriaStronaFelcowa, new Prostokąt(InoxWewSzerokośćStronaFelcowa, InoxWewWysokośćStronaFelcowa, !PraweIsTrue, InoxWewZaokrąglenieStronaFelcowa, OdsunięcieInoxWewWzględemOsiXStronaFelcowa, i * 70 + OdsunięcieInoxWewWzględemOsiYStronaFelcowa), !PraweIsTrue, nazwaModelu: NazwaModelu);
        }

        InoxTekstura = new(InoxKolor, InoxZewSzerokośćStronaPrzylgowa, InoxZewWysokośćStronaPrzylgowa, SkalaParametr);
        SzkłoGeometria = new(SzkłoSzerokość, SzkłoWysokość, PraweIsTrue);
        SzkłoTekstura = new(SzkłoKolor, SzkłoSzerokość, SzkłoWysokość, SkalaParametr);
    }

    protected override void RysujInox()
    {
        Path[] paths = new Path[1];
        Grid grid = new();
        double odsunięcieInoxOdKrawędziX = OdsunięcieOdOsi - InoxZewSzerokośćStronaPrzylgowa / 2;
        double odsunięcieInoxOdKrawędziY = OdległośćInoxOdKrawędziStronaPrzylgowa;

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
