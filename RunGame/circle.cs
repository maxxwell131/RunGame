using System.Drawing;

namespace RunGame
{
    class Circle: Игрок
    {
        public Point center { get; private set; }
        public int radius { get; private set; }
        public Color color { get; private set; }
        int sx, sy;

        public Circle( int x, int y, int radius)
        {
            center = new Point( x, y);
            this.radius = radius;
            color = Color.Blue;
        }

        public void Беги()
        {

        }

        public void Голя()
        {
            color = Color.Red;
        }

        public void НеГоля()
        {
            color = Color.Blue;
        }

        public bool Поймал(object obj)
        {

        }
    }
}
