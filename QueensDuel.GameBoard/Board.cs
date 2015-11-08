namespace QueensDuel.GameBoard
{
    public class Board
    {
        private const int columnCount = 8;

        private const int rowCount = 8;

        private const int outerBoarderSquareCount = 2;

        public BoardPosition[,] Positions { get; set; }

        public Board()
        {
            this.Positions = new BoardPosition[columnCount, rowCount];
            for (int row = 1; row <= rowCount; row++)
            {
                for (int column = 1; column <= columnCount; column++)
                {
                    var boardPosition = new BoardPosition(row, column);
                    
                    // assign a piece to the position if it is not in the battle square
                    if (!IsPositionInBattleSquare(boardPosition))
                    {
                        var pieceColor = (row % 2 == 0 && column % 2 == 0 || row % 2 != 0 && column % 2 != 0) ? PieceColor.Green : PieceColor.Orange;
                        boardPosition.SetPiece(new Piece(0, 0, pieceColor));
                    }

                    this.Positions[row - 1, column - 1] = boardPosition;
                }
            }
        }

        public static bool IsPositionInBattleSquare(BoardPosition boardPosition)
        {
            if (boardPosition.Row >= outerBoarderSquareCount + 1 && boardPosition.Row <= rowCount - outerBoarderSquareCount)
            {
                if (boardPosition.Column >= outerBoarderSquareCount + 1 && boardPosition.Column <= columnCount - outerBoarderSquareCount)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
