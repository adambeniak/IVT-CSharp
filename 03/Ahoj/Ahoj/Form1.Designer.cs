
namespace Ahoj
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
            this.tlačítkoAhoj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoAhoj
            // 
            this.tlačítkoAhoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoAhoj.ForeColor = System.Drawing.Color.Navy;
            this.tlačítkoAhoj.Location = new System.Drawing.Point(140, 57);
            this.tlačítkoAhoj.Name = "tlačítkoAhoj";
            this.tlačítkoAhoj.Size = new System.Drawing.Size(162, 45);
            this.tlačítkoAhoj.TabIndex = 0;
            this.tlačítkoAhoj.Text = "&Ahoj";
            this.tlačítkoAhoj.UseVisualStyleBackColor = true;
            this.tlačítkoAhoj.Click += new System.EventHandler(this.tlačítkoAhoj_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 159);
            this.Controls.Add(this.tlačítkoAhoj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "oknoProgramu";
            this.Text = "Ahoj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoAhoj;
    }
}

