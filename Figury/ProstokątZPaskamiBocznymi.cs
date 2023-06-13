namespace Wizualizer.Figury;

public class ProstokątZPaskamiBocznymi : Prostokąt
{
    public CombinedGeometry KombinacjaFigur { get; set; }

    public Prostokąt ProstokątZew { get; set; }
    protected Prostokąt ProstokątWew { get; set; }
    protected WąskiPasekDoProstokąta PasekLewy { get; set; }
    protected WąskiPasekDoProstokąta PasekPrawy { get; set; }
    protected RóżnicaProstokątów WyciętaGeometria { get; set; }
    protected double PasekLewyPołożenieYWzględemFigury { get; set; }
    protected double PasekPrawyPołożenieYWzględemFigury { get; set; }

    public ProstokątZPaskamiBocznymi(Prostokąt prostokątZewnętrzny,
        WąskiPasekDoProstokąta pasekLewy, WąskiPasekDoProstokąta pasekPrawy, bool praweIsTrue,
        double odsunięcieWzględemOsiX = 0d, double odsunięcieWzględemOsiY = 0d, string nazwaModelu = "BrakModelu")
        : base(odsunięcieWzględemOsiX, odsunięcieWzględemOsiY)
    {
        ProstokątZew = prostokątZewnętrzny;
        PraweIsTrue = praweIsTrue;
        PasekLewy = pasekLewy;
        PasekPrawy = pasekPrawy;
        PasekLewyPołożenieYWzględemFigury = (ProstokątZew.Wysokość - PasekLewy.Wysokość) / 2;
        PasekPrawyPołożenieYWzględemFigury = (ProstokątZew.Wysokość - PasekPrawy.Wysokość) / 2;

        GenerujFigureZPaskami();
        GenerujDXFZPaskami();
    }

