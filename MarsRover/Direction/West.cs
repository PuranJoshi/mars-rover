using MarsRover.Core.Contract;
using MarsRover.Core.Model;

namespace MarsRover.Core.Direction
{
    public class West : IDirection
    {
        private static readonly IDirection _instance = new West();
        private West() { }
        public Model.Direction Name => Model.Direction.West;
        public static IDirection Instance { get { return _instance; } }
        public Position GetPositionDelta()
        {
            return new Position(-1, 0);
        }
        public IDirection GetLeftDirection()
        {
            return South.Instance;
        }
        public IDirection GetRightDirection()
        {
            return North.Instance;
        }
    }
}
