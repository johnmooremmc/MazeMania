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



        Random rand = new Random();



        public Maze(int rows, int columns)
        {
            int x;
            int y;
            Cells = new Cell[columns, rows];

            Rows = rows;
            Columns = columns;

            for (int i = 0; i < columns; i++)
            {



                for (int j = 0; j < rows; j++)
                {



                    Cells[i, j] = new Cell(i, j, (i + j) % 2 == 0);



                }
            }


            

        }


        public void GenerateMaze()
        {
            

            Point startcell = new Point(1, 1);


            Stack<Point> history = new Stack<Point>();


            Cells[startcell.X, startcell.Y].visited = true;
            history.Push(startcell);

            while (history.Count > 0)
            {
                startcell = history.Pop();

                List<Point> lonelyNeighboors = new List<Point>();

                if (startcell.Y - 1 >= 0 && !Cells[startcell.X, startcell.Y - 1].visited)
                {
                    lonelyNeighboors.Add(new Point(startcell.X, startcell.Y - 1));
                }
                if (startcell.Y + 1 < Rows && !Cells[startcell.X, startcell.Y + 1].visited)
                {
                    lonelyNeighboors.Add(new Point(startcell.X, startcell.Y + 1));
                }
                if (startcell.X - 1 >= 0 && !Cells[startcell.X - 1, startcell.Y].visited)
                {
                    lonelyNeighboors.Add(new Point(startcell.X - 1, startcell.Y));
                }
                if (startcell.X + 1 < Columns && !Cells[startcell.X + 1, startcell.Y].visited)
                {
                    lonelyNeighboors.Add(new Point(startcell.X + 1, startcell.Y));
                }


                if (lonelyNeighboors.Count > 0)
                {
                    history.Push(startcell);

                    int dr = rand.Next(0, lonelyNeighboors.Count);
                    Point next = lonelyNeighboors[dr];

                    var V = (next.X - startcell.X, next.Y - startcell.Y);

                    if (V == (1, 0))
                    {
                        Cells[startcell.X, startcell.Y].rightwall = false;

                    }
                    if (V == (0, 1))
                    {
                        Cells[startcell.X, startcell.Y].bottomwall = false;
                    }
                    if (V == (-1, 0))
                    {
                        Cells[startcell.X -1, startcell.Y].rightwall = false;

                    }
                    if (V == (0, -1))
                    {
                        Cells[startcell.X, startcell.Y -1].bottomwall = false;
                    }

                    Cells[next.X, next.Y].visited = true;
                    history.Push(next);

                }

                //https://en.wikipedia.org/wiki/Maze_generation_algorithm#Iterative_implementation

            }


        }

        public void DrawCells(Graphics g)
        {
            for (int i = 0; i < Columns; i++)
            {



                for (int j = 0; j < Rows; j++)
                {

                    Cells[i, j].DrawCells(g);



                }
            }






        }


    }
}
