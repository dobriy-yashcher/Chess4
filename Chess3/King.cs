﻿// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

namespace Chess3
{
    public class King : Piece
    {
        public King(string position = "A1") : base(position) { }

        public override bool isRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) <= 1 && Math.Abs(y - y1) <= 1);
        }
    }
}