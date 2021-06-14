using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace maze_concept
{
    public partial class MazeMania : Form
    {
        public MazeMania()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlDraw, new object[] { true });

            maze = new Maze(26, 24);


        }

        private Maze maze;
        


        private void pnlDraw_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush br = Brushes.Black;

            maze.DrawCells(g);





        }

        private void mstOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PBMenu.Visible = false;
            btnStart.Visible = false;
            btnExit.Visible = false;
            mstOptions.Visible = true;

            btnStart.Enabled = false;
            btnExit.Enabled = false;
            mstOptions.Enabled = true;

            maze.GenerateMaze();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Pink;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Yellow;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Pink;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Yellow;
        }
    }
}
