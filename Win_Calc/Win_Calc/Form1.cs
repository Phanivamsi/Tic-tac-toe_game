using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (count % 2 == 0)
            {
                b.Text = "O";
            }
            else
            {
                b.Text = "X";
            }
            count++;
            if (count >= 5)
            {
                if ((b1.Text == "O" && b2.Text == "O" && b3.Text == "O") || (b1.Text == "X" && b2.Text == "X" && b3.Text == "X"))
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b1.Text + " wins");
                    Application.Exit();
                }
                else if ((b4.Text == "O" && b5.Text == "O" && b6.Text == "O") || (b4.Text == "X" && b5.Text == "X" && b6.Text == "X"))
                {
                    b4.BackColor = Color.Green;
                    b5.BackColor = Color.Green;
                    b6.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b4.Text + " wins");
                    Application.Exit();
                }
                else if ((b7.Text == "O" && b8.Text == "O" && b9.Text == "O") || (b7.Text == "X" && b8.Text == "X" && b9.Text == "X"))
                {
                    b7.BackColor = Color.Green;
                    b8.BackColor = Color.Green;
                    b9.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b7.Text + " wins");
                    Application.Exit();
                }
                else if ((b1.Text == "O" && b4.Text == "O" && b7.Text == "O") || (b1.Text == "X" && b4.Text == "X" && b7.Text == "X"))
                {
                    b1.BackColor = Color.Green;
                    b4.BackColor = Color.Green;
                    b7.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b1.Text + " wins");
                    Application.Exit();
                }
                else if ((b2.Text == "O" && b5.Text == "O" && b8.Text == "O") || (b2.Text == "X" && b5.Text == "X" && b8.Text == "X"))
                {
                    b2.BackColor = Color.Green;
                    b5.BackColor = Color.Green;
                    b8.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b2.Text + " wins");
                    Application.Exit();
                }
                else if ((b3.Text == "O" && b6.Text == "O" && b9.Text == "O") || (b3.Text == "X" && b6.Text == "X" && b9.Text == "X"))
                {
                    b3.BackColor = Color.Green;
                    b6.BackColor = Color.Green;
                    b9.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b3.Text + " wins");
                    Application.Exit();
                }
                else if ((b1.Text == "O" && b5.Text == "O" && b9.Text == "O") || (b1.Text == "X" && b5.Text == "X" && b9.Text == "X"))
                {
                    b1.BackColor = Color.Green;
                    b5.BackColor = Color.Green;
                    b9.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b1.Text + " wins");
                    Application.Exit();
                }
                else if ((b3.Text == "O" && b5.Text == "O" && b7.Text == "O") || (b3.Text == "X" && b5.Text == "X" && b7.Text == "X"))
                {
                    b5.BackColor = Color.Green;
                    b7.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    MessageBox.Show("Game over !!!" + b3.Text + " wins");
                    Application.Exit();
                }
                else
                {
                    if (count == 9)
                    {
                        MessageBox.Show("ITS A DRAW");
                        Application.Exit();
                    }
                }
            }
        }
    }
}
