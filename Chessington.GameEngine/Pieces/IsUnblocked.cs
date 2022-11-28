using System;

namespace Chessington.GameEngine.Pieces
{
    public class IsUnblockedFuncs
    {
        public static bool Pawn(Square currentSquare, Square newSquare, Board board)
        {
            var rowDiff = currentSquare.Row - newSquare.Row;
            if (currentSquare.Col == newSquare.Col)
            {
                if (board.GetPiece(newSquare) != null)
                {
                    return false;
                }
                if (Math.Abs(rowDiff) == 2)
                {
                    if (
                        board.GetPiece(
                            Square.At(currentSquare.Row - rowDiff / 2, currentSquare.Col)
                        ) != null
                    )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool Rook(Square currentSquare, Square newSquare, Board board)
        {
            return true;
        }

        public static bool Bishop(Square currentSquare, Square newSquare, Board board)
        {
            return true;
        }

        public static bool Knight(Square currentSquare, Square newSquare, Board board)
        {
            return true;
        }

        public static bool King(Square currentSquare, Square newSquare, Board board)
        {
            return true;
        }
    }
}
