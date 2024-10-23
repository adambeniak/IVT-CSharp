
namespace Program_s_nabídkou
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nabídkaSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaNový = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaOtevřít = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaOddělovač1 = new System.Windows.Forms.ToolStripSeparator();
            this.podnabídkaKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaÚpravy = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaZpět = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaOddělovač2 = new System.Windows.Forms.ToolStripSeparator();
            this.podnabídkaVyjmout = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaKopírovat = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaVložit = new System.Windows.Forms.ToolStripMenuItem();
            this.nabídkaNástroje = new System.Windows.Forms.ToolStripMenuItem();
            this.podnabídkaUměláInteligence = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabídkaSoubor,
            this.nabídkaÚpravy,
            this.nabídkaNástroje});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nabídkaSoubor
            // 
            this.nabídkaSoubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podnabídkaNový,
            this.podnabídkaOtevřít,
            this.podnabídkaOddělovač1,
            this.podnabídkaKonec});
            this.nabídkaSoubor.Name = "nabídkaSoubor";
            this.nabídkaSoubor.Size = new System.Drawing.Size(57, 20);
            this.nabídkaSoubor.Text = "&Soubor";
            // 
            // podnabídkaNový
            // 
            this.podnabídkaNový.Name = "podnabídkaNový";
            this.podnabídkaNový.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.podnabídkaNový.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaNový.Text = "&Nový ...";
            this.podnabídkaNový.Click += new System.EventHandler(this.podnabídkaNový_Click);
            // 
            // podnabídkaOtevřít
            // 
            this.podnabídkaOtevřít.Name = "podnabídkaOtevřít";
            this.podnabídkaOtevřít.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.podnabídkaOtevřít.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaOtevřít.Text = "&Otevřít ...";
            this.podnabídkaOtevřít.Click += new System.EventHandler(this.podnabídkaOtevřít_Click);
            // 
            // podnabídkaOddělovač1
            // 
            this.podnabídkaOddělovač1.Name = "podnabídkaOddělovač1";
            this.podnabídkaOddělovač1.Size = new System.Drawing.Size(177, 6);
            // 
            // podnabídkaKonec
            // 
            this.podnabídkaKonec.Name = "podnabídkaKonec";
            this.podnabídkaKonec.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaKonec.Text = "&Konec";
            this.podnabídkaKonec.Click += new System.EventHandler(this.podnabídkaKonec_Click);
            // 
            // nabídkaÚpravy
            // 
            this.nabídkaÚpravy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podnabídkaZpět,
            this.podnabídkaOddělovač2,
            this.podnabídkaVyjmout,
            this.podnabídkaKopírovat,
            this.podnabídkaVložit});
            this.nabídkaÚpravy.Name = "nabídkaÚpravy";
            this.nabídkaÚpravy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.nabídkaÚpravy.Size = new System.Drawing.Size(56, 20);
            this.nabídkaÚpravy.Text = "Úpr&avy";
            // 
            // podnabídkaZpět
            // 
            this.podnabídkaZpět.Name = "podnabídkaZpět";
            this.podnabídkaZpět.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.podnabídkaZpět.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaZpět.Text = "&Zpět";
            // 
            // podnabídkaOddělovač2
            // 
            this.podnabídkaOddělovač2.Name = "podnabídkaOddělovač2";
            this.podnabídkaOddělovač2.Size = new System.Drawing.Size(177, 6);
            // 
            // podnabídkaVyjmout
            // 
            this.podnabídkaVyjmout.Name = "podnabídkaVyjmout";
            this.podnabídkaVyjmout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.podnabídkaVyjmout.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaVyjmout.Text = "&Vyjmout";
            // 
            // podnabídkaKopírovat
            // 
            this.podnabídkaKopírovat.Name = "podnabídkaKopírovat";
            this.podnabídkaKopírovat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.podnabídkaKopírovat.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaKopírovat.Text = "&Kopírovat";
            // 
            // podnabídkaVložit
            // 
            this.podnabídkaVložit.Name = "podnabídkaVložit";
            this.podnabídkaVložit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.podnabídkaVložit.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaVložit.Text = "V&ložit";
            // 
            // nabídkaNástroje
            // 
            this.nabídkaNástroje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podnabídkaUměláInteligence});
            this.nabídkaNástroje.Name = "nabídkaNástroje";
            this.nabídkaNástroje.Size = new System.Drawing.Size(63, 20);
            this.nabídkaNástroje.Text = "&Nástroje";
            // 
            // podnabídkaUměláInteligence
            // 
            this.podnabídkaUměláInteligence.Checked = true;
            this.podnabídkaUměláInteligence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.podnabídkaUměláInteligence.Name = "podnabídkaUměláInteligence";
            this.podnabídkaUměláInteligence.Size = new System.Drawing.Size(180, 22);
            this.podnabídkaUměláInteligence.Text = "&Umělá inteligence";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(413, 296);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "oknoProgramu";
            this.Text = "Program s nabídkou";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nabídkaSoubor;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaNový;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaOtevřít;
        private System.Windows.Forms.ToolStripSeparator podnabídkaOddělovač1;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaKonec;
        private System.Windows.Forms.ToolStripMenuItem nabídkaÚpravy;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaZpět;
        private System.Windows.Forms.ToolStripSeparator podnabídkaOddělovač2;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaVyjmout;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaKopírovat;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaVložit;
        private System.Windows.Forms.ToolStripMenuItem nabídkaNástroje;
        private System.Windows.Forms.ToolStripMenuItem podnabídkaUměláInteligence;
    }
}

