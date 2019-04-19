using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsTraktor
{
    public class TraktorParking<T> where T : class, ITransport
    {
        private Dictionary<int, T> ParkingPlaces;

        private int MaxPlacesOnParking;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        private const int ParkingPlaceWidth = 110;
        private const int ParkingPlaceHeight = 70;

        public TraktorParking(int size, int picwidth, int picheight)
        {
            MaxPlacesOnParking = size;
            ParkingPlaces = new Dictionary<int, T>();
            PictureWidth = picwidth;
            PictureHeight = picheight;
        }

        private bool CheckFreePlace(int index)
        {
            return !ParkingPlaces.ContainsKey(index);
        }

        public static int operator +(TraktorParking<T> p, T newtraktor)
        {
            if (p.ParkingPlaces.Count == p.MaxPlacesOnParking)
            {
                return -1;
            }
            for (int i = 0; i < p.MaxPlacesOnParking; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.ParkingPlaces.Add(i, newtraktor);
                    p.ParkingPlaces[i].SetStartPosition(5 + i / 5 * ParkingPlaceWidth + 5, i % 5 * ParkingPlaceHeight + 15, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(TraktorParking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T newtraktor = p.ParkingPlaces[index];
                p.ParkingPlaces.Remove(index);
                return newtraktor;
            }
            return null;
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 5);
            g.DrawRectangle(pen, 0, 0, (MaxPlacesOnParking / 5) * ParkingPlaceWidth, 350);
            for (int i = 0; i < MaxPlacesOnParking / 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * ParkingPlaceWidth, j * ParkingPlaceHeight, i * ParkingPlaceWidth + 110, j * ParkingPlaceHeight);
                }
                g.DrawLine(pen, i * ParkingPlaceWidth, 0, i * ParkingPlaceWidth, 350);
            }
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = ParkingPlaces.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                ParkingPlaces[keys[i]].DrawTransport(g);
            }
        }

        public T this[int ind]
        {
            get
            {
                if (ParkingPlaces.ContainsKey(ind))
                {
                    return ParkingPlaces[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    ParkingPlaces.Add(ind, value);
                    ParkingPlaces[ind].SetStartPosition(5 + ind / 5 * ParkingPlaceWidth + 5, ind % 5 * ParkingPlaceHeight + 15, PictureWidth, PictureHeight);
                }
            }
        }
    }
}
