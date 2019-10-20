using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Checkers.Properties;
using System.Collections;

namespace Checkers.Classes
{
    public class Board
    {
        public int turn;
        public Side.Team currentSide;
        public Player currentPlayer;
        public Player redPlayer;
        public Player blackPlayer;
        public Side red, black;
        public Square [,]square = new Square[8,8];
        private ArrayList SquaresBoard;
        public Rules rules;
        public Referee referee;
        public int state;
        public int resultOfPossibleMoves;
        public int stateMoves;
        public Board()
        {

            red = new Side(Side.Team.Red);
            black = new Side(Side.Team.Black);
            CreatePlayers();
            SquaresBoard = new ArrayList();
            Draw();
            rules = new Rules(this);
            referee = new Referee(this);
        }
        public void Draw()
        {
            int col;
            square = new Square[8, 8];
         
            for (int row = 0; row < 8; row++)
            {
                for (col = 0; col < 8; col++)
                {
                    square[row, col] = new Square(row, col);
                    if (((row == 0 || row == 2) && (col % 2 == 1)) || ((row == 1) && (col % 2 == 0)))
                    {
                        square[row, col].piece = new Piece(black, Piece.PieceType.Checker);

                    }
                  else  if (((row == 5 || row == 7) && (col % 2 == 0)) || ((row == 6) && (col % 2 == 1)))
                    {
                        square[row, col].piece = new Piece(red, Piece.PieceType.Checker);
                    }
                    else 
                    { 
                        square[row, col].piece = new Piece( Piece.PieceType.Empty);

                    }
                    SquaresBoard.Add(square[row,col]);
                }
              
            }
            currentSide= Side.Team.Black;
            currentPlayer = blackPlayer;
            currentPlayer.PSide = black;
       
        }

        public void CreatePlayers()
        {
            redPlayer = new Player(new Side(Side.Team.Red ),Player.PlayerType.Human);
            blackPlayer = new Player(new Side(Side.Team.Black), Player.PlayerType.Human);
        }


        public Square this[int row, int col]
        {
            get
            {
                return square[row, col];
            }
        }

      
        public void TryMove(Square source,Square destination)
        {
         
            int moveResult;
            Move newMove = new Move(source,destination);
            state = referee.VerifyCurrentState(newMove, currentPlayer);
             
            if (state == 1)
            {
                moveResult = rules.DoMove(newMove);

                if (moveResult == -1)
                {
                   
                }
                else
                {
                    NextTurn();

                }

            }
            

         
        }
        public void NextTurn()
        {

            if (currentPlayer == blackPlayer)
            {
                currentPlayer = redPlayer;

                referee.Turn = 1;
            }
            else
            {
                currentPlayer = blackPlayer;

                referee.Turn = 2;
            }

        }
        public ArrayList GetMoves(int source_row,int source_column)
        {
            ArrayList possibleMoves=new ArrayList();

            foreach (Square squars in SquaresBoard)
            {
                Move newMoveTry = new Move(new Square(source_row, source_column),squars);
                stateMoves = referee.VerifyCurrentState(newMoveTry, currentPlayer);
                if (stateMoves == 1)
                {
                   resultOfPossibleMoves = rules.VerifyAllLegalMoves(newMoveTry);

                    if ( resultOfPossibleMoves == 0)
                    {
                            possibleMoves.Add(squars);
                    }

                }

            }
          
            return possibleMoves;
        }
       

    }

}