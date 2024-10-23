namespace Výčet_TextAlign
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
            this.poleSTextem = new System.Windows.Forms.TextBox();
            this.tlačítkoDoleva = new System.Windows.Forms.Button();
            this.tlačítkoNaStřed = new System.Windows.Forms.Button();
            this.tlačítkoDoprava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poleSTextem
            // 
            this.poleSTextem.Location = new System.Drawing.Point(18, 22);
            this.poleSTextem.Name = "poleSTextem";
            this.poleSTextem.Size = new System.Drawing.Size(237, 20);
            this.poleSTextem.TabIndex = 0;
            this.poleSTextem.Text = "Jak jsem zarovnán?";
            // 
            // tlačítkoDoleva
            // 
            this.tlačítkoDoleva.Location = new System.Drawing.Point(18, 58);
            this.tlačítkoDoleva.Name = "tlačítkoDoleva";
            this.tlačítkoDoleva.Size = new System.Drawing.Size(75, 23);
            this.tlačítkoDoleva.TabIndex = 1;
            this.tlačítkoDoleva.Text = "Do&leva";
            this.tlačítkoDoleva.UseVisualStyleBackColor = true;
            this.tlačítkoDoleva.Click += new System.EventHandler(this.tlačítkoDoleva_Click);
            // 
            // tlačítkoNaStřed
            // 
            this.tlačítkoNaStřed.Location = new System.Drawing.Point(99, 58);
            this.tlačítkoNaStřed.Name = "tlačítkoNaStřed";
            this.tlačítkoNaStřed.Size = new System.Drawing.Size(75, 23);
            this.tlačítkoNaStřed.TabIndex = 1;
            this.tlačítkoNaStřed.Text = "Na &střed";
            this.tlačítkoNaStřed.UseVisualStyleBackColor = true;
            this.tlačítkoNaStřed.Click += new System.EventHandler(this.tlačítkoNaStřed_Click);
            // 
            // tlačítkoDoprava
            // 
            this.tlačítkoDoprava.Location = new System.Drawing.Point(180, 58);
            this.tlačítkoDoprava.Name = "tlačítkoDoprava";
            this.tlačítkoDoprava.Size = new System.Drawing.Size(75, 23);
            this.tlačítkoDoprava.TabIndex = 1;
            this.tlačítkoDoprava.Text = "Do&prava";
            this.tlačítkoDoprava.UseVisualStyleBackColor = true;
            this.tlačítkoDoprava.Click += new System.EventHandler(this.tlačítkoDoprava_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 102);
            this.Controls.Add(this.tlačítkoNaStřed);
            this.Controls.Add(this.tlačítkoDoprava);
            this.Controls.Add(this.tlačítkoDoleva);
            this.Controls.Add(this.poleSTextem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Výčet TextAlign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poleSTextem;
        private System.Windows.Forms.Button tlačítkoDoleva;
        private System.Windows.Forms.Button tlačítkoNaStřed;
        private System.Windows.Forms.Button tlačítkoDoprava;
    }
}

