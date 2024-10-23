
namespace Schovej_program
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
            this.tlačítkoSchovejSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoSchovejSe
            // 
            this.tlačítkoSchovejSe.BackColor = System.Drawing.Color.Yellow;
            this.tlačítkoSchovejSe.Location = new System.Drawing.Point(65, 63);
            this.tlačítkoSchovejSe.Name = "tlačítkoSchovejSe";
            this.tlačítkoSchovejSe.Size = new System.Drawing.Size(210, 34);
            this.tlačítkoSchovejSe.TabIndex = 0;
            this.tlačítkoSchovejSe.Text = "&Schovej se!";
            this.tlačítkoSchovejSe.UseVisualStyleBackColor = false;
            this.tlačítkoSchovejSe.Click += new System.EventHandler(this.tlačítkoSchovejSe_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(340, 160);
            this.Controls.Add(this.tlačítkoSchovejSe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Schovej program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoSchovejSe;
    }
}

