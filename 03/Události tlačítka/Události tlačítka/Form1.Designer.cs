
namespace Události_tlačítka
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
            this.tlačítkoZobrazit = new System.Windows.Forms.Button();
            this.tlačítkoUkončit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoZobrazit
            // 
            this.tlačítkoZobrazit.ForeColor = System.Drawing.Color.DarkGreen;
            this.tlačítkoZobrazit.Location = new System.Drawing.Point(77, 65);
            this.tlačítkoZobrazit.Name = "tlačítkoZobrazit";
            this.tlačítkoZobrazit.Size = new System.Drawing.Size(288, 40);
            this.tlačítkoZobrazit.TabIndex = 0;
            this.tlačítkoZobrazit.Text = "&Zobrazit zprávu";
            this.tlačítkoZobrazit.UseVisualStyleBackColor = true;
            this.tlačítkoZobrazit.Click += new System.EventHandler(this.tlačítkoZobrazit_Click);
            this.tlačítkoZobrazit.MouseHover += new System.EventHandler(this.tlačítka_MouseHover);
            // 
            // tlačítkoUkončit
            // 
            this.tlačítkoUkončit.ForeColor = System.Drawing.Color.DarkGreen;
            this.tlačítkoUkončit.Location = new System.Drawing.Point(77, 162);
            this.tlačítkoUkončit.Name = "tlačítkoUkončit";
            this.tlačítkoUkončit.Size = new System.Drawing.Size(288, 40);
            this.tlačítkoUkončit.TabIndex = 1;
            this.tlačítkoUkončit.Text = "&Ukončit program";
            this.tlačítkoUkončit.UseVisualStyleBackColor = true;
            this.tlačítkoUkončit.Click += new System.EventHandler(this.tlačítkoUkončit_Click);
            this.tlačítkoUkončit.MouseHover += new System.EventHandler(this.tlačítka_MouseHover);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(443, 266);
            this.Controls.Add(this.tlačítkoUkončit);
            this.Controls.Add(this.tlačítkoZobrazit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Události tlačítka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoZobrazit;
        private System.Windows.Forms.Button tlačítkoUkončit;
    }
}

