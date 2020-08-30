using MarsRover.Abstraction;
using MarsRover.Common;
using System;
using System.Collections.Generic;

namespace MarsRover.Model
{
    public class RoverPosition : IRoverPosition
    {
        public Coordinate coordinate;
        private readonly List<short> maxCoordinate;
        private readonly string steps;
        public RoverPosition(string[] startCoordinate, string steps, List<short> maxCoordinate)
        {
            this.steps = steps;
            this.coordinate = new Coordinate
            {
                X = Convert.ToInt16(startCoordinate[0]),
                Y = Convert.ToInt16(startCoordinate[1]),
                Direction = (CompassPoint)Enum.Parse(typeof(CompassPoint), startCoordinate[2].ToUpper())
            };
            this.maxCoordinate = maxCoordinate;
        }

        public Coordinate Move()
        {
            foreach (var step in steps)
            {
                switch (step)
                {
                    case 'M':
                        coordinate = GoPosition(coordinate);
                        break;
                    case 'L':
                        coordinate = TurnLeft(coordinate);
                        break;
                    case 'R':
                        coordinate = TurnRight(coordinate);
                        break;
                    default:
                        break;
                }
                if (coordinate.X > maxCoordinate[0] || coordinate.X < 0 || coordinate.Y < 0 || coordinate.Y > maxCoordinate[1])
                {
                    throw new Exception(DirectionsConstant.MaxAreaError);
                }
            }
            return coordinate;
        }

        private Coordinate GoPosition(Coordinate coordinate)
        {

            switch (coordinate.Direction)
            {
                case CompassPoint.E:
                    coordinate.X += 1;
                    return coordinate;
                case CompassPoint.N:
                    coordinate.Y += 1;
                    return coordinate;
                case CompassPoint.S:
                    coordinate.Y -= 1;
                    return coordinate;
                case CompassPoint.W:
                    coordinate.X -= 1;
                    return coordinate;
                default:
                    return coordinate;
            }
        }

        private Coordinate TurnLeft(Coordinate coordinate)
        {
            switch (coordinate.Direction)
            {
                case CompassPoint.E:
                    coordinate.Direction = CompassPoint.N;
                    return coordinate;
                case CompassPoint.N:
                    coordinate.Direction = CompassPoint.W;
                    return coordinate;
                case CompassPoint.S:
                    coordinate.Direction = CompassPoint.E;
                    return coordinate;
                case CompassPoint.W:
                    coordinate.Direction = CompassPoint.S;
                    return coordinate;
                default:
                    return coordinate;
            }
        }

        private Coordinate TurnRight(Coordinate coordinate)
        {
            switch (coordinate.Direction)
            {
                case CompassPoint.E:
                    coordinate.Direction = CompassPoint.S;
                    return coordinate;
                case CompassPoint.N:
                    coordinate.Direction = CompassPoint.E;
                    return coordinate;
                case CompassPoint.S:
                    coordinate.Direction = CompassPoint.W;
                    return coordinate;
                case CompassPoint.W:
                    coordinate.Direction = CompassPoint.N;
                    return coordinate;
                default:
                    return coordinate;
            }
        }
    }
}
