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

        public abstract IEnumerable<Square> GetAvailableMoves(Board board);

        public void MoveTo(Board board, Square newSquare)
        {
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
        }

        public List<Square> GetLine(
            Board board,
            Square currentSquare,
            int rowIterator,
            int colIterator
        )
        {
            var availableMoves = new List<Square>();
            var square = Square.At(
                currentSquare.Row + rowIterator,
                currentSquare.Col + colIterator
            );
            while (
                board.SquareExists(square)
                && (board.GetPiece(square) == null || board.GetPiece(square).Player != this.Player)
            )
            {
                availableMoves.Add(square);
                if (board.GetPiece(square) != null)
                {
                    break;
                }
                square = Square.At(square.Row + rowIterator, square.Col + colIterator);
            }
            return availableMoves;
        }
    }
}
