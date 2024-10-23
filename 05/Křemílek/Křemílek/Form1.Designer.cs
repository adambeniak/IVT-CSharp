
namespace Křemílek
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
            this.poleVěta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tlačítkoProveď
            // 
            this.tlačítkoProveď.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlačítkoProveď.Location = new System.Drawing.Point(183, 48);
            this.tlačítkoProveď.Name = "tlačítkoProveď";
            this.tlačítkoProveď.Size = new System.Drawing.Size(122, 51);
            this.tlačítkoProveď.TabIndex = 0;
            this.tlačítkoProveď.Text = "&Proveď";
            this.tlačítkoProveď.UseVisualStyleBackColor = false;
            this.tlačítkoProveď.Click += new System.EventHandler(this.tlačítkoProveď_Click);
            // 
            // poleVěta
            // 
            this.poleVěta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.poleVěta.ForeColor = System.Drawing.Color.Red;
            this.poleVěta.Location = new System.Drawing.Point(75, 168);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.ReadOnly = true;
            this.poleVěta.Size = new System.Drawing.Size(339, 29);
            this.poleVěta.TabIndex = 1;
            this.poleVěta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(488, 257);
            this.Controls.Add(this.poleVěta);
            this.Controls.Add(this.tlačítkoProveď);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Křemílek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoProveď;
        private System.Windows.Forms.TextBox poleVěta;
    }
}

