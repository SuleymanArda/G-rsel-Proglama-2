namespace MouseTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool mouse_takip = false;
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_takip = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_takip = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_takip)
            {
                var mouseKonumu = this.PointToClient(Cursor.Position);
                button1.Left = mouseKonumu.X - button1.Width / 2;
                button1.Top = mouseKonumu.Y - button1.Height / 2;
            }
        }
    }
}
