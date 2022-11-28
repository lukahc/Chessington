using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.Knight(currentSquare, newSquare);
        }

        public override bool IsUnblocked(Square currentSquare, Square newSquare, Board board)
        {
            return IsUnblockedFuncs.Knight(currentSquare, newSquare, board);
        }
    }
}
