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
        public int row;
        public int col;

        public Square()
        {
            row = 0;
            col = 0;
        }
        public Square(int _row, int _col)
        {
            row = _row;
            col = _col;
        }
         public bool isRed
         {
            get
            {
                return ((row + col) % 2 == 0);
            }
         }
       public int _row
        {
            get { return row; }
            set { row = value; }
        }
        public int _col
        {
            get { return col; }
            set { col = value; }
        }
    }
}
