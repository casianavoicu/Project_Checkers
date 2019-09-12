using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Checkers.Classes
{

    public enum Team
    {
        Red =1,
        Black=2 
    }

    public class Piece
    {
        public Team team;
       
        public Image fi;
        public string f;
        public Image Image { get; protected set; }
        public Team Team { get; protected set; }
        public int row;
        public int type;
        public int column;
        public int Turn;
        public Piece()
        {

        }

        public  Piece(Point position)
        {
            
            row = position.X;
            column = position.Y;
            if (((row == 0 || row == 2) && (column % 2 == 1))|| ((row == 1) && (column % 2 == 0)))
            {
                Team = Team.Black;
                this.Turn = 1;

                Image = Image.FromFile(@"E:\\Checkers\\Checkers\\Checkers\\Pictures\\black60p.png");
                 

            }
            

            else if (((row == 5 || row == 7)&& (column % 2 == 0))|| ((row == 6)&& (column % 2 == 1)))
            {
                 
               
                    Image = Image.FromFile(@"E:\\Checkers\\Checkers\\Checkers\\Pictures\\red60p.png");
                        Team = Team.Red;
                    Turn = 2;
               
            }
            
            else
            {
                Image=null;
            }

          
        }
    }
}
