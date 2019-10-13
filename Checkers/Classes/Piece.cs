using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Checkers.Classes
{


    public class Piece
    {
        public enum PieceType
        {
            Empty, Checker, King
        };

        public Side team;
        public PieceType pieceType;
        public Piece()
        {
            this.pieceType = PieceType.Empty;
        }
        public Piece(PieceType type)
        {
            this.pieceType = type;
        }
        public Piece(Side side, PieceType type)
        {
            this.team = side;
            this.pieceType = type;
        }
        public bool Empty()
        {
            return pieceType == PieceType.Empty;
        }
        public bool Checker()
        {
            return pieceType == PieceType.Checker;
        }
        public bool King()
        {
            return pieceType == PieceType.King;
        }

        public Side Side
        {
            get { return team; }
            set { team = value; }
        }
        public PieceType PType
        {
            get { return pieceType; }
            set { pieceType = value; }
        }
    }
}
