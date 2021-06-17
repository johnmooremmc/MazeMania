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
            

            Stack<Point> history = new Stack<Point>();
            history.Clear();

            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Cells[i, j].visited = false;
                    Cells[i, j].rightwall = true;
                    Cells[i, j].bottomwall = true;
                }
            }

            Point startCell = new Point(1, 1);


            Cells[startCell.X, startCell.Y].visited = true;
            history.Push(startCell);

            while (history.Count > 0)
            {
                startCell = history.Pop();

                List<Point> lonelyNeighbours = new List<Point>();

                if (startCell.Y - 1 >= 0 && !Cells[startCell.X, startCell.Y - 1].visited)
                {
                    lonelyNeighbours.Add(new Point(startCell.X, startCell.Y - 1));
                }
                if (startCell.Y + 1 < Rows && !Cells[startCell.X, startCell.Y + 1].visited)
                {
                    lonelyNeighbours.Add(new Point(startCell.X, startCell.Y + 1));
                }
                if (startCell.X - 1 >= 0 && !Cells[startCell.X - 1, startCell.Y].visited)
                {
                    lonelyNeighbours.Add(new Point(startCell.X - 1, startCell.Y));
                }
                if (startCell.X + 1 < Columns && !Cells[startCell.X + 1, startCell.Y].visited)
                {
                    lonelyNeighbours.Add(new Point(startCell.X + 1, startCell.Y));
                }


                if (lonelyNeighbours.Count > 0)
                {
                    history.Push(startCell);

                    int dr = rand.Next(0, lonelyNeighbours.Count);
                    Point next = lonelyNeighbours[dr];

                    var V = (next.X - startCell.X, next.Y - startCell.Y);

                    if (V == (1, 0))
                    {
                        Cells[startCell.X, startCell.Y].rightwall = false;

                    }
                    if (V == (0, 1))
                    {
                        Cells[startCell.X, startCell.Y].bottomwall = false;
                    }
                    if (V == (-1, 0))
                    {
                        Cells[startCell.X -1, startCell.Y].rightwall = false;

                    }
                    if (V == (0, -1))
                    {
                        Cells[startCell.X, startCell.Y -1].bottomwall = false;
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
