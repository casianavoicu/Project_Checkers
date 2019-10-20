using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    public class Referee
    {
        public Player playerBlack;
        public Player playerRed;
        public Side playerSide;
        public Board board;
        public Move move;
        public Piece piece;
        public int turn;

        public Referee(Board boardMain)
        {
            this.board = boardMain;
        }

        public int VerifyCurrentState(Move move, Player typePlayer)
        {

            if (board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.team == typePlayer.PSide.team 
                && board.square[move.End.squareRow, move.End.squareCol].piece.PType.Equals(Piece.PieceType.Empty) )
            {

                return 1;
            }
            else if (!board.square[move.End.squareRow, move.End.squareCol].piece.PType.Equals(Piece.PieceType.Empty) || board.square[move.Start.squareRow, move.Start.squareCol].piece.Side.team==typePlayer.PSide.team)
            {
                return 2;
            }
            else
                return 2;

        }
        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }


       
    }

       

}
