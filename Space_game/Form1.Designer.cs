﻿namespace Space_game
{
    partial class Space_invaders
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Obserwator = new System.Windows.Forms.Timer(this.components);
            this.Fala = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Label();
            this.Zycie1 = new System.Windows.Forms.PictureBox();
            this.Zycie2 = new System.Windows.Forms.PictureBox();
            this.Gracz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zdrowie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PUNKTY: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.GraczRuch);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.KontrolaPociskow);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.RuchObcego_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1500;
            this.timer4.Tick += new System.EventHandler(this.StrzałTick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.KolizjaZLaserem);
            // 
            // Obserwator
            // 
            this.Obserwator.Interval = 1;
            this.Obserwator.Tick += new System.EventHandler(this.Observe);
            // 
            // Fala
            // 
            this.Fala.AutoSize = true;
            this.Fala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Fala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fala.Location = new System.Drawing.Point(315, 732);
            this.Fala.Name = "Fala";
            this.Fala.Size = new System.Drawing.Size(140, 20);
            this.Fala.TabIndex = 5;
            this.Fala.Text = "Poziom pierwszy";
            // 
            // Finish
            // 
            this.Finish.AutoSize = true;
            this.Finish.Font = new System.Drawing.Font("Sitka Small", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Finish.ForeColor = System.Drawing.Color.White;
            this.Finish.Location = new System.Drawing.Point(286, 285);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(0, 52);
            this.Finish.TabIndex = 7;
            // 
            // Zycie1
            // 
            this.Zycie1.BackgroundImage = global::Space_game.Properties.Resources.tank;
            this.Zycie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zycie1.Location = new System.Drawing.Point(85, 710);
            this.Zycie1.Name = "Zycie1";
            this.Zycie1.Size = new System.Drawing.Size(30, 30);
            this.Zycie1.TabIndex = 4;
            this.Zycie1.TabStop = false;
            // 
            // Zycie2
            // 
            this.Zycie2.BackgroundImage = global::Space_game.Properties.Resources.tank;
            this.Zycie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zycie2.Location = new System.Drawing.Point(121, 710);
            this.Zycie2.Name = "Zycie2";
            this.Zycie2.Size = new System.Drawing.Size(30, 30);
            this.Zycie2.TabIndex = 3;
            this.Zycie2.TabStop = false;
            // 
            // Gracz
            // 
            this.Gracz.BackgroundImage = global::Space_game.Properties.Resources.tank;
            this.Gracz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gracz.Location = new System.Drawing.Point(360, 650);
            this.Gracz.Name = "Gracz";
            this.Gracz.Size = new System.Drawing.Size(50, 50);
            this.Gracz.TabIndex = 2;
            this.Gracz.TabStop = false;
            // 
            // Space_invaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Fala);
            this.Controls.Add(this.Zycie1);
            this.Controls.Add(this.Zycie2);
            this.Controls.Add(this.Gracz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Space_invaders";
            this.Text = "Space game 0.4";
            this.Load += new System.EventHandler(this.Space_invaders_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KlawiszPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KlawiszZwolniony);
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Gracz;
        private System.Windows.Forms.PictureBox Zycie2;
        private System.Windows.Forms.PictureBox Zycie1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer Obserwator;
        private System.Windows.Forms.Label Fala;
        private System.Windows.Forms.Label Finish;
    }
}

