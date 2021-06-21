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
        public Image avatarSkin = Properties.Resources.Avatar1;


        public void DrawAvatar(Graphics g, string skin)
        {
            Pen Pen = Pens.Yellow;
            Brush br = Brushes.Yellow;

            width = 20;
            height = 20;

            g.DrawImage(avatarSkin, x+2, y+2, width, height);

            if (skin == "1")
            {
                avatarSkin = Properties.Resources.Avatar1;
            }
            if (skin == "2")
            {
                avatarSkin = Properties.Resources.Avatar2;
            }
            if (skin == "3")
            {
                avatarSkin = Properties.Resources.Avatar3;
            }
            if (skin == "4")
            {
                avatarSkin = Properties.Resources.Avatar4;
            }
            if (skin == "5")
            {
                avatarSkin = Properties.Resources.Avatar5;
            }
            

        }

    }
}
