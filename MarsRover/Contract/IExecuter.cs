using MarsRover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Contract
{
    public interface IExecuter
    {
        void Execute(Movable movable, Command command);
    }
}
