
namespace Varianty_okna_se_zprávou
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
            this.tlačítko1 = new System.Windows.Forms.Button();
            this.tlačítko2 = new System.Windows.Forms.Button();
            this.tlačítko3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítko1
            // 
            this.tlačítko1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlačítko1.FlatAppearance.BorderSize = 5;
            this.tlačítko1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.tlačítko1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.tlačítko1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tlačítko1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítko1.ForeColor = System.Drawing.Color.DarkRed;
            this.tlačítko1.Location = new System.Drawing.Point(67, 54);
            this.tlačítko1.Name = "tlačítko1";
            this.tlačítko1.Size = new System.Drawing.Size(197, 57);
            this.tlačítko1.TabIndex = 0;
            this.tlačítko1.Text = "tlačítko1";
            this.tlačítko1.UseVisualStyleBackColor = false;
            this.tlačítko1.Click += new System.EventHandler(this.tlačítko1_Click);
            // 
            // tlačítko2
            // 
            this.tlačítko2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlačítko2.FlatAppearance.BorderSize = 5;
            this.tlačítko2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.tlačítko2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.tlačítko2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tlačítko2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítko2.ForeColor = System.Drawing.Color.DarkRed;
            this.tlačítko2.Location = new System.Drawing.Point(69, 135);
            this.tlačítko2.Name = "tlačítko2";
            this.tlačítko2.Size = new System.Drawing.Size(197, 57);
            this.tlačítko2.TabIndex = 1;
            this.tlačítko2.Text = "tlačítko2";
            this.tlačítko2.UseVisualStyleBackColor = false;
            this.tlačítko2.Click += new System.EventHandler(this.tlačítko2_Click);
            // 
            // tlačítko3
            // 
            this.tlačítko3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlačítko3.FlatAppearance.BorderSize = 5;
            this.tlačítko3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.tlačítko3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.tlačítko3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tlačítko3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítko3.ForeColor = System.Drawing.Color.DarkRed;
            this.tlačítko3.Location = new System.Drawing.Point(69, 230);
            this.tlačítko3.Name = "tlačítko3";
            this.tlačítko3.Size = new System.Drawing.Size(197, 57);
            this.tlačítko3.TabIndex = 2;
            this.tlačítko3.Text = "tlačítko3";
            this.tlačítko3.UseVisualStyleBackColor = false;
            this.tlačítko3.Click += new System.EventHandler(this.tlačítko3_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(333, 341);
            this.Controls.Add(this.tlačítko3);
            this.Controls.Add(this.tlačítko2);
            this.Controls.Add(this.tlačítko1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Varianty okna se zprávou";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítko1;
        private System.Windows.Forms.Button tlačítko2;
        private System.Windows.Forms.Button tlačítko3;
    }
}

