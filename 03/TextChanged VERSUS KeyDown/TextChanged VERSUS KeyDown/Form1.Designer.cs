
namespace TextChanged_VERSUS_KeyDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoProgramu));
            this.pole1 = new System.Windows.Forms.TextBox();
            this.pole2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pole1
            // 
            this.pole1.Location = new System.Drawing.Point(107, 110);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(422, 29);
            this.pole1.TabIndex = 0;
            this.pole1.Text = "Něco1";
            this.pole1.TextChanged += new System.EventHandler(this.pole1_TextChanged);
            // 
            // pole2
            // 
            this.pole2.Location = new System.Drawing.Point(107, 194);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(422, 29);
            this.pole2.TabIndex = 1;
            this.pole2.Text = "Něco2";
            this.pole2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pole2_KeyDown);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 332);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "TextChanged VERSUS KeyDown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pole1;
        private System.Windows.Forms.TextBox pole2;
    }
}

