namespace Wizualizer.Figury;

public class SumaProstokątów : Prostokąt
{
    protected new PathGeometry? RegionFigury { get; }
    public CombinedGeometry KombinacjaFigur { get; set; }

    protected Prostokąt ProstokątPierwszy { get; set; }
    protected Prostokąt ProstokątDrugi { get; set; }
    protected SumaProstokątów SumowanaGeometria { get; set; }

    public SumaProstokątów(Prostokąt prostokątPierwszy, Prostokąt prostokątDrugi, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d) : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY, praweIsTrue)
    {
        ProstokątPierwszy = prostokątPierwszy;
        ProstokątDrugi = prostokątDrugi;

        GenerujFigureZProstokątów();
        GenerujDXFZProstokątów();
    }

    public SumaProstokątów(SumaProstokątów geometriaPierwsza, Prostokąt prostokątDrugi, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d) : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY, praweIsTrue)
    {
        SumowanaGeometria = geometriaPierwsza;
        ProstokątDrugi = prostokątDrugi;

        GenerujFigureZKolejnegoWycięcia();
        GenerujDXFZKolejnegoWycięcia();
    }

    protected void GenerujFigureZKolejnegoWycięcia()
    {
        KombinacjaFigur = new();
        KombinacjaFigur.GeometryCombineMode = GeometryCombineMode.Union;
        KombinacjaFigur.Geometry1 = SumowanaGeometria.KombinacjaFigur;
        KombinacjaFigur.Geometry2 = ProstokątDrugi.RegionFigury;
    }

    protected void GenerujDXFZKolejnegoWycięcia()
    {
        NazwaPlikuDXF = $"{SumowanaGeometria.ProstokątPierwszy.Szerokość}x{SumowanaGeometria.ProstokątPierwszy.Wysokość} _ {ProstokątDrugi.Szerokość}x{ProstokątDrugi.Wysokość} - {DateTime.Now.ToString("d")} {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.dxf";
        Thread.Sleep(10);
        DxfElementy.AddRange(SumowanaGeometria.DxfElementy);
        DxfElementy.AddRange(ProstokątDrugi.DxfElementy);

    }

    protected void GenerujFigureZProstokątów()
    {
        KombinacjaFigur = new();
        KombinacjaFigur.GeometryCombineMode = GeometryCombineMode.Union;
        KombinacjaFigur.Geometry1 = ProstokątPierwszy.RegionFigury;
        KombinacjaFigur.Geometry2 = ProstokątDrugi.RegionFigury;
    }

    protected void GenerujDXFZProstokątów()
    {
        NazwaPlikuDXF = $"{ProstokątPierwszy.Szerokość}x{ProstokątPierwszy.Wysokość} _ {ProstokątDrugi.Szerokość}x{ProstokątDrugi.Wysokość} - {DateTime.Now.ToString("d")} {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.dxf";
        Thread.Sleep(10);
        DxfElementy.AddRange(ProstokątPierwszy.DxfElementy);
        DxfElementy.AddRange(ProstokątDrugi.DxfElementy);
        
    }
}
