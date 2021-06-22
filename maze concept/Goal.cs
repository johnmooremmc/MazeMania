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

        

        public void DrawGoal(Graphics g, Image goalSkin)
        {

            width = 45;
            height = 45;
            

            g.DrawImage(goalSkin, x + 2, y + 2, width, height);
            

        }

    }
}
