using TL1;

class Program
{
    public static void Main( string[] args ) 
    {
        int smallAxis = 5;
        int bigAxis = 10;
        try
        {
            Ellipse ellipse = new Ellipse( smallAxis, bigAxis );
            int square = ellipse.GetSquare();
            int length = ellipse.GetLength();
            Console.WriteLine( $"Площадь эллипса: {ellipse.GetSquare()}" );
            Console.WriteLine( $"Длина эллипса: {ellipse.GetLength()}" );
        }
        catch ( ArgumentException ex )
        {
            Console.WriteLine( ex.Message );
        }
    }
}