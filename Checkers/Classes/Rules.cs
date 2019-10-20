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
        public static int scoreBlack= 0 ;
        public static int scoreRed = 0;
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

            else if(isJump(move)==1)
                
                {

                board.square[(move.End.squareRow + move.Start.squareRow) / 2, (move.End.squareCol + move.Start.squareCol) / 2].piece = new Piece(Piece.PieceType.Empty);
                return 2;
            }
            else
                return 3;


        }
        public int isNormal(Move move)

        {
            if ((move.End.squareRow - move.Start.squareRow) == 1 && Math.Abs(move.End.squareCol - move.Start.squareCol) == 1 &&
            board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.isBlack())
            {
                return 1;
            }

           else if ((move.End.squareRow - move.Start.squareRow) == -1 && Math.Abs(move.End.squareCol - move.Start.squareCol) == 1 &&
            board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.isRed())
            {
                return 1;
            }


            else
                return -1;
            
        }
        public int isJump(Move move)
        {
            if (((move.End.squareRow - move.Start.squareRow) == 2) && (board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.isBlack())
                && Math.Abs((move.End.squareCol - move.Start.squareCol)) == 2 &&
                ((board.square[(move.End.squareRow + move.Start.squareRow) / 2, (move.End.squareCol + move.Start.squareCol) / 2].piece.PType.Equals(Piece.PieceType.Checker))
               && (board.square[(move.End.squareRow + move.Start.squareRow) / 2, (move.End.squareCol + move.Start.squareCol) / 2].piece.Side.team) != board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.team))

            {
                return 1;
            }

            else if (((move.End.squareRow - move.Start.squareRow) ==- 2) && (board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.isRed())
                && Math.Abs((move.End.squareCol - move.Start.squareCol)) == 2 &&
                ((board.square[(move.End.squareRow + move.Start.squareRow) / 2, (move.End.squareCol + move.Start.squareCol) / 2].piece.PType.Equals(Piece.PieceType.Checker))
               && (board.square[(move.End.squareRow + move.Start.squareRow) / 2, (move.End.squareCol + move.Start.squareCol) / 2].piece.Side.team) != board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.team))
            {
                return 1;
            }
            else return -1;
        }

        public void ExecuteMove(Move move)
        {
            board.square[move.End.squareRow, move.End.squareCol].piece = board.square[move.Start.squareRow, move.Start.squareCol].piece;
            board.square[move.Start.squareRow, move.Start.squareCol].piece = new Piece(Piece.PieceType.Empty);
            
        }

        public int VerifyAllLegalMoves(Move move)
        {
            if ((VeifyMoveType(move) == 2) || (VeifyMoveType(move) == 1))
            {
            
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public int VeifyMoveType(Move move)
        {


            if (isNormal(move) == 1)
            {
                return 1;
            }

            else if (isJump(move) == 1)

            {
                
                return 2;
            }
            else
                return 3;


        }
    }
}
