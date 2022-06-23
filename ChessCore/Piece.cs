// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

using System;

namespace ChessCore
{
    public abstract class Piece
    {
        public int x;
        public int y;

        public Piece(string position = "A1")
        {
            x = position[0] - 65;
            y = position[1] - 49;
        }
        public Piece(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{Convert.ToChar(x + 65)}{y + 1}";
        }

        public abstract bool isRightMove(int x1, int y1);

        public virtual void Move(int x1, int y1)
        {
            if (isRightMove(x1, y1))
            {
                x = x1;
                y = y1;
            }
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