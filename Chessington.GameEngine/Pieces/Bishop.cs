using System;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.Bishop(currentSquare, newSquare);
        }
    }
}
