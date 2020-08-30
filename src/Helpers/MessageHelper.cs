using MarsRover.Common;
using System;

namespace MarsRover.Helpers
{
    public static class MessageHelper
    {
        public static void DisplayMaxCoordinateMessage()
        {
            Console.WriteLine(DirectionsConstant.MaxCoordinateMessage);
            Console.WriteLine(DirectionsConstant.MaxCoordinateExample);
        }
        public static void DisplayStartCoordinateMessage()
        {
            Console.WriteLine(DirectionsConstant.StartPointMessage);
            Console.WriteLine(DirectionsConstant.StartPointExample);
        }

        public static void DisplayStepsMessage()
        {
            Console.WriteLine(DirectionsConstant.StepsMessage);
            Console.WriteLine(DirectionsConstant.StepsExample);
        }
    }
}
