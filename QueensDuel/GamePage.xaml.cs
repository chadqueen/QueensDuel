using QueensDuel.GameBoard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace QueensDuel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        private GameManager gameManager;

        public GamePage()
        {
            this.InitializeComponent();
            gameManager = new GameManager();
            RenderGamePieces();
        }

        private void RenderGamePieces()
        {
            foreach(var position in this.gameManager.Board.Positions)
            {
                if (position.ContainsPiece())
                {
                    if (position.Piece.Color == PieceColor.Green)
                    {
                        var standardGreenPiece = new StandardGreenPiece();
                        Canvas.SetLeft(standardGreenPiece, position.Piece.Column * 60);
                        Canvas.SetTop(standardGreenPiece, position.Piece.Row * 60);
                        Canvas.SetZIndex(standardGreenPiece, 1);
                        GameBoardCanvas.Children.Add(standardGreenPiece);
                    }

                    if (position.Piece.Color == PieceColor.Orange)
                    {
                        var standardOrangePiece = new StandardOrangePiece();
                        Canvas.SetLeft(standardOrangePiece, position.Piece.Column * 60);
                        Canvas.SetTop(standardOrangePiece, position.Piece.Row * 60);
                        Canvas.SetZIndex(standardOrangePiece, 1);
                        GameBoardCanvas.Children.Add(standardOrangePiece);
                    }
                }
            }
        }
    }
}
