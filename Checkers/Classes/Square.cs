using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Checkers.Classes
{
   public class Square: PictureBox 
    {
        
        public Color clrDefault;          // The default color of the square
        public bool selected = false;     // If the square is selected
        public bool possibleMove = false; // If the square is a possible move for a piece
        public Piece currentPiece ; // The current piece on the square
        public int row;                   // Square's row
        public int col;                   // Square's column
        public string location;           // a1 - h8
       
        public Square()
        {
            // clrDefault = Color.Brown;
            currentPiece = null;
        }
        public Square(Piece currentPiece)
        {
            this.currentPiece = currentPiece;
        }


        public Square(Color defaultColor, int _row, int _col)
        {
            
            clrDefault = defaultColor;
            row = _row;
            col = _col;
           
            this.Location = new Point(col * 70 + 20, row * 70 + 20);
            this.Width = 70;
            this.Height = 70;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BringToFront();

            if (row % 2 == 1) //
            {
                if (col % 2 == 0)
                {
                 this.BackColor = Color.Gray;
                   
                }
                else
                   this.BackColor = Color.LightSalmon;
            }
            else
            {
                if (col % 2 == 0)
                {
                   this.BackColor = Color.LightSalmon;
                }
                else
                    this.BackColor = Color.Gray;
            }
            

            
        }



    }
}
