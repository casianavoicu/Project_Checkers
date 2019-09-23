using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    public class Move
    {
        public Square startSquare;
        public Square endSquare;
        public Piece piece;
        private Piece currentPiece;
        public Move(Square from, Square to)
        {
            startSquare = from;
            endSquare = to;
            piece = from.piece;
            currentPiece = to.piece;
        }

        public Square Start
        {
            get
            {
                return startSquare;
            }
            set

            {
                startSquare = value;
            }

        }

        public Square End
        {

            get
            {
                return endSquare;
            }
            set
            {
                endSquare = value;
            }
        }
        public Piece Piece
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
            }
        }
        /*public bool doMove()
        {
            int x = Math.Abs(startSquare._row - endSquare._row);
            int y = Math.Abs(startSquare._col - endSquare._col);
           // return this.IsValid( board,);
        }
        public bool isValid(Board board,Square start,Square end)

        {
            return true;
        }*/
    }
}
