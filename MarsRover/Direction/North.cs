using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Core.Contract;
using MarsRover.Core.Model;

namespace MarsRover.Core.Direction
{
    public class North : IDirection
    {
        private static readonly IDirection _instance = new North();
        private North() { }
        public Model.Direction Name => Model.Direction.North;
        public static IDirection Instance { get { return _instance; } }
        public Position GetPositionDelta()
        {
            return new Position(0, 1);
        }
        public IDirection GetLeftDirection()
        {
            return West.Instance;
        }
        public IDirection GetRightDirection()
        {
            return East.Instance;
        }
    }
}
