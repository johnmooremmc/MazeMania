using System;
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


        internal void DrawCells(Graphics g)
        {

            Pen Pen = Pens.Black;
            g.DrawRectangle(Pen, x, y, width, height);
            



        }
    
        public Cell(int i, int j)
        {
            width = 25;
            height = 25;

            x = i *width;
            y = j *height;

        }
    
    
    
    
    
    
    }
}
