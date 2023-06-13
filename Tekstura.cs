namespace Wizualizer;

public class Tekstura
{
    public ImageBrush TeksturaObcięta { get; set; }

    public Tekstura(string nazwaPlikuTextury, double szerokość, double wysokość, double skala = 1)
    {
        try
        {
        TeksturaObcięta = new ImageBrush(
            new CroppedBitmap(
                new BitmapImage(
                    new Uri($"Tekstury\\{nazwaPlikuTextury}.jpg", UriKind.Relative)), new Int32Rect(0, 0, (int)(szerokość * skala), (int)(wysokość * skala))));
        }
        catch
        {
            TeksturaObcięta = new ImageBrush(
                new BitmapImage(
                    new Uri($"Tekstury\\{nazwaPlikuTextury}.jpg", UriKind.Relative)));
        }
    }
}
