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
    public partial class Space_invaders : Form
    {
       //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Space_invaders()
        {
            InitializeComponent();
            new Przeciwnik().CreateSprites(this);
            WstawObcego();
            //player.SoundLocation = "space.wav";
            //player.Play();

        }
        List<PictureBox> obcy = new List<PictureBox>();
        List<PictureBox> opoznienie = new List<PictureBox>();

        const int x = 360;
        const int y = 650;
        const int limit = 730;

        int predkosc = -1;
        int lewo =  -1;
        int gora = 0;
        int cnt = 0;
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
            bullet.Name = "Bullet";
            this.Controls.Add(bullet);

        }

        private void GraczRuch(object sender, EventArgs e)
        {
            if(ruchLewo && Gracz.Location.X >=0)
            {
                Gracz.Left-=3;
            }
            else if(ruchPrawo && Gracz.Location.X <= limit)
            {
                Gracz.Left+=3;
            }
        }

        private void KontrolaPociskow(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Bullet")
                {
                    PictureBox bullet = (PictureBox)c;
                    bullet.Top -= 5;

                    if(bullet.Location.Y <=0)
                    {
                        this.Controls.Remove(bullet);
                    }

                    foreach(Control ct in this.Controls)
                    {
                        if (ct is PictureBox && ct.Name == "Laser")
                        {
                            PictureBox laser = (PictureBox)ct;

                            if (bullet.Bounds.IntersectsWith(laser.Bounds))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(laser);
                               // pkt++;
                                //Punkty(pkt);
                            }
                        }
                    }

                    foreach(Control ctrl in this.Controls)
                    {
                        if(ctrl is PictureBox && ctrl.Name == "Alien")
                        {
                            PictureBox obcyy = (PictureBox)ctrl;

                            if(bullet.Bounds.IntersectsWith(obcyy.Bounds) && !LimitPola(obcyy))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(obcyy);
                                obcy.Remove(obcyy);
                                pkt += 5;
                                Punkty(pkt);
                                SprawdzWygrana();
                            }
                            else if(bullet.Bounds.IntersectsWith(obcyy.Bounds) && LimitPola(obcyy))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(obcyy);
                                opoznienie.Add(obcyy);
                                pkt += 5;
                                Punkty(pkt);
                                SprawdzWygrana();
                            }

                        }

                    }

                }
                
            }

        }

        private void SprawdzWygrana()
        {
            int licznik = 0;

            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Alien") licznik++;
            }
           if(this.pkt == 75)
             {
                Fala.Text = "Poziom drugi";
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(2) > DateTime.Now);

                new Przeciwnik().CreateSprites2(this);
                WstawObcego();
             }
             if(this.pkt == 225)
              {
                  Fala.Text = "Poziom trzeci";
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(2) > DateTime.Now);

                new Przeciwnik().CreateSprites3(this);
                  WstawObcego();
              }
             if(this.pkt == 435)
              {
                 Fala.Text = "Poziom czwarty";
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(2) > DateTime.Now);

                new Przeciwnik().CreateSprites4(this);
                  WstawObcego();
              }
            if (this.pkt == 715)
            {
                Fala.Text = "Poziom piąty";
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(2) > DateTime.Now);

                new Przeciwnik().CreateSprites5(this);
                WstawObcego();
            }


            if (this.pkt == 1065) Wygrales();
        }
        

        private void Wygrales() /// komunikat z informacja o wygranej
        {
            gra = false;

            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name == "Finish")
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
                if(c is Label && c.Name == "Finish")
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
        private void Punkty(int pkt)  /// wyswietlanie liczby pkt
        {
            label2.Text = "Punkty: " + pkt.ToString();
        }

        private void Observe(object sender, EventArgs e)
        {
            Obserwator.Stop();
            foreach(PictureBox opozniony in opoznienie)
            {
                obcy.Remove(opozniony);
            }
            opoznienie.Clear();
        }

        private bool LimitPola(PictureBox a)
        {
            return a.Location.X <= 0 || a.Location.X >= limit;
        }


        private void OstatecznaKolizja(PictureBox a)  
         {  
                if(a.Bounds.IntersectsWith(Gracz.Bounds))
                {
                    Przegrales();
                }           
        }

        private void UstawPozycje(PictureBox a)
        {
            int rozmiar = a.Height;

            if(LimitPola(a))
            {
                gora = 1; lewo = 0; cnt++;

                if(cnt == rozmiar)
                {
                    gora = 0; lewo = predkosc * (-1); Obserwator.Start();
                }
                else if(cnt == rozmiar*2)
                {
                    gora = 0; lewo = predkosc; cnt = 0; Obserwator.Start();
                }
            }
        }

        private void RuchObcego()
        {
            foreach(PictureBox obcyy in obcy)
            {
                obcyy.Location = new Point(obcyy.Location.X + lewo, obcyy.Location.Y + gora);
                UstawPozycje(obcyy);
                OstatecznaKolizja(obcyy);
            }
        }



        private void RuchObcego_Tick(object sender, EventArgs e)
        {
            RuchObcego();
        }

        private void WstawObcego()
        {
            foreach(Control c in this.Controls)
            {
                if(c is PictureBox && c.Name =="Alien")
                {
                    PictureBox obcyy = (PictureBox)c;
                    obcy.Add(obcyy);
                }
            }
        }

        private void Laser(PictureBox a)
        {
            PictureBox laser = new PictureBox();
            laser.Location = new Point(a.Location.X + a.Width / 3, a.Location.Y + 20);
            laser.Size = new Size(5, 20);
            laser.BackgroundImage = Properties.Resources.laser;
            laser.BackgroundImageLayout = ImageLayout.Stretch;
            laser.Name = "Laser";
            this.Controls.Add(laser);
        }

        private void StrzałTick(object sender, EventArgs e)
        {
            Random r = new Random();
            int pick; 

            if (obcy.Count > 0)
            {
                pick = r.Next(obcy.Count);
                Laser(obcy[pick]);
            }
        }

        private void KolizjaZLaserem(object sender, EventArgs e)
        {
             foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Laser")
                {
                    PictureBox laser = (PictureBox)c;
                    laser.Top += 5; 

                    if (laser.Location.Y >= limit)
                    {
                        this.Controls.Remove(laser); 
                    }
                    if (laser.Bounds.IntersectsWith(Gracz.Bounds))
                    {
                        this.Controls.Remove(laser); 
                        UtrataZycia(); 
                    }                    
                }
            }
        }

        private void UtrataZycia()
        {
            Gracz.Location = new Point(x,y);
            foreach(Control c in this.Controls)     
            {
                if(c is PictureBox && c.Name.Contains("Zycie") && c.Visible==true)
                    
                {
                    PictureBox Gracz = (PictureBox)c;
                    Gracz.Visible = false;
                    return;
                }
            }
            Przegrales();
        }
    }
}


       