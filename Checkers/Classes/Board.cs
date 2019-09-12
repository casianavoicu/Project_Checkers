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
        public Square[,] squares;
        public Square[,] board = new Square[8, 8];
        public Board()
        {
            squares = new Square[8, 8];
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    squares[r, c] = new Square();

                }
            }
        }

        public List<Point> VerifyMoves(Point positionSource,Point destinationSource)
        {
            Piece movePiece = squares[positionSource.X,positionSource.Y].currentPiece;
            List<Point> checkers = new List<Point>();
            if ((Math.Abs(destinationSource.X - positionSource.X) == 2) && (Math.Abs(destinationSource.Y - positionSource.Y) == 2))
            {
                //check for RedPlayer...

                /* code for testing if th turn is red or kingPiece*/ 
                if (((destinationSource.X-positionSource.X)==-2) && ((destinationSource.Y - positionSource.Y)==2))//up right
                {
                    //test if it's a jump-calling a JumpMethod
                }
                if (((destinationSource.X - positionSource.X) == -2) && ((destinationSource.Y - positionSource.Y) == -2))//up right
                {
                    //test if it's a jump-calling a JumpMethod
                }

                //end of redPlayer

                //check for Black...

                /* code for testing if th turn is black*/
                if (((destinationSource.X - positionSource.X) == 2) && ((destinationSource.Y - positionSource.Y) == 2))//down right
                {
                    //test if it's a jump-calling a JumpMethod
                }
                if (((destinationSource.X - positionSource.X) == 2) && ((destinationSource.Y - positionSource.Y) == -2))//down right
                {
                    //test if it's a jump-calling a JumpMethod
                }

                //end of redPlayer
            }
            return checkers;
        }

    }
}