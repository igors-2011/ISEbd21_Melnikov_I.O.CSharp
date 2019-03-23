using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsFormsTraktor
{
    public partial class FormTraktor : Form
    {
        private Traktor traktor;

        public FormTraktor()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTraktor.Width, pictureBoxTraktor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            traktor.DrawTraktor(gr);
            pictureBoxTraktor.Image = bmp;
        }

        public void CreateTraktor(object sender, EventArgs e)
        {
            traktor = new Traktor(Color.Blue, Color.Green, true, true, 20, 0, 0, pictureBoxTraktor.Width, pictureBoxTraktor.Height);
            Draw();
        }

        public void MoveTraktor(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btn_up":
                    traktor.MoveTraktor(Traktor.MovingDirections.up);
                    break;
                case "btn_down":
                    traktor.MoveTraktor(Traktor.MovingDirections.down);
                    break;
                case "btn_left":
                    traktor.MoveTraktor(Traktor.MovingDirections.left);
                    break;
                case "btn_right":
                    traktor.MoveTraktor(Traktor.MovingDirections.right);
                    break;
            }
            Draw();
        }
    }
}
