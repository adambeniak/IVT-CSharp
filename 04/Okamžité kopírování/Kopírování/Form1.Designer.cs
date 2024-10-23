
namespace Kopírování
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
            this.poleVěta = new System.Windows.Forms.TextBox();
            this.poleKopie = new System.Windows.Forms.TextBox();
            this.popisekVěta = new System.Windows.Forms.Label();
            this.popisekKopie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleVěta
            // 
            this.poleVěta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.poleVěta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.poleVěta.Location = new System.Drawing.Point(117, 23);
            this.poleVěta.Multiline = true;
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.poleVěta.Size = new System.Drawing.Size(350, 70);
            this.poleVěta.TabIndex = 1;
            this.poleVěta.TextChanged += new System.EventHandler(this.poleVěta_TextChanged);
            // 
            // poleKopie
            // 
            this.poleKopie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poleKopie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.poleKopie.Location = new System.Drawing.Point(117, 116);
            this.poleKopie.Multiline = true;
            this.poleKopie.Name = "poleKopie";
            this.poleKopie.ReadOnly = true;
            this.poleKopie.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.poleKopie.Size = new System.Drawing.Size(350, 70);
            this.poleKopie.TabIndex = 3;
            // 
            // popisekVěta
            // 
            this.popisekVěta.AutoSize = true;
            this.popisekVěta.Location = new System.Drawing.Point(12, 23);
            this.popisekVěta.Name = "popisekVěta";
            this.popisekVěta.Size = new System.Drawing.Size(52, 20);
            this.popisekVěta.TabIndex = 0;
            this.popisekVěta.Text = "&Věta:";
            // 
            // popisekKopie
            // 
            this.popisekKopie.AutoSize = true;
            this.popisekKopie.Location = new System.Drawing.Point(12, 116);
            this.popisekKopie.Name = "popisekKopie";
            this.popisekKopie.Size = new System.Drawing.Size(89, 20);
            this.popisekKopie.TabIndex = 2;
            this.popisekKopie.Text = "&Její kopie:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(491, 206);
            this.Controls.Add(this.popisekKopie);
            this.Controls.Add(this.popisekVěta);
            this.Controls.Add(this.poleKopie);
            this.Controls.Add(this.poleVěta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Okamžité kopírování";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.TextBox poleKopie;
        private System.Windows.Forms.Label popisekVěta;
        private System.Windows.Forms.Label popisekKopie;
    }
}

