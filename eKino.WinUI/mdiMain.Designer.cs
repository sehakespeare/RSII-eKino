namespace eKino.WinUI
{
    partial class mdiMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAuditoriumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAuditoriumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProjectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketSalesPerMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlySalesByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.auditoriumsToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.directorsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.projectionsToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUsersToolStripMenuItem,
            this.newUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // listUsersToolStripMenuItem
            // 
            this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
            this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.listUsersToolStripMenuItem.Text = "List users";
            this.listUsersToolStripMenuItem.Click += new System.EventHandler(this.listUsersToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newUserToolStripMenuItem.Text = "New user";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // auditoriumsToolStripMenuItem
            // 
            this.auditoriumsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAuditoriumsToolStripMenuItem,
            this.newAuditoriumToolStripMenuItem});
            this.auditoriumsToolStripMenuItem.Name = "auditoriumsToolStripMenuItem";
            this.auditoriumsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.auditoriumsToolStripMenuItem.Text = "Auditoriums";
            // 
            // listAuditoriumsToolStripMenuItem
            // 
            this.listAuditoriumsToolStripMenuItem.Name = "listAuditoriumsToolStripMenuItem";
            this.listAuditoriumsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listAuditoriumsToolStripMenuItem.Text = "List auditoriums";
            this.listAuditoriumsToolStripMenuItem.Click += new System.EventHandler(this.listAuditoriumsToolStripMenuItem_Click);
            // 
            // newAuditoriumToolStripMenuItem
            // 
            this.newAuditoriumToolStripMenuItem.Name = "newAuditoriumToolStripMenuItem";
            this.newAuditoriumToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newAuditoriumToolStripMenuItem.Text = "New auditorium";
            this.newAuditoriumToolStripMenuItem.Click += new System.EventHandler(this.newAuditoriumToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listGenresToolStripMenuItem,
            this.newGenreToolStripMenuItem});
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // listGenresToolStripMenuItem
            // 
            this.listGenresToolStripMenuItem.Name = "listGenresToolStripMenuItem";
            this.listGenresToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.listGenresToolStripMenuItem.Text = "List genres";
            this.listGenresToolStripMenuItem.Click += new System.EventHandler(this.listGenresToolStripMenuItem_Click);
            // 
            // newGenreToolStripMenuItem
            // 
            this.newGenreToolStripMenuItem.Name = "newGenreToolStripMenuItem";
            this.newGenreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGenreToolStripMenuItem.Text = "New Genre";
            this.newGenreToolStripMenuItem.Click += new System.EventHandler(this.newGenreToolStripMenuItem_Click);
            // 
            // directorsToolStripMenuItem
            // 
            this.directorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDirectorsToolStripMenuItem,
            this.newDirectorToolStripMenuItem});
            this.directorsToolStripMenuItem.Name = "directorsToolStripMenuItem";
            this.directorsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.directorsToolStripMenuItem.Text = "Directors";
            // 
            // listDirectorsToolStripMenuItem
            // 
            this.listDirectorsToolStripMenuItem.Name = "listDirectorsToolStripMenuItem";
            this.listDirectorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.listDirectorsToolStripMenuItem.Text = "List directors";
            this.listDirectorsToolStripMenuItem.Click += new System.EventHandler(this.listDirectorsToolStripMenuItem_Click);
            // 
            // newDirectorToolStripMenuItem
            // 
            this.newDirectorToolStripMenuItem.Name = "newDirectorToolStripMenuItem";
            this.newDirectorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newDirectorToolStripMenuItem.Text = "New director";
            this.newDirectorToolStripMenuItem.Click += new System.EventHandler(this.newDirectorToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMoviesToolStripMenuItem,
            this.newMovieToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.productsToolStripMenuItem.Text = "Movies";
            // 
            // listMoviesToolStripMenuItem
            // 
            this.listMoviesToolStripMenuItem.Name = "listMoviesToolStripMenuItem";
            this.listMoviesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listMoviesToolStripMenuItem.Text = "List movies";
            this.listMoviesToolStripMenuItem.Click += new System.EventHandler(this.listMoviesStripMenuItem_Click);
            // 
            // newMovieToolStripMenuItem
            // 
            this.newMovieToolStripMenuItem.Name = "newMovieToolStripMenuItem";
            this.newMovieToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newMovieToolStripMenuItem.Text = "New movie";
            this.newMovieToolStripMenuItem.Click += new System.EventHandler(this.newMovieToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listProjectionsToolStripMenuItem,
            this.newProjectionToolStripMenuItem});
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.projectionsToolStripMenuItem.Text = "Projections";
            // 
            // listProjectionsToolStripMenuItem
            // 
            this.listProjectionsToolStripMenuItem.Name = "listProjectionsToolStripMenuItem";
            this.listProjectionsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listProjectionsToolStripMenuItem.Text = "List projections";
            this.listProjectionsToolStripMenuItem.Click += new System.EventHandler(this.listProjectionsToolStripMenuItem_Click);
            // 
            // newProjectionToolStripMenuItem
            // 
            this.newProjectionToolStripMenuItem.Name = "newProjectionToolStripMenuItem";
            this.newProjectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newProjectionToolStripMenuItem.Text = "New projection";
            this.newProjectionToolStripMenuItem.Click += new System.EventHandler(this.newProjectionToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketSalesPerMovieToolStripMenuItem,
            this.yearlySalesByMonthToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // ticketSalesPerMovieToolStripMenuItem
            // 
            this.ticketSalesPerMovieToolStripMenuItem.Name = "ticketSalesPerMovieToolStripMenuItem";
            this.ticketSalesPerMovieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ticketSalesPerMovieToolStripMenuItem.Text = "Ticket sales per movie";
            this.ticketSalesPerMovieToolStripMenuItem.Click += new System.EventHandler(this.ticketSalesPerMovieToolStripMenuItem_Click);
            // 
            // yearlySalesByMonthToolStripMenuItem
            // 
            this.yearlySalesByMonthToolStripMenuItem.Name = "yearlySalesByMonthToolStripMenuItem";
            this.yearlySalesByMonthToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yearlySalesByMonthToolStripMenuItem.Text = "Revenue per month";
            this.yearlySalesByMonthToolStripMenuItem.Click += new System.EventHandler(this.revenuePerMonthToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripSplitButton});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripSplitButton
            // 
            this.toolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1});
            this.toolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton.Name = "toolStripSplitButton";
            this.toolStripSplitButton.Size = new System.Drawing.Size(16, 20);
            this.toolStripSplitButton.Text = "Logout";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eKino";
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem listUsersToolStripMenuItem;
        private ToolStripMenuItem newUserToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem listMoviesToolStripMenuItem;
        private ToolStripMenuItem auditoriumsToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem directorsToolStripMenuItem;
        private ToolStripMenuItem projectionsToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem listAuditoriumsToolStripMenuItem;
        private ToolStripMenuItem newAuditoriumToolStripMenuItem;
        private ToolStripMenuItem listGenresToolStripMenuItem;
        private ToolStripMenuItem newGenreToolStripMenuItem;
        private ToolStripMenuItem listDirectorsToolStripMenuItem;
        private ToolStripMenuItem newDirectorToolStripMenuItem;
        private ToolStripMenuItem newMovieToolStripMenuItem;
        private ToolStripMenuItem listProjectionsToolStripMenuItem;
        private ToolStripMenuItem newProjectionToolStripMenuItem;
        private ToolStripMenuItem ticketSalesPerMovieToolStripMenuItem;
        private ToolStripMenuItem yearlySalesByMonthToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton;
        private ToolStripMenuItem logoutToolStripMenuItem1;
    }
}



