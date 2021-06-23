﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace maze_concept
{
    class Cell
    {
        
        public int width, height;
        public int x, y;

        public bool rightwall = true;
        public bool bottomwall = true;

        public bool visited = false;
        
        internal void DrawCells(Graphics g)
        {

            Pen Pen = new Pen(Color.Orange);

            Pen.Width = 2;


            if (rightwall)
            {
                g.DrawLine(Pen, x + width, y, x + width, y + height);

            }
            if (bottomwall)
            {
                g.DrawLine(Pen, x, y+ height, x + width, y + height);

            }
            g.DrawLine(Pen, 0, y, 0, y + this.height);
            g.DrawLine(Pen, x, 0, x + this.width, 0);


        }
    
        public Cell(int i, int j, bool wall)
        {
            width = 50;
            height = 50;

            x = i *width;
            y = j *height;

           
            


        }
    
    
    
    
    
    
    }
}
