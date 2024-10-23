
namespace Nad_prvkem_či_mimo
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
            this.tlačítkoKlikni = new System.Windows.Forms.Button();
            this.poleKlikni = new System.Windows.Forms.TextBox();
            this.políčkoKlikni = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tlačítkoKlikni
            // 
            this.tlačítkoKlikni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoKlikni.Location = new System.Drawing.Point(117, 55);
            this.tlačítkoKlikni.Margin = new System.Windows.Forms.Padding(6);
            this.tlačítkoKlikni.Name = "tlačítkoKlikni";
            this.tlačítkoKlikni.Size = new System.Drawing.Size(229, 82);
            this.tlačítkoKlikni.TabIndex = 0;
            this.tlačítkoKlikni.Text = "Klikni";
            this.tlačítkoKlikni.UseVisualStyleBackColor = true;
            this.tlačítkoKlikni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prvkyKlikni_MouseDown);
            // 
            // poleKlikni
            // 
            this.poleKlikni.Location = new System.Drawing.Point(117, 175);
            this.poleKlikni.Name = "poleKlikni";
            this.poleKlikni.Size = new System.Drawing.Size(229, 29);
            this.poleKlikni.TabIndex = 1;
            this.poleKlikni.Text = "Klikni";
            this.poleKlikni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prvkyKlikni_MouseDown);
            // 
            // políčkoKlikni
            // 
            this.políčkoKlikni.AutoSize = true;
            this.políčkoKlikni.Checked = true;
            this.políčkoKlikni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.políčkoKlikni.Location = new System.Drawing.Point(117, 253);
            this.políčkoKlikni.Name = "políčkoKlikni";
            this.políčkoKlikni.Size = new System.Drawing.Size(79, 28);
            this.políčkoKlikni.TabIndex = 2;
            this.políčkoKlikni.Text = "Klikni";
            this.políčkoKlikni.UseVisualStyleBackColor = true;
            this.políčkoKlikni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prvkyKlikni_MouseDown);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 337);
            this.Controls.Add(this.políčkoKlikni);
            this.Controls.Add(this.poleKlikni);
            this.Controls.Add(this.tlačítkoKlikni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Klikni nad prvkem či mimo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oknoProgramu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoKlikni;
        private System.Windows.Forms.TextBox poleKlikni;
        private System.Windows.Forms.CheckBox políčkoKlikni;
    }
}

