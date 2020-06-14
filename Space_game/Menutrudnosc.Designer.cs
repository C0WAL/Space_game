namespace Space_game
{
    partial class Menutrudnosc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PoziomTrudny = new System.Windows.Forms.Button();
            this.PoziomLatwy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PoziomTrudny
            // 
            this.PoziomTrudny.Location = new System.Drawing.Point(516, 171);
            this.PoziomTrudny.Name = "PoziomTrudny";
            this.PoziomTrudny.Size = new System.Drawing.Size(159, 98);
            this.PoziomTrudny.TabIndex = 1;
            this.PoziomTrudny.Text = "Trudny";
            this.PoziomTrudny.UseVisualStyleBackColor = true;
            this.PoziomTrudny.Click += new System.EventHandler(this.PoziomTrudny_Click);
            // 
            // PoziomLatwy
            // 
            this.PoziomLatwy.Location = new System.Drawing.Point(101, 171);
            this.PoziomLatwy.Name = "PoziomLatwy";
            this.PoziomLatwy.Size = new System.Drawing.Size(153, 98);
            this.PoziomLatwy.TabIndex = 0;
            this.PoziomLatwy.Text = "Łatwy";
            this.PoziomLatwy.UseVisualStyleBackColor = true;
            this.PoziomLatwy.Click += new System.EventHandler(this.PoziomLatwy_Click);
            // 
            // Menutrudnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Space_game.Properties.Resources.backgif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PoziomTrudny);
            this.Controls.Add(this.PoziomLatwy);
            this.DoubleBuffered = true;
            this.Name = "Menutrudnosc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menutrudnosc_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PoziomLatwy;
        private System.Windows.Forms.Button PoziomTrudny;
    }
}