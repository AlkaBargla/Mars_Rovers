using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rovers_Library
{
     public class Plateau: IPlateau
    {
        public Position PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
