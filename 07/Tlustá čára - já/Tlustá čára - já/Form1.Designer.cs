
namespace Tlustá_čára___já
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
            this.panel = new System.Windows.Forms.Panel();
            this.popisekTloušťka = new System.Windows.Forms.Label();
            this.poleTloušťka = new System.Windows.Forms.TextBox();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(219, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(245, 245);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // popisekTloušťka
            // 
            this.popisekTloušťka.AutoSize = true;
            this.popisekTloušťka.Location = new System.Drawing.Point(12, 74);
            this.popisekTloušťka.Name = "popisekTloušťka";
            this.popisekTloušťka.Size = new System.Drawing.Size(97, 24);
            this.popisekTloušťka.TabIndex = 1;
            this.popisekTloušťka.Text = "&Tloušťka:";
            // 
            // poleTloušťka
            // 
            this.poleTloušťka.Location = new System.Drawing.Point(113, 71);
            this.poleTloušťka.Name = "poleTloušťka";
            this.poleTloušťka.Size = new System.Drawing.Size(88, 29);
            this.poleTloušťka.TabIndex = 2;
            this.poleTloušťka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(16, 145);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(185, 44);
            this.tlačítkoPřekresli.TabIndex = 3;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoPřekresli;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.poleTloušťka);
            this.Controls.Add(this.popisekTloušťka);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Tlustá čára - já";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label popisekTloušťka;
        private System.Windows.Forms.TextBox poleTloušťka;
        private System.Windows.Forms.Button tlačítkoPřekresli;
    }
}

