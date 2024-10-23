
namespace Společná_obsluha
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
            this.tlačítkoDlouhý = new System.Windows.Forms.Button();
            this.tlačítkoŠiroký = new System.Windows.Forms.Button();
            this.popisekPoloslepý = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tlačítkoDlouhý
            // 
            this.tlačítkoDlouhý.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoDlouhý.Location = new System.Drawing.Point(43, 74);
            this.tlačítkoDlouhý.Name = "tlačítkoDlouhý";
            this.tlačítkoDlouhý.Size = new System.Drawing.Size(80, 219);
            this.tlačítkoDlouhý.TabIndex = 0;
            this.tlačítkoDlouhý.Text = "&Dlouhý";
            this.tlačítkoDlouhý.UseVisualStyleBackColor = true;
            this.tlačítkoDlouhý.MouseEnter += new System.EventHandler(this.tlačítka_MouseEnter);
            // 
            // tlačítkoŠiroký
            // 
            this.tlačítkoŠiroký.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoŠiroký.Location = new System.Drawing.Point(182, 74);
            this.tlačítkoŠiroký.Name = "tlačítkoŠiroký";
            this.tlačítkoŠiroký.Size = new System.Drawing.Size(232, 64);
            this.tlačítkoŠiroký.TabIndex = 1;
            this.tlačítkoŠiroký.Text = "&Š i r o k ý";
            this.tlačítkoŠiroký.UseVisualStyleBackColor = true;
            this.tlačítkoŠiroký.MouseEnter += new System.EventHandler(this.tlačítka_MouseEnter);
            // 
            // popisekPoloslepý
            // 
            this.popisekPoloslepý.AutoSize = true;
            this.popisekPoloslepý.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisekPoloslepý.Location = new System.Drawing.Point(173, 244);
            this.popisekPoloslepý.Name = "popisekPoloslepý";
            this.popisekPoloslepý.Size = new System.Drawing.Size(231, 49);
            this.popisekPoloslepý.TabIndex = 2;
            this.popisekPoloslepý.Text = "Poloslepý";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 367);
            this.Controls.Add(this.popisekPoloslepý);
            this.Controls.Add(this.tlačítkoŠiroký);
            this.Controls.Add(this.tlačítkoDlouhý);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "oknoProgramu";
            this.Text = "Společná obsluha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoDlouhý;
        private System.Windows.Forms.Button tlačítkoŠiroký;
        private System.Windows.Forms.Label popisekPoloslepý;
    }
}

