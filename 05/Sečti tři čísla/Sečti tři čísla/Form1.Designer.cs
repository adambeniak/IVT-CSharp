
namespace Sečti_tři_čísla
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
            this.poleČíslo3 = new System.Windows.Forms.TextBox();
            this.poleVýsledek = new System.Windows.Forms.TextBox();
            this.tlačítkoSečti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Location = new System.Drawing.Point(85, 21);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(144, 29);
            this.poleČíslo1.TabIndex = 0;
            this.poleČíslo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Location = new System.Drawing.Point(85, 82);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.Size = new System.Drawing.Size(144, 29);
            this.poleČíslo2.TabIndex = 1;
            this.poleČíslo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleČíslo3
            // 
            this.poleČíslo3.Location = new System.Drawing.Point(85, 146);
            this.poleČíslo3.Name = "poleČíslo3";
            this.poleČíslo3.Size = new System.Drawing.Size(144, 29);
            this.poleČíslo3.TabIndex = 2;
            this.poleČíslo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleVýsledek
            // 
            this.poleVýsledek.Location = new System.Drawing.Point(85, 273);
            this.poleVýsledek.Name = "poleVýsledek";
            this.poleVýsledek.ReadOnly = true;
            this.poleVýsledek.Size = new System.Drawing.Size(144, 29);
            this.poleVýsledek.TabIndex = 3;
            this.poleVýsledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlačítkoSečti
            // 
            this.tlačítkoSečti.Location = new System.Drawing.Point(85, 199);
            this.tlačítkoSečti.Name = "tlačítkoSečti";
            this.tlačítkoSečti.Size = new System.Drawing.Size(144, 52);
            this.tlačítkoSečti.TabIndex = 4;
            this.tlačítkoSečti.Text = "&Sečti";
            this.tlačítkoSečti.UseVisualStyleBackColor = true;
            this.tlačítkoSečti.Click += new System.EventHandler(this.tlačítkoSečti_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 320);
            this.Controls.Add(this.tlačítkoSečti);
            this.Controls.Add(this.poleVýsledek);
            this.Controls.Add(this.poleČíslo3);
            this.Controls.Add(this.poleČíslo2);
            this.Controls.Add(this.poleČíslo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Sečti tři čísla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.TextBox poleČíslo3;
        private System.Windows.Forms.TextBox poleVýsledek;
        private System.Windows.Forms.Button tlačítkoSečti;
    }
}

