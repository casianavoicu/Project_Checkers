﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    public class Move
    {
      
        public Square startSquare;
        public Square endSquare;
        public int row;
        public Piece piece;
        private Piece currentPiece;
        
        public Move(Square from, Square to)
        {
            startSquare = from;
            endSquare = to;
            piece = from.piece;
            currentPiece = to.piece;
        }
    


        public Square Start
        {
            get
            {
                return startSquare;
            }
            set

            {
                startSquare = value;
            }

        }

        public Square End
        {

            get
            {
                return endSquare;
            }
            set
            {
                endSquare = value;
            }
        }
        public Piece Piece
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
            }
        }


     



    }
}
