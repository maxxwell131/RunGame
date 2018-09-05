using System;
using System.Drawing;

namespace RunGame
{
    class Circle: Игрок
    {
        public Point center { get; private set; }
        public int radius { get; private set; }
        public Color color { get; private set; }
        int sx, sy;

        public Circle( int x, int y, int radius) : this( x, y, radius, 0, 0)
        {
        }

        public Circle( int x, int y, int radius, int sx, int sy)
        {
            center = new Point(x, y);
            this.radius = radius;
            color = Color.Blue;
            this.sx = sx;
            this.sy = sy;
        }

        public void Беги()
        {
            int x = center.X + sx;
            int y = center.Y + sy;

            if ( x < radius || x > Arena.Range.Width - radius)
            {
                sx = -sx;
            }

            if (y < radius || y > Arena.Range.Height - radius)
            {
                center = new Point(center.X + sx, center.Y + sy);
            }
        }

        public void Голя()
        {
            color = Color.Red;
        }

        public void НеГоля()
        {
            color = Color.Blue;
        }

        public bool Поймал(Игрок obj)
        {
            bool result;
            if (obj.GetType() != typeof(Circle))
            {
                result = false;
            } else
            {
                result = Cross(this, (Circle)obj);
            }
            return result;
        }

        private bool Cross(Circle c1, Circle c2)
        {
            return distance(c1.center, c2.center) < c1.radius + c2.radius;
        }

        //вычисляем расстояние между двумя окружностями
        private int distance(Point p, Point q)
        {
            return Convert.ToInt16(System.Math.Sqrt((p.X - q.X) * (p.X - q.X) + (p.Y - q.Y) * (p.Y - q.Y)));
        }
    }
}
