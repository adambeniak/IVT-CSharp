
namespace Výčet_TextAlign___já
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
            this.poleSTextem = new System.Windows.Forms.TextBox();
            this.tlačítkoDoleva = new System.Windows.Forms.Button();
            this.tlačítkoNaStřed = new System.Windows.Forms.Button();
            this.tlačítkoDoprava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleSTextem
            // 
            this.poleSTextem.Enabled = false;
            this.poleSTextem.ForeColor = System.Drawing.Color.Red;
            this.poleSTextem.Location = new System.Drawing.Point(12, 53);
            this.poleSTextem.Name = "poleSTextem";
            this.poleSTextem.Size = new System.Drawing.Size(399, 29);
            this.poleSTextem.TabIndex = 0;
            this.poleSTextem.Text = "Vodorovné zarovnání textu.";
            // 
            // tlačítkoDoleva
            // 
            this.tlačítkoDoleva.Location = new System.Drawing.Point(12, 129);
            this.tlačítkoDoleva.Name = "tlačítkoDoleva";
            this.tlačítkoDoleva.Size = new System.Drawing.Size(114, 32);
            this.tlačítkoDoleva.TabIndex = 1;
            this.tlačítkoDoleva.Text = "Do&leva";
            this.tlačítkoDoleva.UseVisualStyleBackColor = true;
            this.tlačítkoDoleva.Click += new System.EventHandler(this.tlačítkoDoleva_Click);
            // 
            // tlačítkoNaStřed
            // 
            this.tlačítkoNaStřed.Location = new System.Drawing.Point(154, 129);
            this.tlačítkoNaStřed.Name = "tlačítkoNaStřed";
            this.tlačítkoNaStřed.Size = new System.Drawing.Size(114, 32);
            this.tlačítkoNaStřed.TabIndex = 2;
            this.tlačítkoNaStřed.Text = "Na &střed";
            this.tlačítkoNaStřed.UseVisualStyleBackColor = true;
            this.tlačítkoNaStřed.Click += new System.EventHandler(this.tlačítkoNaStřed_Click);
            // 
            // tlačítkoDoprava
            // 
            this.tlačítkoDoprava.Location = new System.Drawing.Point(296, 129);
            this.tlačítkoDoprava.Name = "tlačítkoDoprava";
            this.tlačítkoDoprava.Size = new System.Drawing.Size(114, 32);
            this.tlačítkoDoprava.TabIndex = 3;
            this.tlačítkoDoprava.Text = "Do&prava";
            this.tlačítkoDoprava.UseVisualStyleBackColor = true;
            this.tlačítkoDoprava.Click += new System.EventHandler(this.tlačítkoDoprava_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 214);
            this.Controls.Add(this.tlačítkoDoprava);
            this.Controls.Add(this.tlačítkoNaStřed);
            this.Controls.Add(this.tlačítkoDoleva);
            this.Controls.Add(this.poleSTextem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výčet TextAlign - já";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleSTextem;
        private System.Windows.Forms.Button tlačítkoDoleva;
        private System.Windows.Forms.Button tlačítkoNaStřed;
        private System.Windows.Forms.Button tlačítkoDoprava;
    }
}

