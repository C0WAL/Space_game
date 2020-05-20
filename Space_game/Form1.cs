using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_game
{
    public partial class Space_invaders : Form
    {
        public Space_invaders()
        {
            InitializeComponent();
            new Przeciwnik().CreateSprites(this);
            ///WstawPrzeciwnika
        }
        List<PictureBox> obcy = new List<PictureBox>();
        List<PictureBox> UsunObcy = new List<PictureBox>();

        const int x = 360;
        const int y = 650;
        const int limit = 730;

        int predkosc = -1;
        int lewo =  -1;
        int gora = 0;
        int zycia = 0;
        int pkt = 0;

        bool gra = true;
        bool ruchLewo;
        bool ruchPrawo;
        bool strzal;

        private void KlawiszPress(object sender, KeyEventArgs e) /// obsługa poruszania sie
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruchLewo = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruchPrawo = true;
            }
            else if (e.KeyCode == Keys.Space && gra && !strzal)
            {
                Pocisk();
                strzal = true;

            }

        }



        private void KlawiszZwolniony(object sender, KeyEventArgs e)  ///Zatrzymywanie ruchu gracza
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruchLewo = false;
            }
            else if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruchPrawo = false;
            }
            else if(e.KeyCode == Keys.Space)
            {
                strzal = false;
            }
        }





        private void Pocisk()
        {
            PictureBox bullet = new PictureBox();
            bullet.Location = new Point(Gracz.Location.X + Gracz.Width / +2, Gracz.Location.Y - 20);
            bullet.Size = new Size(5, 20);
            bullet.BackgroundImage = Properties.Resources.bullet;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Name = "Pocisk";
            this.Controls.Add(bullet);

        }

        private void GraczRuch(object sender, EventArgs e)
        {
            if(ruchLewo && Gracz.Location.X >=0)
            {
                Gracz.Left--;
            }
            else if(ruchPrawo && Gracz.Location.X <= limit)
            {
                Gracz.Left++;
            }
        }

        private void Wystrzel(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Pocisk")
                {
                    PictureBox bullet = (PictureBox)c;
                    bullet.Top -= 5;

                    if(bullet.Location.Y <=0)
                    {
                        this.Controls.Remove(bullet);
                    }

                    foreach(Control ct in this.Controls)
                    {
                        if(ct is PictureBox && ct.Name == "Laser")
                        {
                            /// trzeba dokonczyc
                        }
                    }
                }
                
            }

        }

        

        private void Wygrales() /// komunikat z informacja o wygranej
        {
            gra = false;

            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name == "Koniec")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Wygrales !" + "\n" + "Punkty: " + pkt.ToString();
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void Przegrales() /// zatrzymanie timerow oraz wyswietlenie komunikatu o porazce
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop(); Obserwator.Stop();

            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name == "Koniec")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Przegrales!";
                    gra = false;
                }
                else
                {
                    c.Visible = false;
                }
            }

        }
        private void Punkty(int pkt)
        {
            label2.Text = "Punkty: " + pkt.ToString();
        }

        private void Observe(object sender, EventArgs e)
        {

        }
    }
}


       