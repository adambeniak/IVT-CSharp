
namespace Jiné_zaškrtávání
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
            this.políčkoJsemSpokojen = new System.Windows.Forms.CheckBox();
            this.tlačítkoZaškrtni = new System.Windows.Forms.Button();
            this.tlačítkoZruš = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // políčkoJsemSpokojen
            // 
            this.políčkoJsemSpokojen.AutoSize = true;
            this.políčkoJsemSpokojen.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.políčkoJsemSpokojen.Location = new System.Drawing.Point(121, 74);
            this.políčkoJsemSpokojen.Name = "políčkoJsemSpokojen";
            this.políčkoJsemSpokojen.Size = new System.Drawing.Size(271, 38);
            this.políčkoJsemSpokojen.TabIndex = 0;
            this.políčkoJsemSpokojen.Text = "&Jsem spokojen(a)";
            this.políčkoJsemSpokojen.UseVisualStyleBackColor = true;
            // 
            // tlačítkoZaškrtni
            // 
            this.tlačítkoZaškrtni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tlačítkoZaškrtni.ForeColor = System.Drawing.Color.Black;
            this.tlačítkoZaškrtni.Location = new System.Drawing.Point(12, 183);
            this.tlačítkoZaškrtni.Name = "tlačítkoZaškrtni";
            this.tlačítkoZaškrtni.Size = new System.Drawing.Size(212, 84);
            this.tlačítkoZaškrtni.TabIndex = 1;
            this.tlačítkoZaškrtni.Text = "&Zaškrtni";
            this.tlačítkoZaškrtni.UseVisualStyleBackColor = false;
            this.tlačítkoZaškrtni.Click += new System.EventHandler(this.tlačítkoZaškrtni_Click);
            // 
            // tlačítkoZruš
            // 
            this.tlačítkoZruš.BackColor = System.Drawing.Color.Red;
            this.tlačítkoZruš.ForeColor = System.Drawing.Color.Black;
            this.tlačítkoZruš.Location = new System.Drawing.Point(289, 183);
            this.tlačítkoZruš.Name = "tlačítkoZruš";
            this.tlačítkoZruš.Size = new System.Drawing.Size(212, 84);
            this.tlačítkoZruš.TabIndex = 2;
            this.tlačítkoZruš.Text = "Z&ruš zaškrtnutí";
            this.tlačítkoZruš.UseVisualStyleBackColor = false;
            this.tlačítkoZruš.Click += new System.EventHandler(this.tlačítkoZruš_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 352);
            this.Controls.Add(this.tlačítkoZruš);
            this.Controls.Add(this.tlačítkoZaškrtni);
            this.Controls.Add(this.políčkoJsemSpokojen);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Jiné zaškrtávání";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox políčkoJsemSpokojen;
        private System.Windows.Forms.Button tlačítkoZaškrtni;
        private System.Windows.Forms.Button tlačítkoZruš;
    }
}

