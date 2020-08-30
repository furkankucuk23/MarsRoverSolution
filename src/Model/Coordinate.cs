using MarsRover.Common;
using System;

namespace MarsRover.Model
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CompassPoint Direction { get; set; }
         
        public override string ToString()
        {
            return string.Format(DirectionsConstant.XCoordinate + DirectionsConstant.YCoordinate + DirectionsConstant.Direction, X, Y, Direction); 
        }
    }
}
