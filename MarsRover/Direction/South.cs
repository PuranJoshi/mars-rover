using MarsRover.Core.Contract;
using MarsRover.Core.Model;

namespace MarsRover.Core.Direction
{
    public class South : IDirection
    {
        private static readonly IDirection _instance = new South();
        private South() { }
        public Model.Direction Name => Model.Direction.South;
        public static IDirection Instance { get { return _instance; } }
        public Position GetPositionDelta()
        {
            return new Position(0, -1);
        }
        public IDirection GetLeftDirection()
        {
            return East.Instance;
        }
        public IDirection GetRightDirection()
        {
            return West.Instance;
        }
    }
}
