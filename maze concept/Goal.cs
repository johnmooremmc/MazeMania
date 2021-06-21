using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_concept
{
    class Goal
    {
        public int width, height;
        public int x, y;
        public Image goalSkin = Properties.Resources._32_328161_free_treasure_chest_clip_art_treasure_chest_clipart_free;


        public void DrawGoal(Graphics g)
        {
            

            width = 20;
            height = 20;
            g.DrawImage(goalSkin, x + 2, y + 2, width, height);
            

        }

    }
}
