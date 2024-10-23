
namespace Objednávka
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
            this.poleZákazník = new System.Windows.Forms.TextBox();
            this.poleZboží = new System.Windows.Forms.TextBox();
            this.popisekZákazník = new System.Windows.Forms.Label();
            this.popisekZboží = new System.Windows.Forms.Label();
            this.políčkoStudent = new System.Windows.Forms.CheckBox();
            this.políčkoOsobníOdběr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // poleZákazník
            // 
            this.poleZákazník.Location = new System.Drawing.Point(184, 61);
            this.poleZákazník.Name = "poleZákazník";
            this.poleZákazník.Size = new System.Drawing.Size(362, 26);
            this.poleZákazník.TabIndex = 1;
            // 
            // poleZboží
            // 
            this.poleZboží.Location = new System.Drawing.Point(184, 120);
            this.poleZboží.Name = "poleZboží";
            this.poleZboží.Size = new System.Drawing.Size(362, 26);
            this.poleZboží.TabIndex = 3;
            // 
            // popisekZákazník
            // 
            this.popisekZákazník.AutoSize = true;
            this.popisekZákazník.Location = new System.Drawing.Point(55, 64);
            this.popisekZákazník.Name = "popisekZákazník";
            this.popisekZákazník.Size = new System.Drawing.Size(86, 20);
            this.popisekZákazník.TabIndex = 0;
            this.popisekZákazník.Text = "&Zákazník:";
            // 
            // popisekZboží
            // 
            this.popisekZboží.AutoSize = true;
            this.popisekZboží.Location = new System.Drawing.Point(55, 123);
            this.popisekZboží.Name = "popisekZboží";
            this.popisekZboží.Size = new System.Drawing.Size(58, 20);
            this.popisekZboží.TabIndex = 2;
            this.popisekZboží.Text = "Z&boží:";
            // 
            // políčkoStudent
            // 
            this.políčkoStudent.AutoSize = true;
            this.políčkoStudent.Location = new System.Drawing.Point(59, 182);
            this.políčkoStudent.Name = "políčkoStudent";
            this.políčkoStudent.Size = new System.Drawing.Size(92, 24);
            this.políčkoStudent.TabIndex = 4;
            this.políčkoStudent.Text = "&Student";
            this.políčkoStudent.UseVisualStyleBackColor = true;
            // 
            // políčkoOsobníOdběr
            // 
            this.políčkoOsobníOdběr.AutoSize = true;
            this.políčkoOsobníOdběr.Location = new System.Drawing.Point(59, 212);
            this.políčkoOsobníOdběr.Name = "políčkoOsobníOdběr";
            this.políčkoOsobníOdběr.Size = new System.Drawing.Size(135, 24);
            this.políčkoOsobníOdběr.TabIndex = 5;
            this.políčkoOsobníOdběr.Text = "&Osobní odběr";
            this.políčkoOsobníOdběr.UseVisualStyleBackColor = true;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 293);
            this.Controls.Add(this.políčkoOsobníOdběr);
            this.Controls.Add(this.políčkoStudent);
            this.Controls.Add(this.popisekZboží);
            this.Controls.Add(this.popisekZákazník);
            this.Controls.Add(this.poleZboží);
            this.Controls.Add(this.poleZákazník);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Objednávka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleZákazník;
        private System.Windows.Forms.TextBox poleZboží;
        private System.Windows.Forms.Label popisekZákazník;
        private System.Windows.Forms.Label popisekZboží;
        private System.Windows.Forms.CheckBox políčkoStudent;
        private System.Windows.Forms.CheckBox políčkoOsobníOdběr;
    }
}

