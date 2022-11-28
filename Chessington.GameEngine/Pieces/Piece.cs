using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public abstract class Piece
    {
        protected Piece(Player player)
        {
            Player = player;
        }

        public Player Player { get; private set; }

        public IEnumerable<Square> GetAvailableMoves(Board board)
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
                        && this.IsAvailable(currentSquare, newSquare)
                    )
                    {
                        availableMoves.Add(newSquare);
                    }
                }
            }
            return availableMoves;
        }

        public abstract bool IsAvailable(Square currentSquare, Square newSquare);

        public void MoveTo(Board board, Square newSquare)
        {
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
        }
    }
}
