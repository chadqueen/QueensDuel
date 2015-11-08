using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace QueensDuel.GameBoard.Tests
{
    [TestClass]
    public class PieceTests
    {
        [TestMethod]
        public void Stores_Current_Position_And_Color()
        {
            // arrange
            var piece1Row = 3;
            var piece1Column = 4;

            // act
            var piece = new Piece(piece1Row, piece1Column, PieceColor.Green);

            // assert
            Assert.AreEqual(piece1Row, piece.Row);
            Assert.AreEqual(piece1Column, piece.Column);
            Assert.AreEqual(PieceColor.Green, piece.Color);
        }

        [TestMethod]
        public void Can_Set_Position()
        {
            // arrange
            var piece1Row = 3;
            var piece1Column = 4;
            var piece = new Piece(piece1Row, piece1Column, PieceColor.Green);

            // act
            piece.SetPosition(1, 2);
            var finalRow = piece.Row;
            var finalColumn = piece.Column;

            // assert
            Assert.AreEqual(1, finalRow);
            Assert.AreEqual(2, finalColumn);
        }
    }
}
