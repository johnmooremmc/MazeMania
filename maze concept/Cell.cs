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

        public bool rightwall = true;
        public bool bottomwall = true;

        public bool visited = false;
        
        internal void DrawCells(Graphics g)
        {

            Pen Pen = Pens.Black;
            Brush br = Brushes.Black;

           if (rightwall)
            {
                g.DrawLine(Pen, x + width, y, x + width, y + height);

            }
            if (bottomwall)
            {
                g.DrawLine(Pen, x, y+ height, x + width, y + height);

            }
            if (visited)
            { 
                g.FillEllipse(br, x + width / 4, y + height / 4, width/2, height/2);
            }



        }
    
        public Cell(int i, int j, bool wall)
        {
            width = 25;
            height = 25;

            x = i *width;
            y = j *height;

           
            


        }
    
    
    
    
    
    
    }
}
