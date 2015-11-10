using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensDuel.GameBoard.Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void Sets_Up_Positions_On_Instantiation()
        {
            // arrange

            // act
            var gameBoard = new Board();

            // assert
            Assert.AreEqual(64, gameBoard.Positions.Length);
            Assert.AreEqual(3, gameBoard.Positions[0, 2].BoardIndex);
            Assert.AreEqual(25, gameBoard.Positions[4, 4].BoardIndex);
            Assert.AreEqual(64, gameBoard.Positions[7, 7].BoardIndex);
        }

        [TestMethod]
        public void Configures_Initial_Piece_Configuration()
        {
            // arrange

            // act
            var gameBoard = new Board();

            // assert
            // first row
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[0, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[0, 1].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[0, 2].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[0, 3].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[0, 4].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[0, 5].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[0, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[0, 7].Piece.Color);
            // second row
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[1, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[1, 1].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[1, 2].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[1, 3].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[1, 4].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[1, 5].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[1, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[1, 7].Piece.Color);
            // third row
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[2, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[2, 1].Piece.Color);
            Assert.IsFalse(gameBoard.Positions[2, 2].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[2, 3].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[2, 4].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[2, 5].ContainsPiece());
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[2, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[2, 7].Piece.Color);
            // fourth row
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[3, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[3, 1].Piece.Color);
            Assert.IsFalse(gameBoard.Positions[3, 2].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[3, 3].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[3, 4].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[3, 5].ContainsPiece());
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[3, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[3, 7].Piece.Color);
            // fifth row
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[4, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[4, 1].Piece.Color);
            Assert.IsFalse(gameBoard.Positions[4, 2].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[4, 3].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[4, 4].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[4, 5].ContainsPiece());
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[4, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[4, 7].Piece.Color);
            // sixth row
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[5, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[5, 1].Piece.Color);
            Assert.IsFalse(gameBoard.Positions[5, 2].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[5, 3].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[5, 4].ContainsPiece());
            Assert.IsFalse(gameBoard.Positions[5, 5].ContainsPiece());
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[5, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[5, 7].Piece.Color);
            // seventh row
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[6, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[6, 1].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[6, 2].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[6, 3].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[6, 4].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[6, 5].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[6, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[6, 7].Piece.Color);
            // eighth row
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[7, 0].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[7, 1].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[7, 2].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[7, 3].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[7, 4].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[7, 5].Piece.Color);
            Assert.AreEqual(PieceColor.Orange, gameBoard.Positions[7, 6].Piece.Color);
            Assert.AreEqual(PieceColor.Green, gameBoard.Positions[7, 7].Piece.Color);
        }

        [TestMethod]
        public void Verifies_Board_Position_Is_In_Battle_Square()
        {
            // arrange
            
            // act

            // assert
            Assert.IsTrue(Board.IsPositionInBattleSquare(new BoardPosition(5, 6)));
            // left of the square
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(3, 1)));
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(6, 2)));
            // right of the square
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(2, 7)));
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(4, 8)));
            // above the square
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(1, 3)));
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(2, 5)));
            // below the square
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(7, 4)));
            Assert.IsFalse(Board.IsPositionInBattleSquare(new BoardPosition(8, 6)));
        }

        [TestMethod]
        public void Verifies_If_Piece_Color_Has_Pieces_In_BattleSquare()
        {
            // arrange
            var board = new Board();

            // act
            var orangeHasPiecesInBattleSquareOnInitialization = board.ColorHasPiecesInBattleSquare(PieceColor.Orange);
            var greenHasPiecesInBattleSquareOnInitialization = board.ColorHasPiecesInBattleSquare(PieceColor.Green);

            // assert
            Assert.IsFalse(orangeHasPiecesInBattleSquareOnInitialization);
            Assert.IsFalse(greenHasPiecesInBattleSquareOnInitialization);
        }

        [TestMethod]
        public void Counts_Number_Of_Pieces_A_Piece_Color_Has_In_BattleSquare()
        {
            // arrange
            var board = new Board();

            // act
            var orangePieceCountInBattleSquareOnInitialization = board.CountColorPiecesInBattleSquare(PieceColor.Orange);
            var greenPieceCountInBattleSquareOnInitialization = board.CountColorPiecesInBattleSquare(PieceColor.Green);

            // assert
            Assert.AreEqual(0, orangePieceCountInBattleSquareOnInitialization);
            Assert.AreEqual(0, greenPieceCountInBattleSquareOnInitialization);
        }
    }
}
