using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeForm3X3
{
    public partial class TicTacToeForm4x4 : Form
    {
        private bool isPlayer1Turn;
        private int ButtonClicksCount;
        public TicTacToeForm4x4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerNamegroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Player2NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved", "About Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void TicTacToeForm4x4_Load(object sender, EventArgs e)
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
            isPlayer1Turn =StartPlayer1radioButton.Checked;
            ButtonClicksCount = 0;
        }
        private void EnableButtons(bool enable)
        {
            B1button4.Enabled = enable;
            B2button4.Enabled = enable;
            B3button4.Enabled = enable;
            B4button4.Enabled = enable;
            B5button4.Enabled = enable;
            B6button4.Enabled = enable;
            B7button4.Enabled = enable;
            B8button4.Enabled = enable;
            B9button4.Enabled = enable;
            B10button4.Enabled = enable;
            B11button4.Enabled = enable;
            B12button4.Enabled = enable;
            B13button4.Enabled = enable;
            B14button4.Enabled = enable;
            B15button4.Enabled = enable;
            B16button4.Enabled = enable;
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
            B1button4.Text = "";
            B2button4.Text = "";
            B3button4.Text = "";
            B4button4.Text = "";
            B5button4.Text = "";
            B6button4.Text = "";
            B7button4.Text = "";
            B8button4.Text = "";
            B9button4.Text = "";
            B10button4.Text = "";
            B11button4.Text = "";
            B12button4.Text = "";
            B13button4.Text = "";
            B14button4.Text = "";
            B15button4.Text = "";
            B16button4.Text = "";
        }

        private void EnablePlayerOptions(bool enable)
        {
            PlayerNamegroupBox.Enabled = enable;
            XPlayergroupbox.Enabled = enable;
            StartPlayergroupBox.Enabled = enable;
        }

        private void B1button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn==true)
            {
                if (XPlayer1radioButton.Checked)
                    B1button4.Text = "X";
                else
                    B1button4.Text = "O";
                isPlayer1Turn = false;
                B1button4.Enabled = false;
            }
            else
            {
                if(XPlayer2radioButton.Checked)
                    B1button4.Text = "X";
                else
                B1button4.Text = "O";
                isPlayer1Turn = true;
                B1button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B2button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B2button4.Text = "X";
                else
                    B2button4.Text = "O";
                isPlayer1Turn = false;
                B2button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B2button4.Text = "X";
                else
                    B2button4.Text = "O";
                isPlayer1Turn = true;
                B2button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B3button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B3button4.Text = "X";
                else
                    B3button4.Text = "O";
                isPlayer1Turn = false;
                B3button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B3button4.Text = "X";
                else
                    B3button4.Text = "O";
                isPlayer1Turn = true;
                B3button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B4button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B4button4.Text = "X";
                else
                    B4button4.Text = "O";
                isPlayer1Turn = false;
                B4button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B4button4.Text = "X";
                else
                    B4button4.Text = "O";
                isPlayer1Turn = true;
                B4button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B5button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B5button4.Text = "X";
                else
                    B5button4.Text = "O";
                isPlayer1Turn = false;
                B5button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B5button4.Text = "X";
                else
                    B5button4.Text = "O";
                isPlayer1Turn = true;
                B5button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B6button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B6button4.Text = "X";
                else
                    B6button4.Text = "O";
                isPlayer1Turn = false;
                B6button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B6button4.Text = "X";
                else
                    B6button4.Text = "O";
                isPlayer1Turn = true;
                B6button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B7button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B7button4.Text = "X";
                else
                    B7button4.Text = "O";
                isPlayer1Turn = false;
                B7button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B7button4.Text = "X";
                else
                    B7button4.Text = "O";
                isPlayer1Turn = true;
                B7button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B8button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B8button4.Text = "X";
                else
                    B8button4.Text = "O";
                isPlayer1Turn = false;
                B8button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B8button4.Text = "X";
                else
                    B8button4.Text = "O";
                isPlayer1Turn = true;
                B8button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B9button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B9button4.Text = "X";
                else
                    B9button4.Text = "O";
                isPlayer1Turn = false;
                B9button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B9button4.Text = "X";
                else
                    B9button4.Text = "O";
                isPlayer1Turn = true;
                B9button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B10button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B10button4.Text = "X";
                else
                    B10button4.Text = "O";
                isPlayer1Turn = false;
                B10button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B10button4.Text = "X";
                else
                    B10button4.Text = "O";
                isPlayer1Turn = true;
                B10button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B11button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B11button4.Text = "X";
                else
                    B11button4.Text = "O";
                isPlayer1Turn = false;
                B11button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B11button4.Text = "X";
                else
                    B11button4.Text = "O";
                isPlayer1Turn = true;
                B11button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B12button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B12button4.Text = "X";
                else
                    B12button4.Text = "O";
                isPlayer1Turn = false;
                B12button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B12button4.Text = "X";
                else
                B12button4.Text = "O";
                isPlayer1Turn = true;
                B12button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B13button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B13button4.Text = "X";
                else
                    B13button4.Text = "O";
                isPlayer1Turn = false;
                B13button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B13button4.Text = "X";
                else
                    B13button4.Text = "O";
                isPlayer1Turn = true;
                B13button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B14button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B14button4.Text = "X";
                else
                    B14button4.Text = "O";
                isPlayer1Turn = false;
                B14button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B14button4.Text = "X";
                else
                B14button4.Text = "O";
                isPlayer1Turn = true;
                B14button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B15button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B15button4.Text = "X";
                else
                    B15button4.Text = "O";
                isPlayer1Turn = false;
                B15button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B15button4.Text = "X";
                else
                B15button4.Text = "O";
                isPlayer1Turn = true;
                B15button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void B16button4_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn == true)
            {
                if (XPlayer1radioButton.Checked)
                    B16button4.Text = "X";
                else
                    B16button4.Text = "O";
                isPlayer1Turn = false;
                B16button4.Enabled = false;
            }
            else
            {
                if (XPlayer2radioButton.Checked)
                    B16button4.Text = "X";
                else
                B16button4.Text = "O";
                isPlayer1Turn = true;
                B16button4.Enabled = false;
            }
            ButtonClicksCount++;
            CheckTheWinner();
        }

        private void CheckTheWinner()
        {
            bool isWinner = false;
            if (ButtonClicksCount == 16)
            {
                MessageBox.Show("The Game Is Drawn. Please Reset The Game!!! ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetGame();
            }
            else
            {

                if ((B1button4.Text == B2button4.Text) && (B2button4.Text == B3button4.Text) && (B3button4.Text == B4button4.Text) && (!B1button4.Enabled))
                    isWinner = true;

                else if ((B5button4.Text == B6button4.Text) && (B6button4.Text == B7button4.Text) && (B7button4.Text == B8button4.Text) && (!B5button4.Enabled))
                    isWinner = true;

                else if ((B9button4.Text == B10button4.Text) && (B10button4.Text == B11button4.Text) && (B11button4.Text == B12button4.Text) && (!B9button4.Enabled))
                    isWinner = true;

                else if ((B13button4.Text == B14button4.Text) && (B14button4.Text == B15button4.Text) && (B15button4.Text == B16button4.Text) && (!B13button4.Enabled))
                    isWinner = true;

                else if ((B1button4.Text == B6button4.Text) && (B6button4.Text == B11button4.Text) && (B11button4.Text == B16button4.Text) && (!B1button4.Enabled))
                    isWinner = true;

                else if ((B4button4.Text == B7button4.Text) && (B7button4.Text == B10button4.Text) && (B10button4.Text == B13button4.Text) && (!B4button4.Enabled))
                    isWinner = true;

                else if ((B1button4.Text == B5button4.Text) && (B5button4.Text == B9button4.Text) && (B9button4.Text == B13button4.Text) && (!B1button4.Enabled))
                    isWinner = true;

                else if ((B2button4.Text == B6button4.Text) && (B6button4.Text == B10button4.Text) && (B10button4.Text == B14button4.Text) && (!B2button4.Enabled))
                    isWinner = true;

                else if ((B3button4.Text == B7button4.Text) && (B7button4.Text == B11button4.Text) && (B11button4.Text == B15button4.Text) && (!B3button4.Enabled))
                    isWinner = true;

                else if ((B4button4.Text == B8button4.Text) && (B8button4.Text == B12button4.Text) && (B12button4.Text == B16button4.Text) && (!B4button4.Enabled))
                    isWinner = true;


                if (isWinner==true)
                {
                    if (isPlayer1Turn == false)
                        MessageBox.Show(Player1NametextBox + " Is The Winner!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
               else
                        MessageBox.Show(Player2NametextBox + " Is The Winner!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainmenu tictactoeform4x4 = new Mainmenu();
            tictactoeform4x4.Show();
        }
    }
}
