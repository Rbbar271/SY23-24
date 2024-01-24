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
    enum attacks{sp_attack, sp_deffence, attack, deffence}
    struct pokemon
    {
        public string Name;
        public string Type;
        public string Type2;
        public int Level;
        public attacks Attacktype;
        public int HP;
        public int EXP;
        public bool Legandery;
        public bool Shiny;
        public int Gen;
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
                pokemon p = readpokemon(s);
                showpokemon(p);
                infile.Close();
            }
        }
        private pokemon readpokemon(string s)
        {
            pokemon p = new pokemon();
            string[] feilds = s.Split('|');
            p.Name = feilds[0];
            p.Type = feilds[6];
            p.Level = int.Parse(feilds[1]);
            p.Attacktype = (attacks)Enum.Parse(typeof(attacks), feilds[3]);
            p.HP = int.Parse(feilds[2]);
            p.EXP = int.Parse(feilds[4]);

            if (feilds[8] == "True")
                p.Legandery = true;
            else
                p.Legandery = false;
            if (feilds[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(feilds[5]);
            p.Type2 = feilds[9];
            return p;

        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            debugBox.Clear();
            
            debugBox.Text +=  nametextBox.Text;
            debugBox.Text += "|";
            
            debugBox.Text +=  leveltextBox.Text ;
            debugBox.Text += "|";
            
            debugBox.Text +=  hptextBox.Text ;
            debugBox.Text += "|";
            
            debugBox.Text += AttacktextBox.Text;
            debugBox.Text += "|";
            
            debugBox.Text += exptextBox.Text;
            debugBox.Text += "|";
            
            debugBox.Text += gentextBox.Text;
            debugBox.Text += "|";
            
            debugBox.Text += typetextBox.Text;
            
            if (shinycheckBox.Checked)
            {
                debugBox.Text += "|";
                debugBox.Text += "shiny";
            }
            else
            {
                debugBox.Text += "|";
                debugBox.Text += "none shiny";
            }
            if (leganderycheckBox.Checked)
            {
                debugBox.Text += "|";
                debugBox.Text += "legandery";
            }
            else
            {
                debugBox.Text += "|";
                debugBox.Text += "none legandery";
            }
            if (type2textBox.Visible == true)
            {
                debugBox.Text += "|";
                
                debugBox.Text += type2textBox.Text;
            }
            else
            {
                debugBox.Text += "|";
                debugBox.Text += "monotype";
            }

            StreamWriter outfile = new StreamWriter("pokemon.txt");
            outfile.WriteLine(debugBox.Text);
            outfile.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            type2label.Visible = false;
            type2textBox.Visible = false;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            type2label.Visible = true;
            type2textBox.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
        }

        private void nonmaxbutton_Click(object sender, EventArgs e)
        {
            leveltextBox.Enabled = true;
            leveltextBox.Text = "";
            exptextBox.Enabled = true;
            exptextBox.Text = "";
            maxbutton.Visible = true;
            nonmaxbutton.Visible = false;
        }

        private void maxbutton_Click(object sender, EventArgs e)
        {
            leveltextBox.Text = "100";
            leveltextBox.Enabled = false;
            exptextBox.Text = "0";
            exptextBox.Enabled = false;
            maxbutton.Visible = false;
            nonmaxbutton.Visible = true;
        }
       
        private void sp_attackbutton_Click(object sender, EventArgs e)
        {
            AttacktextBox.Text = "";
            AttacktextBox.Text = "sp_attack";
            sp_attackbutton.Enabled = false;
            sp_deffencebutton.Enabled = true;
            attackbutton.Enabled = true;
            deffencebutton.Enabled = true;
        }

        private void sp_deffencebutton_Click(object sender, EventArgs e)
        {
            AttacktextBox.Text = "";
            AttacktextBox.Text = "sp_deffence";
            sp_attackbutton.Enabled = true;
            sp_deffencebutton.Enabled = false;
            attackbutton.Enabled = true;
            deffencebutton.Enabled = true;
        }

        private void attackbutton_Click(object sender, EventArgs e)
        {
            AttacktextBox.Text = "";
            AttacktextBox.Text = "attack";
            sp_attackbutton.Enabled = true;
            sp_deffencebutton.Enabled = true;
            attackbutton.Enabled = false;
            deffencebutton.Enabled = true;
        }

        private void deffencebutton_Click(object sender, EventArgs e)
        {
            AttacktextBox.Text = "";
            AttacktextBox.Text = "deffence";
            sp_attackbutton.Enabled = true;
            sp_deffencebutton.Enabled = true;
            attackbutton.Enabled = true;
            deffencebutton.Enabled = false;
        }
        void showpokemon(pokemon p)
        {
            nametextBox.Text = p.Name;

        }

    }
}
