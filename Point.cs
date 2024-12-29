using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Constructor
        public Point(int _x, _y) {
            X = _x;
            Y = _y;
        }
        public Point(int Number) {
            X = Y = Number;
        }
        #endregion

    }
}
