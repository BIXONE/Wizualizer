namespace Wizualizer;

public partial class MainWindow : Window
{
    protected bool PraweIsTrue { get; set; }
    protected bool ZewIsTrue { get; set; }
    protected bool AntabaIsTrue { get; set; }
    protected bool SzyldGórnyIsTrue { get; set; }
    protected bool CiemneTłoIsTrue { get; set; }
    protected bool OścieżnicaIsTrue { get; set; }

    public Drzwi DrzwiWizualizacja { get; set; }
    public Antaba Antaba { get; set; }
    public Klamka Klamka { get; set; }
    public Ościeżnica Ościeżnica { get; set; }
    public Skrzydło Skrzydło { get; set; }
    public SzyldDolny SzyldDolny { get; set; }
    public SzyldGórny SzyldGórny { get; set; }

    protected string Technologia { get; set; }
    protected string OścieżnicaTyp { get; set; }
    protected string Model { get; set; }
    protected string Typ { get; set; }
    protected string Szerokość { get; set; }
    protected string Wysokość { get; set; }
    protected string OścieżnicaKolor { get; set; }
    protected string SkrzydłoKolor { get; set; }
    protected string SzyldDolnyKolor { get; set; }
    protected string AntabaKolor { get; set; }
    protected string AntabaDługość { get; set; }

    public string InoxKolor { get; set; }
    public string SzkłoKolor { get; set; }

    Style StyleWybranyPrzycisk = new();
    Style StyleNieWybranyPrzycisk = new();
    SolidColorBrush PodświetlenieSuwaka = (SolidColorBrush)new BrushConverter().ConvertFrom("#5E19FF");
    SolidColorBrush SuwakPoPrawo = (SolidColorBrush)new BrushConverter().ConvertFrom("#3700B8");
    SolidColorBrush SuwakPoLewo = (SolidColorBrush)new BrushConverter().ConvertFrom("#20006B");
    SolidColorBrush AktualneTłoSuwaka = new();

    public MainWindow()
    {
        Technologia = "Thermo 64";
        OścieżnicaTyp = "Aluminiowa";
        OścieżnicaKolor = "Czarny";
        Model = "Solid";
        Typ = "";
        SkrzydłoKolor = "Dąb Naturalny";
        InoxKolor = "Czarna";
        SzkłoKolor = "Szkło";
        Szerokość = "90";
        Wysokość = "200";
        SzyldDolnyKolor = "Czarna";
        AntabaKolor = "Czarna";
        AntabaDługość = "1800";

        OścieżnicaIsTrue = true;
        CiemneTłoIsTrue = true;
        PraweIsTrue = true;
        AntabaIsTrue = false;
        ZewIsTrue = true;
        SzyldGórnyIsTrue = false;
        Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
        Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
        SzyldDolny = new(SzyldDolnyKolor, AntabaIsTrue);
        SzyldGórny = new(SzyldDolny);
        Klamka = new(SzyldDolny.Kolor);
        Antaba = new(AntabaKolor, AntabaDługość, Skrzydło.WysokośćWPrzyldze);

        InitializeComponent();
        PobranieStylówPrzycisków();
        Odśwież();
        UtworzenieKatalogów();
    }

    private void UtworzenieKatalogów()
    {
        if (!System.IO.Directory.Exists(@"DXF"))
        {
            System.IO.Directory.CreateDirectory(@"DXF");
        }
        if (!System.IO.Directory.Exists(@"images"))
        {
            System.IO.Directory.CreateDirectory(@"images");
        }
    }

    private void PobranieStylówPrzycisków()
    {
        StyleNieWybranyPrzycisk = WizualizatorButton.Style;
        StyleWybranyPrzycisk = PrzyciskDoMenu.Style;
    }

