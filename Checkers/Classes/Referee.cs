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


        public Referee(Board boardMain)
        {
            this.board = boardMain;
        }

        public int VerifyCurrentState(Move move, Player typePlayer)
        {

            if (board.square[move.Start._row, move.Start._col].piece.Side.team == typePlayer.PSide.team 
                && board.square[move.End._row, move.End._col].piece.PType.Equals(Piece.PieceType.Empty) )
            {

                return 1;
            }
            else if (!board.square[move.End._row, move.End._col].piece.PType.Equals(Piece.PieceType.Empty) || board.square[move.Start._row, move.Start._col].piece.Side.team==typePlayer.PSide.team)
            {
                return 2;
            }
            else
                return 2;

        }
     


    }

       

}
