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

        public static List<Square> GetLine(
            Board board,
            Square currentSquare,
            int rowIterator,
            int colIterator
        )
        {
            var availableMoves = new List<Square>();
            Square square = Square.At(
                currentSquare.Row + rowIterator,
                currentSquare.Col + colIterator
            );
            while (board.SquareExists(square) && board.GetPiece(square) == null)
            {
                availableMoves.Add(square);
                square = Square.At(square.Row + rowIterator, square.Col + colIterator);
                Console.WriteLine(square.Row);
                Console.WriteLine(square.Col);
                Console.WriteLine(board.SquareExists(square));
            }
            return availableMoves;
        }
    }
}
