namespace Wizualizer.Figury;

public class TrapezProstokątnyPionowy45 : Figura
{
    protected double Szerokość { get; set; }
    protected double Wysokość { get; set; }

    public TrapezProstokątnyPionowy45(double Szerokość, double Wysokość, double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d) 
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY)
    {
        this.Szerokość = Szerokość;
        this.Wysokość = Wysokość;
        GenerujFigure();
    }

    protected override void GenerujFigure()
    {
        ObrysFigury.StartPoint = new Point(0d, 0d);
        Polilinia.Add(new LineSegment() { Point = new Point(0d, Wysokość) });
        Polilinia.Add(new LineSegment() { Point = new Point(Szerokość, Wysokość) });
        Polilinia.Add(new LineSegment() { Point = new Point(Szerokość, Szerokość) });
        ZbiórObrysówFigur.Add(ObrysFigury);
        RegionFigury.Figures = ZbiórObrysówFigur;
    }

    protected override void GenerujDXF()
    {
    }
}
