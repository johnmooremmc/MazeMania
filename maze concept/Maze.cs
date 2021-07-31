using System;
using System.Collections.Generic;
using System.Drawing;

namespace maze_concept
{
    class Maze
    {
        public int Rows;
        public int Columns;
        // defines variable integers for rows and columns of the maze grid

        public Cell[,] Cells;
        // defines the use of the class cell.cs

        Random rand = new Random();
        // defines a random which will be called on

        // below the maze is defined, recieving rows and columns
        public Maze(int rows, int columns)
        {
            Cells = new Cell[columns, rows];
            // cells is defined as the potenical for a cells position by column and row, as a list / array

            Rows = rows;
            Columns = columns;
            // defines rows and columes for use within iterative function below

            for (int i = 0; i < columns; i++)
            // for all columns defined
            {
                for (int j = 0; j < rows; j++)
                // for all rowss defined across columns
                {
                    Cells[i, j] = new Cell(i, j, (i + j) % 2 == 0);
                    // define cell by grid column ad row.

                }
            }
        }

        // below is method for generating maze
        public void GenerateMaze()
        {
            Stack<Point> history = new Stack<Point>();
            // a stack is defined for path generating algorithm

            history.Clear();
            // wipe the history for reseting the map in the future of the game

            for (int i = 0; i < Columns; i++)
            // for all cell by columns
            {
                for (int j = 0; j < Rows; j++)
                // for all rows by columns of cells
                {
                    Cells[i, j].visited = false;
                    Cells[i, j].rightwall = true;
                    Cells[i, j].bottomwall = true;
                    // define the booliens defined within cells, wall positions as true.
                    // there are walls on every cell which will be knocked down in later algorithm section
                    // also vistied, as within history is wiped.
                }
            }

            Point startCell = new Point(1, 1);
            // define starting point, starting at cell 1, 1

            Cells[startCell.X, startCell.Y].visited = true;
            // define start cell x and y position as being visted.

            history.Push(startCell);
            // add visted boolien into history stack

            while (history.Count > 0)
            // while history  has more than 0 values in stack
            {
                startCell = history.Pop();
                // define startcell as from the top value of the stack, removing it

                List<Point> lonelyNeighbours = new List<Point>();
                // define list of nextdoor cells

                if (startCell.Y - 1 >= 0 && !Cells[startCell.X, startCell.Y - 1].visited)
                // if the Y -1  cell has been visted
                {
                    lonelyNeighbours.Add(new Point(startCell.X, startCell.Y - 1));
                    // add this cell to lonelyNieghbours list
                }
                if (startCell.Y + 1 < Rows && !Cells[startCell.X, startCell.Y + 1].visited)
                // if the Y +1 cell has been visted
                {
                    lonelyNeighbours.Add(new Point(startCell.X, startCell.Y + 1));
                    // add this cell to lonelyNieghbours list
                }
                if (startCell.X - 1 >= 0 && !Cells[startCell.X - 1, startCell.Y].visited)
                // if the left cell has been visted
                {
                    lonelyNeighbours.Add(new Point(startCell.X - 1, startCell.Y));
                    // add this cell to lonelyNieghbours list
                }
                if (startCell.X + 1 < Columns && !Cells[startCell.X + 1, startCell.Y].visited)
                // if the right cell has been visted
                {
                    lonelyNeighbours.Add(new Point(startCell.X + 1, startCell.Y));
                    // add this cell to lonelyNieghbours list
                }

                if (lonelyNeighbours.Count > 0)
                // if there are exists a cell next door which has not been visted
                {
                    history.Push(startCell);
                    // push startcell on stack

                    int dr = rand.Next(0, lonelyNeighbours.Count);
                    // pick random new start cell from lonely neighbours
                    Point next = lonelyNeighbours[dr];


                    var V = (next.X - startCell.X, next.Y - startCell.Y);
                    // define the new start cell by cell positions

                    if (V == (1, 0))
                    // if the result shows new start cell is to the right
                    {
                        Cells[startCell.X, startCell.Y].rightwall = false;
                        // remove wall to the right

                    }
                    if (V == (0, 1))
                    // if the result shows new start cell is bottom

                    {
                        Cells[startCell.X, startCell.Y].bottomwall = false;
                        // remove wall to the bottom
                    }
                    if (V == (-1, 0))
                    // if the result shows new start cell is to the left

                    {
                        Cells[startCell.X - 1, startCell.Y].rightwall = false;
                        // remove wall to the gith, from the cell to the left

                    }
                    if (V == (0, -1))
                    // if the result shows new start cell is to the top

                    {
                        Cells[startCell.X, startCell.Y - 1].bottomwall = false;
                        // remove wall to the bottom, from the cell above
                    }

                    Cells[next.X, next.Y].visited = true;
                    // define the new start cell as being visted
                    history.Push(next);
                    // push the next value from / onto the stack
                }
            }
        }

        // defines the drawing of the cells which is called on from form 1, with defined graphics send also
        public void DrawCells(Graphics g)
        {
            for (int i = 0; i < Columns; i++)
            // for all columns
            {
                for (int j = 0; j < Rows; j++)
                // for all rows of all columns
                {
                    Cells[i, j].DrawCells(g);
                    // run draw cells method by i, j quantity of cells
                }
            }
        }
    }
}
