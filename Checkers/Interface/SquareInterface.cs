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
        
        public Color colordDefault;
       
        public int row;                 
        public int col;
        public SquareInterface()
        {
            colordDefault = Color.AliceBlue;
        }


        public SquareInterface(Color defaultColor,int _row,int _col)
        {
            row = _row;
            col = _col;
            colordDefault = defaultColor;
            this.Location = new Point(col * 70 + 20, row * 70 + 20);
            this.Width = 70;
            this.Height = 70;

            this.BorderStyle = BorderStyle.Fixed3D;
            this.BringToFront();
            if(row % 2 == 1) 
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
        public void DrawPiece(Image pieceImage)
        {
            Image = pieceImage;
        }
    }



 }

