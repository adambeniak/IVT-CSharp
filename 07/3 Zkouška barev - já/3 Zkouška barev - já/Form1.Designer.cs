
namespace _3_Zkouška_barev___já
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
            this.popisekPurpurová = new System.Windows.Forms.Label();
            this.popisekMíchaná = new System.Windows.Forms.Label();
            this.popisekR1 = new System.Windows.Forms.Label();
            this.popisekG1 = new System.Windows.Forms.Label();
            this.popisekB1 = new System.Windows.Forms.Label();
            this.polePurpurováR = new System.Windows.Forms.TextBox();
            this.polePurpurováG = new System.Windows.Forms.TextBox();
            this.polePurpurováB = new System.Windows.Forms.TextBox();
            this.poleMíchanáB = new System.Windows.Forms.TextBox();
            this.poleMíchanáG = new System.Windows.Forms.TextBox();
            this.poleMíchanáR = new System.Windows.Forms.TextBox();
            this.popisekB2 = new System.Windows.Forms.Label();
            this.popisekG2 = new System.Windows.Forms.Label();
            this.popisekR2 = new System.Windows.Forms.Label();
            this.panelPurpurová = new System.Windows.Forms.Panel();
            this.panelMíchaná = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // popisekPurpurová
            // 
            this.popisekPurpurová.AutoSize = true;
            this.popisekPurpurová.Location = new System.Drawing.Point(29, 22);
            this.popisekPurpurová.Name = "popisekPurpurová";
            this.popisekPurpurová.Size = new System.Drawing.Size(163, 24);
            this.popisekPurpurová.TabIndex = 0;
            this.popisekPurpurová.Text = "Purpurová barva";
            // 
            // popisekMíchaná
            // 
            this.popisekMíchaná.AutoSize = true;
            this.popisekMíchaná.Location = new System.Drawing.Point(29, 248);
            this.popisekMíchaná.Name = "popisekMíchaná";
            this.popisekMíchaná.Size = new System.Drawing.Size(146, 24);
            this.popisekMíchaná.TabIndex = 1;
            this.popisekMíchaná.Text = "Míchaná barva";
            // 
            // popisekR1
            // 
            this.popisekR1.AutoSize = true;
            this.popisekR1.Location = new System.Drawing.Point(33, 69);
            this.popisekR1.Name = "popisekR1";
            this.popisekR1.Size = new System.Drawing.Size(30, 24);
            this.popisekR1.TabIndex = 2;
            this.popisekR1.Text = "R:";
            // 
            // popisekG1
            // 
            this.popisekG1.AutoSize = true;
            this.popisekG1.Location = new System.Drawing.Point(33, 120);
            this.popisekG1.Name = "popisekG1";
            this.popisekG1.Size = new System.Drawing.Size(31, 24);
            this.popisekG1.TabIndex = 3;
            this.popisekG1.Text = "G:";
            // 
            // popisekB1
            // 
            this.popisekB1.AutoSize = true;
            this.popisekB1.Location = new System.Drawing.Point(33, 174);
            this.popisekB1.Name = "popisekB1";
            this.popisekB1.Size = new System.Drawing.Size(29, 24);
            this.popisekB1.TabIndex = 4;
            this.popisekB1.Text = "B:";
            // 
            // polePurpurováR
            // 
            this.polePurpurováR.Location = new System.Drawing.Point(92, 66);
            this.polePurpurováR.Name = "polePurpurováR";
            this.polePurpurováR.ReadOnly = true;
            this.polePurpurováR.Size = new System.Drawing.Size(100, 29);
            this.polePurpurováR.TabIndex = 5;
            this.polePurpurováR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // polePurpurováG
            // 
            this.polePurpurováG.Location = new System.Drawing.Point(92, 117);
            this.polePurpurováG.Name = "polePurpurováG";
            this.polePurpurováG.ReadOnly = true;
            this.polePurpurováG.Size = new System.Drawing.Size(100, 29);
            this.polePurpurováG.TabIndex = 6;
            this.polePurpurováG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // polePurpurováB
            // 
            this.polePurpurováB.Location = new System.Drawing.Point(92, 171);
            this.polePurpurováB.Name = "polePurpurováB";
            this.polePurpurováB.ReadOnly = true;
            this.polePurpurováB.Size = new System.Drawing.Size(100, 29);
            this.polePurpurováB.TabIndex = 7;
            this.polePurpurováB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleMíchanáB
            // 
            this.poleMíchanáB.Location = new System.Drawing.Point(92, 395);
            this.poleMíchanáB.Name = "poleMíchanáB";
            this.poleMíchanáB.Size = new System.Drawing.Size(100, 29);
            this.poleMíchanáB.TabIndex = 13;
            this.poleMíchanáB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleMíchanáB.TextChanged += new System.EventHandler(this.všechnaPoleMíchaná_TextChanged);
            // 
            // poleMíchanáG
            // 
            this.poleMíchanáG.Location = new System.Drawing.Point(92, 341);
            this.poleMíchanáG.Name = "poleMíchanáG";
            this.poleMíchanáG.Size = new System.Drawing.Size(100, 29);
            this.poleMíchanáG.TabIndex = 12;
            this.poleMíchanáG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleMíchanáG.TextChanged += new System.EventHandler(this.všechnaPoleMíchaná_TextChanged);
            // 
            // poleMíchanáR
            // 
            this.poleMíchanáR.Location = new System.Drawing.Point(92, 290);
            this.poleMíchanáR.Name = "poleMíchanáR";
            this.poleMíchanáR.Size = new System.Drawing.Size(100, 29);
            this.poleMíchanáR.TabIndex = 11;
            this.poleMíchanáR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleMíchanáR.TextChanged += new System.EventHandler(this.všechnaPoleMíchaná_TextChanged);
            // 
            // popisekB2
            // 
            this.popisekB2.AutoSize = true;
            this.popisekB2.Location = new System.Drawing.Point(33, 398);
            this.popisekB2.Name = "popisekB2";
            this.popisekB2.Size = new System.Drawing.Size(29, 24);
            this.popisekB2.TabIndex = 10;
            this.popisekB2.Text = "B:";
            // 
            // popisekG2
            // 
            this.popisekG2.AutoSize = true;
            this.popisekG2.Location = new System.Drawing.Point(33, 344);
            this.popisekG2.Name = "popisekG2";
            this.popisekG2.Size = new System.Drawing.Size(31, 24);
            this.popisekG2.TabIndex = 9;
            this.popisekG2.Text = "G:";
            // 
            // popisekR2
            // 
            this.popisekR2.AutoSize = true;
            this.popisekR2.Location = new System.Drawing.Point(33, 293);
            this.popisekR2.Name = "popisekR2";
            this.popisekR2.Size = new System.Drawing.Size(30, 24);
            this.popisekR2.TabIndex = 8;
            this.popisekR2.Text = "R:";
            // 
            // panelPurpurová
            // 
            this.panelPurpurová.Location = new System.Drawing.Point(229, 49);
            this.panelPurpurová.Name = "panelPurpurová";
            this.panelPurpurová.Size = new System.Drawing.Size(170, 170);
            this.panelPurpurová.TabIndex = 14;
            this.panelPurpurová.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPurpurová_Paint);
            // 
            // panelMíchaná
            // 
            this.panelMíchaná.Location = new System.Drawing.Point(229, 273);
            this.panelMíchaná.Name = "panelMíchaná";
            this.panelMíchaná.Size = new System.Drawing.Size(170, 170);
            this.panelMíchaná.TabIndex = 15;
            this.panelMíchaná.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMíchaná_Paint);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 485);
            this.Controls.Add(this.panelMíchaná);
            this.Controls.Add(this.panelPurpurová);
            this.Controls.Add(this.poleMíchanáB);
            this.Controls.Add(this.poleMíchanáG);
            this.Controls.Add(this.poleMíchanáR);
            this.Controls.Add(this.popisekB2);
            this.Controls.Add(this.popisekG2);
            this.Controls.Add(this.popisekR2);
            this.Controls.Add(this.polePurpurováB);
            this.Controls.Add(this.polePurpurováG);
            this.Controls.Add(this.polePurpurováR);
            this.Controls.Add(this.popisekB1);
            this.Controls.Add(this.popisekG1);
            this.Controls.Add(this.popisekR1);
            this.Controls.Add(this.popisekMíchaná);
            this.Controls.Add(this.popisekPurpurová);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "oknoProgramu";
            this.Text = "Zkouška barev";
            this.Load += new System.EventHandler(this.oknoProgramu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekPurpurová;
        private System.Windows.Forms.Label popisekMíchaná;
        private System.Windows.Forms.Label popisekR1;
        private System.Windows.Forms.Label popisekG1;
        private System.Windows.Forms.Label popisekB1;
        private System.Windows.Forms.TextBox polePurpurováR;
        private System.Windows.Forms.TextBox polePurpurováG;
        private System.Windows.Forms.TextBox polePurpurováB;
        private System.Windows.Forms.TextBox poleMíchanáB;
        private System.Windows.Forms.TextBox poleMíchanáG;
        private System.Windows.Forms.TextBox poleMíchanáR;
        private System.Windows.Forms.Label popisekB2;
        private System.Windows.Forms.Label popisekG2;
        private System.Windows.Forms.Label popisekR2;
        private System.Windows.Forms.Panel panelPurpurová;
        private System.Windows.Forms.Panel panelMíchaná;
    }
}

