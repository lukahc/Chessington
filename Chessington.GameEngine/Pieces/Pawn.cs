using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(this);
            if (this.Player == Player.White)
            {
                availableMoves.Add(Square.At(currentSquare.Row - 1, currentSquare.Col));
                if (currentSquare.Row == 7)
                {
                    availableMoves.Add(Square.At(currentSquare.Row - 2, currentSquare.Col));
                }
            }
            else
            {
                availableMoves.Add(Square.At(currentSquare.Row + 1, currentSquare.Col));
                if (currentSquare.Row == 1)
                {
                    availableMoves.Add(Square.At(currentSquare.Row + 2, currentSquare.Col));
                }
            }
            return availableMoves;
        }
    }
}
