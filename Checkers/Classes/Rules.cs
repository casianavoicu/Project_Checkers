using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers.Classes
{
    public class Rules
    {
        public Board board;
        public Rules(Board board2)
        {
            board = board2;
        }
        public Board Board
        {
            get { return board; }

        }
       
        public int DoMove(Move move)
        {
            //verifyMove
            //set the type of move
            if (VerifyMove(move) == 2)
            {
                ExecuteMove(move);
                return 0;
            }
            else
            {
                   return -1;
            }
        }

        public int VerifyMove(Move move)
        {
          
            if ((Math.Abs((move.End._row - move.Start._row)) == 1) && Math.Abs((move.End._col - move.Start._col)) == 1)
            {
                return 1;
            }
            else if ((Math.Abs((move.End._row - move.Start._row)) == 2) && Math.Abs((move.End._col - move.Start._col)) == 2 && (board.square[move.End._row - 1, move.End._col - 1].piece.PType.Equals(Piece.PieceType.Checker)))
            {
              
                return 2;
            }
            else
                return 3;
           

        }

       

        public void ExecuteMove(Move move)
        {
            board.square[move.End._row, move.End._col].piece = board.square[move.Start._row, move.Start._col].piece;
            board.square[move.Start._row, move.Start._col].piece = new Piece(Piece.PieceType.Empty);


        }
    }
}
