namespace Zahození_návratové_hodnoty
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
            this.popisekZadejteÚdaj = new System.Windows.Forms.Label();
            this.poleÚdaj = new System.Windows.Forms.TextBox();
            this.tlačítkoZjisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisekZadejteÚdaj
            // 
            this.popisekZadejteÚdaj.AutoSize = true;
            this.popisekZadejteÚdaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisekZadejteÚdaj.Location = new System.Drawing.Point(35, 28);
            this.popisekZadejteÚdaj.Name = "popisekZadejteÚdaj";
            this.popisekZadejteÚdaj.Size = new System.Drawing.Size(132, 24);
            this.popisekZadejteÚdaj.TabIndex = 0;
            this.popisekZadejteÚdaj.Text = "Z&adejte údaj:";
            // 
            // poleÚdaj
            // 
            this.poleÚdaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.poleÚdaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleÚdaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.poleÚdaj.Location = new System.Drawing.Point(188, 25);
            this.poleÚdaj.Name = "poleÚdaj";
            this.poleÚdaj.Size = new System.Drawing.Size(206, 29);
            this.poleÚdaj.TabIndex = 1;
            // 
            // tlačítkoZjisti
            // 
            this.tlačítkoZjisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlačítkoZjisti.Location = new System.Drawing.Point(112, 80);
            this.tlačítkoZjisti.Name = "tlačítkoZjisti";
            this.tlačítkoZjisti.Size = new System.Drawing.Size(205, 33);
            this.tlačítkoZjisti.TabIndex = 2;
            this.tlačítkoZjisti.Text = "&Zjisti druh údaje";
            this.tlačítkoZjisti.UseVisualStyleBackColor = true;
            this.tlačítkoZjisti.Click += new System.EventHandler(this.tlačítkoZjisti_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.tlačítkoZjisti;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 138);
            this.Controls.Add(this.tlačítkoZjisti);
            this.Controls.Add(this.poleÚdaj);
            this.Controls.Add(this.popisekZadejteÚdaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Zahození návratové hodnoty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekZadejteÚdaj;
        private System.Windows.Forms.TextBox poleÚdaj;
        private System.Windows.Forms.Button tlačítkoZjisti;
    }
}