    private void Odśwież()
    {
        switch (Model + Typ)
        {
            case "Amberg1": DrzwiWizualizacja = new Amberg1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Amberg2": DrzwiWizualizacja = new Amberg2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Amberg3": DrzwiWizualizacja = new Amberg3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Amberg4": DrzwiWizualizacja = new Amberg4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Biene1": DrzwiWizualizacja = new Biene1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Biene2": DrzwiWizualizacja = new Biene2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Biene3": DrzwiWizualizacja = new Biene3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Biene4": DrzwiWizualizacja = new Biene4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Horn1": DrzwiWizualizacja = new Horn1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Horn2": DrzwiWizualizacja = new Horn2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Horn3": DrzwiWizualizacja = new Horn3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben1": DrzwiWizualizacja = new Kreben1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben2": DrzwiWizualizacja = new Kreben2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben3": DrzwiWizualizacja = new Kreben3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben4": DrzwiWizualizacja = new Kreben4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben5": DrzwiWizualizacja = new Kreben5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben6": DrzwiWizualizacja = new Kreben6(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Kreben7": DrzwiWizualizacja = new Kreben7(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Langen1": DrzwiWizualizacja = new Langen1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Langen2": DrzwiWizualizacja = new Langen2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Langen3": DrzwiWizualizacja = new Langen3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Langen4": DrzwiWizualizacja = new Langen4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Langen5": DrzwiWizualizacja = new Langen5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leimen1": DrzwiWizualizacja = new Leimen1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leimen2": DrzwiWizualizacja = new Leimen2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leimen3": DrzwiWizualizacja = new Leimen3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leoben1": DrzwiWizualizacja = new Leoben1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leoben2": DrzwiWizualizacja = new Leoben2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leoben3": DrzwiWizualizacja = new Leoben3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Leoben4": DrzwiWizualizacja = new Leoben4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden1": DrzwiWizualizacja = new Linden1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden2": DrzwiWizualizacja = new Linden2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden3": DrzwiWizualizacja = new Linden3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden4": DrzwiWizualizacja = new Linden4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden5": DrzwiWizualizacja = new Linden5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Linden6": DrzwiWizualizacja = new Linden6(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lucerna1": DrzwiWizualizacja = new Lucerna1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lucerna2": DrzwiWizualizacja = new Lucerna2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lutter1": DrzwiWizualizacja = new Lutter1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lutter2": DrzwiWizualizacja = new Lutter2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lutter3": DrzwiWizualizacja = new Lutter3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Lutter4": DrzwiWizualizacja = new Lutter4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter1": DrzwiWizualizacja = new Murter1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter2": DrzwiWizualizacja = new Murter2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter3": DrzwiWizualizacja = new Murter3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter4": DrzwiWizualizacja = new Murter4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter5": DrzwiWizualizacja = new Murter5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Murter6": DrzwiWizualizacja = new Murter6(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Roding1": DrzwiWizualizacja = new Roding1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Roding2": DrzwiWizualizacja = new Roding2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Roding3": DrzwiWizualizacja = new Roding3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Samedan1": DrzwiWizualizacja = new Samedan1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Samedan2": DrzwiWizualizacja = new Samedan2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Samedan3": DrzwiWizualizacja = new Samedan3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Selters1": DrzwiWizualizacja = new Selters1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Selters2": DrzwiWizualizacja = new Selters2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Selters3": DrzwiWizualizacja = new Selters3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Selters4": DrzwiWizualizacja = new Selters4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Sion1": DrzwiWizualizacja = new Sion1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Sion2": DrzwiWizualizacja = new Sion2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Solid": DrzwiWizualizacja = new Solid(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur1": DrzwiWizualizacja = new Trebur1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur2": DrzwiWizualizacja = new Trebur2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur3": DrzwiWizualizacja = new Trebur3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur4": DrzwiWizualizacja = new Trebur4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur5": DrzwiWizualizacja = new Trebur5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur6": DrzwiWizualizacja = new Trebur6(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur7": DrzwiWizualizacja = new Trebur7(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur8": DrzwiWizualizacja = new Trebur8(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Trebur9": DrzwiWizualizacja = new Trebur9(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wiener1": DrzwiWizualizacja = new Wiener1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wiener2": DrzwiWizualizacja = new Wiener2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels1": DrzwiWizualizacja = new Wels1(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels2": DrzwiWizualizacja = new Wels2(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels3": DrzwiWizualizacja = new Wels3(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels4": DrzwiWizualizacja = new Wels4(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels5": DrzwiWizualizacja = new Wels5(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;
            case "Wels6": DrzwiWizualizacja = new Wels6(Ościeżnica, Skrzydło, SzyldDolny, Klamka, SzyldGórny, Antaba, AntabaIsTrue, PraweIsTrue, ZewIsTrue, SzyldGórnyIsTrue, InoxKolor, OścieżnicaIsTrue); break;

            default:
                break;
        }

        WizualizacjaObraz.Child = DrzwiWizualizacja.DrzwiBorder;
    }

    private void Wizualizator_Click(object sender, RoutedEventArgs e)
    {
        ZmianaSekcji();
        WizualizatorBorder.Visibility = Visibility.Visible;
        WizualizatorButton.Style = StyleWybranyPrzycisk;
    }

    private void ZmianaSekcji()
    {
        WizualizatorBorder.Visibility = Visibility.Hidden;

        WizualizatorButton.Style = StyleNieWybranyPrzycisk;
    }

    private void ExitButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Minimalizuj_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            WindowState = WindowState.Minimized;
        }
    }

    private void ZmianaPozycjiOkna(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }

    private void PraweLeweSuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (PraweIsTrue == false)
            {
                PraweIsTrue = true;
                PraweLeweSuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                PraweLeweSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else if (PraweIsTrue == true)
            {
                PraweIsTrue = false;
                PraweLeweSuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                PraweLeweSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
            }
            Odśwież();
        }
    }

    private void AntabaKlamkaSuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (AntabaIsTrue == true)
            {
                AntabaIsTrue = false;
                SzyldDolny = new(SzyldDolnyKolor, AntabaIsTrue);
                SzyldGórny = new(SzyldDolny);
                AntabaKlamkaSuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                AntabaKlamkaSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else if (AntabaIsTrue == false)
            {
                AntabaIsTrue = true;
                SzyldDolny = new(SzyldDolnyKolor, AntabaIsTrue);
                SzyldGórny = new(SzyldDolny);
                AntabaKlamkaSuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                AntabaKlamkaSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
            }
            Odśwież();
        }
    }

    private void ZewWewSuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (ZewIsTrue == false)
            {
                ZewIsTrue = true;
                ZewWewSuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                ZewWewSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else if (ZewIsTrue == true)
            {
                ZewIsTrue = false;
                ZewWewSuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                ZewWewSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
            }
            Odśwież();
        }
    }

    private void TechnologiaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Technologia = ((ComboBoxItem)TechnologiaComboBox.SelectedItem).Content.ToString();
        Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
        Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
        Odśwież();
    }

    private void OścieżnicaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        OścieżnicaTyp = ((ComboBoxItem)OścieżnicaComboBox.SelectedItem).Content.ToString();
        Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
        Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
        Odśwież();
    }

