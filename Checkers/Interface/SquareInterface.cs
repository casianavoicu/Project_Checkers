using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Checkers.Interface
{

    public class SquareInterface : PictureBox
    {
        public bool highlighted;
        public int row;
        public int col;
        private  Color RED_COLOR = Color.LightSalmon;
        private  Color BLACK_COLOR = Color.Gray;
        private  Color HIGHLIGHT_COLOR = Color.AliceBlue;
        public Color DEFAULT_COLOR
        {
            get
            {
                if ((row + col) % 2 == 0)
                {
                    return RED_COLOR;
                }
                else
                {
                    return BLACK_COLOR;
                }
            }
        }
        public Color squareColor
        {
            get
            {
                if (highlighted)
                {
                    return HIGHLIGHT_COLOR;
                }
                else
                {
                    return DEFAULT_COLOR;
                }
            }
        }

        public SquareInterface( )
        {
         
        }

        public SquareInterface(int _row, int _col)
        {
            row = _row;
            col = _col;
            Draw();
        }

        public void Redraw(int _row, int _col)
        {
            row = _row;
            col = _col;
            Draw();
        }
        public void Draw()
        {
            this.Location = new Point(col * 80 + 25, row * 80 + 25);
            this.Width = 80;
            this.Height = 80;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BringToFront();
            this.BackColor = squareColor;
        }

        public void DrawPiece(Image pieceImage)
        {   
            Image = pieceImage;
         
        }


    }

}