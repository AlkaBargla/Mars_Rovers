using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rovers_Library
{
    public interface IRover
    {
        IPosition RoverPosition { get; set; }
        Mars_Rovers_Library.Rover.Orientations RoverOrientation { get; set; }
        IPlateau RoverPlateau { get; set; }
        bool IsRobotInsideBoundaries { get; }
        void Process(string commands);
        string ToString();
    }
}
