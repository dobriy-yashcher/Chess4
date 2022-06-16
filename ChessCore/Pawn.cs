// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

namespace ChessCore
{
    public class Pawn : Piece
    {
        public Pawn(string position = "A1") : base(position) { }

        public override bool isRightMove(int x1, int y1)
        {
            return ((x == x1 && y == 2 && y + 2 >= y1) ||
                    (x == x1 && y + 1 == y1));
        }
    }
}