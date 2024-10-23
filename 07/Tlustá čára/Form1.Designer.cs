namespace Tlustá_čára
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
            this.popisekTloušťka = new System.Windows.Forms.Label();
            this.poleTloušťka = new System.Windows.Forms.TextBox();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // popisekTloušťka
            // 
            this.popisekTloušťka.AutoSize = true;
            this.popisekTloušťka.Location = new System.Drawing.Point(14, 38);
            this.popisekTloušťka.Name = "popisekTloušťka";
            this.popisekTloušťka.Size = new System.Drawing.Size(52, 13);
            this.popisekTloušťka.TabIndex = 0;
            this.popisekTloušťka.Text = "&Tloušťka:";
            // 
            // poleTloušťka
            // 
            this.poleTloušťka.Location = new System.Drawing.Point(72, 35);
            this.poleTloušťka.Name = "poleTloušťka";
            this.poleTloušťka.Size = new System.Drawing.Size(31, 20);
            this.poleTloušťka.TabIndex = 1;
            this.poleTloušťka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(17, 70);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(86, 23);
            this.tlačítkoPřekresli.TabIndex = 2;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(119, 16);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(100, 100);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 129);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.poleTloušťka);
            this.Controls.Add(this.popisekTloušťka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Tlustá čára";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekTloušťka;
        private System.Windows.Forms.TextBox poleTloušťka;
        private System.Windows.Forms.Button tlačítkoPřekresli;
        private System.Windows.Forms.Panel panel;
    }
}

