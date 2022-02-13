
namespace New_Puzzle_Game
{
    partial class PuzzleGame2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleGame2));
            this.pnlUI = new System.Windows.Forms.Panel();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.grbAnswer = new System.Windows.Forms.GroupBox();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFromPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlUI.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.grbAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUI
            // 
            this.pnlUI.Controls.Add(this.grbTime);
            this.pnlUI.Controls.Add(this.grbAnswer);
            this.pnlUI.Controls.Add(this.pnlImage);
            this.pnlUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUI.Location = new System.Drawing.Point(0, 24);
            this.pnlUI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUI.Name = "pnlUI";
            this.pnlUI.Size = new System.Drawing.Size(820, 564);
            this.pnlUI.TabIndex = 0;
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.lblTime);
            this.grbTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grbTime.Location = new System.Drawing.Point(415, 377);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(405, 187);
            this.grbTime.TabIndex = 9;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Thời gian";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(152, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 45);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            // 
            // grbAnswer
            // 
            this.grbAnswer.Controls.Add(this.picAnswer);
            this.grbAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grbAnswer.Location = new System.Drawing.Point(1, 377);
            this.grbAnswer.Name = "grbAnswer";
            this.grbAnswer.Size = new System.Drawing.Size(405, 187);
            this.grbAnswer.TabIndex = 7;
            this.grbAnswer.TabStop = false;
            this.grbAnswer.Text = "Kết quả";
            // 
            // picAnswer
            // 
            this.picAnswer.Location = new System.Drawing.Point(128, 24);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(150, 150);
            this.picAnswer.TabIndex = 8;
            this.picAnswer.TabStop = false;
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.Silver;
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(353, 353);
            this.pnlImage.TabIndex = 2;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureToolStripMenuItem,
            this.playToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.playAgainToolStripMenuItem,
            this.backHomeToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(820, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picture1ToolStripMenuItem,
            this.picture2ToolStripMenuItem,
            this.picture3ToolStripMenuItem,
            this.picture4ToolStripMenuItem,
            this.chooseFromPCToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pictureToolStripMenuItem.Text = "&Picture";
            // 
            // picture1ToolStripMenuItem
            // 
            this.picture1ToolStripMenuItem.Name = "picture1ToolStripMenuItem";
            this.picture1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.picture1ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.picture1ToolStripMenuItem.Text = "Picture 1";
            this.picture1ToolStripMenuItem.Click += new System.EventHandler(this.picture1ToolStripMenuItem_Click);
            // 
            // picture2ToolStripMenuItem
            // 
            this.picture2ToolStripMenuItem.Name = "picture2ToolStripMenuItem";
            this.picture2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.picture2ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.picture2ToolStripMenuItem.Text = "Picture 2";
            this.picture2ToolStripMenuItem.Click += new System.EventHandler(this.picture2ToolStripMenuItem_Click);
            // 
            // picture3ToolStripMenuItem
            // 
            this.picture3ToolStripMenuItem.Name = "picture3ToolStripMenuItem";
            this.picture3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.picture3ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.picture3ToolStripMenuItem.Text = "Picture 3";
            this.picture3ToolStripMenuItem.Click += new System.EventHandler(this.picture3ToolStripMenuItem_Click);
            // 
            // picture4ToolStripMenuItem
            // 
            this.picture4ToolStripMenuItem.Name = "picture4ToolStripMenuItem";
            this.picture4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.picture4ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.picture4ToolStripMenuItem.Text = "Picture 4";
            this.picture4ToolStripMenuItem.Click += new System.EventHandler(this.picture4ToolStripMenuItem_Click);
            // 
            // chooseFromPCToolStripMenuItem
            // 
            this.chooseFromPCToolStripMenuItem.Name = "chooseFromPCToolStripMenuItem";
            this.chooseFromPCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.chooseFromPCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.chooseFromPCToolStripMenuItem.Text = "Choose from PC";
            this.chooseFromPCToolStripMenuItem.Click += new System.EventHandler(this.chooseFromPCToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Pl&ay";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.x6ToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.levelToolStripMenuItem.Text = "&Level";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x3ToolStripMenuItem.Text = "3 x 3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x4ToolStripMenuItem.Text = "4 x 4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x5ToolStripMenuItem.Text = "5 x 5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x6ToolStripMenuItem.Text = "6 x 6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.playAgainToolStripMenuItem.Text = "&Play Again";
            this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.playAgainToolStripMenuItem_Click);
            // 
            // backHomeToolStripMenuItem
            // 
            this.backHomeToolStripMenuItem.Name = "backHomeToolStripMenuItem";
            this.backHomeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.backHomeToolStripMenuItem.Text = "&Back Home";
            this.backHomeToolStripMenuItem.Click += new System.EventHandler(this.backHomeToolStripMenuItem_Click);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.audioToolStripMenuItem.Text = "Sound";
            this.audioToolStripMenuItem.Click += new System.EventHandler(this.audioToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PuzzleGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 588);
            this.Controls.Add(this.pnlUI);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PuzzleGame2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp hình 2";
            this.pnlUI.ResumeLayout(false);
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUI;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.GroupBox grbAnswer;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backHomeToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picture1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picture2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picture3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picture4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFromPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
    }
}