// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

namespace Chess3
{
    public class Rook : Piece
    {
        public Rook(string position = "A1") : base(position) { }

        public override bool isRightMove(int x1, int y1)
        {
            return (x == x1 || y == y1);
        }
    }
}