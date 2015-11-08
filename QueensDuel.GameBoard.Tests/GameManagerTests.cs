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
    }
}
