using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var availableMoves = new List<Square>();
            var oneSpaceSquare = Square.At(
                currentSquare.Row + (this.Player == Player.White ? -1 : 1),
                currentSquare.Col
            );
            var twoSpaceSquare = Square.At(
                currentSquare.Row + (this.Player == Player.White ? -2 : 2),
                currentSquare.Col
            );
            var captureSquareL = Square.At(oneSpaceSquare.Row, currentSquare.Col - 1);
            var captureSquareR = Square.At(oneSpaceSquare.Row, currentSquare.Col + 1);
            if (board.SquareExists(oneSpaceSquare) && board.GetPiece(oneSpaceSquare) == null)
            {
                availableMoves.Add(oneSpaceSquare);
                if (
                    board.SquareExists(twoSpaceSquare)
                    && board.GetPiece(twoSpaceSquare) == null
                    && currentSquare.Row == (this.Player == Player.White ? 6 : 1)
                )
                {
                    availableMoves.Add(twoSpaceSquare);
                }
            }
            if (
                board.SquareExists(captureSquareL)
                && board.GetPiece(captureSquareL) != null
                && board.GetPiece(captureSquareL).Player != this.Player
            )
            {
                availableMoves.Add(captureSquareL);
            }
            if (
                board.SquareExists(captureSquareR)
                && board.GetPiece(captureSquareR) != null
                && board.GetPiece(captureSquareR).Player != this.Player
            )
            {
                availableMoves.Add(captureSquareR);
            }
            return availableMoves.Where(board.SquareExists).ToList();
        }
    }
}
