using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var availableMoves = GetLine(board, currentSquare, 1, 0);
            availableMoves.AddRange(GetLine(board, currentSquare, -1, 0));
            availableMoves.AddRange(GetLine(board, currentSquare, 0, 1));
            availableMoves.AddRange(GetLine(board, currentSquare, 0, -1));
            availableMoves.AddRange(GetLine(board, currentSquare, 1, 1));
            availableMoves.AddRange(GetLine(board, currentSquare, 1, -1));
            availableMoves.AddRange(GetLine(board, currentSquare, -1, 1));
            availableMoves.AddRange(GetLine(board, currentSquare, -1, -1));
            return availableMoves;
        }
    }
}
