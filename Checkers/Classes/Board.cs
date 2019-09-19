using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Checkers.Properties;

namespace Checkers.Classes
{
    public class Board
    {
       // public Piece piece;
        public Side red, black;
        public Square [,]square = new Square[8,8];
        public Rules rules;
        public Board()
        {
            red = new Side(Side.Team.Red);
            black = new Side(Side.Team.Black);
            Draw();
            rules = new Rules(this);
           // square = new Square();
        }
        public void Draw()
        {
            int col;
            square = new Square[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (col = 0; col < 8; col++)
                {
                    square[row, col] = new Square(row, col);
                    if (((row == 0 || row == 2) && (col % 2 == 1)) || ((row == 1) && (col % 2 == 0)))
                    {
                        square[row, col].piece = new Piece(black, Piece.PieceType.Checker);
                    }
                    if (((row == 5 || row == 7) && (col % 2 == 0)) || ((row == 6) && (col % 2 == 1)))
                    {
                        square[row, col].piece = new Piece(red, Piece.PieceType.Checker);
                    }
                }
              
            }   
        }
        public Square this[int row, int col]
        {
            get { return square[row, col]; }
        }
       
    }
}