    private void ModelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Model = ((ComboBoxItem)ModelComboBox.SelectedItem).Content.ToString();
        Odśwież();
    }

    private void KolorRamekComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        InoxKolor = ((ComboBoxItem)KolorRamekComboBox.SelectedItem).Content.ToString();
        Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
        Odśwież();
    }

    private void KolorSkrzydłaKolorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        SkrzydłoKolor = ((ComboBoxItem)KolorSkrzydłaKolorBox.SelectedItem).Content.ToString();
        Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
        Odśwież();
    }

    private void KolorOścieżnicyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        OścieżnicaKolor = ((ComboBoxItem)KolorOścieżnicyComboBox.SelectedItem).Content.ToString();
        Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
        Odśwież();
    }

    private void KolorKlamiComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        SzyldDolnyKolor = ((ComboBoxItem)KolorKlamiComboBox.SelectedItem).Content.ToString();
        SzyldDolny = new(SzyldDolnyKolor, AntabaIsTrue);
        SzyldGórny = new(SzyldDolny);
        Klamka = new(SzyldDolny.Kolor);
        Odśwież();
    }

    private void DługośćAntabyCOmboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        AntabaDługość = ((ComboBoxItem)DługośćAntabyCOmboBox.SelectedItem).Content.ToString();
        Antaba = new(AntabaKolor, AntabaDługość, Skrzydło.WysokośćWPrzyldze);
        Odśwież();
    }

    private void KolorAntabyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        AntabaKolor = ((ComboBoxItem)KolorAntabyComboBox.SelectedItem).Content.ToString();
        Antaba = new(AntabaKolor, AntabaDługość, Skrzydło.WysokośćWPrzyldze);
        Odśwież();
    }

    private void SzerokośćWOśćPobrana_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (SzerokośćWOśćPobrana.Text.ToUpper() == "80" || SzerokośćWOśćPobrana.Text.ToUpper() == "80N" || SzerokośćWOśćPobrana.Text.ToUpper() == "90" ||
            SzerokośćWOśćPobrana.Text.ToUpper() == "90N" || SzerokośćWOśćPobrana.Text.ToUpper() == "100")
        {
            Szerokość = SzerokośćWOśćPobrana.Text;
            Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
            Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
            Odśwież();
        }
        else if (int.TryParse(SzerokośćWOśćPobrana.Text, out int result))
        {
            if (result >= 770 && result <= 1210)
            {
                Szerokość = SzerokośćWOśćPobrana.Text;
                Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
                Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
                Odśwież();
            }
        }
    }

    private void WysokośćWOśćPobrana_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (WysokośćWOśćPobrana.Text.ToUpper() == "200")
        {
            Wysokość = WysokośćWOśćPobrana.Text;
            Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
            Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
            Antaba = new(AntabaKolor, AntabaDługość, Skrzydło.WysokośćWPrzyldze);
            Odśwież();
        }
        else if (int.TryParse(WysokośćWOśćPobrana.Text, out int result))
        {
            if (result >= 1800 && result <= 2480)
            {
                Wysokość = WysokośćWOśćPobrana.Text;
                Ościeżnica = new(Technologia, OścieżnicaTyp, Szerokość, Wysokość, OścieżnicaKolor);
                Skrzydło = new(Technologia, Ościeżnica.OścieżnicaTyp, PraweIsTrue, Szerokość, Wysokość, SkrzydłoKolor, InoxKolor, SzkłoKolor);
                Antaba = new(AntabaKolor, AntabaDługość, Skrzydło.WysokośćWPrzyldze);
                Odśwież();
            }
        }
    }

    private void SuwakWizualizator_MouseEnter(object sender, MouseEventArgs e)
    {
        if (sender.GetType() == typeof(Border))
        {
            Border b = sender as Border;
            AktualneTłoSuwaka = (SolidColorBrush)b.Background;
            b.Background = PodświetlenieSuwaka;
        }
    }

    private void SuwakWizualizator_MouseLeave(object sender, MouseEventArgs e)
    {
        if (sender.GetType() == typeof(Border))
        {
            Border b = sender as Border;
            b.Background = AktualneTłoSuwaka;
        }
    }

    private void SzyldGórnySuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (SzyldGórnyIsTrue == false)
            {
                SzyldGórnyIsTrue = true;
                SzyldGórnySuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                SzyldGórnySuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else if (SzyldGórnyIsTrue == true)
            {
                SzyldGórnyIsTrue = false;
                SzyldGórnySuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                SzyldGórnySuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
            }
            Odśwież();
        }
    }

    private void GenerujDxfWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DrzwiWizualizacja.GenerujDXF();
            DrzwiWizualizacja.GenerujJpg();
        }
    }

    private void CiemneJasneSuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (CiemneTłoIsTrue == false)
            {
                CiemneTłoIsTrue = true;
                CiemneJasneSuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                CiemneJasneSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
                WizualizacjaObraz.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#303030");
                CiemneJasneTekst.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#F7FFF2");
                WidocznośćOścieżnicyTekst.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#F7FFF2");
            }
            else if (CiemneTłoIsTrue == true)
            {
                CiemneTłoIsTrue = false;
                CiemneJasneSuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                CiemneJasneSuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
                WizualizacjaObraz.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#808080");
                CiemneJasneTekst.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#000000");
                WidocznośćOścieżnicyTekst.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#000000");
            }
        }
    }

    private void TypComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (((ComboBoxItem)TypComboBox.SelectedItem).Content != null)
            Typ = ((ComboBoxItem)TypComboBox.SelectedItem).Content.ToString();
        else
            Typ = "";
        Odśwież();
    }

    private void WidocznośćOścieżnicySuwakWizualizator_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            if (OścieżnicaIsTrue == false)
            {
                OścieżnicaIsTrue = true;
                WidocznośćOścieżnicySuwakWizualizator.Background = SuwakPoPrawo;
                AktualneTłoSuwaka = SuwakPoPrawo;
                WidocznośćOścieżnicySuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else if (OścieżnicaIsTrue == true)
            {
                OścieżnicaIsTrue = false;
                WidocznośćOścieżnicySuwakWizualizator.Background = SuwakPoLewo;
                AktualneTłoSuwaka = SuwakPoLewo;
                WidocznośćOścieżnicySuwakKropkaWizualizator.HorizontalAlignment = HorizontalAlignment.Right;
            }
        }
        Odśwież();
    }
}
