using MarsRover.Common;
using MarsRover.Helpers;
using MarsRover.Model;
using System;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DirectionsConstant.WelcomeMessage);
            MessageHelper.DisplayMaxCoordinateMessage();
            Console.Write(DirectionsConstant.MaxPointsEntry);

            var maxCoordinateResult = InputHelper.CheckAndGetMaxCoordinate();
            while (!maxCoordinateResult.Item1)
            {
                Console.WriteLine(DirectionsConstant.ErrorMessage);
                Console.Write(DirectionsConstant.MaxPointsEntry);
                maxCoordinateResult = InputHelper.CheckAndGetMaxCoordinate();

            }

            MessageHelper.DisplayStartCoordinateMessage();
            Console.Write(DirectionsConstant.StartPointsEntry);

            var startCoordinateResult = InputHelper.CheckAndGetStartCoordinate();
            while (!startCoordinateResult.Item1)
            {
                Console.WriteLine(DirectionsConstant.ErrorMessage);
                Console.Write(DirectionsConstant.StartPointsEntry);
                startCoordinateResult = InputHelper.CheckAndGetStartCoordinate();
            }

            MessageHelper.DisplayStepsMessage();
            Console.Write(DirectionsConstant.StepsEntry);

            var stepsResult = InputHelper.CheckAndGetSteps();
            while (!stepsResult.Item1)
            {
                Console.WriteLine(DirectionsConstant.ErrorMessage);
                Console.Write(DirectionsConstant.StepsEntry);
                stepsResult = InputHelper.CheckAndGetSteps();
            }

            var direction = new RoverPosition(startCoordinateResult.Item2, stepsResult.Item2, maxCoordinateResult.Item2);
            try
            {
                var lastCoordinate = direction.Move();
                Console.WriteLine(lastCoordinate.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
