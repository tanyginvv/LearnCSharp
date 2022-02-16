using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL1
{
    public class Ellipse
    {
        
        public int SmallAxis { get; private set; }
        public int BigAxis { get; private set; }

        public Ellipse( int smallAxis, int bigAxis )
        {
            if ( smallAxis <= 0 )
            {
                throw new ArgumentException( "SmallAxis cannot be less than or equal to 0" );
            }
            if ( bigAxis <= 0 ) 
            {
                throw new ArgumentException("BigAxis cannot be less than or equal to 0");
            }

            SmallAxis = smallAxis;
            BigAxis = bigAxis;
        }


        public int GetSquare()
        {
            return (int)( SmallAxis * BigAxis * Math.PI );
        }
        public int GetLength()
        {
            return (int)( ( SmallAxis + BigAxis) * Math.PI );
        }
    }
}