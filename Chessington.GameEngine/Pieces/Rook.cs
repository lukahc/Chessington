using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.Rook(currentSquare, newSquare);
        }
    }
}
