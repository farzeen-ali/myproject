using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeForm3X3
{
    public partial class Form9 : Form
    {
        private bool isPlayer1turn;
        private int ButtonClicksCount;
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved", "About Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
        
        
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EnableButtons(true);
            startNewGameToolStripMenuItem.Enabled = false;
            resetGameToolStripMenuItem.Enabled = true;
            EnablePlayerOptions(false);
            isPlayer1turn = Player1radioButton.Checked;
            ButtonClicksCount = 0;
        }
        private void EnableButtons(bool enable)
        {
            B1button.Enabled = enable;
            B2button.Enabled = enable;
            B3button.Enabled = enable;
            B4button.Enabled = enable;
            B5button.Enabled = enable;
            B6button.Enabled = enable;
            B7button.Enabled = enable;
            B8button.Enabled = enable;
            B9button.Enabled = enable;
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            EnablePlayerOptions(true);
            ClearButtons();
        }

        private void ClearButtons()
        {
            B1button.Text = "";
            B2button.Text = "";
            B3button.Text = "";
            B4button.Text = "";
            B5button.Text = "";
            B6button.Text = "";
            B7button.Text = "";
            B8button.Text = "";
            B9button.Text = "";
        }

        private void EnablePlayerOptions(bool enable)
        {
            PlayerNamegroupBox.Enabled = enable;
            XPlayergroupBox.Enabled = enable;
            StartplayergroupBox.Enabled = enable;
        }

        private void B1button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B1button.Text = "X";
                else
                    B1button.Text = "O";
                isPlayer1turn = false;
                B1button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B1button.Text = "X";
                else
                    B1button.Text = "O";
                isPlayer1turn = true;
                B1button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B2button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B2button.Text = "X";
                else
                    B2button.Text = "O";
                isPlayer1turn = false;
                B2button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B2button.Text = "X";
                else
                    B2button.Text = "O";
                isPlayer1turn = true;
                B2button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B3button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B3button.Text = "X";
                else
                    B3button.Text = "O";
                isPlayer1turn = false;
                B3button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B3button.Text = "X";
                else
                    B3button.Text = "O";
                isPlayer1turn = true;
                B3button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B4button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B4button.Text = "X";
                else
                    B4button.Text = "O";
                isPlayer1turn = false;
                B4button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B4button.Text = "X";
                else
                    B4button.Text = "O";
                isPlayer1turn = true;
                B4button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B5button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B5button.Text = "X";
                else
                    B5button.Text = "O";
                isPlayer1turn = false;
                B5button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B5button.Text = "X";
                else
                    B5button.Text = "O";
                isPlayer1turn = true;
                B5button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B6button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B6button.Text = "X";
                else
                    B6button.Text = "O";
                isPlayer1turn = false;
                B6button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B6button.Text = "X";
                else
                    B6button.Text = "O";
                isPlayer1turn = true;
                B6button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B7button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B7button.Text = "X";
                else
                    B7button.Text = "O";
                isPlayer1turn = false;
                B7button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B7button.Text = "X";
                else
                    B7button.Text = "O";
                isPlayer1turn = true;
                B7button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B8button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B8button.Text = "X";
                else
                    B8button.Text = "O";
                isPlayer1turn = false;
                B8button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B8button.Text = "X";
                else
                    B8button.Text = "O";
                isPlayer1turn = true;
                B8button.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B9button_Click(object sender, EventArgs e)
        {
            if (isPlayer1turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B9button.Text = "X";
                else
                    B9button.Text = "O";
                isPlayer1turn = false;
                B9button.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B9button.Text = "X";
                else
                    B9button.Text = "O";
                isPlayer1turn = true;
                B9button.Enabled = false;
            }
            ButtonClicksCount++;

            CheckTheWinner();
        }

        private void CheckTheWinner()
        {
            bool isWinner = false;
            if (ButtonClicksCount == 9)
            {
                
                MessageBox.Show("The Game Is Drawn,Please Reset The Game!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                if ((B1button.Text == B2button.Text) && (B2button.Text == B3button.Text) && (!B1button.Enabled))
                    isWinner = true;
                else if ((B4button.Text == B5button.Text) && (B5button.Text == B6button.Text) && (!B4button.Enabled))
                    isWinner = true;
                else if ((B7button.Text == B8button.Text) && (B8button.Text == B9button.Text) && (!B7button.Enabled))
                    isWinner = true;
                else if ((B1button.Text == B4button.Text) && (B4button.Text == B7button.Text) && (!B1button.Enabled))
                    isWinner = true;
                else if ((B2button.Text == B5button.Text) && (B5button.Text == B8button.Text) && (!B2button.Enabled))
                    isWinner = true;
                else if ((B3button.Text == B6button.Text) && (B6button.Text == B9button.Text) && (!B3button.Enabled))
                    isWinner = true;
                else if ((B1button.Text == B5button.Text) && (B5button.Text == B9button.Text) && (!B1button.Enabled))
                    isWinner = true;
                else if ((B3button.Text == B5button.Text) && (B5button.Text == B7button.Text) && (!B3button.Enabled))
                    isWinner = true;


                if (isWinner == true)
                {
                    if (isPlayer1turn == false)
                        MessageBox.Show(Player1nametextBox.Text + " Is The Winner!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                        MessageBox.Show(Player2nametextBox.Text + " Is The Winner!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
                        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainmenu tictactoeform3x3 = new Mainmenu();
            tictactoeform3x3.Show();
        }
    }
}
