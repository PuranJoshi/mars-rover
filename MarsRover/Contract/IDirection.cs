using MarsRover.Core.Model;

namespace MarsRover.Core.Contract
{
    public interface IDirection
    {
        Model.Direction Name { get; }
        IDirection GetLeftDirection();
        IDirection GetRightDirection();
        Position GetPositionDelta();
    }
}
