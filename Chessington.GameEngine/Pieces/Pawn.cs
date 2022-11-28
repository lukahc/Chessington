using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.Pawn(currentSquare, newSquare, this.Player);
        }
    }
}
