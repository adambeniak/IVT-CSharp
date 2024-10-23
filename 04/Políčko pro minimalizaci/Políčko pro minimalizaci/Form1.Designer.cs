
namespace Políčko_pro_minimalizaci
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
            this.políčkoDovol = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // políčkoDovol
            // 
            this.políčkoDovol.AutoSize = true;
            this.políčkoDovol.Location = new System.Drawing.Point(88, 108);
            this.políčkoDovol.Name = "políčkoDovol";
            this.políčkoDovol.Size = new System.Drawing.Size(230, 28);
            this.políčkoDovol.TabIndex = 0;
            this.políčkoDovol.Text = "&Dovol minimalizaci";
            this.políčkoDovol.UseVisualStyleBackColor = true;
            this.políčkoDovol.CheckedChanged += new System.EventHandler(this.políčkoDovol_CheckedChanged);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(406, 244);
            this.Controls.Add(this.políčkoDovol);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Políčko pro minimalizaci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox políčkoDovol;
    }
}

