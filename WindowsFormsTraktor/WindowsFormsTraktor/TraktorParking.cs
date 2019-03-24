using System.Drawing;

namespace WindowsFormsTraktor
{
    public class TraktorParking<T> where T : class, ITransport
    {
        private T[] ParkingPlaces;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        private const int ParkingPlaceWidth = 110;
        private const int ParkingPlaceHeight = 70;

        public TraktorParking(int size, int picwidth, int picheight)
        {
            ParkingPlaces = new T[size];
            PictureWidth = picwidth;
            PictureHeight = picheight;
            for (int i = 0; i < ParkingPlaces.Length; i++)
            {
                ParkingPlaces[i] = null;
            }
        }

        private bool CheckFreePlace(int placeid)
        {
            return ParkingPlaces[placeid] == null;
        }

        public static int operator +(TraktorParking<T> p, T newtraktor)
        {
            for (int i = 0; i < p.ParkingPlaces.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.ParkingPlaces[i] = newtraktor;
                    p.ParkingPlaces[i].SetStartPosition(5 + i / 5 * ParkingPlaceWidth + 5, i % 5 * ParkingPlaceHeight + 15, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(TraktorParking<T> p, int index)
        {
            if (index < 0 || index > p.ParkingPlaces.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T newtraktor = p.ParkingPlaces[index];
                p.ParkingPlaces[index] = null;
                return newtraktor;
            }
            return null;
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (ParkingPlaces.Length / 5) * ParkingPlaceWidth, 480);
            for (int i = 0; i < ParkingPlaces.Length / 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * ParkingPlaceWidth, j * ParkingPlaceHeight,
                    i * ParkingPlaceWidth + 110, j * ParkingPlaceHeight);
                }
                g.DrawLine(pen, i * ParkingPlaceWidth, 0, i * ParkingPlaceWidth, 400);
            }
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < ParkingPlaces.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    ParkingPlaces[i].DrawTransport(g);
                }
            }
        }
    }
}
