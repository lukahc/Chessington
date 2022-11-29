﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player) : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var availableMoves = new List<Square>
            {
                Square.At(currentSquare.Row + 2, currentSquare.Col + 1),
                Square.At(currentSquare.Row + 2, currentSquare.Col - 1),
                Square.At(currentSquare.Row + 1, currentSquare.Col + 2),
                Square.At(currentSquare.Row + 1, currentSquare.Col - 2),
                Square.At(currentSquare.Row - 2, currentSquare.Col + 1),
                Square.At(currentSquare.Row - 2, currentSquare.Col - 1),
                Square.At(currentSquare.Row - 1, currentSquare.Col + 2),
                Square.At(currentSquare.Row - 1, currentSquare.Col - 2)
            };
            return availableMoves
                .Where(move => board.SquareExists(move) && board.GetPiece(move) == null)
                .ToList();
        }
    }
}
