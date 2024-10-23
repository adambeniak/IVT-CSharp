
namespace Dvojitá_záloha
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
            this.poleVěta = new System.Windows.Forms.TextBox();
            this.tlačítkoZálohuj = new System.Windows.Forms.Button();
            this.poleZáloha = new System.Windows.Forms.TextBox();
            this.polePůvodníZáloha = new System.Windows.Forms.TextBox();
            this.popisekVěta = new System.Windows.Forms.Label();
            this.popisekZáloha = new System.Windows.Forms.Label();
            this.popisekPůvodníZáloha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleVěta
            // 
            this.poleVěta.Location = new System.Drawing.Point(203, 52);
            this.poleVěta.Name = "poleVěta";
            this.poleVěta.Size = new System.Drawing.Size(326, 30);
            this.poleVěta.TabIndex = 1;
            // 
            // tlačítkoZálohuj
            // 
            this.tlačítkoZálohuj.Location = new System.Drawing.Point(203, 134);
            this.tlačítkoZálohuj.Name = "tlačítkoZálohuj";
            this.tlačítkoZálohuj.Size = new System.Drawing.Size(155, 38);
            this.tlačítkoZálohuj.TabIndex = 2;
            this.tlačítkoZálohuj.Text = "&Zálohuj";
            this.tlačítkoZálohuj.UseVisualStyleBackColor = true;
            this.tlačítkoZálohuj.Click += new System.EventHandler(this.tlačítkoZálohuj_Click);
            // 
            // poleZáloha
            // 
            this.poleZáloha.Location = new System.Drawing.Point(203, 228);
            this.poleZáloha.Name = "poleZáloha";
            this.poleZáloha.ReadOnly = true;
            this.poleZáloha.Size = new System.Drawing.Size(326, 30);
            this.poleZáloha.TabIndex = 4;
            // 
            // polePůvodníZáloha
            // 
            this.polePůvodníZáloha.Location = new System.Drawing.Point(203, 311);
            this.polePůvodníZáloha.Name = "polePůvodníZáloha";
            this.polePůvodníZáloha.ReadOnly = true;
            this.polePůvodníZáloha.Size = new System.Drawing.Size(326, 30);
            this.polePůvodníZáloha.TabIndex = 6;
            // 
            // popisekVěta
            // 
            this.popisekVěta.AutoSize = true;
            this.popisekVěta.Location = new System.Drawing.Point(28, 55);
            this.popisekVěta.Name = "popisekVěta";
            this.popisekVěta.Size = new System.Drawing.Size(64, 25);
            this.popisekVěta.TabIndex = 0;
            this.popisekVěta.Text = "&Věta:";
            // 
            // popisekZáloha
            // 
            this.popisekZáloha.AutoSize = true;
            this.popisekZáloha.Location = new System.Drawing.Point(28, 231);
            this.popisekZáloha.Name = "popisekZáloha";
            this.popisekZáloha.Size = new System.Drawing.Size(85, 25);
            this.popisekZáloha.TabIndex = 3;
            this.popisekZáloha.Text = "Zá&loha:";
            // 
            // popisekPůvodníZáloha
            // 
            this.popisekPůvodníZáloha.AutoSize = true;
            this.popisekPůvodníZáloha.Location = new System.Drawing.Point(28, 314);
            this.popisekPůvodníZáloha.Name = "popisekPůvodníZáloha";
            this.popisekPůvodníZáloha.Size = new System.Drawing.Size(167, 25);
            this.popisekPůvodníZáloha.TabIndex = 5;
            this.popisekPůvodníZáloha.Text = "&Původní záloha:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.popisekPůvodníZáloha);
            this.Controls.Add(this.popisekZáloha);
            this.Controls.Add(this.popisekVěta);
            this.Controls.Add(this.polePůvodníZáloha);
            this.Controls.Add(this.poleZáloha);
            this.Controls.Add(this.tlačítkoZálohuj);
            this.Controls.Add(this.poleVěta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Dvojitá záloha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleVěta;
        private System.Windows.Forms.Button tlačítkoZálohuj;
        private System.Windows.Forms.TextBox poleZáloha;
        private System.Windows.Forms.TextBox polePůvodníZáloha;
        private System.Windows.Forms.Label popisekVěta;
        private System.Windows.Forms.Label popisekZáloha;
        private System.Windows.Forms.Label popisekPůvodníZáloha;
    }
}

