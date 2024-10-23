
namespace Úhlopříčky_0
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
            this.poleŠO = new System.Windows.Forms.TextBox();
            this.poleVO = new System.Windows.Forms.TextBox();
            this.poleŠKČO = new System.Windows.Forms.TextBox();
            this.poleVKČO = new System.Windows.Forms.TextBox();
            this.popisekVO = new System.Windows.Forms.Label();
            this.popisekŠO = new System.Windows.Forms.Label();
            this.popisekVKČO = new System.Windows.Forms.Label();
            this.popisekŠKČO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poleŠO
            // 
            this.poleŠO.Location = new System.Drawing.Point(247, 34);
            this.poleŠO.Margin = new System.Windows.Forms.Padding(6);
            this.poleŠO.Name = "poleŠO";
            this.poleŠO.ReadOnly = true;
            this.poleŠO.Size = new System.Drawing.Size(120, 29);
            this.poleŠO.TabIndex = 0;
            // 
            // poleVO
            // 
            this.poleVO.Location = new System.Drawing.Point(247, 89);
            this.poleVO.Margin = new System.Windows.Forms.Padding(6);
            this.poleVO.Name = "poleVO";
            this.poleVO.ReadOnly = true;
            this.poleVO.Size = new System.Drawing.Size(120, 29);
            this.poleVO.TabIndex = 1;
            // 
            // poleŠKČO
            // 
            this.poleŠKČO.Location = new System.Drawing.Point(247, 176);
            this.poleŠKČO.Margin = new System.Windows.Forms.Padding(6);
            this.poleŠKČO.Name = "poleŠKČO";
            this.poleŠKČO.ReadOnly = true;
            this.poleŠKČO.Size = new System.Drawing.Size(120, 29);
            this.poleŠKČO.TabIndex = 2;
            // 
            // poleVKČO
            // 
            this.poleVKČO.Location = new System.Drawing.Point(247, 232);
            this.poleVKČO.Margin = new System.Windows.Forms.Padding(6);
            this.poleVKČO.Name = "poleVKČO";
            this.poleVKČO.ReadOnly = true;
            this.poleVKČO.Size = new System.Drawing.Size(120, 29);
            this.poleVKČO.TabIndex = 3;
            // 
            // popisekVO
            // 
            this.popisekVO.AutoSize = true;
            this.popisekVO.Location = new System.Drawing.Point(29, 37);
            this.popisekVO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.popisekVO.Name = "popisekVO";
            this.popisekVO.Size = new System.Drawing.Size(111, 24);
            this.popisekVO.TabIndex = 4;
            this.popisekVO.Text = "šířka okna:";
            // 
            // popisekŠO
            // 
            this.popisekŠO.AutoSize = true;
            this.popisekŠO.Location = new System.Drawing.Point(29, 91);
            this.popisekŠO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.popisekŠO.Name = "popisekŠO";
            this.popisekŠO.Size = new System.Drawing.Size(118, 24);
            this.popisekŠO.TabIndex = 5;
            this.popisekŠO.Text = "výška okna:";
            // 
            // popisekVKČO
            // 
            this.popisekVKČO.AutoSize = true;
            this.popisekVKČO.Location = new System.Drawing.Point(29, 179);
            this.popisekVKČO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.popisekVKČO.Name = "popisekVKČO";
            this.popisekVKČO.Size = new System.Drawing.Size(144, 24);
            this.popisekVKČO.TabIndex = 6;
            this.popisekVKČO.Text = "šířka KČ okna:";
            // 
            // popisekŠKČO
            // 
            this.popisekŠKČO.AutoSize = true;
            this.popisekŠKČO.Location = new System.Drawing.Point(29, 234);
            this.popisekŠKČO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.popisekŠKČO.Name = "popisekŠKČO";
            this.popisekŠKČO.Size = new System.Drawing.Size(151, 24);
            this.popisekŠKČO.TabIndex = 7;
            this.popisekŠKČO.Text = "výška KČ okna:";
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 315);
            this.Controls.Add(this.popisekŠKČO);
            this.Controls.Add(this.popisekVKČO);
            this.Controls.Add(this.popisekŠO);
            this.Controls.Add(this.popisekVO);
            this.Controls.Add(this.poleVKČO);
            this.Controls.Add(this.poleŠKČO);
            this.Controls.Add(this.poleVO);
            this.Controls.Add(this.poleŠO);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "oknoProgramu";
            this.Text = "Úhlopříčky 0";
            this.Load += new System.EventHandler(this.oknoProgramu_Load);
            this.Resize += new System.EventHandler(this.oknoProgramu_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleŠO;
        private System.Windows.Forms.TextBox poleVO;
        private System.Windows.Forms.TextBox poleŠKČO;
        private System.Windows.Forms.TextBox poleVKČO;
        private System.Windows.Forms.Label popisekVO;
        private System.Windows.Forms.Label popisekŠO;
        private System.Windows.Forms.Label popisekVKČO;
        private System.Windows.Forms.Label popisekŠKČO;
    }
}

