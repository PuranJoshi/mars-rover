using System;
using MarsRover.Core;
using MarsRover.Core.Contract;
using MarsRover.Core.Direction;
using MarsRover.Core.Model;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverFixture
    {
        Movable marsRover;

        [Theory]
        [InlineData(0, 0, Direction.East, Command.L, 0, 0, Direction.North)]
        [InlineData(0, 0, Direction.West, Command.L, 0, 0, Direction.South)]
        [InlineData(0, 0, Direction.North, Command.L, 0, 0, Direction.West)]
        [InlineData(0, 0, Direction.South, Command.L, 0, 0, Direction.East)]
        [InlineData(0, 0, Direction.East, Command.R, 0, 0, Direction.South)]
        [InlineData(0, 0, Direction.West, Command.R, 0, 0, Direction.North)]
        [InlineData(0, 0, Direction.North, Command.R, 0, 0, Direction.East)]
        [InlineData(0, 0, Direction.South, Command.R, 0, 0, Direction.West)]
        [InlineData(0, 0, Direction.East, Command.M, 1, 0, Direction.East)]
        [InlineData(0, 0, Direction.West, Command.M, -1, 0, Direction.West)]
        [InlineData(0, 0, Direction.North, Command.M, 0, 1, Direction.North)]
        [InlineData(0, 0, Direction.South, Command.M, 0, -1, Direction.South)]
        [InlineData(3, 3, Direction.East, Command.M, 4, 3, Direction.East)]
        [InlineData(3, 3, Direction.West, Command.M, 2, 3, Direction.West)]
        [InlineData(3, 3, Direction.North, Command.M, 3, 4, Direction.North)]
        [InlineData(3, 3, Direction.South, Command.M, 3, 2, Direction.South)]
        public void SingleCommand_Execution(double currentX, double currentY, Direction currentDirection, Command command, double newX, double newY, Direction newDirection)
        {
            var direction = GetDirection(currentDirection);
            marsRover = new Rover(currentX, currentY, direction);

            marsRover.Move(command);

            Assert.Equal(newDirection, marsRover.Direction.Name);
            Assert.Equal(newX, marsRover.Position.X);
            Assert.Equal(newY, marsRover.Position.Y);

        }

        private IDirection GetDirection(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.East:
                    return East.Instance;
                case Direction.West:
                    return West.Instance;
                case Direction.North:
                    return North.Instance;
                case Direction.South:
                    return South.Instance;
                default:
                    throw new Exception("Unknown direction");
            }
        }
    }
}