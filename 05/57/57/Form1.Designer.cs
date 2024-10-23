
namespace _57
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
            this.tlačítkoProveď = new System.Windows.Forms.Button();
            this.poleČíslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tlačítkoProveď
            // 
            this.tlačítkoProveď.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tlačítkoProveď.ForeColor = System.Drawing.Color.Maroon;
            this.tlačítkoProveď.Location = new System.Drawing.Point(93, 46);
            this.tlačítkoProveď.Name = "tlačítkoProveď";
            this.tlačítkoProveď.Size = new System.Drawing.Size(158, 51);
            this.tlačítkoProveď.TabIndex = 0;
            this.tlačítkoProveď.Text = "&Proveď";
            this.tlačítkoProveď.UseVisualStyleBackColor = false;
            this.tlačítkoProveď.Click += new System.EventHandler(this.tlačítkoProveď_Click);
            // 
            // poleČíslo
            // 
            this.poleČíslo.ForeColor = System.Drawing.Color.Purple;
            this.poleČíslo.Location = new System.Drawing.Point(93, 148);
            this.poleČíslo.Name = "poleČíslo";
            this.poleČíslo.ReadOnly = true;
            this.poleČíslo.Size = new System.Drawing.Size(158, 29);
            this.poleČíslo.TabIndex = 1;
            this.poleČíslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(345, 223);
            this.Controls.Add(this.poleČíslo);
            this.Controls.Add(this.tlačítkoProveď);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "57";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoProveď;
        private System.Windows.Forms.TextBox poleČíslo;
    }
}

