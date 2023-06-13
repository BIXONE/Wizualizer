namespace Wizualizer.ModeleDrzwi;

public abstract class Drzwi
{
    protected bool OścieżnicaIsTrue { get; set; }
    protected bool AntabaIsTrue { get; set; }
    protected bool PraweIsTrue { get; set; }
    protected bool ZewIsTrue { get; set; }
    protected bool SzyldGórnyIsTrue { get; set; }

    #region Parametry

    // Parametry błędów
    protected bool isError = false;
    protected string KodBłedu { get; set; }

    // Parametry danych wejściowych
    public Antaba Antaba { get; set; }
    public Klamka Klamka { get; set; }
    public Ościeżnica Ościeżnica { get; set; }
    public Skrzydło Skrzydło { get; set; }
    public SzyldDolny SzyldDolny { get; set; }
    public SzyldGórny SzyldGórny { get; set; }
    public string InoxKolor { get; set; }
    public string SzkłoKolor { get; set; }

    // Parametry warstw
    public Border DrzwiBorder { get; set; }
    protected double DrzwiSzerokośćBorder { get; set; }
    protected double DrzwiWysokosćBorder { get; set; }
    public Grid DrzwiGrid { get; set; }
    public Border TłoBorder { get; set; }
    public Dictionary<string, Border> DrzwiWarstwy { get; set; }

    // Wymiary Przylg
    protected double PrzylgaGórna { get; set; }
    protected double PrzylgaDolna { get; set; }
    protected double PrzylgaBoczna { get; set; }
    protected double OdległośćInoxOdKrawędziStronaPrzylgowa { get; set; }
    protected double OdległośćInoxOdKrawędziStronaFelcowa { get; set; }
    protected double OdległośćInoxOdKrawędziStronaFelcowaDół { get; set; }

    // Inne Paramtery
    protected string NazwaModelu { get; set; }
    protected string KolorProgu { get; set; }
    protected double WidocznośćProguParametr { get; set; }
    protected double LuzMiędzyPrzylgąPodłogą { get; set; }
    protected double SkalaParametr { get; set; }

    #endregion

    public Drzwi(Ościeżnica ościeżnica, Skrzydło skrzydło, SzyldDolny szyldDolny, Klamka klamka, SzyldGórny szyldGórny,
        Antaba antaba, bool antabaIsTrue, bool praweIsTrue, bool zewIsTrue, bool szylgGórnyIsTrue, string inoxKolor, bool ościeżnicaIsTrue)
    {
        NazwaModelu = GetType().Name;
        Skrzydło = skrzydło;
        Ościeżnica = ościeżnica;
        SzyldDolny = szyldDolny;
        Klamka = klamka;
        SzyldGórny = szyldGórny;
        Antaba = antaba;
        InoxKolor = inoxKolor + " Ramki";
        ZewIsTrue = zewIsTrue;
        AntabaIsTrue = antabaIsTrue;
        PraweIsTrue = praweIsTrue;
        SzyldGórnyIsTrue = szylgGórnyIsTrue;
        OścieżnicaIsTrue = ościeżnicaIsTrue;

        WyliczeniePrzylgi();
        InicjowanieParametrówDrzwi();
        Inicjalizacja();

        if (PraweIsTrue == false)
            ZmieńKierunekOtwieraniaNaLewy();
    }

    protected void WyliczeniePrzylgi()
    {
        if (Skrzydło.Technologia == "Thermo 64" || Skrzydło.Technologia == "Thermo 78")
        {
            PrzylgaBoczna = 13.5d;
            PrzylgaDolna = 13.5d;
            PrzylgaGórna = 13.5d;
        }
        else if (Skrzydło.Technologia == "Thermo Hot 78" || Skrzydło.Technologia == "Thermo Hot 88")
        {
            PrzylgaDolna = 16d;
            PrzylgaGórna = 31d;
            PrzylgaBoczna = 31d;
        }
    }

    protected void ZmieńKierunekOtwieraniaNaLewy()
    {
        DrzwiBorder.RenderTransformOrigin = new Point(0.5d, 1d);
        ScaleTransform scaleTransform = new();
        scaleTransform.ScaleX = -1d;
        DrzwiBorder.RenderTransform = scaleTransform;
    }

    protected void InicjowanieParametrówDrzwi()
    {
        DrzwiSzerokośćBorder = 1600d;
        DrzwiWysokosćBorder = 2600d;
        SkalaParametr = 0.33d;
        WidocznośćProguParametr = 20d;
        LuzMiędzyPrzylgąPodłogą = 20d;
        OdległośćInoxOdKrawędziStronaPrzylgowa = 2d;
        OdległośćInoxOdKrawędziStronaFelcowa = 15d;
        OdległośćInoxOdKrawędziStronaFelcowaDół = 2d;

        KolorProgu = "szkło";

        SzkłoKolor = "szkło";
    }

