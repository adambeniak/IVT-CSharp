namespace Program_s_popisky
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
            this.poleAdresa = new System.Windows.Forms.TextBox();
            this.polePříjmení = new System.Windows.Forms.TextBox();
            this.popisekJméno = new System.Windows.Forms.Label();
            this.popisekPříjmení = new System.Windows.Forms.Label();
            this.popisekAdresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleJméno
            // 
            this.poleJméno.Location = new System.Drawing.Point(188, 58);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(359, 30);
            this.poleJméno.TabIndex = 1;
            // 
            // poleAdresa
            // 
            this.poleAdresa.Location = new System.Drawing.Point(188, 212);
            this.poleAdresa.Name = "poleAdresa";
            this.poleAdresa.Size = new System.Drawing.Size(359, 30);
            this.poleAdresa.TabIndex = 5;
            // 
            // polePříjmení
            // 
            this.polePříjmení.Location = new System.Drawing.Point(188, 135);
            this.polePříjmení.Name = "polePříjmení";
            this.polePříjmení.Size = new System.Drawing.Size(359, 30);
            this.polePříjmení.TabIndex = 3;
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.popisekJméno.Location = new System.Drawing.Point(50, 61);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(84, 25);
            this.popisekJméno.TabIndex = 0;
            this.popisekJméno.Text = "&Jméno:";
            // 
            // popisekPříjmení
            // 
            this.popisekPříjmení.AutoSize = true;
            this.popisekPříjmení.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.popisekPříjmení.Location = new System.Drawing.Point(50, 138);
            this.popisekPříjmení.Name = "popisekPříjmení";
            this.popisekPříjmení.Size = new System.Drawing.Size(96, 25);
            this.popisekPříjmení.TabIndex = 2;
            this.popisekPříjmení.Text = "&Příjmení:";
            // 
            // popisekAdresa
            // 
            this.popisekAdresa.AutoSize = true;
            this.popisekAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.popisekAdresa.Location = new System.Drawing.Point(50, 215);
            this.popisekAdresa.Name = "popisekAdresa";
            this.popisekAdresa.Size = new System.Drawing.Size(88, 25);
            this.popisekAdresa.TabIndex = 4;
            this.popisekAdresa.Text = "&Adresa:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 306);
            this.Controls.Add(this.popisekAdresa);
            this.Controls.Add(this.popisekPříjmení);
            this.Controls.Add(this.popisekJméno);
            this.Controls.Add(this.poleAdresa);
            this.Controls.Add(this.polePříjmení);
            this.Controls.Add(this.poleJméno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Program s popisky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleJméno;
        private System.Windows.Forms.TextBox poleAdresa;
        private System.Windows.Forms.TextBox polePříjmení;
        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.Label popisekPříjmení;
        private System.Windows.Forms.Label popisekAdresa;
    }
}

