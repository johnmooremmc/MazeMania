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
        // defines integer variables for this class

        public Image avatarSkin = Properties.Resources.Avatar1;
        // deefines a source method for recieving an image

        public void DrawAvatar(Graphics g, string skin)
        {           

            width = 45;
            height = 45;
            // defines integer values for the avater properties which will be drawn 

            g.DrawImage(avatarSkin, x+2, y+2, width, height);
            // draws avater on grid using x and y positions defined elsewhere

            if (skin == "1")
                // if the skin string sent in method = 1
            {
                avatarSkin = Properties.Resources.Avatar3;
                // define the image source of avatarskin as
            }
            if (skin == "2")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar2;
                // define the image source of avatarskin as
            }
            if (skin == "3")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar1;
                // define the image source of avatarskin as
            }
            if (skin == "4")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar4;
                // define the image source of avatarskin as
            }
            if (skin == "5")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar5;
                // define the image source of avatarskin as
            }
            if (skin == "6")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar6;
                // define the image source of avatarskin as
            }
            if (skin == "7")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar7;
                // define the image source of avatarskin as
            }
            //if (skin == "8")
            //{// if the skin string sent in method =
            //    avatarSkin = Properties.Resources.Avatar8;
                  // define the image source of avatarskin as
            //}
            if (skin == "9")
            {// if the skin string sent in method =
                avatarSkin = Properties.Resources.Avatar9;
                // define the image source of avatarskin as
            }
            //if (skin == "10")
            //{// if the skin string sent in method =
            //    avatarSkin = Properties.Resources.Avatar10;
                  // define the image source of avatarskin as
            //}


        }

    }
}
