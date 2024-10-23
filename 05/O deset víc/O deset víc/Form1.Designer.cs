
namespace O_deset_víc
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
            this.poleČíslo1 = new System.Windows.Forms.TextBox();
            this.poleČíslo2 = new System.Windows.Forms.TextBox();
            this.popisekČíslo1 = new System.Windows.Forms.Label();
            this.popisekČíslo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Location = new System.Drawing.Point(223, 47);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(145, 29);
            this.poleČíslo1.TabIndex = 0;
            this.poleČíslo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleČíslo1.TextChanged += new System.EventHandler(this.poleČíslo1_TextChanged);
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Location = new System.Drawing.Point(223, 131);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.ReadOnly = true;
            this.poleČíslo2.Size = new System.Drawing.Size(145, 29);
            this.poleČíslo2.TabIndex = 1;
            this.poleČíslo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekČíslo1
            // 
            this.popisekČíslo1.AutoSize = true;
            this.popisekČíslo1.Location = new System.Drawing.Point(74, 50);
            this.popisekČíslo1.Name = "popisekČíslo1";
            this.popisekČíslo1.Size = new System.Drawing.Size(62, 24);
            this.popisekČíslo1.TabIndex = 2;
            this.popisekČíslo1.Text = "&Číslo:";
            // 
            // popisekČíslo2
            // 
            this.popisekČíslo2.AutoSize = true;
            this.popisekČíslo2.Location = new System.Drawing.Point(74, 134);
            this.popisekČíslo2.Name = "popisekČíslo2";
            this.popisekČíslo2.Size = new System.Drawing.Size(92, 24);
            this.popisekČíslo2.TabIndex = 3;
            this.popisekČíslo2.Text = "&O 10 víc:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 234);
            this.Controls.Add(this.popisekČíslo2);
            this.Controls.Add(this.popisekČíslo1);
            this.Controls.Add(this.poleČíslo2);
            this.Controls.Add(this.poleČíslo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "O deset víc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.Label popisekČíslo1;
        private System.Windows.Forms.Label popisekČíslo2;
    }
}

