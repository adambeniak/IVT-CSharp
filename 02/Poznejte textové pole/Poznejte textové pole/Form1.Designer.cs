
namespace Poznejte_textové_pole
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
            this.popisekHeslo = new System.Windows.Forms.Label();
            this.poleHeslo = new System.Windows.Forms.TextBox();
            this.popisekTajnéInformace = new System.Windows.Forms.Label();
            this.tlačítkoVstup = new System.Windows.Forms.Button();
            this.tlačítkoUložit = new System.Windows.Forms.Button();
            this.poleTajnéInformace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // popisekHeslo
            // 
            this.popisekHeslo.AutoSize = true;
            this.popisekHeslo.Location = new System.Drawing.Point(35, 65);
            this.popisekHeslo.Name = "popisekHeslo";
            this.popisekHeslo.Size = new System.Drawing.Size(59, 19);
            this.popisekHeslo.TabIndex = 0;
            this.popisekHeslo.Text = "&Heslo:";
            // 
            // poleHeslo
            // 
            this.poleHeslo.Location = new System.Drawing.Point(100, 62);
            this.poleHeslo.Name = "poleHeslo";
            this.poleHeslo.Size = new System.Drawing.Size(290, 26);
            this.poleHeslo.TabIndex = 1;
            this.poleHeslo.UseSystemPasswordChar = true;
            // 
            // popisekTajnéInformace
            // 
            this.popisekTajnéInformace.AutoSize = true;
            this.popisekTajnéInformace.Location = new System.Drawing.Point(35, 215);
            this.popisekTajnéInformace.Name = "popisekTajnéInformace";
            this.popisekTajnéInformace.Size = new System.Drawing.Size(136, 19);
            this.popisekTajnéInformace.TabIndex = 3;
            this.popisekTajnéInformace.Text = "&Tajné informace:";
            // 
            // tlačítkoVstup
            // 
            this.tlačítkoVstup.Location = new System.Drawing.Point(85, 117);
            this.tlačítkoVstup.Name = "tlačítkoVstup";
            this.tlačítkoVstup.Size = new System.Drawing.Size(255, 41);
            this.tlačítkoVstup.TabIndex = 2;
            this.tlačítkoVstup.Text = "&Vstup do tajné sekce";
            this.tlačítkoVstup.UseVisualStyleBackColor = true;
            // 
            // tlačítkoUložit
            // 
            this.tlačítkoUložit.Location = new System.Drawing.Point(85, 531);
            this.tlačítkoUložit.Name = "tlačítkoUložit";
            this.tlačítkoUložit.Size = new System.Drawing.Size(255, 41);
            this.tlačítkoUložit.TabIndex = 5;
            this.tlačítkoUložit.Text = "&Uložit na tajné místo";
            this.tlačítkoUložit.UseVisualStyleBackColor = true;
            // 
            // poleTajnéInformace
            // 
            this.poleTajnéInformace.Location = new System.Drawing.Point(39, 245);
            this.poleTajnéInformace.Multiline = true;
            this.poleTajnéInformace.Name = "poleTajnéInformace";
            this.poleTajnéInformace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.poleTajnéInformace.Size = new System.Drawing.Size(351, 259);
            this.poleTajnéInformace.TabIndex = 4;
            this.poleTajnéInformace.UseSystemPasswordChar = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(424, 607);
            this.Controls.Add(this.poleTajnéInformace);
            this.Controls.Add(this.tlačítkoUložit);
            this.Controls.Add(this.tlačítkoVstup);
            this.Controls.Add(this.popisekTajnéInformace);
            this.Controls.Add(this.poleHeslo);
            this.Controls.Add(this.popisekHeslo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Poznejte textové pole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekHeslo;
        private System.Windows.Forms.TextBox poleHeslo;
        private System.Windows.Forms.Label popisekTajnéInformace;
        private System.Windows.Forms.Button tlačítkoVstup;
        private System.Windows.Forms.Button tlačítkoUložit;
        private System.Windows.Forms.TextBox poleTajnéInformace;
    }
}

