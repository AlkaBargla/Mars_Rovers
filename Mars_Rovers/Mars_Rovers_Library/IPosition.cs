using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rovers_Library
{
    public interface IPosition
    {

        int X { get; set; }
        int Y { get; set; }
        string ToString();
    }
}
