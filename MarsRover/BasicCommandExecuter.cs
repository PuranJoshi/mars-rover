using MarsRover.Core.Contract;
using MarsRover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core
{
    public class BasicCommandExecuter : IExecuter
    {
        private readonly double _delta;
        public BasicCommandExecuter(double delta)
        {
            _delta = delta;
        }

        public void Execute(Movable movable, Command command)
        {
            switch (command)
            {
                case Command.L:
                    var newDirection = movable.Direction.GetLeftDirection();
                    movable.ChangeDirection(newDirection);
                    break;
                case Command.R:
                    newDirection = movable.Direction.GetRightDirection();
                    movable.ChangeDirection(newDirection);
                    break;
                case Command.M:
                    var positionDelta = movable.Direction.GetPositionDelta();
                    var newXPos = movable.Position.X + (positionDelta.X * _delta);
                    var newYPos = movable.Position.Y + (positionDelta.Y * _delta);
                    movable.ChangePosition(newXPos, newYPos);
                    break;
                default:
                    //Do nothing
                    break;
            }
        }
    }
}