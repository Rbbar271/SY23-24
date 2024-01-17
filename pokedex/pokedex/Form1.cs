using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    enum attacks{high_damage, low_damage}
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
    }
}
