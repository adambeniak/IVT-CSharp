
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
            this.poleČíslo2 = new System.Windows.Forms.TextBox();
            this.poleČíslo1 = new System.Windows.Forms.TextBox();
            this.poleVýsledek = new System.Windows.Forms.TextBox();
            this.popisekPlus = new System.Windows.Forms.Label();
            this.tlačítkoRovnáSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleČíslo2.Location = new System.Drawing.Point(274, 73);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.Size = new System.Drawing.Size(179, 26);
            this.poleČíslo2.TabIndex = 2;
            this.poleČíslo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleČíslo1.Location = new System.Drawing.Point(30, 73);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(179, 26);
            this.poleČíslo1.TabIndex = 0;
            this.poleČíslo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleVýsledek
            // 
            this.poleVýsledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleVýsledek.Location = new System.Drawing.Point(613, 73);
            this.poleVýsledek.Name = "poleVýsledek";
            this.poleVýsledek.ReadOnly = true;
            this.poleVýsledek.Size = new System.Drawing.Size(179, 26);
            this.poleVýsledek.TabIndex = 4;
            this.poleVýsledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekPlus
            // 
            this.popisekPlus.AutoSize = true;
            this.popisekPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisekPlus.Location = new System.Drawing.Point(232, 76);
            this.popisekPlus.Name = "popisekPlus";
            this.popisekPlus.Size = new System.Drawing.Size(19, 20);
            this.popisekPlus.TabIndex = 1;
            this.popisekPlus.Text = "+";
            this.popisekPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlačítkoRovnáSe
            // 
            this.tlačítkoRovnáSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoRovnáSe.Location = new System.Drawing.Point(486, 73);
            this.tlačítkoRovnáSe.Name = "tlačítkoRovnáSe";
            this.tlačítkoRovnáSe.Size = new System.Drawing.Size(94, 26);
            this.tlačítkoRovnáSe.TabIndex = 3;
            this.tlačítkoRovnáSe.Text = "=";
            this.tlačítkoRovnáSe.UseVisualStyleBackColor = true;
            this.tlačítkoRovnáSe.Click += new System.EventHandler(this.tlačítkoRovnáSe_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoRovnáSe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 172);
            this.Controls.Add(this.tlačítkoRovnáSe);
            this.Controls.Add(this.popisekPlus);
            this.Controls.Add(this.poleVýsledek);
            this.Controls.Add(this.poleČíslo1);
            this.Controls.Add(this.poleČíslo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Sčítačka kombi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleVýsledek;
        private System.Windows.Forms.Label popisekPlus;
        private System.Windows.Forms.Button tlačítkoRovnáSe;
    }
}

