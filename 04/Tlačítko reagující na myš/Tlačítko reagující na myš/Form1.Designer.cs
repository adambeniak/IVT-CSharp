
namespace Tlačítko_reagující_na_myš
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
            this.tlačítko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítko
            // 
            this.tlačítko.BackColor = System.Drawing.Color.Blue;
            this.tlačítko.Location = new System.Drawing.Point(99, 86);
            this.tlačítko.Name = "tlačítko";
            this.tlačítko.Size = new System.Drawing.Size(190, 103);
            this.tlačítko.TabIndex = 0;
            this.tlačítko.UseVisualStyleBackColor = false;
            this.tlačítko.MouseEnter += new System.EventHandler(this.tlačítko_MouseEnter);
            this.tlačítko.MouseLeave += new System.EventHandler(this.tlačítko_MouseLeave);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 275);
            this.Controls.Add(this.tlačítko);
            this.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Tlačítko reagující na myš";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítko;
    }
}

