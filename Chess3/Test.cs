// Turushkin Sergey, 220P, "HW_Chess-3", 13.04.22

using ChessCore;
using System.Diagnostics;

namespace Chess3
{
    public class Test
    {
        public static void Run()
        {
            KingMove();
            QueenMove();
            BishopMove();
            KnightMove();
            RookMove();
            PawnMove();
        }

        public static void KingMove()
        {
            var piece = new King();

            piece.Move("A2");
            Debug.Assert(piece.ToString() == "A2");

            piece.Move("B3");
            Debug.Assert(piece.ToString() == "B3");

            Console.WriteLine("KingMove - success!");
        }

        public static void QueenMove()
        {
            var piece = new Queen();

            piece.Move("H1");
            Debug.Assert(piece.ToString() == "H1");

            piece.Move("A8");
            Debug.Assert(piece.ToString() == "A8");

            Console.WriteLine("QueenMove - success!");
        }

        public static void BishopMove()
        {
            var piece = new Bishop();

            piece.Move("E5");
            Debug.Assert(piece.ToString() == "E5");

            piece.Move("E6");
            Debug.Assert(piece.ToString() == "E5");

            Console.WriteLine("BishopMove - success!");
        }

        public static void KnightMove()
        {
            var piece = new Knight();

            piece.Move("B3");
            Debug.Assert(piece.ToString() == "B3");

            piece.Move("A5");
            Debug.Assert(piece.ToString() == "A5");

            Console.WriteLine("KnightMove - success!");
        }

        public static void RookMove()
        {
            var piece = new Rook();

            piece.Move("F1");
            Debug.Assert(piece.ToString() == "F1");

            piece.Move("D2");
            Debug.Assert(piece.ToString() == "F1");

            Console.WriteLine("RookMove - success!");
        }

        public static void PawnMove()
        {
            var piece = new Pawn();

            piece.Move("A2");
            Debug.Assert(piece.ToString() == "A2");

            piece.Move("B3");
            Debug.Assert(piece.ToString() == "A2");

            Console.WriteLine("PawnMove - success!");
        }
    }
}