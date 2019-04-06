using System.Drawing;

namespace WindowsFormsTraktor
{
    public class Traktor
    {
        private int StartPosX;
        private int StartPosY;

        private int PictureWidth;
        private int PictureHeight;

        private const int TraktorWidth = 90;
        private const int TraktorHeight = 50;

        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public bool IsFrontBailer { private set; get; }
        public bool IsBackBailer { private set; get; }

        public int MovingStep { private set; get; }

        public Traktor (Color main, Color dop, bool frontbailer, bool backbailer, int step, int startx, int starty, int picwidth, int picheight)
        {
            MainColor = main;
            DopColor = dop;
            IsFrontBailer = frontbailer;
            IsBackBailer = backbailer;
            StartPosX = startx;
            StartPosY = starty;
            PictureWidth = picwidth;
            PictureHeight = picheight;
            MovingStep = step;
        }

        public void MoveTraktor(MovingDirections direction)
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

        public void DrawTraktor(Graphics g)
        {
            Brush MainBrush = new SolidBrush(MainColor);
            Brush DopBrush = new SolidBrush(DopColor);
            Brush BlackBrush = new SolidBrush(Color.Black);
            Brush GrayBrush = new SolidBrush(Color.Gray);
            Brush BrownBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(DopBrush, StartPosX + 15, StartPosY, 20, 25);
            g.FillRectangle(BlackBrush, StartPosX + 20, StartPosY + 5, 10, 15);
            g.FillRectangle(DopBrush, StartPosX + 55, StartPosY + 10, 5, 15);
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
            if (IsFrontBailer)
            {
                g.FillPolygon(BrownBrush, new Point[]
                {
                    new Point(StartPosX + 70, StartPosY + 30),
                    new Point(StartPosX + 75, StartPosY + 30),
                    new Point(StartPosX + 80, StartPosY + 25),
                    new Point(StartPosX + 80, StartPosY + 15),
                    new Point(StartPosX + 85, StartPosY + 15),
                    new Point(StartPosX + 85, StartPosY + 35),
                    new Point(StartPosX + 70, StartPosY + 35)
                });
            }
            if (IsBackBailer)
            {
                g.FillPolygon(BrownBrush, new Point[]
                {
                    new Point(StartPosX, StartPosY + 5),
                    new Point(StartPosX + 10, StartPosY + 5),
                    new Point(StartPosX + 10, StartPosY + 20),
                    new Point(StartPosX + 15, StartPosY + 20),
                    new Point(StartPosX + 15, StartPosY + 25),
                    new Point(StartPosX + 5, StartPosY + 25),
                    new Point(StartPosX + 5, StartPosY + 20),
                    new Point(StartPosX, StartPosY + 20),
                    new Point(StartPosX, StartPosY + 15),
                    new Point(StartPosX + 5, StartPosY + 15),
                    new Point(StartPosX + 5, StartPosY + 10),
                    new Point(StartPosX, StartPosY + 10)
                });
            }
        }
    }
}
