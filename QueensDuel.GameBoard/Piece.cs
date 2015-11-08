namespace QueensDuel.GameBoard
{
    public enum PieceColor
    {
        Orange,
        Green
    }

    public class Piece
    {
        public int Row { get; private set; }

        public int Column { get; private set; }

        /// <summary>
        /// Private set variable storing the color of the piece. Cannot be changed after instantiation
        /// </summary>
        public PieceColor Color { get; private set; }

        public Piece(int row, int column, PieceColor color)
        {
            this.Color = color;
            this.SetPosition(row, column);
        }

        /// <summary>
        /// Sets row and column directly without any logic. Does not perform any restrictions,
        /// expecting the consuming function to validate the row and column values
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void SetPosition(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
