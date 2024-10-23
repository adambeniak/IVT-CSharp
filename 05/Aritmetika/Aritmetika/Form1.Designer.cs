
namespace Aritmetika
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
            this.tlačítkoSečti = new System.Windows.Forms.Button();
            this.tlačítkoOdečti = new System.Windows.Forms.Button();
            this.tlačítkoVynásob = new System.Windows.Forms.Button();
            this.popisekVýsledek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Location = new System.Drawing.Point(45, 107);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(188, 29);
            this.poleČíslo1.TabIndex = 0;
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Location = new System.Drawing.Point(45, 196);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.Size = new System.Drawing.Size(188, 29);
            this.poleČíslo2.TabIndex = 1;
            // 
            // poleVýsledek
            // 
            this.poleVýsledek.Location = new System.Drawing.Point(498, 152);
            this.poleVýsledek.Name = "poleVýsledek";
            this.poleVýsledek.ReadOnly = true;
            this.poleVýsledek.Size = new System.Drawing.Size(188, 29);
            this.poleVýsledek.TabIndex = 5;
            // 
            // tlačítkoSečti
            // 
            this.tlačítkoSečti.Location = new System.Drawing.Point(295, 43);
            this.tlačítkoSečti.Name = "tlačítkoSečti";
            this.tlačítkoSečti.Size = new System.Drawing.Size(160, 48);
            this.tlačítkoSečti.TabIndex = 2;
            this.tlačítkoSečti.Text = "&Sečti";
            this.tlačítkoSečti.UseVisualStyleBackColor = true;
            this.tlačítkoSečti.Click += new System.EventHandler(this.tlačítkoSečti_Click);
            // 
            // tlačítkoOdečti
            // 
            this.tlačítkoOdečti.Location = new System.Drawing.Point(295, 143);
            this.tlačítkoOdečti.Name = "tlačítkoOdečti";
            this.tlačítkoOdečti.Size = new System.Drawing.Size(160, 48);
            this.tlačítkoOdečti.TabIndex = 3;
            this.tlačítkoOdečti.Text = "&Odečti";
            this.tlačítkoOdečti.UseVisualStyleBackColor = true;
            this.tlačítkoOdečti.Click += new System.EventHandler(this.tlačítkoOdečti_Click);
            // 
            // tlačítkoVynásob
            // 
            this.tlačítkoVynásob.Location = new System.Drawing.Point(295, 242);
            this.tlačítkoVynásob.Name = "tlačítkoVynásob";
            this.tlačítkoVynásob.Size = new System.Drawing.Size(160, 48);
            this.tlačítkoVynásob.TabIndex = 4;
            this.tlačítkoVynásob.Text = "&Vynásob";
            this.tlačítkoVynásob.UseVisualStyleBackColor = true;
            this.tlačítkoVynásob.Click += new System.EventHandler(this.tlačítkoVynásob_Click);
            // 
            // popisekVýsledek
            // 
            this.popisekVýsledek.AutoSize = true;
            this.popisekVýsledek.Location = new System.Drawing.Point(494, 110);
            this.popisekVýsledek.Name = "popisekVýsledek";
            this.popisekVýsledek.Size = new System.Drawing.Size(101, 24);
            this.popisekVýsledek.TabIndex = 6;
            this.popisekVýsledek.Text = "Výsledek:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 333);
            this.Controls.Add(this.popisekVýsledek);
            this.Controls.Add(this.tlačítkoVynásob);
            this.Controls.Add(this.tlačítkoOdečti);
            this.Controls.Add(this.tlačítkoSečti);
            this.Controls.Add(this.poleVýsledek);
            this.Controls.Add(this.poleČíslo2);
            this.Controls.Add(this.poleČíslo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Aritmetika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.TextBox poleVýsledek;
        private System.Windows.Forms.Button tlačítkoSečti;
        private System.Windows.Forms.Button tlačítkoOdečti;
        private System.Windows.Forms.Button tlačítkoVynásob;
        private System.Windows.Forms.Label popisekVýsledek;
    }
}

