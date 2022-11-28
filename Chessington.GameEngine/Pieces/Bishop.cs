using System;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(this);
            for (var r = 0; r < 8; r++)
            {
                for (var c = 0; c < 8; c++)
                {
                    var newSquare = Square.At(r, c);
                    if (
                        !newSquare.Equals(currentSquare)
                        && Math.Abs(currentSquare.Row - newSquare.Row)
                            == Math.Abs(currentSquare.Col - newSquare.Col)
                    )
                    {
                        availableMoves.Add(newSquare);
                    }
                }
            }
            return availableMoves;
        }
    }
}
