using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var availableMoves = new List<Square>();
            if (this.Player == Player.White)
            {
                var oneSpaceSquare = Square.At(currentSquare.Row - 1, currentSquare.Col);
                if (board.GetPiece(oneSpaceSquare) == null)
                {
                    availableMoves.Add(oneSpaceSquare);
                    var twoSpaceSquare = Square.At(4, currentSquare.Col);
                    if (board.GetPiece(twoSpaceSquare) == null && currentSquare.Row == 6)
                    {
                        availableMoves.Add(twoSpaceSquare);
                    }
                }
            }
            else
            {
                var oneSpaceSquare = Square.At(currentSquare.Row + 1, currentSquare.Col);
                if (board.GetPiece(oneSpaceSquare) == null)
                {
                    availableMoves.Add(oneSpaceSquare);
                    var twoSpaceSquare = Square.At(3, currentSquare.Col);
                    if (board.GetPiece(twoSpaceSquare) == null && currentSquare.Row == 1)
                    {
                        availableMoves.Add(twoSpaceSquare);
                    }
                }
            }
            return availableMoves;
        }
    }
}
