using System;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class IsAvailableFuncs
    {
        public static bool Pawn(Square currentSquare, Square newSquare, Player player)
        {
            if (currentSquare.Col != newSquare.Col)
            {
                return false;
            }
            if (player == Player.White)
            {
                if (
                    currentSquare.Row == newSquare.Row + 1
                    || (currentSquare.Row == 7 && newSquare.Row == 5)
                )
                {
                    return true;
                }
            }
            else
            {
                if (
                    currentSquare.Row == newSquare.Row - 1
                    || (currentSquare.Row == 1 && newSquare.Row == 3)
                )
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Rook(Square currentSquare, Square newSquare)
        {
            return currentSquare.Row == newSquare.Row || currentSquare.Col == newSquare.Col;
        }

        public static bool Bishop(Square currentSquare, Square newSquare)
        {
            return Math.Abs(currentSquare.Row - newSquare.Row)
                == Math.Abs(currentSquare.Col - newSquare.Col);
        }

        public static bool Knight(Square currentSquare, Square newSquare)
        {
            return false;
        }

        public static bool King(Square currentSquare, Square newSquare)
        {
            return false;
        }
    }
}
