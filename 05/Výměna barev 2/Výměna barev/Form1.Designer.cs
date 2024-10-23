
namespace Výměna_barev
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
            this.tlačítko1 = new System.Windows.Forms.Button();
            this.tlačítko2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítko1
            // 
            this.tlačítko1.BackColor = System.Drawing.Color.Red;
            this.tlačítko1.Location = new System.Drawing.Point(60, 51);
            this.tlačítko1.Name = "tlačítko1";
            this.tlačítko1.Size = new System.Drawing.Size(212, 56);
            this.tlačítko1.TabIndex = 0;
            this.tlačítko1.UseVisualStyleBackColor = false;
            this.tlačítko1.Click += new System.EventHandler(this.tlačítka_Click);
            // 
            // tlačítko2
            // 
            this.tlačítko2.BackColor = System.Drawing.Color.Lime;
            this.tlačítko2.Location = new System.Drawing.Point(60, 149);
            this.tlačítko2.Name = "tlačítko2";
            this.tlačítko2.Size = new System.Drawing.Size(212, 56);
            this.tlačítko2.TabIndex = 1;
            this.tlačítko2.UseVisualStyleBackColor = false;
            this.tlačítko2.Click += new System.EventHandler(this.tlačítka_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 257);
            this.Controls.Add(this.tlačítko2);
            this.Controls.Add(this.tlačítko1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výměna barev";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítko1;
        private System.Windows.Forms.Button tlačítko2;
    }
}

