using System.Drawing;

namespace WindowsFormsTraktor
{
    class TraktorExcavator : Traktor
    {
        Color DopColor;
        
        public bool IsFrontBailer { private set; get; }
        public bool IsBackBailer { private set; get; }

        public TraktorExcavator(Color main, Color dop, int step, int startx, int starty, int picwidth, int picheight, bool frontbailer, bool backbailer) : base (main, step, startx, starty, picwidth, picheight)
        {
            MainColor = main;
            DopColor = dop;
            MovingStep = step;
            StartPosX = startx;
            StartPosY = starty;
            PictureWidth = picwidth;
            PictureHeight = picheight;
            IsFrontBailer = frontbailer;
            IsBackBailer = backbailer;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Brush DopBrush = new SolidBrush(DopColor);
            Brush BrownBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(DopBrush, StartPosX + 15, StartPosY, 20, 25);
            g.FillRectangle(DopBrush, StartPosX + 55, StartPosY + 10, 5, 15);
            g.FillRectangle(new SolidBrush(Color.Black), StartPosX + 20, StartPosY + 5, 10, 15);
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
