using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunGame
{
    class Arena
    {
        static public Size Range { get; private set; }
        static Random random = new Random();

        PictureBox picture;
        Graphics graphics;

        public Arena(PictureBox picture)
        {
            this.picture = picture;
            Range = picture.Size;
            this.picture.Image = new Bitmap(Range.Width, Range.Height);
            graphics = Graphics.FromImage(this.picture.Image);
            Clear();
        }

        public void Clear()
        {
            graphics.Clear(picture.BackColor);
        }

        public void Show(Circle circle)
        {
            Pen pen = new Pen(circle.color);
            graphics.DrawEllipse(pen, circle.center.X - circle.radius,
                circle.center.Y - circle.radius,
                2 * circle.radius,
                2 * circle.radius);
        }

        public void Refresh()
        {
            picture.Refresh();
        }

        static public Circle NewCircle()
        {
            int r = random.Next(Range.Width / 50, Range.Width / 20);
            int x = random.Next( r, Range.Width - r);
            int y = random.Next( r, Range.Height - r);
            int sx = random.Next( -5, +6);
            int sy = random.Next( -5, +6);
            return new Circle( x, y, r, sx, sy);
        }
    }
}
