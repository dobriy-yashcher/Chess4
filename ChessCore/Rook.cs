// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

namespace ChessCore
{
    public class Rook : Piece
    {
        public Rook(string position = "A1") : base(position) { }
        public Rook(int x = 0, int y = 0) : base(x, y) { }

        public override bool isRightMove(int x1, int y1)
        {
            return (x == x1 || y == y1);
        }
    }
}