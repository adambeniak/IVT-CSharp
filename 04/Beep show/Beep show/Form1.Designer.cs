
namespace Beep_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoProgramu));
            this.tlačítkoPípej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlačítkoPípej
            // 
            this.tlačítkoPípej.Location = new System.Drawing.Point(95, 86);
            this.tlačítkoPípej.Name = "tlačítkoPípej";
            this.tlačítkoPípej.Size = new System.Drawing.Size(158, 54);
            this.tlačítkoPípej.TabIndex = 0;
            this.tlačítkoPípej.Text = "&Pípej!";
            this.tlačítkoPípej.UseVisualStyleBackColor = true;
            this.tlačítkoPípej.Click += new System.EventHandler(this.tlačítkoPípej_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 226);
            this.Controls.Add(this.tlačítkoPípej);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Beep show";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlačítkoPípej;
    }
}

