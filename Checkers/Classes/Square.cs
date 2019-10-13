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

        public Square(int _row, int _col)
        {
            row = _row;
            col = _col;
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
