using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace QueensDuel.GameBoard.Tests
{
    [TestClass]
    public class GameManagerTests
    {
        [TestMethod]
        public void Should_Build_The_Board_Assets_On_Instantiation()
        {
            // arrange

            // act
            var gameManager = new GameManager();

            // assert
            Assert.IsNotNull(gameManager.Board);
        }

        [TestMethod]
        public void Sets_Orange_As_The_First_Turn_Move_Color()
        {
            // arrange

            // act
            var gameManager = new GameManager();

            // assert
            Assert.AreEqual(PieceColor.Orange, gameManager.CurrentTurnColor);
        }

        [TestMethod]
        public void Keeps_A_Log_Of_Moves_For_The_Game_Defaulting_To_Empty_List()
        {
            // arrange

            // act
            var gameManager = new GameManager();

            // assert
            Assert.AreEqual(0, gameManager.GetMoveLog().Count);
        }
    }
}
