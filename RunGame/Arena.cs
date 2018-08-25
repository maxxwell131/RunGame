using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Clear()
        {
            graphics.Clear(picture.BackColor);
        }
    }
}
