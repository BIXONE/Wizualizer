namespace Wizualizer.Figury;

public class RóżnicaProstokątów : Prostokąt
{
    protected new PathGeometry? RegionFigury { get; }
    public CombinedGeometry KombinacjaFigur { get; set; }

    protected Prostokąt ProstokątZew { get; set; }
    protected Prostokąt ProstokątWew { get; set; }
    protected RóżnicaProstokątów WyciętaGeometria { get; set; }
    protected ProstokątZPaskamiBocznymi ProstokątZPaskami { get; set; }

    public RóżnicaProstokątów(Prostokąt prostokątZewnętrzny, Prostokąt prostokątWewnętrzny, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d, string nazwaModelu = "BrakModelu") 
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY, praweIsTrue, nazwaModelu: nazwaModelu)
    {
        ProstokątZew = prostokątZewnętrzny;
        ProstokątWew = prostokątWewnętrzny;

        GenerujFigureZProstokątów();
        GenerujDXFZProstokątów();
    }

    public RóżnicaProstokątów(RóżnicaProstokątów wyciętaGeometria, Prostokąt prostokątWewnętrzny, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d, string nazwaModelu = "BrakModelu") 
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY, praweIsTrue, nazwaModelu: nazwaModelu)
    {
        WyciętaGeometria = wyciętaGeometria;
        ProstokątWew = prostokątWewnętrzny;

        GenerujFigureZKolejnegoWycięcia();
        GenerujDXFZKolejnegoWycięcia();
    }

    public RóżnicaProstokątów(ProstokątZPaskamiBocznymi wyciętaGeometria, Prostokąt prostokątWewnętrzny, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d, string nazwaModelu = "BrakModelu")
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY, praweIsTrue, nazwaModelu: nazwaModelu)
    {
        ProstokątZPaskami = wyciętaGeometria;
        ProstokątWew = prostokątWewnętrzny;

        GenerujFigureZProstokątaZPaskami();
        GenerujDXFZProstokątaZPaskami();
    }

    protected void GenerujFigureZProstokątaZPaskami()
    {
        KombinacjaFigur = new();
        KombinacjaFigur.GeometryCombineMode = GeometryCombineMode.Exclude;
        KombinacjaFigur.Geometry1 = ProstokątZPaskami.RegionFigury;
        KombinacjaFigur.Geometry2 = ProstokątWew.RegionFigury;
    }

    protected void GenerujDXFZProstokątaZPaskami()
    {
        NazwaPlikuDXF = $"{NazwaModelu} {ProstokątZPaskami.ProstokątZew.Szerokość}x{ProstokątZPaskami.ProstokątZew.Wysokość} _ {ProstokątWew.Szerokość}x{ProstokątWew.Wysokość} - {DateTime.Now.ToString("d")} {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.dxf";
        Thread.Sleep(10);
        DxfElementy.AddRange(ProstokątZPaskami.DxfElementy);
        DxfElementy.AddRange(ProstokątWew.DxfElementy);

    }

    protected void GenerujFigureZKolejnegoWycięcia()
    {
        KombinacjaFigur = new();
        KombinacjaFigur.GeometryCombineMode = GeometryCombineMode.Exclude;
        KombinacjaFigur.Geometry1 = WyciętaGeometria.KombinacjaFigur;
        KombinacjaFigur.Geometry2 = ProstokątWew.RegionFigury;
    }

    protected void GenerujDXFZKolejnegoWycięcia()
    {
        NazwaPlikuDXF = $"{NazwaModelu} - {DateTime.Now.ToString("d")} {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.dxf";
        Thread.Sleep(10);
        DxfElementy.AddRange(WyciętaGeometria.DxfElementy);
        DxfElementy.AddRange(ProstokątWew.DxfElementy);

    }

    protected void GenerujFigureZProstokątów()
    {
        KombinacjaFigur = new();
        KombinacjaFigur.GeometryCombineMode = GeometryCombineMode.Exclude;
        KombinacjaFigur.Geometry1 = ProstokątZew.RegionFigury;
        KombinacjaFigur.Geometry2 = ProstokątWew.RegionFigury;
    }

    protected void GenerujDXFZProstokątów()
    {
        NazwaPlikuDXF = $"{NazwaModelu} {ProstokątZew.Szerokość}x{ProstokątZew.Wysokość} _ {ProstokątWew.Szerokość}x{ProstokątWew.Wysokość} - {DateTime.Now.ToString("d")} {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.dxf";
        Thread.Sleep(10);
        DxfElementy.AddRange(ProstokątZew.DxfElementy);
        DxfElementy.AddRange(ProstokątWew.DxfElementy);
        
    }
}
