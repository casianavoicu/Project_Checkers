using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checkers.Classes;
using System.IO;
using System.Reflection;


namespace Checkers
{
    public partial class Form1 : Form
    {   Board board;
        //Team team;
         int pos= -1;
        int pod = -1;
        public Square[,] boardSquare1;
        //  List<Move> movePossible = new List<Move>();
        List<Point> moves;
        public Form1()
        {


            InitializeComponent();
            CreateBoard();

        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            FormGame f2 = new FormGame();
            f2.ShowDialog();
        }

        private void CreateBoard()
        {
            int c;
           // Piece pieceCreate = new Piece();
            boardSquare1 = new Square[8,8];
            board = new Board();
            for (int r = 0; r < 8; r++)
            {
                for (c = 0; c < 8; c++)
                {
                    boardSquare1[r, c] = new Square(Color.White, r, c);
                    panelCheckers.Controls.Add(boardSquare1[r, c]);
                    boardSquare1[r, c].Click += SquareClick;
                    //  board.squares[r,c] = new Square(pieceCreate.CreatePiece(localisation)
                }

            }

        }
      private  void SquareClick(object sender, EventArgs e)
        {
           
            PictureBox squarePictureBox = sender as PictureBox;
            int pictureBoxIndex = panelCheckers.Controls.IndexOf(squarePictureBox);
            Point squarePosition = GetCoordinates(pictureBoxIndex);
            Square clickedSquare = board.squares[squarePosition.X, squarePosition.Y];
           // clickedSquare.currentPiece
          
            // squarePictureBox.BackColor=Color.AliceBlue;
             Console.WriteLine(board.squares[squarePosition.X, squarePosition.Y].currentPiece.Team);
            //  Console.WriteLine(board.squares[squarePosition.X, squarePosition.Y].currentPiece.);


            if (VerifySelectedPiece(clickedSquare) && clickedSquare.currentPiece != null)

            {
                pos = pictureBoxIndex;
                Console.WriteLine("pos" + pos);
                Console.WriteLine("pod1" + pod);
             //   moves = board.VerifyMoves(squarePosition,destPosition); // checks the moves
            }
            else
            {
                pod = pictureBoxIndex;
                Console.WriteLine("pod" + pod);
            }
            
             MovePieces(squarePosition);

             ResetCoordinates();




        }
        private void ResetCoordinates()
        {
            pos = -1;
            pod = -1;
        }
        private void MovePieces(Point squarePosition)
        {
            Piece pieceOriginal = board.squares[GetCoordinates(pos).X, GetCoordinates(pos).Y].currentPiece;
            board.squares[GetCoordinates(pos).X, GetCoordinates(pos).Y].currentPiece = null;
            board.squares[squarePosition.X, squarePosition.Y].currentPiece = pieceOriginal;
            ((PictureBox)panelCheckers.Controls[pos]).Image = null;
            ((PictureBox)panelCheckers.Controls[pod]).Image = pieceOriginal.Image;

        }
        private bool VerifySelectedPiece(Square clickedSquare)
        {

                return  clickedSquare.currentPiece != null;
        }

        private Point GetCoordinates(int index)
        {
            int x = index % 8;
            int y = index / 8;
            Console.WriteLine(x);
            Console.WriteLine(y);
            return new Point(x, y);
        }

        private void start_Click(object sender, EventArgs e)
        {
           
            board = new Board();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {   
                    Point position = new Point(i, j);
                    board.squares[i, j] = new Square(new Piece(position));
                   
                    if (board.squares[i, j].currentPiece != null)
                    {
                        ((PictureBox)panelCheckers.Controls[(i * 8) + j]).Image = board.squares[i, j].currentPiece.Image;
                    }
                   
                }
            }
        }
    }
    }

