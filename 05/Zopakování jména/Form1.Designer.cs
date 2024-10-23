namespace Zopakování_jména
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
            this.popisekJméno = new System.Windows.Forms.Label();
            this.poleJméno = new System.Windows.Forms.TextBox();
            this.tlačítkoZobraz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekJméno
            // 
            this.popisekJméno.AutoSize = true;
            this.popisekJméno.Location = new System.Drawing.Point(38, 42);
            this.popisekJméno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.popisekJméno.Name = "popisekJméno";
            this.popisekJméno.Size = new System.Drawing.Size(127, 24);
            this.popisekJméno.TabIndex = 0;
            this.popisekJméno.Text = "&Vaše jméno:";
            // 
            // poleJméno
            // 
            this.poleJméno.Location = new System.Drawing.Point(180, 37);
            this.poleJméno.Margin = new System.Windows.Forms.Padding(6);
            this.poleJméno.Name = "poleJméno";
            this.poleJméno.Size = new System.Drawing.Size(320, 29);
            this.poleJméno.TabIndex = 1;
            // 
            // tlačítkoZobraz
            // 
            this.tlačítkoZobraz.Location = new System.Drawing.Point(156, 107);
            this.tlačítkoZobraz.Margin = new System.Windows.Forms.Padding(6);
            this.tlačítkoZobraz.Name = "tlačítkoZobraz";
            this.tlačítkoZobraz.Size = new System.Drawing.Size(228, 42);
            this.tlačítkoZobraz.TabIndex = 2;
            this.tlačítkoZobraz.Text = "&Zobraz zprávu";
            this.tlačítkoZobraz.UseVisualStyleBackColor = true;
            this.tlačítkoZobraz.Click += new System.EventHandler(this.tlačítkoZobraz_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoZobraz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 185);
            this.Controls.Add(this.tlačítkoZobraz);
            this.Controls.Add(this.poleJméno);
            this.Controls.Add(this.popisekJméno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Zopakování jména";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekJméno;
        private System.Windows.Forms.TextBox poleJméno;
        private System.Windows.Forms.Button tlačítkoZobraz;
    }
}

