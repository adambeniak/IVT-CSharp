
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
            this.tlačítkoKopíruj = new System.Windows.Forms.Button();
            this.tlačítkoVymaž = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleVěta
            // 
            this.poleVěta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.poleVěta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.poleVěta.Location = new System.Drawing.Point(201, 50);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.Size = new System.Drawing.Size(352, 26);
            this.poleVěta.TabIndex = 1;
            // 
            // poleKopie
            // 
            this.poleKopie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poleKopie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.poleKopie.Location = new System.Drawing.Point(201, 137);
            this.poleKopie.Name = "poleKopie";
            this.poleKopie.ReadOnly = true;
            this.poleKopie.Size = new System.Drawing.Size(352, 26);
            this.poleKopie.TabIndex = 3;
            // 
            // popisekVěta
            // 
            this.popisekVěta.AutoSize = true;
            this.popisekVěta.Location = new System.Drawing.Point(53, 50);
            this.popisekVěta.Name = "popisekVěta";
            this.popisekVěta.Size = new System.Drawing.Size(52, 20);
            this.popisekVěta.TabIndex = 0;
            this.popisekVěta.Text = "&Věta:";
            // 
            // popisekKopie
            // 
            this.popisekKopie.AutoSize = true;
            this.popisekKopie.Location = new System.Drawing.Point(53, 137);
            this.popisekKopie.Name = "popisekKopie";
            this.popisekKopie.Size = new System.Drawing.Size(89, 20);
            this.popisekKopie.TabIndex = 2;
            this.popisekKopie.Text = "&Její kopie:";
            // 
            // tlačítkoKopíruj
            // 
            this.tlačítkoKopíruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tlačítkoKopíruj.Location = new System.Drawing.Point(201, 219);
            this.tlačítkoKopíruj.Name = "tlačítkoKopíruj";
            this.tlačítkoKopíruj.Size = new System.Drawing.Size(98, 40);
            this.tlačítkoKopíruj.TabIndex = 4;
            this.tlačítkoKopíruj.Text = "&Kopíruj";
            this.tlačítkoKopíruj.UseVisualStyleBackColor = false;
            this.tlačítkoKopíruj.Click += new System.EventHandler(this.tlačítkoKopíruj_Click);
            // 
            // tlačítkoVymaž
            // 
            this.tlačítkoVymaž.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tlačítkoVymaž.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tlačítkoVymaž.Location = new System.Drawing.Point(455, 219);
            this.tlačítkoVymaž.Name = "tlačítkoVymaž";
            this.tlačítkoVymaž.Size = new System.Drawing.Size(98, 40);
            this.tlačítkoVymaž.TabIndex = 5;
            this.tlačítkoVymaž.Text = "Vy&maž";
            this.tlačítkoVymaž.UseVisualStyleBackColor = false;
            this.tlačítkoVymaž.Click += new System.EventHandler(this.tlačítkoVymaž_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoKopíruj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.CancelButton = this.tlačítkoVymaž;
            this.ClientSize = new System.Drawing.Size(613, 297);
            this.Controls.Add(this.tlačítkoVymaž);
            this.Controls.Add(this.tlačítkoKopíruj);
            this.Controls.Add(this.popisekKopie);
            this.Controls.Add(this.popisekVěta);
            this.Controls.Add(this.poleKopie);
            this.Controls.Add(this.poleVěta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Implicitní a stornovací tlačítko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.TextBox poleKopie;
        private System.Windows.Forms.Label popisekVěta;
        private System.Windows.Forms.Label popisekKopie;
        private System.Windows.Forms.Button tlačítkoKopíruj;
        private System.Windows.Forms.Button tlačítkoVymaž;
    }
}

