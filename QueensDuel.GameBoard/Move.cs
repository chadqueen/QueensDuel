using System;

namespace QueensDuel.GameBoard
{
    public class Move
    {
        public PieceColor PieceColor { get; private set; }

        public bool PieceJumped { get; private set; }

        public bool PieceCaptured { get; private set; }

        private BoardPosition InitialPosition;

        private BoardPosition EndingPosition;

        public Move(PieceColor color, BoardPosition initialPosition, BoardPosition endingPosition, bool pieceJumped = false, bool pieceCaptured = false)
        {
            if (initialPosition.ContainsPiece())
            {
                throw new ArgumentException("Move initial posiiton must not contain a piece");
            }

            if (endingPosition.ContainsPiece())
            {
                throw new ArgumentException("Move ending posiiton must not contain a piece");
            }

            if (pieceCaptured && !pieceJumped)
            {
                throw new ArgumentException("Capture moves are required to be configured as a jump move");
            }

            if (!ValidateMove(initialPosition, endingPosition, pieceJumped, pieceCaptured))
            {
                throw new ArgumentException("Invalid move requested");
            }

            this.PieceColor = color;
            this.PieceJumped = pieceJumped;
            this.PieceCaptured = pieceCaptured;
            this.InitialPosition = initialPosition;
            this.EndingPosition = endingPosition;
        }

        public BoardPosition GetInitialPosition()
        {
            return this.InitialPosition;
        }

        public BoardPosition GetEndingPosition()
        {
            return this.EndingPosition;
        }

        public static bool ValidateMove(BoardPosition initialPosition, BoardPosition endingPosition, bool pieceJumped = false, bool pieceCaptured = false)
        {
            // make sure the end position is within the valid board
            if ((endingPosition.Row <= 8 && endingPosition.Row >= 1) && (endingPosition.Column <= 8 && endingPosition.Column >= 1))
            {
                // make sure the move is either on the same row or same column, diagonal moves not allowed
                if (!(initialPosition.Row != endingPosition.Row && initialPosition.Column != endingPosition.Column))
                {
                    // test for slide moves versus jump moves
                    if (pieceJumped)
                    {
                        // jump move
                        if (Math.Abs(initialPosition.Row - endingPosition.Row) == 2 || Math.Abs(initialPosition.Column - endingPosition.Column) == 2)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        // slide move
                        if (Math.Abs(initialPosition.Row - endingPosition.Row) == 1 || Math.Abs(initialPosition.Column - endingPosition.Column) == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            

            return false;
        }
    }
}
