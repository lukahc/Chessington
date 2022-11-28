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
            if (currentSquare.Col == newSquare.Col)
            {
                var sign = currentSquare.Row < newSquare.Row ? 1 : -1;
                for (var i = currentSquare.Row + sign; i != newSquare.Row + sign; i += sign)
                {
                    if (board.GetPiece(Square.At(i, currentSquare.Col)) != null)
                    {
                        return false;
                    }
                }
            }
            else
            {
                var sign = currentSquare.Col < newSquare.Col ? 1 : -1;
                for (var i = currentSquare.Col + sign; i != newSquare.Col + sign; i += sign)
                {
                    if (board.GetPiece(Square.At(currentSquare.Row, i)) != null)
                    {
                        return false;
                    }
                }
            }
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
