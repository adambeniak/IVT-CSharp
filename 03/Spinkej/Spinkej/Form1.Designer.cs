
namespace Spinkej
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
            this.poleText = new System.Windows.Forms.TextBox();
            this.tlačítkoSpi = new System.Windows.Forms.Button();
            this.tlačítkoTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleText
            // 
            this.poleText.BackColor = System.Drawing.Color.MistyRose;
            this.poleText.Location = new System.Drawing.Point(152, 62);
            this.poleText.Multiline = true;
            this.poleText.Name = "poleText";
            this.poleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.poleText.Size = new System.Drawing.Size(284, 78);
            this.poleText.TabIndex = 0;
            // 
            // tlačítkoSpi
            // 
            this.tlačítkoSpi.Location = new System.Drawing.Point(152, 224);
            this.tlačítkoSpi.Name = "tlačítkoSpi";
            this.tlačítkoSpi.Size = new System.Drawing.Size(284, 88);
            this.tlačítkoSpi.TabIndex = 1;
            this.tlačítkoSpi.Text = "&Spinkej";
            this.tlačítkoSpi.UseVisualStyleBackColor = true;
            this.tlačítkoSpi.Click += new System.EventHandler(this.tlačítkoSpi_Click);
            // 
            // tlačítkoTest
            // 
            this.tlačítkoTest.Location = new System.Drawing.Point(152, 396);
            this.tlačítkoTest.Name = "tlačítkoTest";
            this.tlačítkoTest.Size = new System.Drawing.Size(284, 88);
            this.tlačítkoTest.TabIndex = 2;
            this.tlačítkoTest.Text = "&Test";
            this.tlačítkoTest.UseVisualStyleBackColor = true;
            this.tlačítkoTest.Click += new System.EventHandler(this.tlačítkoTest_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 547);
            this.Controls.Add(this.tlačítkoTest);
            this.Controls.Add(this.tlačítkoSpi);
            this.Controls.Add(this.poleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Spinkej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleText;
        private System.Windows.Forms.Button tlačítkoSpi;
        private System.Windows.Forms.Button tlačítkoTest;
    }
}

