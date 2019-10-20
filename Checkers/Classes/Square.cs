using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Checkers.Classes
{
    public class Square
    {
        public Piece piece;
        private int row;
        private int col;

        public Square(int squareRow, int squareCol)
        {
            row = squareRow;
            col = squareCol;
        }
       
        public int squareRow
        {
            get { return row; }
            set { row = value; }
        }
        public int squareCol
        {
            get { return col; }
            set { col = value; }
        }
           
    }
}
