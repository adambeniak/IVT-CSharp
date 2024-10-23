
namespace Výsledek_utkání
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
            this.poleSparta = new System.Windows.Forms.TextBox();
            this.poleBaník = new System.Windows.Forms.TextBox();
            this.popisekSparta = new System.Windows.Forms.Label();
            this.popisekBaník = new System.Windows.Forms.Label();
            this.tlačítkoZobraz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleSparta
            // 
            this.poleSparta.Location = new System.Drawing.Point(345, 75);
            this.poleSparta.Name = "poleSparta";
            this.poleSparta.Size = new System.Drawing.Size(100, 29);
            this.poleSparta.TabIndex = 0;
            // 
            // poleBaník
            // 
            this.poleBaník.Location = new System.Drawing.Point(345, 151);
            this.poleBaník.Name = "poleBaník";
            this.poleBaník.Size = new System.Drawing.Size(100, 29);
            this.poleBaník.TabIndex = 1;
            // 
            // popisekSparta
            // 
            this.popisekSparta.AutoSize = true;
            this.popisekSparta.Location = new System.Drawing.Point(94, 78);
            this.popisekSparta.Name = "popisekSparta";
            this.popisekSparta.Size = new System.Drawing.Size(212, 24);
            this.popisekSparta.TabIndex = 2;
            this.popisekSparta.Text = "Kolik gólů dala &Sparta";
            // 
            // popisekBaník
            // 
            this.popisekBaník.AutoSize = true;
            this.popisekBaník.Location = new System.Drawing.Point(94, 154);
            this.popisekBaník.Name = "popisekBaník";
            this.popisekBaník.Size = new System.Drawing.Size(193, 24);
            this.popisekBaník.TabIndex = 3;
            this.popisekBaník.Text = "Kolik gólů dal &Baník";
            // 
            // tlačítkoZobraz
            // 
            this.tlačítkoZobraz.Location = new System.Drawing.Point(185, 213);
            this.tlačítkoZobraz.Name = "tlačítkoZobraz";
            this.tlačítkoZobraz.Size = new System.Drawing.Size(145, 54);
            this.tlačítkoZobraz.TabIndex = 4;
            this.tlačítkoZobraz.Text = "&Zobraz skóre";
            this.tlačítkoZobraz.UseVisualStyleBackColor = true;
            this.tlačítkoZobraz.Click += new System.EventHandler(this.tlačítkoZobraz_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoZobraz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.tlačítkoZobraz);
            this.Controls.Add(this.popisekBaník);
            this.Controls.Add(this.popisekSparta);
            this.Controls.Add(this.poleBaník);
            this.Controls.Add(this.poleSparta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výsledek utkání";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleSparta;
        private System.Windows.Forms.TextBox poleBaník;
        private System.Windows.Forms.Label popisekSparta;
        private System.Windows.Forms.Label popisekBaník;
        private System.Windows.Forms.Button tlačítkoZobraz;
    }
}

