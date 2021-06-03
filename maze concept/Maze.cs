using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace maze_concept
{
    class Maze
    {

        public int Rows;
        public int Columns;
        public Cell[,] Cells;
        

        public Maze(int rows, int columns)
        {
            int x;
            int y;
            Cells = new Cell[rows,columns];

            Rows = rows;
            Columns = columns;

            for (int i = 0; i < rows; i++)
            {
                


                for (int j = 0; j < columns; j++)
                {
                    
                    Cells[i, j] = new Cell(i, j, (i + j) % 2 == 0);

                    



                }
            }

        }

        public void DrawCells(Graphics g)
        {
            for (int i = 0; i < Rows; i++)
            {



                for (int j = 0; j < Columns; j++)
                {
                    
                    Cells[i, j].DrawCells(g);



                }
            }






        }


    }
}
