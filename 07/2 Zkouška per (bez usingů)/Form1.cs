namespace Zkouška_per
{
    public partial class oknoProgramu : System.Windows.Forms.Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Graphics kp = e.Graphics;

            // Vytvoříme nové pero
            System.Drawing.Pen modréPero = new System.Drawing.Pen(System.Drawing.Color.Blue);
            kp.DrawLine(modréPero, 20, 0, 20, 100);
            
            // Změníme tloušťku pera na 10 pixelů
            modréPero.Width = 10;
            kp.DrawLine(modréPero, 40, 0, 40, 100);

            // Změníme barvu pera na světle modrou
            modréPero.Color = System.Drawing.Color.LightBlue;
            kp.DrawLine(modréPero, 60, 0, 60, 100);

            // Další pero dvouparametrickým konstruktorem
            System.Drawing.Pen červenéPero = new System.Drawing.Pen(System.Drawing.Color.Red, 20);
            kp.DrawLine(červenéPero, 100, 0, 100, 100);
        }
    }
}