using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Classes;
using System.Windows.Forms;
using System.Drawing;

namespace Checkers.Interface
{
    public class PieceImages 
    {

        public Image Image { get; protected set; }

      
        public Image DrawPiece1(Piece Piece)
        {

            if (Piece == null || Piece.pieceType == Piece.PieceType.Empty)
            {


                return null;

            }

            else if (Piece.Side.isBlack())
            {
                if (Piece.pieceType == Piece.PieceType.Checker)
                {
                    Image = Image.FromFile(@"E:\\Checkers\\Checkers\\Checkers\\Pictures\\black60p.png");
                    return Image;
                }
            }
            else
            {
                if (Piece.pieceType == Piece.PieceType.Checker)
                {
                    Image = Image.FromFile(@"E:\\Checkers\\Checkers\\Checkers\\Pictures\\red60p.png");
                    return Image;
                }
            }
            return null;
        }
      
    }

}
