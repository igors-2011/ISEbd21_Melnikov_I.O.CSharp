using System.Drawing;

namespace WindowsFormsTraktor
{
    public abstract class Vehicle : ITransport
    {
        

        protected int StartPosX;
        protected int StartPosY;

        protected int PictureWidth;
        protected int PictureHeight;

        public int MovingStep { protected set; get; }

        public Color MainColor;

        public void SetStartPosition(int x, int y, int picwidth, int picheight)
        {
            StartPosX = x;
            StartPosY = y;
            PictureWidth = picwidth;
            PictureHeight = picheight;
        }

        public abstract void MoveTransport(MovingDirections direction);

        public abstract void DrawTransport(Graphics g);
    }
}
