namespace QueensDuel.GameBoard
{
    public class GameManager
    {
        public Board Board { get; set; }

        public GameManager()
        {
            this.Board = new Board();
        }
    }
}
