namespace Proměnlivá_nabídka
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hlavníNabídka = new System.Windows.Forms.MenuStrip();
            this.nabídkaSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaSouborOtevřít = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaSouborZavřít = new System.Windows.Forms.ToolStripMenuItem();
            this.oddělovačNabídky = new System.Windows.Forms.ToolStripSeparator();
            this.nabídkaSouborKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaProjekt = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaProjektVlastnostiProjektu = new System.Windows.Forms.ToolStripMenuItem();
            this.popisekJméno = new System.Windows.Forms.Label();
            this.poleJméno = new System.Windows.Forms.TextBox();
            this.hlavníNabídka.SuspendLayout();
            this.SuspendLayout();
            // 
            // hlavníNabídka
            // 
            this.hlavníNabídka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabídkaSoubor,
            this.nabídkaProjekt});
            this.hlavníNabídka.Location = new System.Drawing.Point(0, 0);
            this.hlavníNabídka.Name = "hlavníNabídka";
            this.hlavníNabídka.Size = new System.Drawing.Size(292, 24);
            this.hlavníNabídka.TabIndex = 0;
            this.hlavníNabídka.Text = "menuStrip1";
            // 
            // nabídkaSoubor
            // 
            this.nabídkaSoubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabídkaSouborOtevřít,
            this.nabídkaSouborZavřít,
            this.oddělovačNabídky,
            this.nabídkaSouborKonec});
            this.nabídkaSoubor.Name = "nabídkaSoubor";
            this.nabídkaSoubor.Size = new System.Drawing.Size(57, 20);
            this.nabídkaSoubor.Text = "&Soubor";
            // 
            // nabídkaSouborOtevřít
            // 
            this.nabídkaSouborOtevřít.Name = "nabídkaSouborOtevřít";
            this.nabídkaSouborOtevřít.Size = new System.Drawing.Size(110, 22);
            this.nabídkaSouborOtevřít.Text = "&Otevřít";
            this.nabídkaSouborOtevřít.Click += new System.EventHandler(this.nabídkaSouborOtevřít_Click);
            // 
            // nabídkaSouborZavřít
            // 
            this.nabídkaSouborZavřít.Enabled = false;
            this.nabídkaSouborZavřít.Name = "nabídkaSouborZavřít";
            this.nabídkaSouborZavřít.Size = new System.Drawing.Size(110, 22);
            this.nabídkaSouborZavřít.Text = "&Zavřít";
            this.nabídkaSouborZavřít.Click += new System.EventHandler(this.nabídkaSouborZavřít_Click);
            // 
            // oddělovačNabídky
            // 
            this.oddělovačNabídky.Name = "oddělovačNabídky";
            this.oddělovačNabídky.Size = new System.Drawing.Size(107, 6);
            // 
            // nabídkaSouborKonec
            // 
            this.nabídkaSouborKonec.Name = "nabídkaSouborKonec";
            this.nabídkaSouborKonec.Size = new System.Drawing.Size(110, 22);
            this.nabídkaSouborKonec.Text = "&Konec";
            this.nabídkaSouborKonec.Click += new System.EventHandler(this.nabídkaSouborKonec_Click);
            // 
            // nabídkaProjekt
            // 
            this.nabídkaProjekt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabídkaProjektVlastnostiProjektu});
            this.nabídkaProjekt.Name = "nabídkaProjekt";
            this.nabídkaProjekt.Size = new System.Drawing.Size(56, 20);
            this.nabídkaProjekt.Text = "&Projekt";
            // 
            // nabídkaProjektVlastnostiProjektu
            // 
            this.nabídkaProjektVlastnostiProjektu.Enabled = false;
            this.nabídkaProjektVlastnostiProjektu.Name = "nabídkaProjektVlastnostiProjektu";
            this.nabídkaProjektVlastnostiProjektu.Size = new System.Drawing.Size(172, 22);
            this.nabídkaProjektVlastnostiProjektu.Text = "&Vlastnosti projektu";
            this.nabídkaProjektVlastnostiProjektu.Click += new System.EventHandler(this.nabídkaProjektVlastnostiProjektu_Click);
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.Location = new System.Drawing.Point(13, 112);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(129, 13);
            this.popisekJméno.TabIndex = 1;
            this.popisekJméno.Text = "&Jméno souboru (projektu):";
            // 
            // poleJméno
            // 
            this.poleJméno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poleJméno.Location = new System.Drawing.Point(16, 129);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(264, 20);
            this.poleJméno.TabIndex = 2;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 169);
            this.Controls.Add(this.poleJméno);
            this.Controls.Add(this.popisekJméno);
            this.Controls.Add(this.hlavníNabídka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.hlavníNabídka;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Proměnlivá nabídka";
            this.hlavníNabídka.ResumeLayout(false);
            this.hlavníNabídka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip hlavníNabídka;
        private System.Windows.Forms.ToolStripMenuItem nabídkaSoubor;
        private System.Windows.Forms.ToolStripMenuItem nabídkaSouborOtevřít;
        private System.Windows.Forms.ToolStripMenuItem nabídkaSouborZavřít;
        private System.Windows.Forms.ToolStripMenuItem nabídkaProjekt;
        private System.Windows.Forms.ToolStripSeparator oddělovačNabídky;
        private System.Windows.Forms.ToolStripMenuItem nabídkaSouborKonec;
        private System.Windows.Forms.ToolStripMenuItem nabídkaProjektVlastnostiProjektu;
        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.TextBox poleJméno;
    }
}

