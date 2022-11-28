using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player) : base(player) { }

        public override bool IsAvailable(Square currentSquare, Square newSquare)
        {
            return IsAvailableFuncs.Bishop(currentSquare, newSquare)
                || IsAvailableFuncs.Rook(currentSquare, newSquare);
        }

        public override bool IsUnblocked(Square currentSquare, Square newSquare, Board board)
        {
            return IsUnblockedFuncs.Bishop(currentSquare, newSquare, board)
                || IsUnblockedFuncs.Rook(currentSquare, newSquare, board);
        }
    }
}
