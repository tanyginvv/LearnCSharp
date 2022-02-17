namespace TL1
{
    public class Ellipse
    {
        public int MinorAxis { get; private set; }
        public int MajorAxis { get; private set; }

        public Ellipse( int minorAxis, int majorAxis )
        {
            if ( minorAxis <= 0 )
            {
                throw new ArgumentException( "Minor semiaxis of ellipse cannot be less than or equal to 0" );
            }
            if ( majorAxis <= 0 ) 
            {
                throw new ArgumentException( "Major semiaxis of ellipse cannot be less than or equal to 0" );
            }

            MinorAxis = minorAxis;
            MajorAxis = majorAxis;
        }

        public int GetSquare()
        {
            return ( int )( Math.PI * MinorAxis * MajorAxis );
        }
        public int GetLength()
        {
            return ( int )( Math.PI * (MinorAxis + MajorAxis) );
        }
    }
}