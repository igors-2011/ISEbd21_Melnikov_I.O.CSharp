using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTraktor
{
    public partial class FormTraktorParking : Form
    {
        MultiLevelTraktorParking parking;

        private const int levels = 5;

        private void Draw()
        {
            if (listBoxParkingLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxParkingLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        public FormTraktorParking()
        {
            InitializeComponent();
            parking = new MultiLevelTraktorParking(levels, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < levels; i++)
            {
                listBoxParkingLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxParkingLevels.SelectedIndex = 0;
            Draw();
        }

        private void ParkTraktor(object sender, EventArgs e)
        {
            if (listBoxParkingLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var traktor = new Traktor(dialog.Color, 0, 100, 1000, pictureBoxParking.Width, pictureBoxParking.Height);
                    int place = parking[listBoxParkingLevels.SelectedIndex] + traktor;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void ParkTraktorExcavator(object sender, EventArgs e)
        {
            if (listBoxParkingLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var traktor = new TraktorExcavator(dialog.Color, dialogDop.Color, 0, 100, 1000, pictureBoxParking.Width, pictureBoxParking.Height, true, true);
                        int place = parking[listBoxParkingLevels.SelectedIndex] + traktor;
                        Draw();
                    }
                }
            }
        }

        private void TakeTraktor(object sender, EventArgs e)
        {
            if (listBoxParkingLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlaceNumber.Text != "")
                {
                    var traktor = parking[listBoxParkingLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlaceNumber.Text);
                    if (traktor != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakenTransport.Width, pictureBoxTakenTransport.Height);
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
        private void listBoxParkingLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
