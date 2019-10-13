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

     
        public Referee(Board boardMain)
        {
            this.board = boardMain;
        }

        public int VerifyCurrentState(Move move,Player typePlayer)
        {
            Console.WriteLine(typePlayer.PSide.team);

            if (board.square[move.Start._row, move.Start._col].piece.Side.team == typePlayer.PSide.team)
            {

                return 1;
            }
            else return 2;
          
        }
        public Player GetSide(Side.Team typePlayer)
        {
            if (typePlayer == Side.Team.Black)
            {
                return playerBlack;
             
            }
            else return playerRed;
        }
        
        
       

    }

       

}
