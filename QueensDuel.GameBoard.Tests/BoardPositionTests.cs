using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace QueensDuel.GameBoard.Tests
{
    [TestClass]
    public class BoardPositionTests
    {
        [TestMethod]
        public void Sets_Row_And_Column_Only_On_Instantiation()
        {
            // arrange
            var positionRow = 3;
            var positionColumn = 4;

            // act
            var boardPosition = new BoardPosition(positionRow, positionColumn);

            // assert
            Assert.AreEqual(positionRow, boardPosition.Row);
            Assert.AreEqual(positionColumn, boardPosition.Column);
        }

        [TestMethod]
        public void Sets_Row_And_Column_And_Piece_On_Instantiation()
        {
            // arrange
            var positionRow = 3;
            var positionColumn = 4;
            var piece = new Piece(3, 4, PieceColor.Orange);

            // act
            var boardPosition = new BoardPosition(positionRow, positionColumn, piece);

            // assert
            Assert.AreEqual(positionRow, boardPosition.Piece.Row);
            Assert.AreEqual(positionColumn, boardPosition.Column);
        }

        [TestMethod]
        public void Sets_Row_And_Column_For_Piece_When_Set_To_Position()
        {
            // arrange
            var piece = new Piece(3, 4, PieceColor.Orange);

            // act
            var boardPosition = new BoardPosition(1, 1, piece);
            var firstPieceRow = boardPosition.Piece.Row;
            var firstPieceColumn = boardPosition.Piece.Column;
            boardPosition.SetPiece(new Piece(5, 6, PieceColor.Green));

            // assert
            Assert.AreEqual(1, boardPosition.Row);
            Assert.AreEqual(1, boardPosition.Column);
            Assert.AreEqual(1, firstPieceRow);
            Assert.AreEqual(1, firstPieceColumn);
            Assert.AreEqual(1, boardPosition.Piece.Row);
            Assert.AreEqual(1, boardPosition.Piece.Column);
        }

        [TestMethod]
        public void Verifies_If_Board_Position_Is_Occupied_By_Piece()
        {
            // arrange
            var boardPositionWithPiece = new BoardPosition(1, 1, new Piece(2, 3, PieceColor.Green));
            var boardPositionWithoutPiece = new BoardPosition(1, 1);

            // act

            // assert
            Assert.IsTrue(boardPositionWithPiece.ContainsPiece());
            Assert.IsFalse(boardPositionWithoutPiece.ContainsPiece());
        }

        [TestMethod]
        public void Can_Clear_Piece_From_Position()
        {
            // arrange
            var boardPosition = new BoardPosition(1, 1, new Piece(2, 3, PieceColor.Green));

            // act
            boardPosition.ClearPieceFromPosition();

            // assert
            Assert.IsFalse(boardPosition.ContainsPiece());
        }
    }
}
