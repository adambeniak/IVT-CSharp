
namespace Výměna_stavu_ano_ne
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
            this.políčko1 = new System.Windows.Forms.CheckBox();
            this.políčko2 = new System.Windows.Forms.CheckBox();
            this.tlačítkoVyměň = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // políčko1
            // 
            this.políčko1.AutoSize = true;
            this.políčko1.Location = new System.Drawing.Point(175, 45);
            this.políčko1.Name = "políčko1";
            this.políčko1.Size = new System.Drawing.Size(201, 28);
            this.políčko1.TabIndex = 0;
            this.políčko1.Text = "Mám rád &první věc";
            this.políčko1.UseVisualStyleBackColor = true;
            // 
            // políčko2
            // 
            this.políčko2.AutoSize = true;
            this.políčko2.Location = new System.Drawing.Point(175, 124);
            this.políčko2.Name = "políčko2";
            this.políčko2.Size = new System.Drawing.Size(222, 28);
            this.políčko2.TabIndex = 1;
            this.políčko2.Text = "Mám rád &druhou věc";
            this.políčko2.UseVisualStyleBackColor = true;
            // 
            // tlačítkoVyměň
            // 
            this.tlačítkoVyměň.Location = new System.Drawing.Point(175, 213);
            this.tlačítkoVyměň.Name = "tlačítkoVyměň";
            this.tlačítkoVyměň.Size = new System.Drawing.Size(216, 61);
            this.tlačítkoVyměň.TabIndex = 2;
            this.tlačítkoVyměň.Text = "&Vyměň";
            this.tlačítkoVyměň.UseVisualStyleBackColor = true;
            this.tlačítkoVyměň.Click += new System.EventHandler(this.tlačítkoVyměň_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoVyměň;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.tlačítkoVyměň);
            this.Controls.Add(this.políčko2);
            this.Controls.Add(this.políčko1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výměna stavu ano/ne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox políčko1;
        private System.Windows.Forms.CheckBox políčko2;
        private System.Windows.Forms.Button tlačítkoVyměň;
    }
}

