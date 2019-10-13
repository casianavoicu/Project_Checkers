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
     
        public Referee referee;
        public Board board;
        public int result;
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

            if ((VerifyMove(move) == 2) || (VerifyMove(move) == 1))
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


            if (isNormal(move)==1)
            {

                return 1;
            }
            else if ((Math.Abs((move.End._row - move.Start._row)) == 2)
                && Math.Abs((move.End._col - move.Start._col)) == 2 &&
                ((board.square[(move.End._row + move.Start._row)/2 ,(move.End._col + move.Start._col)/2].piece.PType.Equals(Piece.PieceType.Checker)) 
               && (board.square[(move.End._row + move.Start._row) / 2, (move.End._col + move.Start._col) / 2].piece.Side.team) != board.square[move.Start._row, move.Start._col].piece.Side.team))
                {

                board.square[(move.End._row + move.Start._row) / 2, (move.End._col + move.Start._col) / 2].piece = new Piece(Piece.PieceType.Empty);
                return 2;
            }
            else
                return 3;


        }
        public int isNormal(Move move)

        {
            if ((move.End._row - move.Start._row) == 1 && Math.Abs(move.End._col - move.Start._col) == 1 &&
            board.square[move.Start._row, move.Start._col].piece.Side.isBlack())
            {
                return 1;
            }

           else if ((move.End._row - move.Start._row) == -1 && Math.Abs(move.End._col - move.Start._col) == 1 &&
            board.square[move.Start._row, move.Start._col].piece.Side.isRed())
            {
                return 1;
            }


            else
                return -1;
            
        }
        public int isJump(Move move)
        {
            if (move.End._row - move.Start._row == 2 &&
                  (move.End._col - move.Start._col) == 2 &&
                  board.square[move.Start._row, move.Start._col].piece.Side.isBlack() &&
                  //(board.square[(move.End._row + move.Start._row)/2, (move.End._col + move.Start._col)/2].piece.PType.Equals(Piece.PieceType.Checker)) 
                  board.square[(move.End._row + move.Start._row) / 2, (move.End._col + move.Start._col) / 2].piece.Side.team != board.square[move.Start._row, move.Start._col].piece.Side.team)

            {
                return 2;
            }
            else return -1;
        }

        public void ExecuteMove(Move move)
        {
            board.square[move.End._row, move.End._col].piece = board.square[move.Start._row, move.Start._col].piece;
            board.square[move.Start._row, move.Start._col].piece = new Piece(Piece.PieceType.Empty);
            
        }
    }
}
