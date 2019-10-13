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
using Checkers.Interface;
using System.IO;
using System.Reflection;


namespace Checkers
{
    public partial class Form1 : Form
    {   Board board;
        public PictureBox pb;
        public Form1()
        {
            InitializeComponent();
     
      
            board = new Board();
            BoardInterface boardInterface = new BoardInterface(panelCheckers,this);
            

        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            FormGame f2 = new FormGame();
            f2.ShowDialog();
        }
       


    }
}

