
namespace Odstíny_šedi___já
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
            this.poleOdstín = new System.Windows.Forms.TextBox();
            this.popisekOdstín = new System.Windows.Forms.Label();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // poleOdstín
            // 
            this.poleOdstín.Location = new System.Drawing.Point(165, 62);
            this.poleOdstín.Name = "poleOdstín";
            this.poleOdstín.Size = new System.Drawing.Size(69, 29);
            this.poleOdstín.TabIndex = 1;
            this.poleOdstín.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekOdstín
            // 
            this.popisekOdstín.AutoSize = true;
            this.popisekOdstín.Location = new System.Drawing.Point(12, 65);
            this.popisekOdstín.Name = "popisekOdstín";
            this.popisekOdstín.Size = new System.Drawing.Size(147, 24);
            this.popisekOdstín.TabIndex = 0;
            this.popisekOdstín.Text = "&Odstín (0-255):";
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(16, 135);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(218, 44);
            this.tlačítkoPřekresli.TabIndex = 2;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(264, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 200);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoPřekresli;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 225);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.popisekOdstín);
            this.Controls.Add(this.poleOdstín);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Odstíny šedi - já";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleOdstín;
        private System.Windows.Forms.Label popisekOdstín;
        private System.Windows.Forms.Button tlačítkoPřekresli;
        private System.Windows.Forms.Panel panel;
    }
}

