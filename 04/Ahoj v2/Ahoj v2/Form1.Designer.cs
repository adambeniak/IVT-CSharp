
namespace Ahoj_v2
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
            this.textovéPole = new System.Windows.Forms.TextBox();
            this.tlačítkoAhoj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textovéPole
            // 
            this.textovéPole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textovéPole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textovéPole.Location = new System.Drawing.Point(35, 72);
            this.textovéPole.Name = "textovéPole";
            this.textovéPole.Size = new System.Drawing.Size(247, 26);
            this.textovéPole.TabIndex = 0;
            // 
            // tlačítkoAhoj
            // 
            this.tlačítkoAhoj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlačítkoAhoj.ForeColor = System.Drawing.Color.Red;
            this.tlačítkoAhoj.Location = new System.Drawing.Point(340, 68);
            this.tlačítkoAhoj.Name = "tlačítkoAhoj";
            this.tlačítkoAhoj.Size = new System.Drawing.Size(130, 34);
            this.tlačítkoAhoj.TabIndex = 1;
            this.tlačítkoAhoj.Text = "&Ahoj";
            this.tlačítkoAhoj.UseVisualStyleBackColor = false;
            this.tlačítkoAhoj.Click += new System.EventHandler(this.tlačítkoAhoj_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 171);
            this.Controls.Add(this.tlačítkoAhoj);
            this.Controls.Add(this.textovéPole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Ahoj v2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textovéPole;
        private System.Windows.Forms.Button tlačítkoAhoj;
    }
}

