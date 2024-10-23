namespace Odstíny_šedi
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
            this.popisekOdstín = new System.Windows.Forms.Label();
            this.poleOdstín = new System.Windows.Forms.TextBox();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // popisekOdstín
            // 
            this.popisekOdstín.AutoSize = true;
            this.popisekOdstín.Location = new System.Drawing.Point(15, 38);
            this.popisekOdstín.Name = "popisekOdstín";
            this.popisekOdstín.Size = new System.Drawing.Size(78, 13);
            this.popisekOdstín.TabIndex = 0;
            this.popisekOdstín.Text = "&Odstín (0-255):";
            // 
            // poleOdstín
            // 
            this.poleOdstín.Location = new System.Drawing.Point(99, 35);
            this.poleOdstín.Name = "poleOdstín";
            this.poleOdstín.Size = new System.Drawing.Size(31, 20);
            this.poleOdstín.TabIndex = 1;
            this.poleOdstín.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(18, 70);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(112, 23);
            this.tlačítkoPřekresli.TabIndex = 2;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(147, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(100, 100);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 129);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.poleOdstín);
            this.Controls.Add(this.popisekOdstín);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Odstíny šedi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekOdstín;
        private System.Windows.Forms.TextBox poleOdstín;
        private System.Windows.Forms.Button tlačítkoPřekresli;
        private System.Windows.Forms.Panel panel;
    }
}

