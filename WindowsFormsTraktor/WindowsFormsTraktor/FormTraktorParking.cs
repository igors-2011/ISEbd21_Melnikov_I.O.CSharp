using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTraktor
{
    public partial class FormTraktorParking : Form
    {
        TraktorParking<ITransport> parking;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        public FormTraktorParking()
        {
            InitializeComponent();
            parking = new TraktorParking<ITransport>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void ParkTraktor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var traktor = new Traktor(dialog.Color, 0, 100, 1000, pictureBoxParking.Width, pictureBoxParking.Height);
                int place = parking + traktor;
                Draw();
            }
        }

        private void ParkTraktorExcavator(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var traktor = new TraktorExcavator(dialog.Color, dialogDop.Color, 0, 100, 1000, pictureBoxParking.Width, pictureBoxParking.Height, true, true);
                    int place = parking + traktor;
                    Draw();
                }
            }
        }

        private void TakeTraktor(object sender, EventArgs e)
        {
            if (maskedTextBoxPlaceNumber.Text != "")
            {
                var traktor = parking - Convert.ToInt32(maskedTextBoxPlaceNumber.Text);
                if (traktor != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakenTransport.Width,pictureBoxTakenTransport.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    traktor.SetStartPosition(5, 5, pictureBoxTakenTransport.Width, pictureBoxTakenTransport.Height);
                    traktor.DrawTransport(gr);
                    pictureBoxTakenTransport.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakenTransport.Width, pictureBoxTakenTransport.Height);
                    pictureBoxTakenTransport.Image = bmp;
                }
                Draw();
            }
        }
    }
}
