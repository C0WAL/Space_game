using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_game
{
    class Przeciwnik
    {
        private int szerokość, wysokość;
        private int kolumny, wiersze;
        private int x, y, odstępy;

        public Przeciwnik()
        {
            szerokość = 40;
            wysokość = 40;
            kolumny = 5;
            wiersze = 3;
            odstępy = 10;
            x = 150;
            y = 0;
        }
        private void CreateControl(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x, y);
            pb.Size = new Size(szerokość, wysokość);
            pb.BackgroundImage = Properties.Resources.invaders;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien";
            p.Controls.Add(pb);
        }
        public void CreateSprites(Form p)
        {
            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    CreateControl(p);
                    x += szerokość + odstępy;
                }
                y += wysokość + odstępy;
                x = 150;
            }
        }

        public void CreateSprites2(Form p)
        {
            wiersze = 5;
            kolumny = 6;

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    CreateControl(p);
                    x += szerokość + odstępy;
                }
                y += wysokość + odstępy;
                x = 150;
            }
        }

        public void CreateSprites3(Form p)
        {
            wiersze = 6;
            kolumny = 7;

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    CreateControl(p);
                    x += szerokość + odstępy;
                }
                y += wysokość + odstępy;
                x = 150;
            }
        }
        public void CreateSprites4(Form p)
        {
            wiersze = 7;
            kolumny = 8;

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    CreateControl(p);
                    x += szerokość + odstępy;
                }
                y += wysokość + odstępy;
                x = 150;
            }
        }
        public void CreateSprites5(Form p)
        {
            wiersze = 7;
            kolumny = 10;

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    CreateControl(p);
                    x += szerokość + odstępy;
                }
                y += wysokość + odstępy;
                x = 150;
            }
        }

    }
}