    protected void Inicjalizacja()
    {
        WłaściwościBorders();

        RysujDrzwi();

        DrzwiBorder = new()
        {
            Width = DrzwiSzerokośćBorder * SkalaParametr,
            Height = DrzwiWysokosćBorder * SkalaParametr,
            Background = Brushes.Transparent,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,

            Child = DrzwiGrid
        };
    }

    protected void WłaściwościBorders()
    {
        DrzwiGrid = new()
        {
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Center
        };

        if (ZewIsTrue == true)
        {
            DrzwiWarstwy = new(){
            { "Próg", new Border() },
            { "LewaNoga", new Border() },
            { "PrawaNoga", new Border() },
            { "GórnaBelka", new Border() },

            { "Skrzydło", new Border() },
            { "Szkło", new Border() },
            { "Inox", new Border() },
            { "SzyldDolny", new Border() },
            { "SzyldGórny", new Border() },
            { "Klamka", new Border() },
            { "Antaba", new Border() }};

            for (int i = 0; i < DrzwiWarstwy.Count; i++)
            {
                if (i < 4)
                {
                    DrzwiWarstwy.ElementAt(i).Value.Width = Ościeżnica.SzerokośćWOśc * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Height = Ościeżnica.WysokośćWOśc * SkalaParametr;
                }
                else
                {
                    DrzwiWarstwy.ElementAt(i).Value.Width = Skrzydło.SzerokośćWPrzyldze * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Height = Skrzydło.WysokośćWPrzyldze * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Margin = new Thickness(0, 0, 0, LuzMiędzyPrzylgąPodłogą * SkalaParametr);
                }
                DrzwiWarstwy.ElementAt(i).Value.VerticalAlignment = VerticalAlignment.Bottom;
                DrzwiWarstwy.ElementAt(i).Value.HorizontalAlignment = HorizontalAlignment.Center;
                DrzwiWarstwy.ElementAt(i).Value.Background = Brushes.Transparent;
                DrzwiGrid.Children.Add(DrzwiWarstwy.ElementAt(i).Value);
            }
        }
        else
        {
            DrzwiWarstwy = new(){
            { "Skrzydło", new Border() },
            { "Szkło", new Border() },
            { "Inox", new Border() },

            { "Próg", new Border() },
            { "LewaNoga", new Border() },
            { "PrawaNoga", new Border() },
            { "GórnaBelka", new Border() },

            { "SzyldDolny", new Border() },
            { "SzyldGórny", new Border() },
            { "Klamka", new Border() },
            { "Antaba", new Border() }};

            for (int i = 0; i < DrzwiWarstwy.Count; i++)
            {
                if (i > 2 && i < 7)
                {
                    DrzwiWarstwy.ElementAt(i).Value.Width = Ościeżnica.SzerokośćWOśc * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Height = Ościeżnica.WysokośćWOśc * SkalaParametr;
                }
                else
                {
                    DrzwiWarstwy.ElementAt(i).Value.Width = Skrzydło.SzerokośćWPrzyldze * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Height = Skrzydło.WysokośćWPrzyldze * SkalaParametr;
                    DrzwiWarstwy.ElementAt(i).Value.Margin = new Thickness(0, 0, 0, LuzMiędzyPrzylgąPodłogą * SkalaParametr);
                }
                DrzwiWarstwy.ElementAt(i).Value.VerticalAlignment = VerticalAlignment.Bottom;
                DrzwiWarstwy.ElementAt(i).Value.HorizontalAlignment = HorizontalAlignment.Center;
                DrzwiWarstwy.ElementAt(i).Value.Background = Brushes.Transparent;
                DrzwiGrid.Children.Add(DrzwiWarstwy.ElementAt(i).Value);
            }
        }


    }

    protected void RysujDrzwi()
    {
        RysujPróg();
        RysujLewąNogę();
        RysujPrawąNogę();
        RysujGórnąBelkę();
        RysujSkrzydło();
        RysujOkucia();
    }

    protected void RysujOkucia()
    {
        RysujSzyldDolny();


        if (AntabaIsTrue == true)
        {
            RysujAntabe();
        }
        else if (AntabaIsTrue == false)
        {
            RysujKlamke();
        }

        if (SzyldGórnyIsTrue == true)
            RysujSzyldGórny();
    }

    #region Rysowanie ościeżnicy

