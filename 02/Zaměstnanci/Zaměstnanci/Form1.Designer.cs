
namespace Zaměstnanci
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
            this.popisekZaměstnanec = new System.Windows.Forms.Label();
            this.poleZaměstnanec = new System.Windows.Forms.TextBox();
            this.polePlat = new System.Windows.Forms.TextBox();
            this.popisekPlat = new System.Windows.Forms.Label();
            this.popisekKč = new System.Windows.Forms.Label();
            this.políčkoNaDobuNeurčitou = new System.Windows.Forms.CheckBox();
            this.tlačítkoOdeslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekZaměstnanec
            // 
            this.popisekZaměstnanec.AutoSize = true;
            this.popisekZaměstnanec.Location = new System.Drawing.Point(67, 45);
            this.popisekZaměstnanec.Name = "popisekZaměstnanec";
            this.popisekZaměstnanec.Size = new System.Drawing.Size(149, 25);
            this.popisekZaměstnanec.TabIndex = 0;
            this.popisekZaměstnanec.Text = "&Zaměstnanec:";
            // 
            // poleZaměstnanec
            // 
            this.poleZaměstnanec.BackColor = System.Drawing.SystemColors.Info;
            this.poleZaměstnanec.Location = new System.Drawing.Point(206, 42);
            this.poleZaměstnanec.Name = "poleZaměstnanec";
            this.poleZaměstnanec.Size = new System.Drawing.Size(355, 30);
            this.poleZaměstnanec.TabIndex = 1;
            // 
            // polePlat
            // 
            this.polePlat.BackColor = System.Drawing.SystemColors.Info;
            this.polePlat.Location = new System.Drawing.Point(206, 99);
            this.polePlat.Name = "polePlat";
            this.polePlat.Size = new System.Drawing.Size(320, 30);
            this.polePlat.TabIndex = 3;
            this.polePlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekPlat
            // 
            this.popisekPlat.AutoSize = true;
            this.popisekPlat.Location = new System.Drawing.Point(67, 102);
            this.popisekPlat.Name = "popisekPlat";
            this.popisekPlat.Size = new System.Drawing.Size(56, 25);
            this.popisekPlat.TabIndex = 2;
            this.popisekPlat.Text = "&Plat:";
            // 
            // popisekKč
            // 
            this.popisekKč.AutoSize = true;
            this.popisekKč.Location = new System.Drawing.Point(532, 102);
            this.popisekKč.Name = "popisekKč";
            this.popisekKč.Size = new System.Drawing.Size(38, 25);
            this.popisekKč.TabIndex = 4;
            this.popisekKč.Text = "Kč";
            // 
            // políčkoNaDobuNeurčitou
            // 
            this.políčkoNaDobuNeurčitou.AutoSize = true;
            this.políčkoNaDobuNeurčitou.Location = new System.Drawing.Point(71, 155);
            this.políčkoNaDobuNeurčitou.Name = "políčkoNaDobuNeurčitou";
            this.políčkoNaDobuNeurčitou.Size = new System.Drawing.Size(210, 29);
            this.políčkoNaDobuNeurčitou.TabIndex = 5;
            this.políčkoNaDobuNeurčitou.Text = "&Na dobu neurčitou";
            this.políčkoNaDobuNeurčitou.UseVisualStyleBackColor = true;
            // 
            // tlačítkoOdeslat
            // 
            this.tlačítkoOdeslat.BackColor = System.Drawing.Color.Plum;
            this.tlačítkoOdeslat.Location = new System.Drawing.Point(168, 202);
            this.tlačítkoOdeslat.Name = "tlačítkoOdeslat";
            this.tlačítkoOdeslat.Size = new System.Drawing.Size(292, 40);
            this.tlačítkoOdeslat.TabIndex = 6;
            this.tlačítkoOdeslat.Text = "&Odeslat do databáze";
            this.tlačítkoOdeslat.UseVisualStyleBackColor = false;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(628, 279);
            this.Controls.Add(this.tlačítkoOdeslat);
            this.Controls.Add(this.políčkoNaDobuNeurčitou);
            this.Controls.Add(this.popisekKč);
            this.Controls.Add(this.polePlat);
            this.Controls.Add(this.popisekPlat);
            this.Controls.Add(this.poleZaměstnanec);
            this.Controls.Add(this.popisekZaměstnanec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Zaměstnanci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekZaměstnanec;
        private System.Windows.Forms.TextBox poleZaměstnanec;
        private System.Windows.Forms.TextBox polePlat;
        private System.Windows.Forms.Label popisekPlat;
        private System.Windows.Forms.Label popisekKč;
        private System.Windows.Forms.CheckBox políčkoNaDobuNeurčitou;
        private System.Windows.Forms.Button tlačítkoOdeslat;
    }
}

