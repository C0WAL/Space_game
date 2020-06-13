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
    public partial class Menutytul : Form
    {
        public Menutytul()
        {
            InitializeComponent();
        }

        private void Menutytul_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menutrudnosc f2 = new Menutrudnosc();
            f2.ShowDialog();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
