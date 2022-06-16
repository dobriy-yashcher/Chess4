// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

using System;

namespace Chess3
{
    public class Queen : Piece
    {
        public Queen(string position = "A1") : base(position) { }

        public override bool isRightMove(int x1, int y1)
        {
            return (x == x1 || y == y1 || Math.Abs(x - x1) == Math.Abs(y - y1));
        }
    }
}