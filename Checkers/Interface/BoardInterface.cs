using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checkers.Classes;

namespace Checkers.Interface
{
    public class BoardInterface
    {
        public static Image getI;
        public static Image setI;
        public SquareInterface[,] boardSquare;
        public Panel panel;
        public int selectedPiece = -1;
        public int selectedDestination = -1;
        private ArrayList Squares;
        public ArrayList IM;
        public string selectedSquare;
        public PieceImages checkersImages = new PieceImages();
         public  Board checkersBoard = new Board();
        public BoardInterface(Panel panel )
        {
            this.boardSquare = new SquareInterface[8, 8];
          
            this.panel = panel;
            Squares = new ArrayList();
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                   SquareInterface boardSquare = new SquareInterface(Color.White, r, c);

                    
                       
                         panel.Controls.Add(boardSquare);
                         Squares.Add(boardSquare);
                         boardSquare.Click += SquareClick;
                         boardSquare.DrawPiece(checkersImages.DrawPiece1(checkersBoard.square[r, c].piece));
                      
            

                }
            }
           



        }
        private void SquareClick(object sender, EventArgs e)
        {

            SquareInterface square = (SquareInterface)sender;
            PictureBox squarePictureBox = sender as PictureBox;
            int pictureBoxIndex = this.panel.Controls.IndexOf(squarePictureBox);
            Point coordinates = GetCoordinates(pictureBoxIndex);
            // Console.WriteLine(checkersBoard.square[coordinates.X,coordinates.Y].piece.);
            // Move move = checkersBoard.square[coordinates.X,coordinates.Y].piece.
           // int source =
           // int move = checkersBoard.rules.canMove(source,destination);
        }
      
        private Point GetCoordinates(int index)
        {
            int x = index / 8;
            int y = index % 8;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            return new Point(x, y);
          

        }

       
    }
}
