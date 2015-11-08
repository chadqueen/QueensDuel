namespace QueensDuel.GameBoard
{
    public class BoardPosition
    {
        public int Row { get; private set; }

        public int Column { get; private set; }

        public Piece Piece { get; private set; }

        public int BoardIndex { get { return Row * Column; } }

        /// <summary>
        /// Storage class for row and column, does not restric the value of the input,
        /// expects consuming class to validate appropriate row/column value
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public BoardPosition(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            this.Piece = null;
        }

        /// <summary>
        /// Storage class for row and column, does not restric the value of the input,
        /// expects consuming class to validate appropriate row/column value
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="piece"></param>
        public BoardPosition(int row, int column, Piece piece)
        {
            this.Row = row;
            this.Column = column;
            this.Piece = piece;
            this.Piece.SetPosition(this.Row, this.Column);
        }

        public void ClearPieceFromPosition()
        {
            this.Piece = null;
        }

        public bool ContainsPiece()
        {
            return this.Piece != null;
        }

        public void SetPiece(Piece piece)
        {
            this.Piece = piece;
            this.Piece.SetPosition(this.Row, this.Column);
        }
    }
}
