using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.King(currentSquare, newSquare);
        }
    }
}
