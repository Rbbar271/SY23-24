using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    enum attacks{sp_attck, sp_deffence, attack, deffence}
    struct pokemon
    {
        string Name;
        string Type;
        string Type2;
        int Level;
        attacks Attacktype;
        int HP;
        int EXP;
        bool Legandery;
        bool Shiny;
        int Gen;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("pokemon.txt"))
            {
                StreamReader infile = new StreamReader("pokemon.txt");
                string s = infile.ReadToEnd();
                infile.Close();
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            debugBox.Clear();
            debugBox.Text += " " + nametextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + leveltextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + hptextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + AttacktextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + exptextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + gentextBox.Text + " " ;
            debugBox.Text += " | ";
            debugBox.Text += " " + typetextBox.Text + " " ;
            if (type2textBox != null && type2textBox.Text != "nune")
            {
                debugBox.Text += " | ";
                debugBox.Text += " " + type2textBox.Text + " ";
            }
            if (shinycheckBox.Checked)
            {
                debugBox.Text += " | ";
                debugBox.Text += " shiny ";
            }
            if (leganderycheckBox.Checked)
            {
                debugBox.Text += " | ";
                debugBox.Text += " legandery ";
            }

            StreamWriter outfile = new StreamWriter("pokemon.txt");
            outfile.WriteLine(debugBox.Text);
            outfile.Close();
        }
    }
}
