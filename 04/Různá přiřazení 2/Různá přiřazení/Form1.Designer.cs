
namespace Různá_přiřazení
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.poleVěta = new System.Windows.Forms.TextBox();
            this.popisekVěta = new System.Windows.Forms.Label();
            this.tlačítkoAhojLidi = new System.Windows.Forms.Button();
            this.tlačítkoVymaž = new System.Windows.Forms.Button();
            this.tlačítkoTextČerveně = new System.Windows.Forms.Button();
            this.tlačítkoZablokuj = new System.Windows.Forms.Button();
            this.tlačítkoOdblokuj = new System.Windows.Forms.Button();
            this.tlačítkoObnov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleVěta
            // 
            this.poleVěta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poleVěta.ForeColor = System.Drawing.Color.Blue;
            this.poleVěta.Location = new System.Drawing.Point(119, 55);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.Size = new System.Drawing.Size(356, 26);
            this.poleVěta.TabIndex = 1;
            // 
            // popisekVěta
            // 
            this.popisekVěta.AutoSize = true;
            this.popisekVěta.Location = new System.Drawing.Point(61, 58);
            this.popisekVěta.Name = "popisekVěta";
            this.popisekVěta.Size = new System.Drawing.Size(52, 20);
            this.popisekVěta.TabIndex = 0;
            this.popisekVěta.Text = "&Věta:";
            // 
            // tlačítkoAhojLidi
            // 
            this.tlačítkoAhojLidi.Location = new System.Drawing.Point(65, 122);
            this.tlačítkoAhojLidi.Name = "tlačítkoAhojLidi";
            this.tlačítkoAhojLidi.Size = new System.Drawing.Size(130, 43);
            this.tlačítkoAhojLidi.TabIndex = 2;
            this.tlačítkoAhojLidi.Text = "&Ahoj, lidi";
            this.tlačítkoAhojLidi.UseVisualStyleBackColor = true;
            this.tlačítkoAhojLidi.Click += new System.EventHandler(this.tlačítkoAhojLidi_Click);
            // 
            // tlačítkoVymaž
            // 
            this.tlačítkoVymaž.Location = new System.Drawing.Point(65, 198);
            this.tlačítkoVymaž.Name = "tlačítkoVymaž";
            this.tlačítkoVymaž.Size = new System.Drawing.Size(130, 43);
            this.tlačítkoVymaž.TabIndex = 3;
            this.tlačítkoVymaž.Text = "Vy&maž";
            this.tlačítkoVymaž.UseVisualStyleBackColor = true;
            this.tlačítkoVymaž.Click += new System.EventHandler(this.tlačítkoVymaž_Click);
            // 
            // tlačítkoTextČerveně
            // 
            this.tlačítkoTextČerveně.Location = new System.Drawing.Point(65, 274);
            this.tlačítkoTextČerveně.Name = "tlačítkoTextČerveně";
            this.tlačítkoTextČerveně.Size = new System.Drawing.Size(130, 43);
            this.tlačítkoTextČerveně.TabIndex = 4;
            this.tlačítkoTextČerveně.Text = "&Text červeně";
            this.tlačítkoTextČerveně.UseVisualStyleBackColor = true;
            this.tlačítkoTextČerveně.Click += new System.EventHandler(this.tlačítkoTextČerveně_Click);
            // 
            // tlačítkoZablokuj
            // 
            this.tlačítkoZablokuj.Location = new System.Drawing.Point(345, 122);
            this.tlačítkoZablokuj.Name = "tlačítkoZablokuj";
            this.tlačítkoZablokuj.Size = new System.Drawing.Size(130, 43);
            this.tlačítkoZablokuj.TabIndex = 5;
            this.tlačítkoZablokuj.Text = "&Zablokuj";
            this.tlačítkoZablokuj.UseVisualStyleBackColor = true;
            this.tlačítkoZablokuj.Click += new System.EventHandler(this.tlačítkoZablokuj_Click);
            // 
            // tlačítkoOdblokuj
            // 
            this.tlačítkoOdblokuj.Enabled = false;
            this.tlačítkoOdblokuj.Location = new System.Drawing.Point(345, 198);
            this.tlačítkoOdblokuj.Name = "tlačítkoOdblokuj";
            this.tlačítkoOdblokuj.Size = new System.Drawing.Size(130, 43);
            this.tlačítkoOdblokuj.TabIndex = 6;
            this.tlačítkoOdblokuj.Text = "&Odblokuj";
            this.tlačítkoOdblokuj.UseVisualStyleBackColor = true;
            this.tlačítkoOdblokuj.Click += new System.EventHandler(this.tlačítkoOdblokuj_Click);
            // 
            // tlačítkoObnov
            // 
            this.tlačítkoObnov.Location = new System.Drawing.Point(230, 275);
            this.tlačítkoObnov.Name = "tlačítkoObnov";
            this.tlačítkoObnov.Size = new System.Drawing.Size(245, 42);
            this.tlačítkoObnov.TabIndex = 7;
            this.tlačítkoObnov.Text = "O&bnov původní stav";
            this.tlačítkoObnov.UseVisualStyleBackColor = true;
            this.tlačítkoObnov.Click += new System.EventHandler(this.tlačítkoObnov_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(554, 338);
            this.Controls.Add(this.tlačítkoObnov);
            this.Controls.Add(this.tlačítkoOdblokuj);
            this.Controls.Add(this.tlačítkoZablokuj);
            this.Controls.Add(this.tlačítkoTextČerveně);
            this.Controls.Add(this.tlačítkoVymaž);
            this.Controls.Add(this.tlačítkoAhojLidi);
            this.Controls.Add(this.popisekVěta);
            this.Controls.Add(this.poleVěta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Různá přiřazení 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.Label popisekVěta;
        private System.Windows.Forms.Button tlačítkoAhojLidi;
        private System.Windows.Forms.Button tlačítkoVymaž;
        private System.Windows.Forms.Button tlačítkoTextČerveně;
        private System.Windows.Forms.Button tlačítkoZablokuj;
        private System.Windows.Forms.Button tlačítkoOdblokuj;
        private System.Windows.Forms.Button tlačítkoObnov;
    }
}

