
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
            this.pnlDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).BeginInit();
            this.mstOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Controls.Add(this.btnExit);
            this.pnlDraw.Controls.Add(this.btnStart);
            this.pnlDraw.Controls.Add(this.PBMenu);
            this.pnlDraw.Location = new System.Drawing.Point(12, 22);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(521, 545);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(41, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 71);
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
            this.btnStart.Location = new System.Drawing.Point(41, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 71);
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
            this.PBMenu.Location = new System.Drawing.Point(0, -41);
            this.PBMenu.Name = "PBMenu";
            this.PBMenu.Size = new System.Drawing.Size(545, 595);
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
            this.mstOptions.Size = new System.Drawing.Size(545, 24);
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
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "5";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "6";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem8.Text = "7";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem9.Text = "8";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "9";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem11.Text = "10";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // tmrAvatar
            // 
            this.tmrAvatar.Tick += new System.EventHandler(this.tmrAvatar_Tick);
            // 
            // MazeMania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(545, 579);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.mstOptions);
            this.MainMenuStrip = this.mstOptions;
            this.Name = "MazeMania";
            this.Text = "MazeMania";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeMania_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MazeMania_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MazeMania_KeyUp);
            this.pnlDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBMenu)).EndInit();
            this.mstOptions.ResumeLayout(false);
            this.mstOptions.PerformLayout();
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
    }
}

