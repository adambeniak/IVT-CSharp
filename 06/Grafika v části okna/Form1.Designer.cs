namespace Grafika_v_části_okna
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
            this.panel = new System.Windows.Forms.Panel();
            this.popisekXstředu = new System.Windows.Forms.Label();
            this.poleXstředu = new System.Windows.Forms.TextBox();
            this.popisekYStředu = new System.Windows.Forms.Label();
            this.poleYstředu = new System.Windows.Forms.TextBox();
            this.popisekŠířka = new System.Windows.Forms.Label();
            this.poleŠířka = new System.Windows.Forms.TextBox();
            this.popisekVýška = new System.Windows.Forms.Label();
            this.poleVýška = new System.Windows.Forms.TextBox();
            this.tlačítkoPřekresli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(130, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 200);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // popisekXstředu
            // 
            this.popisekXstředu.AutoSize = true;
            this.popisekXstředu.Location = new System.Drawing.Point(13, 25);
            this.popisekXstředu.Name = "popisekXstředu";
            this.popisekXstředu.Size = new System.Drawing.Size(50, 13);
            this.popisekXstředu.TabIndex = 4;
            this.popisekXstředu.Text = "&X středu:";
            // 
            // poleXstředu
            // 
            this.poleXstředu.Location = new System.Drawing.Point(67, 22);
            this.poleXstředu.MaxLength = 3;
            this.poleXstředu.Name = "poleXstředu";
            this.poleXstředu.Size = new System.Drawing.Size(48, 20);
            this.poleXstředu.TabIndex = 5;
            this.poleXstředu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekYStředu
            // 
            this.popisekYStředu.AutoSize = true;
            this.popisekYStředu.Location = new System.Drawing.Point(13, 65);
            this.popisekYStředu.Name = "popisekYStředu";
            this.popisekYStředu.Size = new System.Drawing.Size(50, 13);
            this.popisekYStředu.TabIndex = 6;
            this.popisekYStředu.Text = "&Y středu:";
            // 
            // poleYstředu
            // 
            this.poleYstředu.Location = new System.Drawing.Point(67, 62);
            this.poleYstředu.MaxLength = 3;
            this.poleYstředu.Name = "poleYstředu";
            this.poleYstředu.Size = new System.Drawing.Size(48, 20);
            this.poleYstředu.TabIndex = 7;
            this.poleYstředu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekŠířka
            // 
            this.popisekŠířka.AutoSize = true;
            this.popisekŠířka.Location = new System.Drawing.Point(13, 105);
            this.popisekŠířka.Name = "popisekŠířka";
            this.popisekŠířka.Size = new System.Drawing.Size(37, 13);
            this.popisekŠířka.TabIndex = 8;
            this.popisekŠířka.Text = "&Šířka:";
            // 
            // poleŠířka
            // 
            this.poleŠířka.Location = new System.Drawing.Point(67, 102);
            this.poleŠířka.MaxLength = 3;
            this.poleŠířka.Name = "poleŠířka";
            this.poleŠířka.Size = new System.Drawing.Size(48, 20);
            this.poleŠířka.TabIndex = 9;
            this.poleŠířka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // popisekVýška
            // 
            this.popisekVýška.AutoSize = true;
            this.popisekVýška.Location = new System.Drawing.Point(13, 145);
            this.popisekVýška.Name = "popisekVýška";
            this.popisekVýška.Size = new System.Drawing.Size(39, 13);
            this.popisekVýška.TabIndex = 10;
            this.popisekVýška.Text = "&Výška:";
            // 
            // poleVýška
            // 
            this.poleVýška.Location = new System.Drawing.Point(67, 142);
            this.poleVýška.MaxLength = 3;
            this.poleVýška.Name = "poleVýška";
            this.poleVýška.Size = new System.Drawing.Size(48, 20);
            this.poleVýška.TabIndex = 11;
            this.poleVýška.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlačítkoPřekresli
            // 
            this.tlačítkoPřekresli.Location = new System.Drawing.Point(16, 178);
            this.tlačítkoPřekresli.Name = "tlačítkoPřekresli";
            this.tlačítkoPřekresli.Size = new System.Drawing.Size(99, 23);
            this.tlačítkoPřekresli.TabIndex = 12;
            this.tlačítkoPřekresli.Text = "&Překresli";
            this.tlačítkoPřekresli.UseVisualStyleBackColor = true;
            this.tlačítkoPřekresli.Click += new System.EventHandler(this.tlačítkoPřekresli_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 226);
            this.Controls.Add(this.tlačítkoPřekresli);
            this.Controls.Add(this.poleVýška);
            this.Controls.Add(this.popisekVýška);
            this.Controls.Add(this.poleŠířka);
            this.Controls.Add(this.popisekŠířka);
            this.Controls.Add(this.poleYstředu);
            this.Controls.Add(this.popisekYStředu);
            this.Controls.Add(this.poleXstředu);
            this.Controls.Add(this.popisekXstředu);
            this.Controls.Add(this.panel);
            this.Name = "oknoProgramu";
            this.Text = "Grafika v části okna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label popisekXstředu;
        private System.Windows.Forms.TextBox poleXstředu;
        private System.Windows.Forms.Label popisekYStředu;
        private System.Windows.Forms.TextBox poleYstředu;
        private System.Windows.Forms.Label popisekŠířka;
        private System.Windows.Forms.TextBox poleŠířka;
        private System.Windows.Forms.Label popisekVýška;
        private System.Windows.Forms.TextBox poleVýška;
        private System.Windows.Forms.Button tlačítkoPřekresli;
    }
}

