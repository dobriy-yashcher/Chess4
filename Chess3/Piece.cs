// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

namespace Chess3
{
    public class Piece
    {
        public int x;
        public int y;

        public Piece(string position = "A1")
        {
            x = position[0] - 65;
            y = position[1] - 49;
        }

        public override string ToString()
        {
            return $"{Convert.ToChar(x + 65)}{y + 1}";
        }

        public virtual bool isRightMove(int x1, int y1)
        {
            return false;
        }

        public virtual void Move(string position)
        {
            int x1 = position[0] - 65;
            int y1 = position[1] - 49;

            if (isRightMove(x1, y1))
            {
                x = x1;
                y = y1;
            }
        }
    }
}