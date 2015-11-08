using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;

namespace QueensDuel.GameBoard.Tests
{
    [TestClass]
    public class MoveTests
    {
        [TestMethod]
        public void Requires_Piece_Color_Initial_Position_And_Ending_Position_On_Instantiation()
        {
            // arrange
            var pieceColor = PieceColor.Orange;
            var initialPosition = new BoardPosition(1, 1);
            var endingPosition = new BoardPosition(1, 2);

            // act
            var move = new Move(pieceColor, initialPosition, endingPosition);

            // assert
            Assert.AreEqual(pieceColor, move.PieceColor);
            Assert.AreEqual(initialPosition, move.GetInitialPosition());
            Assert.AreEqual(endingPosition, move.GetEndingPosition());
        }

        [TestMethod]
        public void Rejects_Instantiation_If_Either_Position_Has_A_Piece_Assigned()
        {
            // arrange
            var pieceColor = PieceColor.Orange;
            var initialPosition = new BoardPosition(1, 1);
            var endingPosition = new BoardPosition(1, 2);
            var invalidInitialPosition = new BoardPosition(1, 1, new Piece(0, 0, PieceColor.Orange));
            var invalidEndingPosition = new BoardPosition(1, 2, new Piece(0, 0, PieceColor.Orange));

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => new Move(pieceColor, invalidInitialPosition, endingPosition));
            Assert.ThrowsException<ArgumentException>(() => new Move(pieceColor, initialPosition, invalidEndingPosition));
        }

        [TestMethod]
        public void Saves_If_Piece_Was_Jumped_Defaulting_To_False()
        {
            // arrange
            var pieceColor = PieceColor.Orange;
            var initialPosition = new BoardPosition(1, 1);
            var slideEndingPosition = new BoardPosition(1, 2);
            var jumpEndingPosition = new BoardPosition(1, 3);

            // act
            var moveWithDefaultJumpState = new Move(pieceColor, initialPosition, slideEndingPosition);
            var moveWithDefinedJumpStateTrue = new Move(pieceColor, initialPosition, jumpEndingPosition, true);
            var moveWithDefinedJumpStateFalse = new Move(pieceColor, initialPosition, slideEndingPosition, false);

            // assert
            Assert.IsFalse(moveWithDefaultJumpState.PieceJumped);
            Assert.IsFalse(moveWithDefinedJumpStateFalse.PieceJumped);
            Assert.IsTrue(moveWithDefinedJumpStateTrue.PieceJumped);
        }

        [TestMethod]
        public void Saves_If_Piece_Was_Captured_During_Jump_Defaulting_To_False()
        {
            // arrange
            var pieceColor = PieceColor.Orange;
            var initialPosition = new BoardPosition(1, 1);
            var endingPosition = new BoardPosition(1, 3);

            // act
            var jumpMoveWithCapturedPiece = new Move(pieceColor, initialPosition, endingPosition, true, true);
            var jumpMoveWithoutCapturedPiece = new Move(pieceColor, initialPosition, endingPosition, true, false);
            var jumpMoveWithDefaultCapturedPieceState = new Move(pieceColor, initialPosition, endingPosition, true);

            // assert
            Assert.IsTrue(jumpMoveWithCapturedPiece.PieceCaptured);
            Assert.IsFalse(jumpMoveWithoutCapturedPiece.PieceCaptured);
            Assert.IsFalse(jumpMoveWithDefaultCapturedPieceState.PieceCaptured);
        }

        [TestMethod]
        public void True_Captured_Piece_State_Requires_True_Jump_State()
        {
            // arrange
            var pieceColor = PieceColor.Orange;
            var initialPosition = new BoardPosition(1, 1);
            var endingPosition = new BoardPosition(1, 2);

            // act

            // assert
            Assert.ThrowsException<ArgumentException>(() => new Move(pieceColor, initialPosition, endingPosition, false, true));
        }

        [TestMethod]
        public void Validates_A_NonJump_Move_Is_A_Valid_One_Space_Move()
        {
            // arrange

            // act

            // assert
            // test for moving out of bounds of the board
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(1, 1), new BoardPosition(0, 1)));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(1, 1), new BoardPosition(1, 0)));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(8, 9)));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(9, 8)));

            // test for diagonal move request
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(1, 1), new BoardPosition(2, 2)));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(5, 5), new BoardPosition(6, 4)));

            // test for multispace nonjump slide
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(6, 8)));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(8, 6)));
        }

        [TestMethod]
        public void Validates_A_Jump_Move_Is_A_Valid_Two_Space_Move()
        {
            // arrange

            // act

            // assert
            // test for moving out of bounds of the board
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(1, 2), new BoardPosition(0, 2), true));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(2, 1), new BoardPosition(2, 0), true));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(7, 7), new BoardPosition(7, 9), true));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(7, 7), new BoardPosition(9, 7), true));

            // test for diagonal move request
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(1, 1), new BoardPosition(3, 3), true));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(5, 5), new BoardPosition(7, 3), true));

            // test for multispace jump
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(5, 8), true));
            Assert.ThrowsException<ArgumentException>(() => new Move(PieceColor.Green, new BoardPosition(8, 8), new BoardPosition(8, 5), true));
        }
    }
}
