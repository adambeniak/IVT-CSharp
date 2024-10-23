
namespace Aritmetika_2
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
            this.poleSoučet = new System.Windows.Forms.TextBox();
            this.poleRozdíl = new System.Windows.Forms.TextBox();
            this.poleSoučin = new System.Windows.Forms.TextBox();
            this.popisekVýchozíHodnoty = new System.Windows.Forms.Label();
            this.popisekSoučet = new System.Windows.Forms.Label();
            this.popisekRozdíl = new System.Windows.Forms.Label();
            this.popisekSoučin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleČíslo1
            // 
            this.poleČíslo1.Location = new System.Drawing.Point(40, 76);
            this.poleČíslo1.Name = "poleČíslo1";
            this.poleČíslo1.Size = new System.Drawing.Size(179, 29);
            this.poleČíslo1.TabIndex = 0;
            this.poleČíslo1.TextChanged += new System.EventHandler(this.poleČísla_TextChanged);
            // 
            // poleČíslo2
            // 
            this.poleČíslo2.Location = new System.Drawing.Point(265, 76);
            this.poleČíslo2.Name = "poleČíslo2";
            this.poleČíslo2.Size = new System.Drawing.Size(179, 29);
            this.poleČíslo2.TabIndex = 1;
            this.poleČíslo2.TextChanged += new System.EventHandler(this.poleČísla_TextChanged);
            // 
            // poleSoučet
            // 
            this.poleSoučet.Location = new System.Drawing.Point(40, 205);
            this.poleSoučet.Name = "poleSoučet";
            this.poleSoučet.Size = new System.Drawing.Size(179, 29);
            this.poleSoučet.TabIndex = 2;
            // 
            // poleRozdíl
            // 
            this.poleRozdíl.Location = new System.Drawing.Point(266, 205);
            this.poleRozdíl.Name = "poleRozdíl";
            this.poleRozdíl.Size = new System.Drawing.Size(179, 29);
            this.poleRozdíl.TabIndex = 3;
            // 
            // poleSoučin
            // 
            this.poleSoučin.Location = new System.Drawing.Point(492, 205);
            this.poleSoučin.Name = "poleSoučin";
            this.poleSoučin.Size = new System.Drawing.Size(179, 29);
            this.poleSoučin.TabIndex = 4;
            // 
            // popisekVýchozíHodnoty
            // 
            this.popisekVýchozíHodnoty.AutoSize = true;
            this.popisekVýchozíHodnoty.Location = new System.Drawing.Point(36, 49);
            this.popisekVýchozíHodnoty.Name = "popisekVýchozíHodnoty";
            this.popisekVýchozíHodnoty.Size = new System.Drawing.Size(171, 24);
            this.popisekVýchozíHodnoty.TabIndex = 5;
            this.popisekVýchozíHodnoty.Text = "Výchozí hodnoty:";
            // 
            // popisekSoučet
            // 
            this.popisekSoučet.AutoSize = true;
            this.popisekSoučet.Location = new System.Drawing.Point(36, 178);
            this.popisekSoučet.Name = "popisekSoučet";
            this.popisekSoučet.Size = new System.Drawing.Size(81, 24);
            this.popisekSoučet.TabIndex = 6;
            this.popisekSoučet.Text = "Součet:";
            // 
            // popisekRozdíl
            // 
            this.popisekRozdíl.AutoSize = true;
            this.popisekRozdíl.Location = new System.Drawing.Point(262, 178);
            this.popisekRozdíl.Name = "popisekRozdíl";
            this.popisekRozdíl.Size = new System.Drawing.Size(74, 24);
            this.popisekRozdíl.TabIndex = 7;
            this.popisekRozdíl.Text = "Rozdíl:";
            // 
            // popisekSoučin
            // 
            this.popisekSoučin.AutoSize = true;
            this.popisekSoučin.Location = new System.Drawing.Point(488, 178);
            this.popisekSoučin.Name = "popisekSoučin";
            this.popisekSoučin.Size = new System.Drawing.Size(81, 24);
            this.popisekSoučin.TabIndex = 8;
            this.popisekSoučin.Text = "Součin:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 332);
            this.Controls.Add(this.popisekSoučin);
            this.Controls.Add(this.popisekRozdíl);
            this.Controls.Add(this.popisekSoučet);
            this.Controls.Add(this.popisekVýchozíHodnoty);
            this.Controls.Add(this.poleSoučin);
            this.Controls.Add(this.poleRozdíl);
            this.Controls.Add(this.poleSoučet);
            this.Controls.Add(this.poleČíslo2);
            this.Controls.Add(this.poleČíslo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Aritmetika 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleČíslo1;
        private System.Windows.Forms.TextBox poleČíslo2;
        private System.Windows.Forms.TextBox poleSoučet;
        private System.Windows.Forms.TextBox poleRozdíl;
        private System.Windows.Forms.TextBox poleSoučin;
        private System.Windows.Forms.Label popisekVýchozíHodnoty;
        private System.Windows.Forms.Label popisekSoučet;
        private System.Windows.Forms.Label popisekRozdíl;
        private System.Windows.Forms.Label popisekSoučin;
    }
}

