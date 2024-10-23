
namespace Přesouvání
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
            this.popisekVěta = new System.Windows.Forms.Label();
            this.poleVěta = new System.Windows.Forms.TextBox();
            this.popisekJejíKopie = new System.Windows.Forms.Label();
            this.poleKopie = new System.Windows.Forms.TextBox();
            this.tlačítkoPřesuň = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekVěta
            // 
            this.popisekVěta.AutoSize = true;
            this.popisekVěta.Location = new System.Drawing.Point(41, 78);
            this.popisekVěta.Name = "popisekVěta";
            this.popisekVěta.Size = new System.Drawing.Size(45, 19);
            this.popisekVěta.TabIndex = 0;
            this.popisekVěta.Text = "&Věta:";
            // 
            // poleVěta
            // 
            this.poleVěta.Location = new System.Drawing.Point(176, 75);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.Size = new System.Drawing.Size(412, 26);
            this.poleVěta.TabIndex = 1;
            this.poleVěta.Text = "Nějaká věta.";
            // 
            // popisekJejíKopie
            // 
            this.popisekJejíKopie.AutoSize = true;
            this.popisekJejíKopie.Location = new System.Drawing.Point(41, 153);
            this.popisekJejíKopie.Name = "popisekJejíKopie";
            this.popisekJejíKopie.Size = new System.Drawing.Size(81, 19);
            this.popisekJejíKopie.TabIndex = 2;
            this.popisekJejíKopie.Text = "&Její kopie:";
            // 
            // poleKopie
            // 
            this.poleKopie.Location = new System.Drawing.Point(176, 150);
            this.poleKopie.Name = "poleKopie";
            this.poleKopie.Size = new System.Drawing.Size(412, 26);
            this.poleKopie.TabIndex = 3;
            // 
            // tlačítkoPřesuň
            // 
            this.tlačítkoPřesuň.Location = new System.Drawing.Point(233, 236);
            this.tlačítkoPřesuň.Name = "tlačítkoPřesuň";
            this.tlačítkoPřesuň.Size = new System.Drawing.Size(167, 32);
            this.tlačítkoPřesuň.TabIndex = 4;
            this.tlačítkoPřesuň.Text = "&Přesuň";
            this.tlačítkoPřesuň.UseVisualStyleBackColor = true;
            this.tlačítkoPřesuň.Click += new System.EventHandler(this.tlačítkoPřesuň_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 312);
            this.Controls.Add(this.tlačítkoPřesuň);
            this.Controls.Add(this.poleKopie);
            this.Controls.Add(this.popisekJejíKopie);
            this.Controls.Add(this.poleVěta);
            this.Controls.Add(this.popisekVěta);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Přesouvání";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekVěta;
        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.Label popisekJejíKopie;
        private System.Windows.Forms.TextBox poleKopie;
        private System.Windows.Forms.Button tlačítkoPřesuň;
    }
}

