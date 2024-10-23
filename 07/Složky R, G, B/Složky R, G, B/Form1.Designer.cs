
namespace Složky_R__G__B
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
            this.tlačítkoZpráva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoZpráva
            // 
            this.tlačítkoZpráva.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tlačítkoZpráva.Location = new System.Drawing.Point(94, 50);
            this.tlačítkoZpráva.Margin = new System.Windows.Forms.Padding(6);
            this.tlačítkoZpráva.Name = "tlačítkoZpráva";
            this.tlačítkoZpráva.Size = new System.Drawing.Size(210, 63);
            this.tlačítkoZpráva.TabIndex = 0;
            this.tlačítkoZpráva.Text = "&Zpráva";
            this.tlačítkoZpráva.UseVisualStyleBackColor = false;
            this.tlačítkoZpráva.Click += new System.EventHandler(this.tlačítkoZpráva_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoZpráva;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(399, 162);
            this.Controls.Add(this.tlačítkoZpráva);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Složky R, G, B";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoZpráva;
    }
}

