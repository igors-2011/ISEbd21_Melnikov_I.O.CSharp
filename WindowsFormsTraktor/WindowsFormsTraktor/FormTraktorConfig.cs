using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTraktor
{
    public partial class FormTraktorConfig : Form
    {
        ITransport traktor = null;

        public FormTraktorConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private event TransportDelegate EventAddTransport;

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void DrawTransport()
        {
            if (traktor != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTraktor.Width, pictureBoxTraktor.Height);
                Graphics gr = Graphics.FromImage(bmp);
                traktor.SetStartPosition(10, 10, pictureBoxTraktor.Width, pictureBoxTraktor.Height);
                traktor.DrawTransport(gr);
                pictureBoxTraktor.Image = bmp;
            }
        }

        private void labelTraktor_MouseDown(object sender, MouseEventArgs e)
        {
            labelTraktor.DoDragDrop(labelTraktor.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelTraktorExcavator_MouseDown(object sender, MouseEventArgs e)
        {
            labelTraktor.DoDragDrop(labelTraktorExcavator.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelForPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelForPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Трактор":
                    traktor = new Traktor(Color.Gray, 20, 10, 10, pictureBoxTraktor.Width, pictureBoxTraktor.Height);
                    break;
                case "Трактор-экскаватор":
                    traktor = new TraktorExcavator(Color.Gray, Color.Gray, 20, 10, 10, pictureBoxTraktor.Width, pictureBoxTraktor.Height, true, true);
                    break;
            }
            DrawTransport();
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (traktor != null)
            {
                traktor.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (traktor != null)
            {
                if (traktor is TraktorExcavator)
                {
                    (traktor as TraktorExcavator).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTransport();
                }
            }
        }

        public void AddEvent(TransportDelegate ev)
        {
            if (EventAddTransport == null)
            {
                EventAddTransport = new TransportDelegate(ev);
            }
            else
            {
                EventAddTransport += ev;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            EventAddTransport?.Invoke(traktor);
            Close();
        }
    }
}
