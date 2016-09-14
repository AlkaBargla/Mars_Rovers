using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rovers_Library;


namespace Mars_Rovers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input to 1st rover");
            Console.WriteLine("6 , 6");
            Console.WriteLine("1 2 N");

            //Initializing the first rover with the rover position, the rover orientation and the plateau limit;
            Rover roverOne = new Rover(new Position(1, 2), Mars_Rovers_Library.Rover.Orientations.N, new Plateau(new Position(6, 6)));

            Console.WriteLine("MLRMRLMM");
            roverOne.Process("MLRMRLMM");
           
            
            //Initializing the second rover with the rover position, the rover orientation and the plateau limit;
            Rover roverTwo = new Rover(new Position(2, 2), Mars_Rovers_Library.Rover.Orientations.E, new Plateau(new Position(6, 6)));
           
            Console.WriteLine("MRMLRMRM");
            roverTwo.Process("MRMLRMRM");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Output 1 and 2 rover");
            Console.WriteLine(roverOne.ToString());
            Console.WriteLine(roverTwo.ToString());

            Console.ReadLine();

        }
    }
}
