
namespace Schovej_jméno
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
            this.poleJméno = new System.Windows.Forms.TextBox();
            this.popisekJméno = new System.Windows.Forms.Label();
            this.tlačítkoSchovej = new System.Windows.Forms.Button();
            this.tlačítkoOdkryj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleJméno
            // 
            this.poleJméno.Location = new System.Drawing.Point(95, 19);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(417, 26);
            this.poleJméno.TabIndex = 1;
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.Location = new System.Drawing.Point(12, 22);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(67, 20);
            this.popisekJméno.TabIndex = 0;
            this.popisekJméno.Text = "&Jméno:";
            // 
            // tlačítkoSchovej
            // 
            this.tlačítkoSchovej.Location = new System.Drawing.Point(95, 67);
            this.tlačítkoSchovej.Name = "tlačítkoSchovej";
            this.tlačítkoSchovej.Size = new System.Drawing.Size(137, 68);
            this.tlačítkoSchovej.TabIndex = 2;
            this.tlačítkoSchovej.Text = "&Schovej";
            this.tlačítkoSchovej.UseVisualStyleBackColor = true;
            this.tlačítkoSchovej.Click += new System.EventHandler(this.tlačítkoSchovej_Click);
            // 
            // tlačítkoOdkryj
            // 
            this.tlačítkoOdkryj.Enabled = false;
            this.tlačítkoOdkryj.Location = new System.Drawing.Point(375, 67);
            this.tlačítkoOdkryj.Name = "tlačítkoOdkryj";
            this.tlačítkoOdkryj.Size = new System.Drawing.Size(137, 68);
            this.tlačítkoOdkryj.TabIndex = 3;
            this.tlačítkoOdkryj.Text = "&Odkryj";
            this.tlačítkoOdkryj.UseVisualStyleBackColor = true;
            this.tlačítkoOdkryj.Click += new System.EventHandler(this.tlačítkoOdkryj_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 151);
            this.Controls.Add(this.tlačítkoOdkryj);
            this.Controls.Add(this.tlačítkoSchovej);
            this.Controls.Add(this.popisekJméno);
            this.Controls.Add(this.poleJméno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Schovej jméno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleJméno;
        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.Button tlačítkoSchovej;
        private System.Windows.Forms.Button tlačítkoOdkryj;
    }
}

