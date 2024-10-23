
namespace Báječný_soused
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
            this.poleJá = new System.Windows.Forms.TextBox();
            this.poleSoused = new System.Windows.Forms.TextBox();
            this.popisekJá = new System.Windows.Forms.Label();
            this.popisekSoused = new System.Windows.Forms.Label();
            this.tlačítkoChamtivý = new System.Windows.Forms.Button();
            this.tlačítkoZávistivý = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleJá
            // 
            this.poleJá.Location = new System.Drawing.Point(375, 72);
            this.poleJá.Name = "poleJá";
            this.poleJá.Size = new System.Drawing.Size(170, 29);
            this.poleJá.TabIndex = 0;
            // 
            // poleSoused
            // 
            this.poleSoused.Location = new System.Drawing.Point(375, 162);
            this.poleSoused.Name = "poleSoused";
            this.poleSoused.Size = new System.Drawing.Size(170, 29);
            this.poleSoused.TabIndex = 1;
            // 
            // popisekJá
            // 
            this.popisekJá.AutoSize = true;
            this.popisekJá.Location = new System.Drawing.Point(57, 75);
            this.popisekJá.Name = "popisekJá";
            this.popisekJá.Size = new System.Drawing.Size(176, 24);
            this.popisekJá.TabIndex = 2;
            this.popisekJá.Text = "Počet čehokoli já:";
            // 
            // popisekSoused
            // 
            this.popisekSoused.AutoSize = true;
            this.popisekSoused.Location = new System.Drawing.Point(57, 165);
            this.popisekSoused.Name = "popisekSoused";
            this.popisekSoused.Size = new System.Drawing.Size(228, 24);
            this.popisekSoused.TabIndex = 3;
            this.popisekSoused.Text = "Počet čehokoli soused:";
            // 
            // tlačítkoChamtivý
            // 
            this.tlačítkoChamtivý.Location = new System.Drawing.Point(134, 249);
            this.tlačítkoChamtivý.Name = "tlačítkoChamtivý";
            this.tlačítkoChamtivý.Size = new System.Drawing.Size(126, 44);
            this.tlačítkoChamtivý.TabIndex = 4;
            this.tlačítkoChamtivý.Text = "&Chamtivý";
            this.tlačítkoChamtivý.UseVisualStyleBackColor = true;
            this.tlačítkoChamtivý.Click += new System.EventHandler(this.tlačítkoChamtivý_Click);
            // 
            // tlačítkoZávistivý
            // 
            this.tlačítkoZávistivý.Location = new System.Drawing.Point(350, 249);
            this.tlačítkoZávistivý.Name = "tlačítkoZávistivý";
            this.tlačítkoZávistivý.Size = new System.Drawing.Size(126, 44);
            this.tlačítkoZávistivý.TabIndex = 5;
            this.tlačítkoZávistivý.Text = "&Závistivý";
            this.tlačítkoZávistivý.UseVisualStyleBackColor = true;
            this.tlačítkoZávistivý.Click += new System.EventHandler(this.tlačítkoZávistivý_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 353);
            this.Controls.Add(this.tlačítkoZávistivý);
            this.Controls.Add(this.tlačítkoChamtivý);
            this.Controls.Add(this.popisekSoused);
            this.Controls.Add(this.popisekJá);
            this.Controls.Add(this.poleSoused);
            this.Controls.Add(this.poleJá);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Báječný soused";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleJá;
        private System.Windows.Forms.TextBox poleSoused;
        private System.Windows.Forms.Label popisekJá;
        private System.Windows.Forms.Label popisekSoused;
        private System.Windows.Forms.Button tlačítkoChamtivý;
        private System.Windows.Forms.Button tlačítkoZávistivý;
    }
}

