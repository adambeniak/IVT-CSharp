
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
            this.popisekPohlaví = new System.Windows.Forms.Label();
            this.knoflíkMuž = new System.Windows.Forms.RadioButton();
            this.knoflíkŽena = new System.Windows.Forms.RadioButton();
            this.tlačítkoOdešli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.Location = new System.Drawing.Point(31, 50);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(66, 23);
            this.popisekJméno.TabIndex = 0;
            this.popisekJméno.Text = "&Jméno:";
            // 
            // poleJméno
            // 
            this.poleJméno.Location = new System.Drawing.Point(103, 47);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(284, 31);
            this.poleJméno.TabIndex = 1;
            // 
            // popisekVěk
            // 
            this.popisekVěk.AutoSize = true;
            this.popisekVěk.Location = new System.Drawing.Point(31, 128);
            this.popisekVěk.Name = "popisekVěk";
            this.popisekVěk.Size = new System.Drawing.Size(44, 23);
            this.popisekVěk.TabIndex = 2;
            this.popisekVěk.Text = "&Věk:";
            // 
            // poleVěk
            // 
            this.poleVěk.Location = new System.Drawing.Point(103, 125);
            this.poleVěk.Name = "poleVěk";
            this.poleVěk.Size = new System.Drawing.Size(63, 31);
            this.poleVěk.TabIndex = 3;
            // 
            // popisekPohlaví
            // 
            this.popisekPohlaví.AutoSize = true;
            this.popisekPohlaví.Location = new System.Drawing.Point(31, 204);
            this.popisekPohlaví.Name = "popisekPohlaví";
            this.popisekPohlaví.Size = new System.Drawing.Size(73, 23);
            this.popisekPohlaví.TabIndex = 4;
            this.popisekPohlaví.Text = "Pohlaví:";
            // 
            // knoflíkMuž
            // 
            this.knoflíkMuž.AutoSize = true;
            this.knoflíkMuž.Location = new System.Drawing.Point(103, 230);
            this.knoflíkMuž.Name = "knoflíkMuž";
            this.knoflíkMuž.Size = new System.Drawing.Size(63, 27);
            this.knoflíkMuž.TabIndex = 5;
            this.knoflíkMuž.TabStop = true;
            this.knoflíkMuž.Text = "&Muž";
            this.knoflíkMuž.UseVisualStyleBackColor = true;
            // 
            // knoflíkŽena
            // 
            this.knoflíkŽena.AutoSize = true;
            this.knoflíkŽena.Location = new System.Drawing.Point(103, 263);
            this.knoflíkŽena.Name = "knoflíkŽena";
            this.knoflíkŽena.Size = new System.Drawing.Size(66, 27);
            this.knoflíkŽena.TabIndex = 6;
            this.knoflíkŽena.TabStop = true;
            this.knoflíkŽena.Text = "&Žena";
            this.knoflíkŽena.UseVisualStyleBackColor = true;
            // 
            // tlačítkoOdešli
            // 
            this.tlačítkoOdešli.Location = new System.Drawing.Point(35, 328);
            this.tlačítkoOdešli.Name = "tlačítkoOdešli";
            this.tlačítkoOdešli.Size = new System.Drawing.Size(352, 39);
            this.tlačítkoOdešli.TabIndex = 7;
            this.tlačítkoOdešli.Text = "&Odešli do databáze";
            this.tlačítkoOdešli.UseVisualStyleBackColor = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 417);
            this.Controls.Add(this.tlačítkoOdešli);
            this.Controls.Add(this.knoflíkŽena);
            this.Controls.Add(this.knoflíkMuž);
            this.Controls.Add(this.poleVěk);
            this.Controls.Add(this.poleJméno);
            this.Controls.Add(this.popisekPohlaví);
            this.Controls.Add(this.popisekVěk);
            this.Controls.Add(this.popisekJméno);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Přepínač";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.TextBox poleJméno;
        private System.Windows.Forms.Label popisekVěk;
        private System.Windows.Forms.TextBox poleVěk;
        private System.Windows.Forms.Label popisekPohlaví;
        private System.Windows.Forms.RadioButton knoflíkMuž;
        private System.Windows.Forms.RadioButton knoflíkŽena;
        private System.Windows.Forms.Button tlačítkoOdešli;
    }
}