    protected void RysujLewąNogę()
    {
        Path path = new()
        {
            Data = new Prostokąt(Ościeżnica.SzerokośćOŚC, Ościeżnica.WysokośćWOśc, true).RegionFigury,
            Stroke = Brushes.Black,
            StrokeThickness = 1,
            Fill = new Tekstura(Ościeżnica.OścieżnicaKolor, Ościeżnica.SzerokośćOŚC, Ościeżnica.WysokośćWOśc, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Ościeżnica.SzerokośćOŚC * SkalaParametr,
            Height = Ościeżnica.WysokośćWOśc * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(0, 0, 0, 0)
        };

        if (OścieżnicaIsTrue == false)
        {
            path.StrokeThickness = 0d;
            path.Fill = Brushes.Transparent;
        }

        DrzwiWarstwy["LewaNoga"].Child = path;
    }

    protected void RysujPrawąNogę()
    {
        Path path = new()
        {
            Data = new Prostokąt(Ościeżnica.SzerokośćOŚC, Ościeżnica.WysokośćWOśc, true).RegionFigury,
            Stroke = Brushes.Black,
            StrokeThickness = 1,
            Fill = new Tekstura(Ościeżnica.OścieżnicaKolor, Ościeżnica.SzerokośćOŚC, Ościeżnica.WysokośćWOśc, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Ościeżnica.SzerokośćOŚC * SkalaParametr,
            Height = Ościeżnica.WysokośćWOśc * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness((Ościeżnica.SzerokośćWOśc - Ościeżnica.SzerokośćOŚC) * SkalaParametr, 0, 0, 0),
            RenderTransformOrigin = new Point(0.5d, 1d),
            RenderTransform = new ScaleTransform() { ScaleX = -1d }
        };

        if (OścieżnicaIsTrue == false)
        {
            path.StrokeThickness = 0d;
            path.Fill = Brushes.Transparent;
        }

        DrzwiWarstwy["PrawaNoga"].Child = path;
    }

    protected void RysujGórnąBelkę()
    {
        Path path = new()
        {
            Data = new TrapezRównowamiennyPionowy45(Ościeżnica.SzerokośćOŚC, Ościeżnica.SzerokośćWOśc).RegionFigury,
            Stroke = Brushes.Black,
            StrokeThickness = 1,
            Fill = new Tekstura(Ościeżnica.OścieżnicaKolor, Ościeżnica.SzerokośćOŚC, Ościeżnica.SzerokośćWOśc, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Ościeżnica.SzerokośćOŚC * SkalaParametr,
            Height = Ościeżnica.SzerokośćWOśc * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(0, 0, 0, (Ościeżnica.WysokośćWOśc - Ościeżnica.SzerokośćWOśc - Ościeżnica.SzerokośćOŚC) * SkalaParametr),
            RenderTransform = new RotateTransform(-90)
        };

        if (OścieżnicaIsTrue == false)
        {
            path.StrokeThickness = 0d;
            path.Fill = Brushes.Transparent;
        }

        DrzwiWarstwy["GórnaBelka"].Child = path;
    }

    protected void RysujPróg()
    {
        Path path = new()
        {
            Data = new Prostokąt(Ościeżnica.SzerokośćWOśc, WidocznośćProguParametr, true).RegionFigury,
            Stroke = Brushes.Black,
            StrokeThickness = 1,
            Fill = new Tekstura("Inox", Ościeżnica.SzerokośćWOśc, WidocznośćProguParametr, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Ościeżnica.SzerokośćWOśc * SkalaParametr,
            Height = WidocznośćProguParametr * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Center,
            Margin = new Thickness(0, 0, 0, 0)
        };

        if (OścieżnicaIsTrue == false)
        {
            path.StrokeThickness = 0d;
            path.Fill = Brushes.Transparent;
        }

        DrzwiWarstwy["Próg"].Child = path;
    }

    #endregion

    #region Rysowanie Skrzydła

    protected void RysujSkrzydło()
    {
        Path path = new()
        {
            Data = new Prostokąt(Skrzydło.SzerokośćWPrzyldze, Skrzydło.WysokośćWPrzyldze, true).RegionFigury,
            Stroke = Brushes.Black,
            StrokeThickness = 1,
            Fill = new Tekstura(Skrzydło.SkrzydłoKolor, Skrzydło.SzerokośćWPrzyldze, Skrzydło.WysokośćWPrzyldze, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Skrzydło.SzerokośćWPrzyldze * SkalaParametr,
            Height = Skrzydło.WysokośćWPrzyldze * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Center,
            Margin = new Thickness(0, 0, 0, 0)
        };

        DrzwiWarstwy["Skrzydło"].Child = path;
    }

    protected abstract void RysujSzkło();

    protected abstract void RysujInox();

    public abstract void GenerujDXF();

    public void GenerujJpg()
    {
        RenderTargetBitmap renderTargetBitmap = new((int)DrzwiBorder.Width, (int)DrzwiBorder.Height, 0, 0, PixelFormats.Default);
        renderTargetBitmap.Render(DrzwiGrid);

        JpegBitmapEncoder jpeg = new();
        jpeg.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

        using (System.IO.Stream stream = System.IO.File.Create(@"images\plik"
                + string.Join('_', DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString()
                , DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString()) + ".jpg"))
        {
            jpeg.Save(stream);
        }
    }
    #endregion

    #region Rysowanie Okuć

    void RysujSzyldDolny()
    {
        Path path = new()
        {
            Data = new Prostokąt(SzyldDolny.SzyldDolnySzerokość, SzyldDolny.SzyldDolnyWysokość, true).RegionFigury,
            StrokeThickness = 0,
            Fill = new Tekstura(Klamka.Kolor, Skrzydło.SzerokośćWPrzyldze, Skrzydło.WysokośćWPrzyldze, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = SzyldDolny.SzyldDolnySzerokość * SkalaParametr,
            Height = SzyldDolny.SzyldDolnyWysokość * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness((SzyldDolny.SzyldDolnyParametrX - SzyldDolny.SzyldDolnySzerokość / 2d) * SkalaParametr,
            0d, 0d, (SzyldDolny.SzyldDolnyParametrY - SzyldDolny.SzyldDolnyWysokośćKlamkiWSzyldzie) * SkalaParametr)
        };

        DrzwiWarstwy["SzyldDolny"].Child = path;
    }

    void RysujKlamke()
    {
        Path path = new()
        {
            Data = new Prostokąt(Klamka.KlamkaSzerokość, Klamka.KlamkaWysokość, true).RegionFigury,
            StrokeThickness = 0,
            Fill = new Tekstura(Klamka.Kolor, Klamka.KlamkaSzerokość, Klamka.KlamkaWysokość, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Klamka.KlamkaSzerokość * SkalaParametr,
            Height = Klamka.KlamkaWysokość * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            RenderTransform = new RotateTransform(-90),
            Margin = new Thickness((SzyldDolny.SzyldDolnyParametrX - SzyldDolny.SzyldDolnySzerokość / 2d) * SkalaParametr,
            0d, 0d, (SzyldDolny.SzyldDolnyParametrY - SzyldDolny.SzyldDolnyWysokośćKlamkiWSzyldzie) * SkalaParametr)
        };

        DrzwiWarstwy["Klamka"].Child = path;
    }

    void RysujSzyldGórny()
    {
        Path path = new()
        {
            Data = new Prostokąt(SzyldGórny.SzyldGórnySzerokość, SzyldGórny.SzyldGórnyWysokość, true).RegionFigury,
            StrokeThickness = 0,
            Fill = new Tekstura(Klamka.Kolor, SzyldGórny.SzyldGórnySzerokość, SzyldGórny.SzyldGórnyWysokość, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = SzyldGórny.SzyldGórnySzerokość * SkalaParametr,
            Height = SzyldGórny.SzyldGórnyWysokość * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness((SzyldGórny.SzyldGórnyParametrX - SzyldGórny.SzyldGórnySzerokość / 2d) * SkalaParametr,
            0d, 0d, (SzyldGórny.SzyldGórnyParametrY - SzyldDolny.SzyldDolnyWysokośćKlamkiWSzyldzie) * SkalaParametr)
        };

        DrzwiWarstwy["SzyldGórny"].Child = path;
    }

    void RysujAntabe()
    {
        Path path = new()
        {
            Data = new Prostokąt(Antaba.AntabaSzerokość, Antaba.AntabaWysokość, true).RegionFigury,
            StrokeThickness = 0,
            Fill = new Tekstura(Antaba.Kolor, Antaba.AntabaSzerokość, Antaba.AntabaWysokość, SkalaParametr).TeksturaObcięta,
            Stretch = Stretch.Fill,
            Width = Antaba.AntabaSzerokość * SkalaParametr,
            Height = Antaba.AntabaWysokość * SkalaParametr,
            VerticalAlignment = VerticalAlignment.Bottom,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness((Antaba.AntabaParametrX - Antaba.AntabaSzerokość / 2) * SkalaParametr,
            0d, 0d, (Ościeżnica.WysokośćWOśc - Antaba.AntabaWysokość) / 2d * SkalaParametr)
        };

        DrzwiWarstwy["Antaba"].Child = path;
    }

    #endregion
}
