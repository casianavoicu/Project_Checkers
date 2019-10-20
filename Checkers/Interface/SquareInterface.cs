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
        private static PictureBox draggedImage;    // Image being dragged
        private static PictureBox beforeImage;

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
            this.Location = new Point(col * 80 + 30, row * 80 + 30);
            this.Width = 80;
            this.Height = 80;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BringToFront();
          
            if (row % 2 == 1) 
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
        public void Draq(Color defaultColor)
        {
         
            colordDefault = defaultColor;
            this.Location = new Point(col * 80 + 30, row * 80 + 30);
            this.Width = 80;
            this.Height = 80;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BringToFront();

            if (row % 2 == 1)
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
        public void highlight(bool state)
        {
            if (state)
            {
                this.BackColor =Color.Empty;
            }
            



        }
        

    

    }



}

