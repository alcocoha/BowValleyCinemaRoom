namespace BowValleyCinemaRoom
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScreenAddNewAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.seeUserRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMovieToolStripMenuItem,
            this.seeMoviesToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // createMovieToolStripMenuItem
            // 
            this.createMovieToolStripMenuItem.Name = "createMovieToolStripMenuItem";
            this.createMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createMovieToolStripMenuItem.Text = "Add New Movie";
            this.createMovieToolStripMenuItem.Click += new System.EventHandler(this.createMovieToolStripMenuItem_Click);
            // 
            // seeMoviesToolStripMenuItem
            // 
            this.seeMoviesToolStripMenuItem.Name = "seeMoviesToolStripMenuItem";
            this.seeMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seeMoviesToolStripMenuItem.Text = "See Movies";
            this.seeMoviesToolStripMenuItem.Click += new System.EventHandler(this.seeMoviesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScreenAddNewAdmin,
            this.seeUserRegistersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // openScreenAddNewAdmin
            // 
            this.openScreenAddNewAdmin.Name = "openScreenAddNewAdmin";
            this.openScreenAddNewAdmin.Size = new System.Drawing.Size(168, 22);
            this.openScreenAddNewAdmin.Text = "Add New Admin";
            this.openScreenAddNewAdmin.Click += new System.EventHandler(this.openScreenAddNewAdmin_Click);
            // 
            // seeUserRegistersToolStripMenuItem
            // 
            this.seeUserRegistersToolStripMenuItem.Name = "seeUserRegistersToolStripMenuItem";
            this.seeUserRegistersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.seeUserRegistersToolStripMenuItem.Text = "See User Registers";
            this.seeUserRegistersToolStripMenuItem.Click += new System.EventHandler(this.seeUserRegistersToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 351);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "BowValleyCinemaRoom - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem createMovieToolStripMenuItem;
        private ToolStripMenuItem seeMoviesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem openScreenAddNewAdmin;
        private ToolStripMenuItem seeUserRegistersToolStripMenuItem;
    }
}