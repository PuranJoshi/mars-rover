using MarsRover.Core.Contract;
using MarsRover.Core.Model;
using System;

namespace MarsRover.Core
{
    public abstract class Movable
    {
        public Position Position { get; private set; }
        public IDirection Direction { get; private set; }
        private readonly IExecuter _commandExecuter;
        public Movable(double x, double y, IDirection direction, IExecuter commandExecuter)
        {
            Direction = direction;
            Position = new Position(x, y);
            _commandExecuter = commandExecuter;
        }
        public virtual void Move(Command command)
        {
            _commandExecuter.Execute(this, command);
        }
        internal void ChangeDirection(IDirection direction)
        {
            Direction = direction;
        }
        internal void ChangePosition(double xPos, double yPos)
        {
            var newPosition = new Position(xPos, yPos);
            Position = newPosition + 1;
        }
    }
}
