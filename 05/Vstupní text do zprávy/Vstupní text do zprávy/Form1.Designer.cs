
namespace Vstupní_text_do_zprávy
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
            this.tlačítkoZopakuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleVěta
            // 
            this.poleVěta.ForeColor = System.Drawing.Color.Blue;
            this.poleVěta.Location = new System.Drawing.Point(50, 35);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.Size = new System.Drawing.Size(455, 29);
            this.poleVěta.TabIndex = 0;
            // 
            // tlačítkoZopakuj
            // 
            this.tlačítkoZopakuj.Location = new System.Drawing.Point(164, 101);
            this.tlačítkoZopakuj.Name = "tlačítkoZopakuj";
            this.tlačítkoZopakuj.Size = new System.Drawing.Size(227, 35);
            this.tlačítkoZopakuj.TabIndex = 1;
            this.tlačítkoZopakuj.Text = "&Zopakuj do zprávy";
            this.tlačítkoZopakuj.UseVisualStyleBackColor = true;
            this.tlačítkoZopakuj.Click += new System.EventHandler(this.tlačítkoZopakuj_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 148);
            this.Controls.Add(this.tlačítkoZopakuj);
            this.Controls.Add(this.poleVěta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Vstupní text do zprávy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.Button tlačítkoZopakuj;
    }
}

