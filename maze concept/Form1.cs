using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;


namespace maze_concept
{
    public partial class MazeMania : Form
    {
        public MazeMania()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlDraw, new object[] { true });
            // doublebuffering script, which will cause for frames to be more smoothly transitioning

            Random rand = new Random();
            // defines random

            maze = new Maze(10, 10);
            // defines maze class, sending rows and columns, 10 by 10 grid size. 10 columns, 10 rows

            avatar = new Avatar();
            goal = new Goal();
            HighScores = new HighScores();
            // defines path to classes


            avatar.x = maze.Cells[5 + rand.Next(-5, 5), 5 + rand.Next(-5, 5)].x;
            avatar.y = maze.Cells[5 + rand.Next(-5, 5), 5 + rand.Next(-5, 5)].y;
            // defines avatar.x and y starting position by random

            goal.x = maze.Cells[5 + rand.Next(-5, 5), 5 + rand.Next(-5, 5)].x;
            goal.y = maze.Cells[5 + rand.Next(-5, 5), 5 + rand.Next(-5, 5)].y;
            // defines goal.x and y starting position

        }


        private Maze maze;
        private Avatar avatar;
        private Goal goal;
        private HighScores HighScores;
        // defines classes


        bool playing = false;
        string skin = "1";
        // defines variables for further use

        int Score;
        // defines empty integer value for future score

        int timeLeft;
        int gameTime = 30;
        // gametime will become the time left, defined here in one place

        bool currentSkin = false;
        public Image goalSkin = Properties.Resources.Avatar10;
        public Image goalSkin2 = Properties.Resources.Avatar8;
        // defines image path for goal


        string username;
        bool btnUserSpace = false;
        // defines username which will be input on username screen

        bool FormVisable = false;




        // below, on load of form
        private void MazeMania_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Maze Mania, Within this game your goal is to collect as much Treasure as you can before the timer runs out. \n \n \n Using W A S D, or the arrow keys you will navigate through the randomly generated mazes.");
            // message box, how to play instructions

            mstOptions.BringToFront();
            // bring to front property to ensure options bar is not hidden

            //lblHighscore1.Text = username textfromsavefile + Score textfromsavefile

        }

        private void pnlDraw_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // defines graphics by the pannel 

            maze.DrawCells(g);
            // runs method in Maze.cs

            avatar.DrawAvatar(g, skin);
            // runs method in Avatar.cs




            if (currentSkin)
            {

                goal.DrawGoal(g, goalSkin);
            }
            else
            {
                goal.DrawGoal(g, goalSkin2);

            }// Above is a T flip flop, for the two goal skins.

            CheckConditions();
            // runs method check conditions, checks time, and score
        }

        private void mstOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        // below, when button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            PBMenu.Visible = false;
            btnStart.Visible = false;
            btnExit.Visible = false;
            // menue objects are hidden

            LBhighscores.Visible = false;
            LBhighscores.Enabled = false;
            // highscores are hidden

            btnUsername.Visible = true;
            btnUsername.Enabled = true;
            PBusernamescreen.Visible = true;
            // username objects are shown

            txtBusername.Visible = true;
            txtBusername.Enabled = true;
            txtBusername.BringToFront();
            // username input is shown and enabled


        }

        // when exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // apllication.Exit() is a safe way to exit, without worry of curruption
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // apllication.Exit() is a safe way to exit, without worry of curruption
        }

        // when start button is hovered over
        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Pink;
            // change colour property to pink colour
        }

        // when start button has mouse leave button
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Yellow;
            // change button colour property back to yellow
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Pink;
            // change button colour property to pink
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Yellow;
            // change button colour property back to yellow
        }

        // on timer tick
        private void tmrAvatar_Tick(object sender, EventArgs e)
        {
            var ActiveCheck = MazeMania.ActiveForm;
            if (ActiveCheck == null)
            {
                FormVisable = false;
            }
            else
            {
                FormVisable = true;
            }

            if (playing)
            // if the game is said to be playing
            {
                timeLeft -= 1;
                // take 1 seccond off time left

                lblTime.Text = "Time: " + timeLeft.ToString();
                // update timer on screen

                if (timeLeft <= 0)
                // if the time left hits 0
                {
                    playing = false;
                    // stop game

                    LBhighscores.Items.Clear();




                    if (FormVisable)
                    {
                        HighScores.UpdateHighScore(username, Score, FormVisable);
                        //check if form is active to prevent crashing
                    }




                    // run highscore method in highscores.cs

                    lblGameOverScore.Text = "Score: " + Score.ToString();
                    // run gameover screen text

                    lblGameOverScore.Visible = true;
                    lblGameOver.Visible = true;
                    LBhighscores.Visible = true;
                    LBhighscores.Enabled = true;


                    btnGameOverRestart.Visible = true;
                    btnGameOverRestart.Enabled = true;
                    // show game over text
                }
                else
                {
                    lblGameOverScore.Visible = false;
                    lblGameOver.Visible = false;
                    LBhighscores.Visible = false;
                    LBhighscores.Enabled = false;

                    // if the game is not over, hide the game over screen

                    btnGameOverRestart.Visible = false;
                    btnGameOverRestart.Enabled = false;
                    // disable restart button on gameover screen
                }
            }
        }

        private void MazeMania_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void MazeMania_KeyDown(object sender, KeyEventArgs e)
        {
            if (playing)
            // if playing
            {
                if (e.KeyCode == Keys.D)
                // on "D" button key press
                {
                    if (avatar.x / 50 < maze.Columns)
                    // if avatar is not in right most cell column
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x + 50;
                            // change avatar.x position by 1 cell
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    // suppress stupidly annoying win10 error sound :)


                }
                if (e.KeyCode == Keys.A)
                // on A button press
                {
                    if ((avatar.x - 50) / 50 >= 0)
                    // if avatar not in left most column
                    {
                        if (maze.Cells[avatar.x / 50 - 1, avatar.y / 50].rightwall != true)
                        {
                            avatar.x = avatar.x - 50;
                            // move avatar in to left cell
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    // supress win10 error sound

                }
                if (e.KeyCode == Keys.W)
                // on W button press
                {
                    if ((avatar.y - 50) / 50 >= 0)
                    // if avatar no in top most row
                    {
                        if (maze.Cells[avatar.x / 50, (avatar.y / 50) - 1].bottomwall != true)
                        {
                            avatar.y = avatar.y - 50;
                            // ove avatar up
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    // supress win10 error sound

                }
                if (e.KeyCode == Keys.S)
                // On S button press
                {
                    if (avatar.y / 50 < maze.Rows)
                    // if not in bottom row
                    {
                        if (maze.Cells[avatar.x / 50, avatar.y / 50].bottomwall != true)
                        {
                            avatar.y = avatar.y + 50;
                            // move avatar down
                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    // supress win10 error sound

                }


                // for all these controls below, on key press check if the avatar is in extreme cell.  If not, then move avatar to that cell
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
                // End of arrow key controls


                pnlDraw.Invalidate();
                // invalidate forces the panel to redraw
            }
        }

        private void MazeMania_KeyUp(object sender, KeyEventArgs e)
        {
        }

        // when restart button pressed
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentSkin = !currentSkin;
            // forces the skin to change

            LBhighscores.Items.Clear();
            if (FormVisable)
            {
                HighScores.UpdateHighScore(username, Score, FormVisable);
                //check if form is active to prevent crashing
            }
            // run throguh highscores

            pnlDraw.Refresh();
            maze.GenerateMaze();
            // regenerate map
            pnlDraw.Invalidate();
            // force redraw panel



            Random rand2 = new Random();
            goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
            // new random goal position


            avatar.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            avatar.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
            // new random avatar position

            Score = 0;
            // score is reset to 0
            lblScore.Text = "Score: " + Score.ToString();
            // update score lable

            timeLeft = gameTime;
            // timeleft is reset back to gametime

            lblTime.Text = "Time: " + timeLeft.ToString();
            // update time lable

            playing = true;
            // set game to play

            btnGameOverRestart.ForeColor = Color.Yellow;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            skin = "1";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();

            // force redraw with new skin based on avatar class

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            skin = "2";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class


        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            skin = "3";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class


        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            skin = "4";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class


        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            skin = "5";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class


        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            skin = "6";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class


        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            skin = "7";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            skin = "8";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            skin = "9";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            skin = "10";
            pnlDraw.Refresh();
            pnlDraw.Invalidate();
            // force redraw with new skin based on avatar class

        }

        public void CheckConditions()
        {
            if (avatar.x == goal.x & avatar.y == goal.y)
            // if the avatar and goal are in same position
            {
                maze.GenerateMaze();
                // regenerate maze

                Random rand2 = new Random();
                goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
                // new random goal position

                currentSkin = !currentSkin;
                // change goal skin

                pnlDraw.Refresh();
                pnlDraw.Invalidate();
                // force redraw panel

                Score += 1;
                // add 1 to score

                lblScore.Text = "Score: " + Score.ToString();
                // update score lable
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
            // if there is text in username text box
            {

                txtBusername.Visible = false;
                txtBusername.Enabled = false;

                PBusernamescreen.Visible = false;
                btnUsername.Visible = false;
                btnUsername.Enabled = false;
                // hidde objects on username screen

                mstOptions.Visible = true;

                lblScore.Visible = true;
                lblTime.Visible = true;
                lblUsername.Visible = true;
                PBItems.Visible = true;

                btnStart.Enabled = false;
                btnExit.Enabled = false;
                mstOptions.Enabled = true;
                // show objects in game layout

                timeLeft = gameTime;
                playing = true;
                tmrAvatar.Enabled = true;
                // start the game

                lblUsername.Text = username;
                // set the username lable by the username input

                maze.GenerateMaze();

                pnlDraw.Invalidate();
                // force panel to redraw
            }
        }

        private void PBusernamescreen_Click(object sender, EventArgs e)
        {

        }



        private void txtBusername_TextChanged(object sender, EventArgs e)
        {
            username = txtBusername.Text;
            // username input updated on username lable

            if (txtBusername.Text == "")
            // if the textbox is empty
            {
                btnUsername.Enabled = false;
                btnUserSpace = false;
                // input button is disabled
            }

            if (txtBusername.Text != "")
            // if the text box is not empty
            {
                btnUsername.Enabled = true;
                btnUserSpace = true;
                // enable the text box
            }
        }

        private void LBhighscores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // below is a devalopement bug testing algorithm, which is disabled by the logic that the score may never be equal or less than -1
            if (playing)
            // if playing
            {
                if (Score <= -1)
                // if the score is less or equal to a value.
                {
                    pnlDraw.Refresh();
                    maze.GenerateMaze();
                    pnlDraw.Invalidate();
                    // reset maze
                    if (FormVisable)
                    {
                        HighScores.UpdateHighScore(username, Score, FormVisable);
                        //check if form is active to prevent crashing
                    }

                    Random rand2 = new Random();
                    goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                    goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
                    // reset goal position

                    avatar.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
                    avatar.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
                    // reset avatar position

                    Score = 0;
                    lblScore.Text = "Score: " + Score.ToString();
                    // score reset

                    timeLeft = gameTime;
                    lblTime.Text = "Time: " + timeLeft.ToString();
                    playing = true;
                    // reset time and start playing
                }

            }
        }

        public void UpdateListBox(string names, int score2)
        {
            // LBhighscores.Items.Add(names + " - " + score2.ToString());
            // add values to listbox, highscores currently bugged
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOverScore_Click(object sender, EventArgs e)
        {

        }

        // reset button click, reset the game
        private void btnGameOverRestart_Click(object sender, EventArgs e)
        {
            currentSkin = !currentSkin;

            pnlDraw.Refresh();
            maze.GenerateMaze();
            // generate new maze

            pnlDraw.Invalidate();
            // force redraw

            Random rand2 = new Random();
            goal.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            goal.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
            // new goal position

            avatar.x = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].x;
            avatar.y = maze.Cells[5 + rand2.Next(-5, 5), 5 + rand2.Next(-5, 5)].y;
            // new avatar position

            Score = 0;
            lblScore.Text = "Score: " + Score.ToString();
            // reset score

            timeLeft = gameTime;
            lblTime.Text = "Time: " + timeLeft.ToString();
            playing = true;
            // start playing

            btnGameOverRestart.ForeColor = Color.Yellow;


        }

        private void btnGameOverRestart_MouseHover(object sender, EventArgs e)
        {
            btnGameOverRestart.ForeColor = Color.Pink;
            // reset button on hover change colour to pink
        }

        private void MazeMania_MouseHover(object sender, EventArgs e)
        {

        }

        private void PBMenu_MouseHover(object sender, EventArgs e)
        {
            FormVisable = true;
            LBhighscores.Items.Clear();

            HighScores.UpdateHighScore(username, Score, FormVisable);

            // run through hishcores to upadate, in case of new results
        }
    }
}
