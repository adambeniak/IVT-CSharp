namespace Tečka_na_zadané_pozici
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.popisekX = new System.Windows.Forms.Label();
            this.poleX = new System.Windows.Forms.TextBox();
            this.popisekY = new System.Windows.Forms.Label();
            this.poleY = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekX
            // 
            this.popisekX.AutoSize = true;
            this.popisekX.Location = new System.Drawing.Point(16, 76);
            this.popisekX.Name = "popisekX";
            this.popisekX.Size = new System.Drawing.Size(17, 13);
            this.popisekX.TabIndex = 0;
            this.popisekX.Text = "&X:";
            // 
            // poleX
            // 
            this.poleX.Location = new System.Drawing.Point(39, 73);
            this.poleX.Name = "poleX";
            this.poleX.Size = new System.Drawing.Size(55, 20);
            this.poleX.TabIndex = 1;
            this.poleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekY
            // 
            this.popisekY.AutoSize = true;
            this.popisekY.Location = new System.Drawing.Point(16, 114);
            this.popisekY.Name = "popisekY";
            this.popisekY.Size = new System.Drawing.Size(17, 13);
            this.popisekY.TabIndex = 2;
            this.popisekY.Text = "&Y:";
            // 
            // poleY
            // 
            this.poleY.Location = new System.Drawing.Point(39, 111);
            this.poleY.Name = "poleY";
            this.poleY.Size = new System.Drawing.Size(55, 20);
            this.poleY.TabIndex = 3;
            this.poleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(113, 22);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 200);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(19, 149);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(75, 23);
            this.tlačítkoPřekresli.TabIndex = 4;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 244);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.poleY);
            this.Controls.Add(this.popisekY);
            this.Controls.Add(this.poleX);
            this.Controls.Add(this.popisekX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Tečka na zadané pozici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekX;
        private System.Windows.Forms.TextBox poleX;
        private System.Windows.Forms.Label popisekY;
        private System.Windows.Forms.TextBox poleY;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button tlačítkoPřekresli;
    }
}

