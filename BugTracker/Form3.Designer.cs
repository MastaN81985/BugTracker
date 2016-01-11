namespace BugTracker
{
    partial class Form3
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAuditHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bugsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // connectToDatabaseToolStripMenuItem
            // 
            this.connectToDatabaseToolStripMenuItem.Name = "connectToDatabaseToolStripMenuItem";
            this.connectToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.connectToDatabaseToolStripMenuItem.Text = "Connect To Database";
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBugToolStripMenuItem,
            this.reportBugFixToolStripMenuItem,
            this.checkAuditHistoryToolStripMenuItem});
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bugsToolStripMenuItem.Text = "Bugs";
            // 
            // newBugToolStripMenuItem
            // 
            this.newBugToolStripMenuItem.Name = "newBugToolStripMenuItem";
            this.newBugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBugToolStripMenuItem.Text = "New Bug Report";
            // 
            // reportBugFixToolStripMenuItem
            // 
            this.reportBugFixToolStripMenuItem.Name = "reportBugFixToolStripMenuItem";
            this.reportBugFixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportBugFixToolStripMenuItem.Text = "Report Bug Fix";
            // 
            // checkAuditHistoryToolStripMenuItem
            // 
            this.checkAuditHistoryToolStripMenuItem.Name = "checkAuditHistoryToolStripMenuItem";
            this.checkAuditHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkAuditHistoryToolStripMenuItem.Text = "Check Audit History";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 557);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAuditHistoryToolStripMenuItem;
    }
}