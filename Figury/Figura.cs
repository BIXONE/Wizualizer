namespace Wizualizer.Figury;

public abstract class Figura
{
    public PathGeometry RegionFigury { get; set; }
    public List<DxfEntity> DxfElementy { get; set; }

    protected PathFigureCollection ZbiórObrysówFigur { get; set; }
    protected PathFigure ObrysFigury { get; set; }
    protected PathSegmentCollection Polilinia { get; set; }

    protected string NazwaPlikuDXF { get; set; }
    protected DxfFile PlikDXF { get; set; }

    public double OdsunięcieWzględemOsiX { get; set; }
    public double OdsunięcieWzględemOsiY { get; set; }

    protected Figura(double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d)
    {
        OdsunięcieWzględemOsiX = odsunięcieWzględemOsiX;
        OdsunięcieWzględemOsiY = odsunięcieWzględemOsiY;

        NazwaPlikuDXF = "Brak nazwy Pliku";
        DxfElementy = new();
        PlikDXF = new();
        RegionFigury = new();
        ZbiórObrysówFigur = new();
        Polilinia = new();
        ObrysFigury = new()
        {
            IsClosed = true,
            Segments = Polilinia
        };
    }

    protected abstract void GenerujFigure();
    protected abstract void GenerujDXF();

    public void ZapiszPlikDXF()
    {
        for (int i = 0; i < DxfElementy.Count; i++)
        {
            PlikDXF.Entities.Add(DxfElementy[i]);
        }
        PlikDXF.Save(@"DXF\" + NazwaPlikuDXF);
    }
}