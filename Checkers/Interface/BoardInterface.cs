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
        public bool highlighted;
        public Point selectedSquareCoordinates ;
        public Square from;
         public Square to;
        public bool selected =false;
        public SquareInterface[,] boardSquare;
        public PictureBox squarePic;
         public Panel panel;
        Point LastSquareSelected;
        public  Point sourcePoint;
        public  Point destinationPoint;
        public Square sourcePoint1;
        public Square destinationPoint1;
        private ArrayList Squares;
        public ArrayList IM;
        public Form1 formMain;
        public string selectedSquare;
        public PieceImages checkersImages = new PieceImages();
        public  Board checkersBoard = new Board();
        
        public BoardInterface(Panel panel ,Form1 form)
        {
            this.formMain = form;
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
                         boardSquare.AllowDrop = true;
                         boardSquare.MouseClick += SquareClick;
                         boardSquare.DrawPiece(checkersImages.DrawPiece1(checkersBoard.square[r, c].piece));
                         boardSquare.MouseDown += SquareDown;
           

                }
            }
        
           // formMain.label1.Text = "It's black's turn";
       
     

        }
       private void SquareClick(object sender, MouseEventArgs e)
        {
          
            SquareInterface square = (SquareInterface)sender;
            
            PictureBox squarePictureBox = sender as PictureBox;

            int pictureBoxIndex = this.panel.Controls.IndexOf(squarePictureBox);
            Point coordinates = GetCoordinates(pictureBoxIndex);
             squarePic = squarePictureBox;
           
        }
        

        
        private void SquareDown(object sender, MouseEventArgs e)
        {
            

            PictureBox _square = sender as PictureBox;
            int pictureBoxIndex = this.panel.Controls.IndexOf(_square);
            Point coordinates = GetCoordinates(pictureBoxIndex);
            Square row = new Square(coordinates.X,coordinates.Y);
            row._row = coordinates.X;
            row._col = coordinates.Y;
           Console.WriteLine(checkersBoard.square[coordinates.X, coordinates.Y]._col);
            if (_square.Image != null )
            {
                selected = true;
                sourcePoint = coordinates;
                sourcePoint1 = new Square(sourcePoint.X, sourcePoint.Y);
                sourcePoint1._row = sourcePoint.X;
                sourcePoint1._col = sourcePoint.Y;

                foreach (SquareInterface boardSquare in Squares)
                {
                    boardSquare.highlight(true);
                    highlighted = true;
                }

            }
            if (LastSquareSelected == Point.Empty && _square.Image==null && selected==true)
            {
                
                destinationPoint = coordinates;
                LastSquareSelected = coordinates;
                destinationPoint1 = new Square(destinationPoint.X, destinationPoint.Y);
                destinationPoint1._row = destinationPoint.X;
                destinationPoint1._col = destinationPoint.Y;
                checkersBoard.TryMove(sourcePoint1,destinationPoint1);
               
                RefreshBoard();
            
                // formMain.label1 = checkersBoard.turnLabel ;
                selected = false;

                
            }
           

            LastSquareSelected = Point.Empty;
          
        }

        public void RefreshBoard()
        {
            foreach (SquareInterface boardSquare in Squares)
            {

                if (boardSquare.BackColor == Color.Empty)
                {

                    boardSquare.Draq(Color.AliceBlue);

                }

                if (boardSquare.BackColor != null )
                {
               
                    boardSquare.DrawPiece(checkersImages.DrawPiece1(checkersBoard.square[boardSquare.row,boardSquare.col].piece));
                 
                }
                

            }

         
        }

        private Point GetCoordinates(int index)

        {
            int x = index / 8;
            int y = index % 8;
            return new Point(x, y);
          
        }

       
    }
}
