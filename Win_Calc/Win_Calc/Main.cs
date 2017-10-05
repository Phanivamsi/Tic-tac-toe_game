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
    public partial class Main : Form
    {
        Form f;
        public Main()
        {
            InitializeComponent();
            f = new Form1();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            f = new Form1();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.Close();
            f = new Form1();
            f.Show();
        }
    }
}
