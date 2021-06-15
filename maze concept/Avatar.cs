using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_concept
{
    class Avatar
    {
        public int width, height;
        public int x, y;

        public void DrawAvatar(Graphics g)
        {
            Pen Pen = Pens.Black;
            Brush br = Brushes.Black;

            width = 20;
            height = 20;

            

            g.DrawRectangle(Pen, x+2, y+2, width, height);
            g.FillRectangle(br, x + 2, y + 2, width, height);



        }

    }
}
