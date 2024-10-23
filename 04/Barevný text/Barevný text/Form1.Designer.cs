
namespace Barevný_text
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
            this.poleText = new System.Windows.Forms.TextBox();
            this.tlačítko1 = new System.Windows.Forms.Button();
            this.tlačítko2 = new System.Windows.Forms.Button();
            this.tlačítko3 = new System.Windows.Forms.Button();
            this.tlačítko4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleText
            // 
            this.poleText.Location = new System.Drawing.Point(45, 47);
            this.poleText.Name = "poleText";
            this.poleText.Size = new System.Drawing.Size(457, 26);
            this.poleText.TabIndex = 0;
            this.poleText.Text = "Barevný text";
            this.poleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlačítko1
            // 
            this.tlačítko1.BackColor = System.Drawing.Color.Red;
            this.tlačítko1.Location = new System.Drawing.Point(45, 120);
            this.tlačítko1.Name = "tlačítko1";
            this.tlačítko1.Size = new System.Drawing.Size(158, 46);
            this.tlačítko1.TabIndex = 1;
            this.tlačítko1.Text = "1. barva";
            this.tlačítko1.UseVisualStyleBackColor = false;
            this.tlačítko1.Click += new System.EventHandler(this.tlačítko1_Click);
            // 
            // tlačítko2
            // 
            this.tlačítko2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tlačítko2.Location = new System.Drawing.Point(344, 120);
            this.tlačítko2.Name = "tlačítko2";
            this.tlačítko2.Size = new System.Drawing.Size(158, 46);
            this.tlačítko2.TabIndex = 2;
            this.tlačítko2.Text = "2. barva";
            this.tlačítko2.UseVisualStyleBackColor = false;
            this.tlačítko2.Click += new System.EventHandler(this.tlačítko2_Click);
            // 
            // tlačítko3
            // 
            this.tlačítko3.BackColor = System.Drawing.Color.Lime;
            this.tlačítko3.Location = new System.Drawing.Point(45, 212);
            this.tlačítko3.Name = "tlačítko3";
            this.tlačítko3.Size = new System.Drawing.Size(158, 46);
            this.tlačítko3.TabIndex = 3;
            this.tlačítko3.Text = "3. barva";
            this.tlačítko3.UseVisualStyleBackColor = false;
            this.tlačítko3.Click += new System.EventHandler(this.tlačítko3_Click);
            // 
            // tlačítko4
            // 
            this.tlačítko4.BackColor = System.Drawing.Color.Fuchsia;
            this.tlačítko4.Location = new System.Drawing.Point(344, 212);
            this.tlačítko4.Name = "tlačítko4";
            this.tlačítko4.Size = new System.Drawing.Size(158, 46);
            this.tlačítko4.TabIndex = 4;
            this.tlačítko4.Text = "4. barva";
            this.tlačítko4.UseVisualStyleBackColor = false;
            this.tlačítko4.Click += new System.EventHandler(this.tlačítko4_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 304);
            this.Controls.Add(this.tlačítko4);
            this.Controls.Add(this.tlačítko3);
            this.Controls.Add(this.tlačítko2);
            this.Controls.Add(this.tlačítko1);
            this.Controls.Add(this.poleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Barevný text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleText;
        private System.Windows.Forms.Button tlačítko1;
        private System.Windows.Forms.Button tlačítko2;
        private System.Windows.Forms.Button tlačítko3;
        private System.Windows.Forms.Button tlačítko4;
    }
}

