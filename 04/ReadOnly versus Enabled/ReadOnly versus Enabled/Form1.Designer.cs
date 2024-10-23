
namespace ReadOnly_versus_Enabled
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
            this.SuspendLayout();
            // 
            // pole1
            // 
            this.pole1.BackColor = System.Drawing.Color.LightGreen;
            this.pole1.Location = new System.Drawing.Point(71, 44);
            this.pole1.Name = "pole1";
            this.pole1.ReadOnly = true;
            this.pole1.Size = new System.Drawing.Size(341, 26);
            this.pole1.TabIndex = 0;
            this.pole1.Text = "jhgjkhgkjhgkjgk";
            // 
            // pole2
            // 
            this.pole2.BackColor = System.Drawing.Color.LightGreen;
            this.pole2.Enabled = false;
            this.pole2.Location = new System.Drawing.Point(71, 123);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(341, 26);
            this.pole2.TabIndex = 1;
            this.pole2.Text = "khgvkjvkvkhgvfkg";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 193);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "ReadOnly versus Enabled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pole1;
        private System.Windows.Forms.TextBox pole2;
    }
}

