using System;
using MarsRover.Core.Contract;

namespace MarsRover.Core
{
    public class Rover : Movable
    {
        public Rover(double x, double y, IDirection direction)
            : base(x,y,direction, new BasicCommandExecuter(1))
        {

        }

        internal Rover(double x, double y, IDirection direction, IExecuter executor)
            : base(x, y, direction, executor)
        {
        }
    }
}
