using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameModel;

namespace GraphicalGame
{
    public partial class Form1 : Form
    {
        private Game g = null; //referencja do obiektu gra

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            groupBoxRandomizing.Visible = true;
            ButtonNewGame.Enabled = false;
            buttonStop.Visible = true;
        }
        
        //randomize
        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxScopeFrom.Text);
            int b = int.Parse(textBoxScopeTo.Text);
            g = new Game(a, b);
            // wypisz komunikat żeby odgadywać
            labelCommunicate1.Text = $"A number from {a} to {b} was randomized!";
            labelCommunicate1.Visible = true;
            groupBoxRandomizing.Enabled = false; //nie można już teraz wpisywać w groupbox 
            groupBoxProposal.Visible = true;                    
        }
    }
}
