
namespace maze_concept
{
    partial class MazeMania
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeMania));
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.LBhighscores = new System.Windows.Forms.ListBox();
            this.txtBusername = new System.Windows.Forms.TextBox();
            this.btnUsername = new System.Windows.Forms.Button();
            this.PBusernamescreen = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.PBMenu = new System.Windows.Forms.PictureBox();
            this.mstOptions = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrAvatar = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.PBItems = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBusernamescreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).BeginInit();
            this.mstOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Controls.Add(this.LBhighscores);
            this.pnlDraw.Controls.Add(this.txtBusername);
            this.pnlDraw.Controls.Add(this.btnUsername);
            this.pnlDraw.Controls.Add(this.PBusernamescreen);
            this.pnlDraw.Controls.Add(this.btnExit);
            this.pnlDraw.Controls.Add(this.btnStart);
            this.pnlDraw.Controls.Add(this.PBMenu);
            this.pnlDraw.Location = new System.Drawing.Point(12, 83);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(505, 567);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_paint);
            // 
            // LBhighscores
            // 
            this.LBhighscores.FormattingEnabled = true;
            this.LBhighscores.Location = new System.Drawing.Point(108, 496);
            this.LBhighscores.Name = "LBhighscores";
            this.LBhighscores.Size = new System.Drawing.Size(386, 56);
            this.LBhighscores.TabIndex = 7;
            this.LBhighscores.SelectedIndexChanged += new System.EventHandler(this.LBhighscores_SelectedIndexChanged);
            // 
            // txtBusername
            // 
            this.txtBusername.Location = new System.Drawing.Point(117, 127);
            this.txtBusername.MaxLength = 16;
            this.txtBusername.Name = "txtBusername";
            this.txtBusername.Size = new System.Drawing.Size(225, 20);
            this.txtBusername.TabIndex = 6;
            this.txtBusername.Visible = false;
            this.txtBusername.TextChanged += new System.EventHandler(this.txtBusername_TextChanged);
            // 
            // btnUsername
            // 
            this.btnUsername.Enabled = false;
            this.btnUsername.Location = new System.Drawing.Point(117, 240);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(225, 63);
            this.btnUsername.TabIndex = 4;
            this.btnUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Visible = false;
            this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // PBusernamescreen
            // 
            this.PBusernamescreen.BackColor = System.Drawing.Color.Black;
            this.PBusernamescreen.Image = global::maze_concept.Properties.Resources.Username_input;
            this.PBusernamescreen.Location = new System.Drawing.Point(-20, -71);
            this.PBusernamescreen.Name = "PBusernamescreen";
            this.PBusernamescreen.Size = new System.Drawing.Size(544, 638);
            this.PBusernamescreen.TabIndex = 5;
            this.PBusernamescreen.TabStop = false;
            this.PBusernamescreen.Visible = false;
            this.PBusernamescreen.Click += new System.EventHandler(this.PBusernamescreen_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(41, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 73);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(41, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 73);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // PBMenu
            // 
            this.PBMenu.Image = ((System.Drawing.Image)(resources.GetObject("PBMenu.Image")));
            this.PBMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBMenu.InitialImage")));
            this.PBMenu.Location = new System.Drawing.Point(0, -116);
            this.PBMenu.Name = "PBMenu";
            this.PBMenu.Size = new System.Drawing.Size(508, 680);
            this.PBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMenu.TabIndex = 0;
            this.PBMenu.TabStop = false;
            // 
            // mstOptions
            // 
            this.mstOptions.Enabled = false;
            this.mstOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.mstOptions.Location = new System.Drawing.Point(0, 0);
            this.mstOptions.Name = "mstOptions";
            this.mstOptions.Size = new System.Drawing.Size(542, 24);
            this.mstOptions.TabIndex = 1;
            this.mstOptions.Text = "menuStrip1";
            this.mstOptions.Visible = false;
            this.mstOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstOptions_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.skinsToolStripMenuItem.Text = "Skins";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem11.Text = "10";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // tmrAvatar
            // 
            this.tmrAvatar.Interval = 1000;
            this.tmrAvatar.Tick += new System.EventHandler(this.tmrAvatar_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(12, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(96, 28);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Visible = false;
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(156, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 27);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username: ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUsername.Visible = false;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(374, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 27);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:  00:00";
            this.lblTime.Visible = false;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // PBItems
            // 
            this.PBItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PBItems.Enabled = false;
            this.PBItems.Location = new System.Drawing.Point(-8, -2);
            this.PBItems.Name = "PBItems";
            this.PBItems.Size = new System.Drawing.Size(556, 79);
            this.PBItems.TabIndex = 2;
            this.PBItems.TabStop = false;
            this.PBItems.Visible = false;
            this.PBItems.Click += new System.EventHandler(this.PBItems_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MazeMania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(542, 662);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.PBItems);
            this.Controls.Add(this.mstOptions);
            this.MainMenuStrip = this.mstOptions;
            this.Name = "MazeMania";
            this.Text = "MazeMania";
            this.Load += new System.EventHandler(this.MazeMania_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeMania_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MazeMania_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MazeMania_KeyUp);
            this.pnlDraw.ResumeLayout(false);
            this.pnlDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBusernamescreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).EndInit();
            this.mstOptions.ResumeLayout(false);
            this.mstOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.MenuStrip mstOptions;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.PictureBox PBMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrAvatar;
        private System.Windows.Forms.PictureBox PBItems;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnUsername;
        private System.Windows.Forms.PictureBox PBusernamescreen;
        private System.Windows.Forms.TextBox txtBusername;
        public System.Windows.Forms.ListBox LBhighscores;
        private System.Windows.Forms.Timer timer1;
    }
}

