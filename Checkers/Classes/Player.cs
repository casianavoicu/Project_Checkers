using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    public class Player
    {
        public enum PlayerType { Human,Computer};
        protected PlayerType Type;
        protected Side Side;
        protected Piece currentPiece;

        public Player(Side side, PlayerType type)
        {
            Type = type;
            Side = side;
        }
        public PlayerType PType
        {
            get { return Type; }
            set { Type = value; }
        }
        public Side PSide
        {
            get { return Side; }
            set { Side = value; }
        }


    }
}