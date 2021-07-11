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

            Random rand = new Random();

            maze = new Maze(10, 10);
            avatar = new Avatar();
            goal = new Goal();
            HighScores = new HighScores();
            

            avatar.x = maze.Cells[ 5+ rand.Next(-5,5),  5+ rand.Next(-5, 5)].x;
            avatar.y = maze.Cells[ 5+ rand.Next(-5, 5), 5+ rand.Next(-5, 5)].y;

            goal.x = maze.Cells[ 5+ rand.Next(-5, 5),  5+ rand.Next(-5, 5)].x;
            goal.y = maze.Cells[ 5+ rand.Next(-5, 5),  5+ rand.Next(-5, 5)].y;
            
        }


        private Maze maze;
        private Avatar avatar;
        private Goal goal;
        private HighScores HighScores;

        bool playing = false;
        string skin = "1";

        int Score;

        int timeLeft;
        int gameTime = 30;

        bool currentSkin = false;
        public Image goalSkin = Properties.Resources.Avatar10;
        public Image goalSkin2 = Properties.Resources.Avatar8;

        string username;
        bool btnUserSpace = false;





        private void MazeMania_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Welcome to Maze Mania, Within this game your goal is to collect as much Treasure as you can before the timer runs out. \n \n \n Using W A S D, or the arrow keys you will navigate through the randomly generated mazes.");

            mstOptions.BringToFront();

            HighScores.UpdateHighScore(username, Score);

            //lblHighscore1.Text = username textfromsavefile + Score textfromsavefile

        }




        private void pnlDraw_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush br = Brushes.Black;

            maze.DrawCells(g);

            avatar.DrawAvatar(g, skin);
            


            
            if (currentSkin)
            {

            goal.DrawGoal(g, goalSkin);
            } else
            {
                goal.DrawGoal(g, goalSkin2);
                
            }

            CheckConditions();





        }

        private void mstOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PBMenu.Visible = false;
            btnStart.Visible = false;
            btnExit.Visible = false;

            LBhighscores.Visible = false;
            LBhighscores.Enabled = false;


            btnUsername.Visible = true;
            btnUsername.Enabled = true;
            PBusernamescreen.Visible = true;

            txtBusername.Visible = true;
            txtBusername.Enabled = true;
            txtBusername.BringToFront();


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

        private void tmrAvatar_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                timeLeft -= 1;
                lblTime.Text = "Time: " + timeLeft.ToString();
                if(timeLeft <= 0)
                {
                    playing = false;
                    HighScores.UpdateHighScore(username, Score);
                }
            }
        }

        private void MazeMania_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void MazeMania_KeyDown(object sender, KeyEventArgs e)
        {
            if (playing)
            {
                if (e.KeyCode == Keys.D)
                {
                    if (avatar.x / 50 < maze.Columns)
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x + 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;


                }
                if (e.KeyCode == Keys.A)
                {
                    if ((avatar.x - 50) / 50 >= 0)
                    {
                        if (maze.Cells[avatar.x / 50 - 1, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x - 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
                if (e.KeyCode == Keys.W)
                {
                    if ((avatar.y - 50) / 50 >= 0)
                    {
                        if (maze.Cells[avatar.x / 50, (avatar.y / 50) - 1].bottomwall != true)
                        {
                            avatar.y = avatar.y - 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
                if (e.KeyCode == Keys.S)
                {
                    if (avatar.y / 50 < maze.Rows)
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].bottomwall != true)
                        {
                            avatar.y = avatar.y + 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }

                if (e.KeyCode == Keys.Right) 
                {
                    if (avatar.x / 50 < maze.Columns)
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x + 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;


                }
                if (e.KeyCode == Keys.Left)
                {
                    if ((avatar.x - 50) / 50 >= 0)
                    {
                        if (maze.Cells[avatar.x / 50 - 1, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x - 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
                if (e.KeyCode == Keys.Up)
                {
                    if ((avatar.y - 50) / 50 >= 0)
                    {
                        if (maze.Cells[avatar.x / 50, (avatar.y / 50) - 1].bottomwall != true)
                        {
                            avatar.y = avatar.y - 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (avatar.y / 50 < maze.Rows)
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].bottomwall != true)
                        {
                            avatar.y = avatar.y + 50;
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
                pnlDraw.Invalidate();
            }
            }

        private void MazeMania_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentSkin = !currentSkin;

            pnlDraw.Refresh();
            maze.GenerateMaze();
            pnlDraw.Invalidate();

            Random rand2 = new Random();
            goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;

            avatar.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            avatar.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;

            Score = 0;
            lblScore.Text = "Score: " + Score.ToString();

            timeLeft = gameTime;
            lblTime.Text = "Time: " + timeLeft.ToString();
            playing = true;


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            skin = "1";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            skin = "2";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            skin = "3";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            skin = "4";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            skin = "5";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            skin = "6";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            skin = "7";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            skin = "8";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            skin = "9";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            skin = "10";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
        }

        public void CheckConditions()
        {
            if (avatar.x == goal.x & avatar.y == goal.y )
            {
                maze.GenerateMaze();

                Random rand2 = new Random();
                goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;

                currentSkin = !currentSkin;

                pnlDraw.Refresh();
                pnlDraw.Invalidate();
                
                
                
                Score += 1;
                lblScore.Text = "Score: " + Score.ToString();

            }

        }

        private void PBItems_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            if (btnUserSpace) 
            {
                
            txtBusername.Visible = false;
                txtBusername.Enabled = false;

                PBusernamescreen.Visible = false;
                btnUsername.Visible = false;
                btnUsername.Enabled = false;

                mstOptions.Visible = true;

                lblScore.Visible = true;
                lblTime.Visible = true;
                lblUsername.Visible = true;
                PBItems.Visible = true;

                btnStart.Enabled = false;
                btnExit.Enabled = false;
                mstOptions.Enabled = true;

                timeLeft = gameTime;
                playing = true;
                tmrAvatar.Enabled = true;

                lblUsername.Text = username;

                maze.GenerateMaze();

                pnlDraw.Invalidate();
            }
        }

        private void PBusernamescreen_Click(object sender, EventArgs e)
        {

        }

        private void txtBusername_TextChanged(object sender, EventArgs e)
        {
            username = txtBusername.Text;

            if(txtBusername.Text == "")
            {
                btnUsername.Enabled = false;
                btnUserSpace = false;
            }

            if(txtBusername.Text != "")
            {
                btnUsername.Enabled = true;
                btnUserSpace = true;

            }
        }

        

        private void LBhighscores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                if (Score <= -1)
                {
                    pnlDraw.Refresh();
                    maze.GenerateMaze();
                    pnlDraw.Invalidate();

                    Random rand2 = new Random();
                    goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                    goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;

                    avatar.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                    avatar.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;

                    Score = 0;
                    lblScore.Text = "Score: " + Score.ToString();

                    timeLeft = gameTime;
                    lblTime.Text = "Time: " + timeLeft.ToString();
                    playing = true;
                }

            }
        }

        public void UpdateListBox(string names, int score2)
        {
            LBhighscores.Items.Add(names + " - " + score2.ToString());


        }





    }
}
