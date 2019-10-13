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
        public Side.Team currentSide;
        public Player currentPlayer;
        public Player redPlayer;
        public Player blackPlayer;
        public Side red, black;
        public Square [,]square = new Square[8,8];
        private ArrayList SquaresBoard;
        public Rules rules;
        public Referee referee;
        public int i;
        public Board()
        {

            red = new Side(Side.Team.Red);
            black = new Side(Side.Team.Black);
            CreatePlayers();
            Draw();
            rules = new Rules(this);
            referee = new Referee(this);
        }
        public void Draw()
        {
            int col;
            square = new Square[8, 8];
            SquaresBoard = new ArrayList();
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
                    SquaresBoard.Add(square);
                }
              
            }
            currentSide= Side.Team.Black;
            //  currentPlayer =Player.PlayerType[currentSide];
            currentPlayer = blackPlayer;

        }

        public void CreatePlayers()
        {
            redPlayer = new Player(new Side(Side.Team.Red ),Player.PlayerType.Human);
            blackPlayer = new Player(new Side(Side.Team.Black), Player.PlayerType.Human);
        }


        public Square this[int row, int col]
        {
            get { return square[row, col]; }
        }

      
        public int TryMove(Square source,Square destination)
        {
            //currentPlayer = blackPlayer;
            //currentSide = Side.Team.Black;

            int result;
            //Console.WriteLine(source._col);
             Move newMove = new Move(source,destination);
            // Referee newMove = new Referee(source, destination, currentSide);
            
            i = referee.VerifyCurrentState(newMove, currentPlayer);
            Console.WriteLine(i);
            if (i == 1)
            {
                result = rules.DoMove(newMove);
                NextTurn();
            }
           
            result =- 1;
            
            return result;
        }
        public void NextTurn()
        {

            if (currentPlayer == blackPlayer)
            {
                currentPlayer = redPlayer;

            }
            else
                currentPlayer = blackPlayer;
        }

    }

}