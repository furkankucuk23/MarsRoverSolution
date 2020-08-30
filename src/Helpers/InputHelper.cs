using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace MarsRover.Helpers
{
    public static class InputHelper
    {
        public static Tuple<bool, List<short>> CheckAndGetMaxCoordinate()
        {
            try
            {
                var maxCoordinate = Console.ReadLine()?.Trim()?.Split(' ')?.Select(x => Convert.ToInt16(x))?.ToList();
                if (maxCoordinate == null || !maxCoordinate.Any() || maxCoordinate.Count != 2)
                {
                    return new Tuple<bool, List<short>>(false, null);
                }
                else
                {
                    return new Tuple<bool, List<short>>(true, maxCoordinate);
                }
            }
            catch
            {
                return new Tuple<bool, List<short>>(false, null);
            }

        }
        public static Tuple<bool, string[]> CheckAndGetStartCoordinate()
        {
            try
            {
                var startCoordinate = Console.ReadLine()?.Trim()?.Split(' ');
                if ((startCoordinate == null || !startCoordinate.Any() || startCoordinate.Length != 3) ||
                    !Regex.IsMatch(startCoordinate[0], "^[0-9]*$") ||
                    !Regex.IsMatch(startCoordinate[1], "^[0-9]*$") ||
                    !Regex.IsMatch(startCoordinate[2], @"^[enwsENWS]+$"))
                {
                    return new Tuple<bool, string[]>(false, null);
                }
                else
                {
                    return new Tuple<bool, string[]>(true, startCoordinate);
                }
            }
            catch
            {
                return new Tuple<bool, string[]>(false, null);
            }

        }

        public static Tuple<bool, string> CheckAndGetSteps()
        {
            try
            {
                var steps = Console.ReadLine().ToUpper();

                if (Regex.IsMatch(steps, @"^[lmrLMR]+$"))
                {
                    return new Tuple<bool, string>(true, steps);
                }
                else
                {
                    return new Tuple<bool, string>(false, null);
                }
            }
            catch
            {
                return new Tuple<bool, string>(false, null);
            }

        }
    }
}
