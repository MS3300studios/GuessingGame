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
        //new game
        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            groupBoxRandomizing.Visible = true;
            ButtonNewGame.Enabled = false;
            buttonStop.Visible = true;
            groupBoxProposal.Visible = false;
            groupBoxRandomizing.Enabled = true;
            labelCommunicate1.Visible = false;
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


        //confirm
        private void button1_Click(object sender, EventArgs e)
        {
            int proposal = int.Parse(textBoxProposal.Text);
            var anw = g.Anwser(proposal);

            switch(anw)
            {
                case Anwsers.TooLittle:
                    labelAnwser.ForeColor = Color.Red;
                    labelAnwser.Text = "Too little!";
                    break;
                case Anwsers.TooMuch:
                    labelAnwser.ForeColor = Color.Red;
                    labelAnwser.Text = "Too much!";
                    break;
                case Anwsers.Score:
                    labelAnwser.ForeColor = Color.Green;
                    labelAnwser.Text = "Score!";
                    buttonConfirm.Enabled = false;
                    textBoxProposal.Enabled = false;
                    ButtonNewGame.Enabled = true;
                    break;

            }
        }

        private void textBoxScopeFrom_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            if (int.TryParse(textBoxScopeFrom.Text, out score)) //out oznacza tutaj że ma wywalić ten wynik poza nawias do int score
            {
                textBoxScopeFrom.BackColor = Color.LightGreen;
                ButtonRandomize.Enabled = true;
            }
            else
            {
                textBoxScopeFrom.BackColor = Color.PaleVioletRed;
                ButtonRandomize.Enabled = false;
            }
        }
    }
}
