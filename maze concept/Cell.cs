using System.Drawing;


namespace maze_concept
{
    class Cell
    {

        public int width, height;
        public int x, y;
        // defines integer variables

        public bool rightwall = true;
        public bool bottomwall = true;
        // defines boolein variables

        public bool visited = false;
        // defines boolein variables


        // below is a method which can be called on from form one which requires defined graphics
        internal void DrawCells(Graphics g)
        {

            Pen Pen = new Pen(Color.Orange);
            // pen is defined as being orange

            Pen.Width = 2;
            // pen width property is defined as being a factor of 2 from the origonal width value


            if (rightwall)
            { // if the boolein right wall is true when the method is called
                g.DrawLine(Pen, x + width, y, x + width, y + height);
                // draw a line from defined y value, down a distance of height.  The right wall of the current cell
                // across a single x value
            }
            if (bottomwall)
            { // if the boolein bottle wall is true when the method is called
                g.DrawLine(Pen, x, y + height, x + width, y + height);
                // draw a line across from x to x + width
            }
            // across a single x value

            g.DrawLine(Pen, 0, y, 0, y + this.height);
            g.DrawLine(Pen, x, 0, x + this.width, 0);
            // draw two lines across the entire left side of the grid and across the entire top of the grid


        }

        public Cell(int i, int j, bool wall)
        {
            width = 50;
            height = 50;
            // a cell is defined, having a width and height of 50,50.

            x = i * width;
            y = j * height;
            // x and y position used in the method above are defined for each cell by an incremental i and j value




        }






    }
}
