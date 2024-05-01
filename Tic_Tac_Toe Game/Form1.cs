using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmTicTackToeGame : Form
    {
        char[,] Board = new char[3, 3] { { '?', '?', '?' }, { '?', '?', '?' }, { '?', '?', '?' } };

        bool Player1Turn = true;
        enum Choices { O = 0, X = 1 };
        public frmTicTackToeGame()
        {
            InitializeComponent();
        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen whitePen = new Pen(White);
            whitePen.Width = 8;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Horizontal lines
            e.Graphics.DrawLine(whitePen, 400, 200, 700, 200);
            e.Graphics.DrawLine(whitePen, 400, 270, 700, 270);

            // Vertical lines
            e.Graphics.DrawLine(whitePen, 500, 130, 500, 340);
            e.Graphics.DrawLine(whitePen, 600, 130, 600, 340);
        }    
        char GetChoiceName(Choices Choice)
        {
            if (Choice == Choices.X)
                return 'X';
            else
                return 'O';
        }
        void ChangeCellBackColor(PictureBox Cell)
        {
            Color greenBackColor = Color.LawnGreen;
            Cell.BackColor = greenBackColor;
            Cell.Padding = new Padding(10, 5, 10, 5);
        }
        void MakeCellsLineGreen(string[] Cordinates)
        {
            foreach(PictureBox Cell in pnlCells.Controls.OfType<PictureBox>())
            {
                if(Cordinates.Contains(Cell.Tag.ToString()))
                {
                    ChangeCellBackColor(Cell);
                }
            }
        }
        bool CheckForWinner(char PlayerChoice)
        {
            string[] Cordinates = new string[3];
            for(int i = 0; i < 3; i++)
            {
                // Check Horizontal Lines
                if (Board[i, 0] == PlayerChoice && Board[i, 1] == PlayerChoice && Board[i, 2] == PlayerChoice)
                {
                    Cordinates[0] = $"{i.ToString()},{0}";
                    Cordinates[1] = $"{i.ToString()},{1}";
                    Cordinates[2] = $"{i.ToString()},{2}";
                    MakeCellsLineGreen(Cordinates);
                    return true;
                }
                // Check Vertical Lines
                if (Board[0, i] == PlayerChoice && Board[1, i] == PlayerChoice && Board[2, i] == PlayerChoice)
                {
                    Cordinates[0] = $"{0},{i.ToString()}";
                    Cordinates[1] = $"{1},{i.ToString()}";
                    Cordinates[2] = $"{2},{i.ToString()}";
                    MakeCellsLineGreen(Cordinates);
                    return true;
                }       
            }
            // Check Left-to-Right Diagonal
            if (Board[0, 0] == PlayerChoice && Board[1, 1] == PlayerChoice && Board[2, 2] == PlayerChoice)
            {
                Cordinates[0] = $"{0},{0}";
                Cordinates[1] = $"{1},{1}";
                Cordinates[2] = $"{2},{2}";
                MakeCellsLineGreen(Cordinates);
                return true;
            }
            // Check Right-to-Left Diagonal
            if (Board[0, 2] == PlayerChoice && Board[1, 1] == PlayerChoice && Board[2, 0] == PlayerChoice)
            {
                Cordinates[0] = $"{0},{2}";
                Cordinates[1] = $"{1},{1}";
                Cordinates[2] = $"{2},{0}";
                MakeCellsLineGreen(Cordinates);
                return true;
            }
            return false;
        }
        bool isBoardFull()
        {
            for(short i = 0; i < 3; i++)
            {
                for(short j = 0; j < 3; j++)
                {
                    if (Board[i, j] == '?')
                        return false;
                }
            }
            return true;
        }
        bool isGameOver()
        {
            
            return CheckForWinner(GetChoiceName(Choices.X)) 
                    || CheckForWinner(GetChoiceName(Choices.O)) 
                    || isBoardFull();
        }
        void MakeCellsDisabled()
        {
            foreach(PictureBox Cell in pnlCells.Controls.OfType<PictureBox>())
            {
                Cell.Enabled = false;
            }
        }
        void ShowFinalResult()
        {
            if(CheckForWinner(GetChoiceName(Choices.O)))   
                lblWinner.Text = "Player2";

            else if(CheckForWinner(GetChoiceName(Choices.X)))
                lblWinner.Text = "Player1";

            else
                 lblWinner.Text = "Draw";

            lblTurn.Text = "Game Over";

        }
        private void Tic_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            string[] Cordinates = ((pb.Tag.ToString()).Split(','));

            int Row = Convert.ToInt32(Cordinates[0]);
            int Col = Convert.ToInt32(Cordinates[1]);

            if (Board[Row, Col] == '?' && !isGameOver())
            {
                if (Player1Turn)
                {
                    lblTurn.Text = "Player 1";
                    pb.Image = Resources.X;
                    Board[Row, Col] = 'X';
                    Player1Turn = false;
                    lblTurn.Text = "Player 2";
                }
                else
                {    
                    pb.Image = Resources.O;
                    Board[Row, Col] = 'O';
                    Player1Turn = true;
                    lblTurn.Text = "Player 1";
                }

                if (isGameOver())
                {
                    ShowFinalResult();
                    MakeCellsDisabled();
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pb.Enabled = false;
                return;
            }

        }
        void ResetBoard()
        {
            Board = new char[3, 3]
            {
                {'?', '?', '?' },
                {'?', '?', '?' },
                {'?', '?', '?' }
            };
        }
        void ResetCells()
        {
            foreach(PictureBox Cell in pnlCells.Controls.OfType<PictureBox>())
            {
                Cell.Image = Resources.question_mark_96;
                Cell.Enabled = true;
                Cell.BackColor = Color.Transparent;
            }
        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
            Player1Turn = true;

            ResetCells();
            ResetBoard();
        }
    }
}
