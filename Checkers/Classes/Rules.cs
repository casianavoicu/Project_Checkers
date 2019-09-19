using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void canMove(Move move)
        {
            board[move.endSquare.row, move.endSquare.col].piece = board[move.startSquare.row, move.startSquare.col].piece;
            board[move.startSquare.row, move.startSquare.col].piece = new Piece(Piece.PieceType.Empty);
            //Move newmove = new Move();
        }
    }
}
