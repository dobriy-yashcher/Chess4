// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

using System;

namespace ChessCore
{
    public class Knight : Piece
    {
        public Knight(string position = "A1") : base(position) { }
        public Knight(int x = 0, int y = 0) : base(x, y) { }

        public override bool isRightMove(int x1, int y1)
        {
            return ((Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1) ||
                    (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2));
        }
    }
}