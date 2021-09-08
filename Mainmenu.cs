using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeForm3X3
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 tictactoe3x3 = new Form9();
            tictactoe3x3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicTacToeForm4x4 tictactoeform3x3 = new TicTacToeForm4x4();
            tictactoeform3x3.Show();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
