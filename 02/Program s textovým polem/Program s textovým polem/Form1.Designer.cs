namespace Program_s_textovým_polem
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
            this.SuspendLayout();
            // 
            // poleText
            // 
            this.poleText.BackColor = System.Drawing.Color.Thistle;
            this.poleText.ForeColor = System.Drawing.Color.Teal;
            this.poleText.Location = new System.Drawing.Point(60, 77);
            this.poleText.Multiline = true;
            this.poleText.Name = "poleText";
            this.poleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.poleText.Size = new System.Drawing.Size(451, 77);
            this.poleText.TabIndex = 0;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(570, 230);
            this.Controls.Add(this.poleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "oknoProgramu";
            this.Text = "Program s textovým polem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleText;
    }
}

