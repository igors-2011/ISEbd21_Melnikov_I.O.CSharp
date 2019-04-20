using System;
using System.Drawing;

namespace WindowsFormsTraktor
{
    public class Traktor : Vehicle
    {
        private const int TraktorWidth = 90;
        private const int TraktorHeight = 50;

        public Traktor(Color main, int step, int startx, int starty, int picwidth, int picheight)
        {
            MainColor = main;
            StartPosX = startx;
            StartPosY = starty;
            PictureWidth = picwidth;
            PictureHeight = picheight;
            MovingStep = step;
        }

        public Traktor(string information)
        {
            string[] traktorinfo = information.Split(';');
            if (traktorinfo.Length == 6)
            {
                MainColor = Color.FromName(traktorinfo[0]);
                StartPosX = Convert.ToInt32(traktorinfo[1]);
                StartPosY = Convert.ToInt32(traktorinfo[2]);
                PictureWidth = Convert.ToInt32(traktorinfo[3]);
                PictureHeight = Convert.ToInt32(traktorinfo[4]);
                MovingStep = Convert.ToInt32(traktorinfo[5]);
            }
        }

        public override void MoveTransport(MovingDirections direction)
        {
            switch (direction)
            {
                case MovingDirections.up:
                    if (StartPosY - MovingStep >= 0)
                    {
                        StartPosY -= MovingStep;
                    }
                    break;
                case MovingDirections.down:
                    if (StartPosY + MovingStep <= PictureHeight - TraktorHeight)
                    {
                        StartPosY += MovingStep;
                    }
                    break;
                case MovingDirections.left:
                    if (StartPosX - MovingStep >= 0)
                    {
                        StartPosX -= MovingStep;
                    }
                    break;
                case MovingDirections.right:
                    if (StartPosX + MovingStep <= PictureWidth - TraktorWidth)
                    {
                        StartPosX += MovingStep;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Brush MainBrush = new SolidBrush(MainColor);
            Brush BlackBrush = new SolidBrush(Color.Black);
            Brush GrayBrush = new SolidBrush(Color.Gray);
            g.FillRectangle(MainBrush, StartPosX + 15, StartPosY, 20, 25);
            g.FillRectangle(BlackBrush, StartPosX + 20, StartPosY + 5, 10, 15);
            g.FillRectangle(MainBrush, StartPosX + 55, StartPosY + 10, 5, 15);
            g.FillPolygon(MainBrush, new Point[]
            {
                new Point(StartPosX + 35, StartPosY + 20),
                new Point(StartPosX + 70, StartPosY + 25),
                new Point(StartPosX + 70, StartPosY + 40),
                new Point(StartPosX + 10, StartPosY + 40),
                new Point(StartPosX + 10, StartPosY + 30),
                new Point(StartPosX + 15, StartPosY + 25),
                new Point(StartPosX + 35, StartPosY + 25)
            });
            g.FillEllipse(BlackBrush, StartPosX + 10, StartPosY + 30, 20, 20);
            g.FillEllipse(GrayBrush, StartPosX + 15, StartPosY + 35, 10, 10);
            g.FillEllipse(BlackBrush, StartPosX + 50, StartPosY + 35, 15, 15);
            g.FillEllipse(GrayBrush, StartPosX + 55, StartPosY + 40, 5, 5);
        }
        public override string ToString()
        {
            return "" + MainColor.Name + ';' + StartPosX + ';' + StartPosY + ';' + PictureWidth + ';' + PictureHeight + ';' + MovingStep;
        }
    }
}
