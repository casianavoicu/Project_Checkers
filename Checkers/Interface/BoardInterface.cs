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
        public bool selected =false;
        public SquareInterface[,] boardSquare;
        public PictureBox squarePic;
        public Panel panel;
        Point LastSquareSelected;
        Point LastSelectedSource;
        public  Point sourcePointTemp;
        public  Point destinationPointTemp;
        public Square sourcePoint;
        public Square destinationPoint;
        private ArrayList Squares;
        public Game formMain;
        public string selectedSquare;
        public PieceImages checkersImages = new PieceImages();
        public  Board checkersBoard = new Board();
        
        public BoardInterface(Panel panel ,Game form)
        {
            this.formMain = form;
            this.boardSquare = new SquareInterface[8, 8];
          
            this.panel = panel;
           
            Squares = new ArrayList();
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                   SquareInterface boardSquare = new SquareInterface();

                         boardSquare.Redraw(r,c);              
                         panel.Controls.Add(boardSquare);
                         Squares.Add(boardSquare);
                         boardSquare.DrawPiece(checkersImages.DrawPiece1(checkersBoard.square[r, c].piece));
                         boardSquare.MouseDown += SquareDown;
           
                }
            }
        
           formMain.label1.Text = "Black's Turn";

        }

        
        private void SquareDown(object sender, MouseEventArgs e)
        {
            highlighted = false;
            RefreshBoard();

            PictureBox _square = sender as PictureBox;
            int pictureBoxIndex = this.panel.Controls.IndexOf(_square);
            Point coordinates = GetCoordinates(pictureBoxIndex);
       
            if (_square.Image != null)
            {
                selected = true;
                sourcePointTemp = coordinates;
                sourcePoint = new Square(sourcePointTemp.X, sourcePointTemp.Y);
                sourcePoint.squareRow = sourcePointTemp.X;
                sourcePoint.squareCol = sourcePointTemp.Y;
                highlighted = true;
                LastSelectedSource.X = sourcePoint.squareRow;
                LastSelectedSource.Y = sourcePoint.squareCol;
                RefreshBoard();
          

            }
            if (LastSquareSelected == Point.Empty && _square.Image==null && selected==true)
            {
                highlighted = false;
               
                destinationPointTemp = coordinates;
                LastSquareSelected = coordinates;
                destinationPoint = new Square(destinationPointTemp.X, destinationPointTemp.Y);
                destinationPoint.squareRow = destinationPointTemp.X;
                destinationPoint.squareCol = destinationPointTemp.Y;
                checkersBoard.TryMove(sourcePoint,destinationPoint);

                RefreshBoard();
                
                int writeLabelTurnText = checkersBoard.referee.Turn;

                if (writeLabelTurnText == 1)
                {
                    formMain.label1.Text = "Red's Turn";
                    formMain.label1.ForeColor = Color.Red; 
                }
                else

                {
                    formMain.label1.Text = "Black's Turn";
                    formMain.label1.ForeColor = Color.Black;
                }
                selected = false;

                
            }
       
            LastSelectedSource = Point.Empty;
            LastSquareSelected = Point.Empty;
        
        }

        public void RefreshBoard()
        {
            foreach (SquareInterface boardSquare in Squares)
            {

                if (LastSelectedSource != Point.Empty)
                {
                    ArrayList moves =  checkersBoard.GetMoves(LastSelectedSource.X, LastSelectedSource.Y);


                 if (highlighted)
                    {
                        foreach (Square sq in moves)
                        {
                          if((sq.squareRow == boardSquare.row )&& (sq.squareCol == boardSquare.col))
                            
                            {
                                boardSquare.highlighted = true;
                                boardSquare.BackColor = boardSquare.squareColor;
                            }
                        }
                      
                    }
                }
             
                if (boardSquare.BackColor == boardSquare.squareColor && !highlighted)
                {
                    boardSquare.highlighted = false;
                    boardSquare.BackColor = boardSquare.DEFAULT_COLOR;
                    boardSquare.DrawPiece(checkersImages.DrawPiece1(checkersBoard.square[boardSquare.row, boardSquare.col].piece));
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
