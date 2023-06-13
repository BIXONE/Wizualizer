namespace Wizualizer.Figury;

public class Prostokąt : Figura
{
    public double Szerokość { get; }
    public double Wysokość { get; }
    public double PromieńZaokrąglenia { get; set; }
    protected bool PraweIsTrue { get; set; }
    protected string NazwaModelu { get; set; }

    public Prostokąt(double szerokość, double wysokość, bool praweIsTrue, double promieńZaokrąglenia = 0d, 
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d, string nazwaModelu = "BrakModelu")
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY)
    {
        Szerokość = szerokość;
        Wysokość = wysokość;
        PromieńZaokrąglenia = promieńZaokrąglenia;
        PraweIsTrue = praweIsTrue;
        NazwaModelu = nazwaModelu;

        GenerujFigure();
        GenerujDXF();
    }

    public Prostokąt(double odsunięcieWzględemOsiX = 0, double odsunięcieWzględemOsiY = 0) : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY)
    {
    }

    protected override void GenerujFigure()
    {
        ObrysFigury.StartPoint = new Point(OdsunięcieWzględemOsiX, -(OdsunięcieWzględemOsiY + PromieńZaokrąglenia));

        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, -(OdsunięcieWzględemOsiY)),
            Size = new Size(PromieńZaokrąglenia, PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, -(OdsunięcieWzględemOsiY))
        });
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(Szerokość + OdsunięcieWzględemOsiX, -(OdsunięcieWzględemOsiY + PromieńZaokrąglenia)),
            Size = new Size(PromieńZaokrąglenia, PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(Szerokość + OdsunięcieWzględemOsiX, -(Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia))
        });
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, -(Wysokość + OdsunięcieWzględemOsiY)),
            Size = new Size(PromieńZaokrąglenia, PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, -(Wysokość + OdsunięcieWzględemOsiY))
        });
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(OdsunięcieWzględemOsiX, -(Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia)),
            Size = new Size(PromieńZaokrąglenia, PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });

        ZbiórObrysówFigur.Add(ObrysFigury);

        RegionFigury.Figures = ZbiórObrysówFigur;
    }

    protected override void GenerujDXF()
    {
        NazwaPlikuDXF = $"{NazwaModelu} {Szerokość}x{Wysokość}.dxf";

        if (PraweIsTrue == true)
        {
            if (PromieńZaokrąglenia >= 0d)
            {
                DxfElementy.Add(new DxfLine(new(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, OdsunięcieWzględemOsiY, 0d), new(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, OdsunięcieWzględemOsiY, 0d)));
                DxfElementy.Add(new DxfLine(new(Szerokość + OdsunięcieWzględemOsiX, OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), new(Szerokość + OdsunięcieWzględemOsiX, Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d)));
                DxfElementy.Add(new DxfLine(new(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, Wysokość + OdsunięcieWzględemOsiY, 0d), new(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, Wysokość + OdsunięcieWzględemOsiY, 0d)));
                DxfElementy.Add(new DxfLine(new(OdsunięcieWzględemOsiX, Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), new(OdsunięcieWzględemOsiX, OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d)));

                if (PromieńZaokrąglenia > 0d)
                {
                    DxfElementy.Add(new DxfArc(new(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 270d, 0d));
                    DxfElementy.Add(new DxfArc(new(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia, Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 0d, 90d));
                    DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 90d, 180d));
                    DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PromieńZaokrąglenia, OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 180d, 270d));
                }
            }
        }
        else
        {
            if (PromieńZaokrąglenia >= 0d)
            {
                DxfElementy.Add(new DxfLine(new(-(OdsunięcieWzględemOsiX + PromieńZaokrąglenia), OdsunięcieWzględemOsiY, 0d), new(-(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia), OdsunięcieWzględemOsiY, 0d)));
                DxfElementy.Add(new DxfLine(new(-(Szerokość + OdsunięcieWzględemOsiX), OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), new(-(Szerokość + OdsunięcieWzględemOsiX), Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d)));
                DxfElementy.Add(new DxfLine(new(-(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia), Wysokość + OdsunięcieWzględemOsiY, 0d), new(-(OdsunięcieWzględemOsiX + PromieńZaokrąglenia), Wysokość + OdsunięcieWzględemOsiY, 0d)));
                DxfElementy.Add(new DxfLine(new(-(OdsunięcieWzględemOsiX), Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), new(-(OdsunięcieWzględemOsiX), OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d)));

                if (PromieńZaokrąglenia > 0d)
                {
                    DxfElementy.Add(new DxfArc(new(-(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia), OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 180d, 270d));
                    DxfElementy.Add(new DxfArc(new(-(Szerokość + OdsunięcieWzględemOsiX - PromieńZaokrąglenia), Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 90d, 180d));
                    DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PromieńZaokrąglenia), Wysokość + OdsunięcieWzględemOsiY - PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 0d, 90d));
                    DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PromieńZaokrąglenia), OdsunięcieWzględemOsiY + PromieńZaokrąglenia, 0d), PromieńZaokrąglenia, 270d, 0d));
                }
            }
        }
    }
}
