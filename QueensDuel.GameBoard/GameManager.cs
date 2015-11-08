using System.Collections.Generic;

namespace QueensDuel.GameBoard
{
    public class GameManager
    {
        private const PieceColor startingColor = PieceColor.Orange;

        private List<Move> MoveLog;

        public PieceColor CurrentTurnColor { get; private set; }

        public Board Board { get; set; }

        public GameManager()
        {
            this.Board = new Board();
            this.CurrentTurnColor = startingColor;
            this.MoveLog = new List<Move>();
        }

        public List<Move> GetMoveLog()
        {
            return this.MoveLog;
        }
    }
}
