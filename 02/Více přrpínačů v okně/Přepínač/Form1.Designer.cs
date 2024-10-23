
namespace Přepínač
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
            this.popisekJméno = new System.Windows.Forms.Label();
            this.poleJméno = new System.Windows.Forms.TextBox();
            this.popisekVěk = new System.Windows.Forms.Label();
            this.poleVěk = new System.Windows.Forms.TextBox();
            this.knoflíkMuž = new System.Windows.Forms.RadioButton();
            this.knoflíkŽena = new System.Windows.Forms.RadioButton();
            this.tlačítkoOdešli = new System.Windows.Forms.Button();
            this.skupinaPohlaví = new System.Windows.Forms.GroupBox();
            this.skupinaStav = new System.Windows.Forms.GroupBox();
            this.knoflíkSvobodný = new System.Windows.Forms.RadioButton();
            this.knoflíkŽenatý = new System.Windows.Forms.RadioButton();
            this.knoflíkVdovec = new System.Windows.Forms.RadioButton();
            this.knoflíkRozvedený = new System.Windows.Forms.RadioButton();
            this.skupinaPohlaví.SuspendLayout();
            this.skupinaStav.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.Location = new System.Drawing.Point(31, 35);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(66, 23);
            this.popisekJméno.TabIndex = 0;
            this.popisekJméno.Text = "&Jméno:";
            // 
            // poleJméno
            // 
            this.poleJméno.Location = new System.Drawing.Point(103, 32);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(284, 31);
            this.poleJméno.TabIndex = 1;
            // 
            // popisekVěk
            // 
            this.popisekVěk.AutoSize = true;
            this.popisekVěk.Location = new System.Drawing.Point(31, 98);
            this.popisekVěk.Name = "popisekVěk";
            this.popisekVěk.Size = new System.Drawing.Size(44, 23);
            this.popisekVěk.TabIndex = 2;
            this.popisekVěk.Text = "&Věk:";
            // 
            // poleVěk
            // 
            this.poleVěk.Location = new System.Drawing.Point(103, 95);
            this.poleVěk.Name = "poleVěk";
            this.poleVěk.Size = new System.Drawing.Size(63, 31);
            this.poleVěk.TabIndex = 3;
            // 
            // knoflíkMuž
            // 
            this.knoflíkMuž.AutoSize = true;
            this.knoflíkMuž.Location = new System.Drawing.Point(23, 30);
            this.knoflíkMuž.Name = "knoflíkMuž";
            this.knoflíkMuž.Size = new System.Drawing.Size(63, 27);
            this.knoflíkMuž.TabIndex = 0;
            this.knoflíkMuž.TabStop = true;
            this.knoflíkMuž.Text = "&Muž";
            this.knoflíkMuž.UseVisualStyleBackColor = true;
            // 
            // knoflíkŽena
            // 
            this.knoflíkŽena.AutoSize = true;
            this.knoflíkŽena.Location = new System.Drawing.Point(23, 63);
            this.knoflíkŽena.Name = "knoflíkŽena";
            this.knoflíkŽena.Size = new System.Drawing.Size(66, 27);
            this.knoflíkŽena.TabIndex = 1;
            this.knoflíkŽena.TabStop = true;
            this.knoflíkŽena.Text = "&Žena";
            this.knoflíkŽena.UseVisualStyleBackColor = true;
            // 
            // tlačítkoOdešli
            // 
            this.tlačítkoOdešli.Location = new System.Drawing.Point(35, 361);
            this.tlačítkoOdešli.Name = "tlačítkoOdešli";
            this.tlačítkoOdešli.Size = new System.Drawing.Size(352, 39);
            this.tlačítkoOdešli.TabIndex = 6;
            this.tlačítkoOdešli.Text = "&Odešli do databáze";
            this.tlačítkoOdešli.UseVisualStyleBackColor = true;
            // 
            // skupinaPohlaví
            // 
            this.skupinaPohlaví.Controls.Add(this.knoflíkMuž);
            this.skupinaPohlaví.Controls.Add(this.knoflíkŽena);
            this.skupinaPohlaví.Location = new System.Drawing.Point(35, 173);
            this.skupinaPohlaví.Name = "skupinaPohlaví";
            this.skupinaPohlaví.Size = new System.Drawing.Size(110, 100);
            this.skupinaPohlaví.TabIndex = 4;
            this.skupinaPohlaví.TabStop = false;
            this.skupinaPohlaví.Text = "Pohlaví";
            // 
            // skupinaStav
            // 
            this.skupinaStav.Controls.Add(this.knoflíkRozvedený);
            this.skupinaStav.Controls.Add(this.knoflíkSvobodný);
            this.skupinaStav.Controls.Add(this.knoflíkVdovec);
            this.skupinaStav.Controls.Add(this.knoflíkŽenatý);
            this.skupinaStav.Location = new System.Drawing.Point(170, 173);
            this.skupinaStav.Name = "skupinaStav";
            this.skupinaStav.Size = new System.Drawing.Size(217, 159);
            this.skupinaStav.TabIndex = 5;
            this.skupinaStav.TabStop = false;
            this.skupinaStav.Text = "Rodinný stav";
            // 
            // knoflíkSvobodný
            // 
            this.knoflíkSvobodný.AutoSize = true;
            this.knoflíkSvobodný.Location = new System.Drawing.Point(28, 30);
            this.knoflíkSvobodný.Name = "knoflíkSvobodný";
            this.knoflíkSvobodný.Size = new System.Drawing.Size(128, 27);
            this.knoflíkSvobodný.TabIndex = 0;
            this.knoflíkSvobodný.TabStop = true;
            this.knoflíkSvobodný.Text = "&Svobodný/-á";
            this.knoflíkSvobodný.UseVisualStyleBackColor = true;
            // 
            // knoflíkŽenatý
            // 
            this.knoflíkŽenatý.AutoSize = true;
            this.knoflíkŽenatý.Location = new System.Drawing.Point(28, 63);
            this.knoflíkŽenatý.Name = "knoflíkŽenatý";
            this.knoflíkŽenatý.Size = new System.Drawing.Size(137, 27);
            this.knoflíkŽenatý.TabIndex = 1;
            this.knoflíkŽenatý.TabStop = true;
            this.knoflíkŽenatý.Text = "Ž&enatý/vdaná";
            this.knoflíkŽenatý.UseVisualStyleBackColor = true;
            // 
            // knoflíkVdovec
            // 
            this.knoflíkVdovec.AutoSize = true;
            this.knoflíkVdovec.Location = new System.Drawing.Point(28, 129);
            this.knoflíkVdovec.Name = "knoflíkVdovec";
            this.knoflíkVdovec.Size = new System.Drawing.Size(140, 27);
            this.knoflíkVdovec.TabIndex = 3;
            this.knoflíkVdovec.TabStop = true;
            this.knoflíkVdovec.Text = "V&dovec/vdova";
            this.knoflíkVdovec.UseVisualStyleBackColor = true;
            // 
            // knoflíkRozvedený
            // 
            this.knoflíkRozvedený.AutoSize = true;
            this.knoflíkRozvedený.Location = new System.Drawing.Point(28, 96);
            this.knoflíkRozvedený.Name = "knoflíkRozvedený";
            this.knoflíkRozvedený.Size = new System.Drawing.Size(138, 27);
            this.knoflíkRozvedený.TabIndex = 2;
            this.knoflíkRozvedený.TabStop = true;
            this.knoflíkRozvedený.Text = "&Rozvedený/-á";
            this.knoflíkRozvedený.UseVisualStyleBackColor = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 432);
            this.Controls.Add(this.skupinaStav);
            this.Controls.Add(this.skupinaPohlaví);
            this.Controls.Add(this.tlačítkoOdešli);
            this.Controls.Add(this.poleVěk);
            this.Controls.Add(this.poleJméno);
            this.Controls.Add(this.popisekVěk);
            this.Controls.Add(this.popisekJméno);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Více přepínačů v okně";
            this.skupinaPohlaví.ResumeLayout(false);
            this.skupinaPohlaví.PerformLayout();
            this.skupinaStav.ResumeLayout(false);
            this.skupinaStav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.TextBox poleJméno;
        private System.Windows.Forms.Label popisekVěk;
        private System.Windows.Forms.TextBox poleVěk;
        private System.Windows.Forms.RadioButton knoflíkMuž;
        private System.Windows.Forms.RadioButton knoflíkŽena;
        private System.Windows.Forms.Button tlačítkoOdešli;
        private System.Windows.Forms.GroupBox skupinaPohlaví;
        private System.Windows.Forms.GroupBox skupinaStav;
        private System.Windows.Forms.RadioButton knoflíkRozvedený;
        private System.Windows.Forms.RadioButton knoflíkSvobodný;
        private System.Windows.Forms.RadioButton knoflíkVdovec;
        private System.Windows.Forms.RadioButton knoflíkŽenatý;
    }
}

