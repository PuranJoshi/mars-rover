using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Model
{
    public class Position
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
