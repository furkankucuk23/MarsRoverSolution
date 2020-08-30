using MarsRover;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRoverTest
{
    public class MarsRoverUnitTest
    {
        [Fact]
        public void When_MaxCoordinate55_StartCoordinate12N_StepsLMLMLMLMM_ShouldReturn13N()
        {
            var maxCoordinate = new List<short>() { 5, 5 };
            var startCoordinate = new string[] { "1", "2", "N" };
            var steps = "LMLMLMLMM";

            var direction = new RoverPosition(startCoordinate, steps, maxCoordinate);
            var result = direction.Move();

            Assert.Equal(1, result.X);
            Assert.Equal(3, result.Y);
            Assert.Equal(CompassPoint.N, result.Direction);
        }

        [Fact]
        public void When_MaxCoordinate55_StartCoordinate12N_StepsLMLMLMLMM_ShouldReturn13N2()
        {
            var maxCoordinate = new List<short>() { 5, 5 };
            var startCoordinate = new string[] { "1", "2", "N" };
            var steps = "LMLMLMLMM";

            var direction = new RoverPosition(startCoordinate, steps, maxCoordinate);
            var result = direction.Move();

            Assert.Equal(2, result.X);
            Assert.Equal(3, result.Y);
            Assert.Equal(CompassPoint.N, result.Direction);
        }
    }
}
