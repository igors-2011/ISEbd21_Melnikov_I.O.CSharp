using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTraktor
{
    public partial class FormTraktorParking : Form
    {
        MultiLevelTraktorParking parking;

        FormTraktorConfig form;

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

        private void AddTransport(ITransport traktor)
        {
            if (traktor != null && listBoxParkingLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxParkingLevels.SelectedIndex] + traktor;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            form = new FormTraktorConfig();
            form.AddEvent(AddTransport);
            form.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
