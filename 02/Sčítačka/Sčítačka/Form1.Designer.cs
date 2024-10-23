
namespace Sčítačka
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
            this.poleVýsledek = new System.Windows.Forms.TextBox();
            this.popisekPlus = new System.Windows.Forms.Label();
            this.tlačítkoRovnáSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Location = new System.Drawing.Point(47, 87);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(100, 26);
            this.poleČíslo1.TabIndex = 0;
            this.poleČíslo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Location = new System.Drawing.Point(214, 87);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.Size = new System.Drawing.Size(100, 26);
            this.poleČíslo2.TabIndex = 2;
            this.poleČíslo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleVýsledek
            // 
            this.poleVýsledek.Location = new System.Drawing.Point(481, 87);
            this.poleVýsledek.Name = "poleVýsledek";
            this.poleVýsledek.ReadOnly = true;
            this.poleVýsledek.Size = new System.Drawing.Size(159, 26);
            this.poleVýsledek.TabIndex = 4;
            this.poleVýsledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekPlus
            // 
            this.popisekPlus.AutoSize = true;
            this.popisekPlus.Location = new System.Drawing.Point(171, 90);
            this.popisekPlus.Name = "popisekPlus";
            this.popisekPlus.Size = new System.Drawing.Size(19, 20);
            this.popisekPlus.TabIndex = 1;
            this.popisekPlus.Text = "+";
            // 
            // tlačítkoRovnáSe
            // 
            this.tlačítkoRovnáSe.Location = new System.Drawing.Point(348, 87);
            this.tlačítkoRovnáSe.Name = "tlačítkoRovnáSe";
            this.tlačítkoRovnáSe.Size = new System.Drawing.Size(99, 26);
            this.tlačítkoRovnáSe.TabIndex = 3;
            this.tlačítkoRovnáSe.Text = "=";
            this.tlačítkoRovnáSe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlačítkoRovnáSe.UseVisualStyleBackColor = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 200);
            this.Controls.Add(this.tlačítkoRovnáSe);
            this.Controls.Add(this.popisekPlus);
            this.Controls.Add(this.poleVýsledek);
            this.Controls.Add(this.poleČíslo2);
            this.Controls.Add(this.poleČíslo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Sčítačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.TextBox poleVýsledek;
        private System.Windows.Forms.Label popisekPlus;
        private System.Windows.Forms.Button tlačítkoRovnáSe;
    }
}

