using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsFormsTraktor
{
    public partial class FormTraktor : Form
    {
        private ITransport transport;

        public FormTraktor()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTraktor.Width, pictureBoxTraktor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            transport.DrawTransport(gr);
            pictureBoxTraktor.Image = bmp;
        }

        public void CreateTraktor(object sender, EventArgs e)
        {
            transport = new Traktor(Color.Blue, 20, 0, 0, pictureBoxTraktor.Width, pictureBoxTraktor.Height);
            Draw();
        }

        public void CreateExcavator(object sender, EventArgs e)
        {
            transport = new TraktorExcavator(Color.Blue, Color.Green, 20, 0, 0, pictureBoxTraktor.Width, pictureBoxTraktor.Height, true, true);
            Draw();
        }

        public void MoveTraktor(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btn_up":
                    transport.MoveTransport(Vehicle.MovingDirections.up);
                    break;
                case "btn_down":
                    transport.MoveTransport(Vehicle.MovingDirections.down);
                    break;
                case "btn_left":
                    transport.MoveTransport(Vehicle.MovingDirections.left);
                    break;
                case "btn_right":
                    transport.MoveTransport(Vehicle.MovingDirections.right);
                    break;
            }
            Draw();
        }
    }
}
