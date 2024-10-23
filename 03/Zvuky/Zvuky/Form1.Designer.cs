
namespace Zvuky
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
            this.tlačítkoZvuk1 = new System.Windows.Forms.Button();
            this.tlačítkoZvuk2 = new System.Windows.Forms.Button();
            this.tlačítkoZvuk3 = new System.Windows.Forms.Button();
            this.tlačítkoZvuk4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoZvuk1
            // 
            this.tlačítkoZvuk1.Location = new System.Drawing.Point(54, 30);
            this.tlačítkoZvuk1.Name = "tlačítkoZvuk1";
            this.tlačítkoZvuk1.Size = new System.Drawing.Size(228, 82);
            this.tlačítkoZvuk1.TabIndex = 0;
            this.tlačítkoZvuk1.Text = "&Asterisk";
            this.tlačítkoZvuk1.UseVisualStyleBackColor = true;
            this.tlačítkoZvuk1.Click += new System.EventHandler(this.tlačítkoZvuk1_Click);
            // 
            // tlačítkoZvuk2
            // 
            this.tlačítkoZvuk2.Location = new System.Drawing.Point(54, 151);
            this.tlačítkoZvuk2.Name = "tlačítkoZvuk2";
            this.tlačítkoZvuk2.Size = new System.Drawing.Size(228, 82);
            this.tlačítkoZvuk2.TabIndex = 1;
            this.tlačítkoZvuk2.Text = "&Beep";
            this.tlačítkoZvuk2.UseVisualStyleBackColor = true;
            this.tlačítkoZvuk2.Click += new System.EventHandler(this.tlačítkoZvuk2_Click);
            // 
            // tlačítkoZvuk3
            // 
            this.tlačítkoZvuk3.Location = new System.Drawing.Point(54, 269);
            this.tlačítkoZvuk3.Name = "tlačítkoZvuk3";
            this.tlačítkoZvuk3.Size = new System.Drawing.Size(228, 82);
            this.tlačítkoZvuk3.TabIndex = 2;
            this.tlačítkoZvuk3.Text = "&Exclamation";
            this.tlačítkoZvuk3.UseVisualStyleBackColor = true;
            this.tlačítkoZvuk3.Click += new System.EventHandler(this.tlačítkoZvuk3_Click);
            // 
            // tlačítkoZvuk4
            // 
            this.tlačítkoZvuk4.Location = new System.Drawing.Point(54, 395);
            this.tlačítkoZvuk4.Name = "tlačítkoZvuk4";
            this.tlačítkoZvuk4.Size = new System.Drawing.Size(228, 82);
            this.tlačítkoZvuk4.TabIndex = 3;
            this.tlačítkoZvuk4.Text = "&Hand";
            this.tlačítkoZvuk4.UseVisualStyleBackColor = true;
            this.tlačítkoZvuk4.Click += new System.EventHandler(this.tlačítkoZvuk4_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 506);
            this.Controls.Add(this.tlačítkoZvuk4);
            this.Controls.Add(this.tlačítkoZvuk3);
            this.Controls.Add(this.tlačítkoZvuk2);
            this.Controls.Add(this.tlačítkoZvuk1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Zvuky";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoZvuk1;
        private System.Windows.Forms.Button tlačítkoZvuk2;
        private System.Windows.Forms.Button tlačítkoZvuk3;
        private System.Windows.Forms.Button tlačítkoZvuk4;
    }
}