    protected void GenerujFigureZPaskami()
    {
        ObrysFigury.StartPoint = new Point(
            OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
            -(OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia));

        //    \--------
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                -(OdsunięcieWzględemOsiY)),
            Size = new Size(ProstokątZew.PromieńZaokrąglenia, ProstokątZew.PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                 OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia,
                -(OdsunięcieWzględemOsiY))
        });

        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                 OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                -(OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia)),
            Size = new Size(ProstokątZew.PromieńZaokrąglenia, ProstokątZew.PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury - PasekPrawy.PromieńZaokrągleniaNegatywny))
        });

        //             /------- 
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury)),
            Size = new Size(PasekPrawy.PromieńZaokrągleniaNegatywny, PasekPrawy.PromieńZaokrągleniaNegatywny),
            SweepDirection = SweepDirection.Clockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury))
        });

        //                     |      
        //             /-------/
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.PromieńZaokrągleniaPozytywny)),
            Size = new Size(PasekPrawy.PromieńZaokrągleniaPozytywny, PasekPrawy.PromieńZaokrągleniaPozytywny),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - PasekPrawy.PromieńZaokrągleniaPozytywny))
        });

        //              -------\   
        //                     |      
        //             /-------/
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość)),
            Size = new Size(PasekPrawy.PromieńZaokrągleniaPozytywny, PasekPrawy.PromieńZaokrągleniaPozytywny),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość))
        });

        //             |           
        //             \-------\   
        //                     |      
        //             /-------/
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość + PasekPrawy.PromieńZaokrągleniaNegatywny)),
            Size = new Size(PasekPrawy.PromieńZaokrągleniaNegatywny, PasekPrawy.PromieńZaokrągleniaNegatywny),
            SweepDirection = SweepDirection.Clockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                -(OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - ProstokątZew.PromieńZaokrąglenia))
        });

        //    ---------\           
        //             |           
        //             \-------\   
        //                     |      
        //             /-------/
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia,
                -(OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość)),
            Size = new Size(ProstokątZew.PromieńZaokrąglenia, ProstokątZew.PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                -(OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość))
        });

        //   /---------\           
        //   |         |           
        //             \-------\   
        //                     |      
        //             /-------/
        //             |
        //    \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                -(OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - ProstokątZew.PromieńZaokrąglenia)),
            Size = new Size(ProstokątZew.PromieńZaokrąglenia, ProstokątZew.PromieńZaokrąglenia),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość + PasekLewy.PromieńZaokrągleniaNegatywny))
        });

        //          /---------\           
        //          |         |           
        //   -------/         \-------\   
        //                            |      
        //                    /-------/
        //                    |
        //           \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość)),
            Size = new Size(PasekLewy.PromieńZaokrągleniaNegatywny, PasekLewy.PromieńZaokrągleniaNegatywny),
            SweepDirection = SweepDirection.Clockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość))
        });

        //          /---------\           
        //          |         |           
        //  /-------/         \-------\   
        //  |                         |      
        //                    /-------/
        //                    |
        //           \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - PasekLewy.PromieńZaokrągleniaPozytywny)),
            Size = new Size(PasekLewy.PromieńZaokrągleniaPozytywny, PasekLewy.PromieńZaokrągleniaPozytywny),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.PromieńZaokrągleniaPozytywny))
        });

        //          /---------\           
        //          |         |           
        //  /-------/         \-------\   
        //  |                         |      
        //  \-------          /-------/
        //                    |
        //           \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury)),
            Size = new Size(PasekLewy.PromieńZaokrągleniaPozytywny, PasekLewy.PromieńZaokrągleniaPozytywny),
            SweepDirection = SweepDirection.Counterclockwise
        });
        Polilinia.Add(new LineSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury))
        });

        //          /---------\           
        //          |         |           
        //  /-------/         \-------\   
        //  |                         |      
        //  \-------\         /-------/
        //                    |
        //           \--------/
        Polilinia.Add(new ArcSegment()
        {
            Point = new Point(
                OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                -(OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury - PasekLewy.PromieńZaokrągleniaNegatywny)),
            Size = new Size(PasekLewy.PromieńZaokrągleniaNegatywny, PasekLewy.PromieńZaokrągleniaNegatywny),
            SweepDirection = SweepDirection.Clockwise
        });

        ZbiórObrysówFigur.Add(ObrysFigury);

        RegionFigury.Figures = ZbiórObrysówFigur;
    }

    protected void GenerujDXFZPaskami()
    {
        NazwaPlikuDXF = $"{NazwaModelu} {Szerokość}x{Wysokość}.dxf";



        if (PraweIsTrue == true)
        {
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                OdsunięcieWzględemOsiY, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia,
                OdsunięcieWzględemOsiY, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX,
                OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d),
                new(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury - PasekPrawy.PromieńZaokrągleniaNegatywny, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - PasekPrawy.PromieńZaokrągleniaPozytywny, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość + PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość,
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia,
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość + PasekLewy.PromieńZaokrągleniaNegatywny, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                new(OdsunięcieWzględemOsiX,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.PromieńZaokrągleniaPozytywny, 0d)));

            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury, 0d)));
            
            DxfElementy.Add(new DxfLine(
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury - PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość,
                OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d)));

            if (ProstokątZew.PromieńZaokrąglenia > 0d)
            {
                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                    OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d), 
                    ProstokątZew.PromieńZaokrąglenia, 180d, 270d));

                DxfElementy.Add(new DxfArc(new(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX - ProstokątZew.PromieńZaokrąglenia,
                    OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 270d, 0d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia,
                    OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 0d, 90d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia,
                    OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 90d, 180d));
            }

            if (PasekLewy.PromieńZaokrągleniaNegatywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury - PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekLewy.PromieńZaokrągleniaNegatywny, 0d, 90d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny,
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość + PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekLewy.PromieńZaokrągleniaNegatywny, 270d, 0d));
            }

            if (PasekLewy.PromieńZaokrągleniaPozytywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekLewy.PromieńZaokrągleniaPozytywny, 90d, 180d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny,
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekLewy.PromieńZaokrągleniaPozytywny, 180d, 270d));
            }

            if (PasekPrawy.PromieńZaokrągleniaNegatywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość + PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaNegatywny, 180d, 270d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny,
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury - PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaNegatywny, 90d, 180d));
            }

            if (PasekPrawy.PromieńZaokrągleniaPozytywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaPozytywny, 0d, 90d));

                DxfElementy.Add(new DxfArc(new(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny,
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaPozytywny, 270d, 0d));
            }
        }
        else
        {
            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia),
                OdsunięcieWzględemOsiY, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia),
                OdsunięcieWzględemOsiY, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX),
                OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d),
                new(-(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury - PasekPrawy.PromieńZaokrągleniaNegatywny, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - PasekPrawy.PromieńZaokrągleniaPozytywny, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość),
                OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość + PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość),
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia),
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia),
                OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość),
                OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość + PasekLewy.PromieńZaokrągleniaNegatywny, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                new(-(OdsunięcieWzględemOsiX),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.PromieńZaokrągleniaPozytywny, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury, 0d)));

            DxfElementy.Add(new DxfLine(
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość),
                OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury - PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość),
                OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d)));

            if (ProstokątZew.PromieńZaokrąglenia > 0d)
            {
                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia),
                    OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 270d, 0d));

                DxfElementy.Add(new DxfArc(new(-(PasekLewy.Szerokość + ProstokątZew.Szerokość + OdsunięcieWzględemOsiX - ProstokątZew.PromieńZaokrąglenia),
                    OdsunięcieWzględemOsiY + ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 180d, 270d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość - ProstokątZew.PromieńZaokrąglenia),
                    OdsunięcieWzględemOsiY + 2 * PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 90d, 180d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.PromieńZaokrąglenia),
                    OdsunięcieWzględemOsiY + 2 * PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - ProstokątZew.PromieńZaokrąglenia, 0d),
                    ProstokątZew.PromieńZaokrąglenia, 0d, 90d));
            }

            if (PasekLewy.PromieńZaokrągleniaNegatywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny),
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury - PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekLewy.PromieńZaokrągleniaNegatywny, 90d, 180d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość - PasekLewy.PromieńZaokrągleniaNegatywny),
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość + PasekLewy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekLewy.PromieńZaokrągleniaNegatywny, 180d, 270d));
            }

            if (PasekLewy.PromieńZaokrągleniaPozytywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny),
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.Wysokość - PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekLewy.PromieńZaokrągleniaPozytywny, 0d, 90d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.PromieńZaokrągleniaPozytywny),
                    OdsunięcieWzględemOsiY + PasekLewyPołożenieYWzględemFigury + PasekLewy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekLewy.PromieńZaokrągleniaPozytywny, 270d, 0d));
            }

            if (PasekPrawy.PromieńZaokrągleniaNegatywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny),
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość + PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaNegatywny, 270d, 0d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.PromieńZaokrągleniaNegatywny),
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury - PasekPrawy.PromieńZaokrągleniaNegatywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaNegatywny, 0d, 90d));
            }

            if (PasekPrawy.PromieńZaokrągleniaPozytywny > 0d)
            {
                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny),
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.Wysokość - PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaPozytywny, 90d, 180d));

                DxfElementy.Add(new DxfArc(new(-(OdsunięcieWzględemOsiX + PasekLewy.Szerokość + ProstokątZew.Szerokość + PasekPrawy.Szerokość - PasekPrawy.PromieńZaokrągleniaPozytywny),
                    OdsunięcieWzględemOsiY + PasekPrawyPołożenieYWzględemFigury + PasekPrawy.PromieńZaokrągleniaPozytywny, 0d),
                    PasekPrawy.PromieńZaokrągleniaPozytywny, 180d, 270d));
            }
        }

    }
}

