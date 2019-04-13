using System.Drawing;

namespace WindowsFormsTraktor
{
    public interface ITransport
    {
        void SetStartPosition(int x, int y, int picwidth, int picheight);
        void MoveTransport(MovingDirections direction);
        void DrawTransport(Graphics g);
    }
}
