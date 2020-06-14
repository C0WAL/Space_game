using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_game
{
    public partial class Menutrudnosc : Form
    {
        public Menutrudnosc()
        {
            InitializeComponent();
        }

        private void PoziomLatwy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Space_invaders f3 = new Space_invaders();
            f3.ShowDialog();
        }

        private void Menutrudnosc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PoziomTrudny_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trudny.Space_invaders f4 = new Trudny.Space_invaders();
            f4.ShowDialog();
        }
    }
}
