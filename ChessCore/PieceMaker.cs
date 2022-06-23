using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    public class PieceMaker
    {
        static public Piece Make(string pieceCode, int x = 0, int y = 0)
        {
            Piece piece = null;

            switch (pieceCode)
            {
                case "King":
                case "0":
                case "K":
                    piece = new King(x, y);
                    break;

                case "Queen":
                case "1":
                case "Q":
                    piece = new Queen(x, y);
                    break;

                case "Bishop":
                case "2":
                case "B":
                    piece = new Bishop(x, y);
                    break;

                case "Knight":
                case "3":
                case "N":
                    piece = new Knight(x, y);
                    break;

                case "Rook":
                case "4":
                case "R":
                    piece = new Rook(x, y);
                    break;

                case "Pawn":
                case "5":
                case "P":
                    piece = new Pawn(x, y);
                    break;

                default: throw (new Exception("Unknown piece code."));
            }

            return piece;
        }

        static public Piece Make(int pieceCode, int x = 0, int y = 0)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }
}
