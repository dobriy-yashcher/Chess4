// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

using System;

namespace ChessCore
{
    public class Bishop : Piece
    {
        public Bishop(string position = "A1") : base(position) { }
        public Bishop(int x = 0, int y = 0) : base(x, y) { }

        public override bool isRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) == Math.Abs(y - y1));
        }
    }
}