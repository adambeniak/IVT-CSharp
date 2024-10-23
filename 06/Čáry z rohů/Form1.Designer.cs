namespace Čáry_z_rohů
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
            this.SuspendLayout();
            // 
            // popisekX
            // 
            this.popisekX.AutoSize = true;
            this.popisekX.Location = new System.Drawing.Point(27, 147);
            this.popisekX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.popisekX.Name = "popisekX";
            this.popisekX.Size = new System.Drawing.Size(26, 20);
            this.popisekX.TabIndex = 0;
            this.popisekX.Text = "&X:";
            // 
            // poleX
            // 
            this.poleX.Location = new System.Drawing.Point(65, 143);
            this.poleX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.poleX.Name = "poleX";
            this.poleX.Size = new System.Drawing.Size(89, 26);
            this.poleX.TabIndex = 1;
            this.poleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleX.TextChanged += new System.EventHandler(this.poleXiY_TextChanged);
            // 
            // popisekY
            // 
            this.popisekY.AutoSize = true;
            this.popisekY.Location = new System.Drawing.Point(27, 206);
            this.popisekY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.popisekY.Name = "popisekY";
            this.popisekY.Size = new System.Drawing.Size(26, 20);
            this.popisekY.TabIndex = 2;
            this.popisekY.Text = "&Y:";
            // 
            // poleY
            // 
            this.poleY.Location = new System.Drawing.Point(65, 202);
            this.poleY.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.poleY.Name = "poleY";
            this.poleY.Size = new System.Drawing.Size(89, 26);
            this.poleY.TabIndex = 3;
            this.poleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poleY.TextChanged += new System.EventHandler(this.poleXiY_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MistyRose;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(188, 14);
            this.panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(346, 347);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.poleY);
            this.Controls.Add(this.popisekY);
            this.Controls.Add(this.poleX);
            this.Controls.Add(this.popisekX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Čáry z rohů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekX;
        private System.Windows.Forms.TextBox poleX;
        private System.Windows.Forms.Label popisekY;
        private System.Windows.Forms.TextBox poleY;
        private System.Windows.Forms.Panel panel;
    }
}

