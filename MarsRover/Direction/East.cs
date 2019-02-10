using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Core.Contract;
using MarsRover.Core.Model;

namespace MarsRover.Core.Direction
{
    public class East : IDirection
    {
        private static readonly IDirection _instance = new East();
        private East() { }
        public static IDirection Instance { get { return _instance; } }
        public Model.Direction Name => Model.Direction.East;
        public Position GetPositionDelta()
        {
            return new Position(1, 0);
        }
        public IDirection GetLeftDirection()
        {
            return North.Instance;
        }
        public IDirection GetRightDirection()
        {
            return South.Instance;
        }
    }
}
