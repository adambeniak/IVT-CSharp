
namespace Kontextově_závislý_přepínač
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
            this.popisekZboží = new System.Windows.Forms.Label();
            this.poleZboží = new System.Windows.Forms.TextBox();
            this.popisekAdresa = new System.Windows.Forms.Label();
            this.poleAdresa = new System.Windows.Forms.TextBox();
            this.políčkoSleva = new System.Windows.Forms.CheckBox();
            this.přepínačDruhSlevy = new System.Windows.Forms.GroupBox();
            this.knoflíkDůchodce = new System.Windows.Forms.RadioButton();
            this.knoflíkUčitel = new System.Windows.Forms.RadioButton();
            this.knoflíkStudent = new System.Windows.Forms.RadioButton();
            this.tlačítkoOdeslat = new System.Windows.Forms.Button();
            this.přepínačDruhSlevy.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisekZboží
            // 
            this.popisekZboží.AutoSize = true;
            this.popisekZboží.Location = new System.Drawing.Point(13, 67);
            this.popisekZboží.Name = "popisekZboží";
            this.popisekZboží.Size = new System.Drawing.Size(68, 24);
            this.popisekZboží.TabIndex = 0;
            this.popisekZboží.Text = "&Zboží:";
            // 
            // poleZboží
            // 
            this.poleZboží.Location = new System.Drawing.Point(169, 64);
            this.poleZboží.Name = "poleZboží";
            this.poleZboží.Size = new System.Drawing.Size(325, 29);
            this.poleZboží.TabIndex = 1;
            // 
            // popisekAdresa
            // 
            this.popisekAdresa.AutoSize = true;
            this.popisekAdresa.Location = new System.Drawing.Point(13, 140);
            this.popisekAdresa.Name = "popisekAdresa";
            this.popisekAdresa.Size = new System.Drawing.Size(150, 24);
            this.popisekAdresa.TabIndex = 2;
            this.popisekAdresa.Text = "&Dodací adresa:";
            // 
            // poleAdresa
            // 
            this.poleAdresa.Location = new System.Drawing.Point(169, 137);
            this.poleAdresa.Name = "poleAdresa";
            this.poleAdresa.Size = new System.Drawing.Size(325, 29);
            this.poleAdresa.TabIndex = 3;
            // 
            // políčkoSleva
            // 
            this.políčkoSleva.AutoSize = true;
            this.políčkoSleva.Location = new System.Drawing.Point(17, 232);
            this.políčkoSleva.Name = "políčkoSleva";
            this.políčkoSleva.Size = new System.Drawing.Size(80, 28);
            this.políčkoSleva.TabIndex = 4;
            this.políčkoSleva.Text = "&Sleva";
            this.políčkoSleva.UseVisualStyleBackColor = true;
            this.políčkoSleva.CheckedChanged += new System.EventHandler(this.políčkoSleva_CheckedChanged);
            // 
            // přepínačDruhSlevy
            // 
            this.přepínačDruhSlevy.Controls.Add(this.knoflíkDůchodce);
            this.přepínačDruhSlevy.Controls.Add(this.knoflíkUčitel);
            this.přepínačDruhSlevy.Controls.Add(this.knoflíkStudent);
            this.přepínačDruhSlevy.Enabled = false;
            this.přepínačDruhSlevy.Location = new System.Drawing.Point(169, 232);
            this.přepínačDruhSlevy.Name = "přepínačDruhSlevy";
            this.přepínačDruhSlevy.Size = new System.Drawing.Size(169, 154);
            this.přepínačDruhSlevy.TabIndex = 5;
            this.přepínačDruhSlevy.TabStop = false;
            this.přepínačDruhSlevy.Text = "Druh slevy";
            // 
            // knoflíkDůchodce
            // 
            this.knoflíkDůchodce.AutoSize = true;
            this.knoflíkDůchodce.Location = new System.Drawing.Point(6, 113);
            this.knoflíkDůchodce.Name = "knoflíkDůchodce";
            this.knoflíkDůchodce.Size = new System.Drawing.Size(124, 28);
            this.knoflíkDůchodce.TabIndex = 2;
            this.knoflíkDůchodce.TabStop = true;
            this.knoflíkDůchodce.Text = "&Důchodce";
            this.knoflíkDůchodce.UseVisualStyleBackColor = true;
            // 
            // knoflíkUčitel
            // 
            this.knoflíkUčitel.AutoSize = true;
            this.knoflíkUčitel.Location = new System.Drawing.Point(6, 79);
            this.knoflíkUčitel.Name = "knoflíkUčitel";
            this.knoflíkUčitel.Size = new System.Drawing.Size(80, 28);
            this.knoflíkUčitel.TabIndex = 1;
            this.knoflíkUčitel.TabStop = true;
            this.knoflíkUčitel.Text = "&Učitel";
            this.knoflíkUčitel.UseVisualStyleBackColor = true;
            // 
            // knoflíkStudent
            // 
            this.knoflíkStudent.AutoSize = true;
            this.knoflíkStudent.Location = new System.Drawing.Point(6, 45);
            this.knoflíkStudent.Name = "knoflíkStudent";
            this.knoflíkStudent.Size = new System.Drawing.Size(99, 28);
            this.knoflíkStudent.TabIndex = 0;
            this.knoflíkStudent.TabStop = true;
            this.knoflíkStudent.Text = "S&tudent";
            this.knoflíkStudent.UseVisualStyleBackColor = true;
            // 
            // tlačítkoOdeslat
            // 
            this.tlačítkoOdeslat.Location = new System.Drawing.Point(137, 407);
            this.tlačítkoOdeslat.Name = "tlačítkoOdeslat";
            this.tlačítkoOdeslat.Size = new System.Drawing.Size(241, 56);
            this.tlačítkoOdeslat.TabIndex = 6;
            this.tlačítkoOdeslat.Text = "&Odeslat objednávku";
            this.tlačítkoOdeslat.UseVisualStyleBackColor = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(514, 527);
            this.Controls.Add(this.tlačítkoOdeslat);
            this.Controls.Add(this.přepínačDruhSlevy);
            this.Controls.Add(this.políčkoSleva);
            this.Controls.Add(this.poleAdresa);
            this.Controls.Add(this.popisekAdresa);
            this.Controls.Add(this.poleZboží);
            this.Controls.Add(this.popisekZboží);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Kontextově závislý přepínač";
            this.přepínačDruhSlevy.ResumeLayout(false);
            this.přepínačDruhSlevy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekZboží;
        private System.Windows.Forms.TextBox poleZboží;
        private System.Windows.Forms.Label popisekAdresa;
        private System.Windows.Forms.TextBox poleAdresa;
        private System.Windows.Forms.CheckBox políčkoSleva;
        private System.Windows.Forms.GroupBox přepínačDruhSlevy;
        private System.Windows.Forms.RadioButton knoflíkDůchodce;
        private System.Windows.Forms.RadioButton knoflíkUčitel;
        private System.Windows.Forms.RadioButton knoflíkStudent;
        private System.Windows.Forms.Button tlačítkoOdeslat;
    }
}

