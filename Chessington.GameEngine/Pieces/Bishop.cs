using System;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var availableMoves = GetLine(board, currentSquare, 1, 1);
            availableMoves.AddRange(GetLine(board, currentSquare, 1, -1));
            availableMoves.AddRange(GetLine(board, currentSquare, -1, 1));
            availableMoves.AddRange(GetLine(board, currentSquare, -1, -1));
            return availableMoves;
        }
    }
}
