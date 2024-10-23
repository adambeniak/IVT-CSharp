
namespace Výměna_dívek
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
            this.pole1 = new System.Windows.Forms.TextBox();
            this.pole2 = new System.Windows.Forms.TextBox();
            this.popisek1 = new System.Windows.Forms.Label();
            this.popisek2 = new System.Windows.Forms.Label();
            this.tlačítkoVyměň = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pole1
            // 
            this.pole1.ForeColor = System.Drawing.Color.Red;
            this.pole1.Location = new System.Drawing.Point(214, 55);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(204, 29);
            this.pole1.TabIndex = 0;
            this.pole1.Text = "Iveta";
            // 
            // pole2
            // 
            this.pole2.ForeColor = System.Drawing.Color.Lime;
            this.pole2.Location = new System.Drawing.Point(214, 211);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(204, 29);
            this.pole2.TabIndex = 1;
            this.pole2.Text = "Kristýna";
            // 
            // popisek1
            // 
            this.popisek1.AutoSize = true;
            this.popisek1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.popisek1.Location = new System.Drawing.Point(63, 58);
            this.popisek1.Name = "popisek1";
            this.popisek1.Size = new System.Drawing.Size(82, 24);
            this.popisek1.TabIndex = 2;
            this.popisek1.Text = "&Janova:";
            // 
            // popisek2
            // 
            this.popisek2.AutoSize = true;
            this.popisek2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.popisek2.Location = new System.Drawing.Point(63, 214);
            this.popisek2.Name = "popisek2";
            this.popisek2.Size = new System.Drawing.Size(122, 24);
            this.popisek2.TabIndex = 3;
            this.popisek2.Text = "&Františkova:";
            // 
            // tlačítkoVyměň
            // 
            this.tlačítkoVyměň.Location = new System.Drawing.Point(166, 120);
            this.tlačítkoVyměň.Name = "tlačítkoVyměň";
            this.tlačítkoVyměň.Size = new System.Drawing.Size(163, 49);
            this.tlačítkoVyměň.TabIndex = 4;
            this.tlačítkoVyměň.Text = "&Vyměň";
            this.tlačítkoVyměň.UseVisualStyleBackColor = true;
            this.tlačítkoVyměň.Click += new System.EventHandler(this.tlačítkoVyměň_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoVyměň;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 294);
            this.Controls.Add(this.tlačítkoVyměň);
            this.Controls.Add(this.popisek2);
            this.Controls.Add(this.popisek1);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výměna dívek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pole1;
        private System.Windows.Forms.TextBox pole2;
        private System.Windows.Forms.Label popisek1;
        private System.Windows.Forms.Label popisek2;
        private System.Windows.Forms.Button tlačítkoVyměň;
    }
}

